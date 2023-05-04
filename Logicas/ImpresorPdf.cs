using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Logicas
{
    public class ImpresorPdf
    {
        public static void Imprimir(string nombre, string html)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            string modificado = nombre.Replace(" ", "_");
            guardar.FileName = modificado + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            //List<string> html = new List<string>();
            //if (datos.Count < 2)
            //{
            //    html.Add(plantilla);
            //    html[0] = html[0].Replace("@Tabla", datos[0]);
            //    html[0] = html[0].Replace("@Dia", DateTime.Now.Day.ToString());
            //    html[0] = html[0].Replace("@Mes", DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month));
            //    html[0] = html[0].Replace("@Año", DateTime.Now.Year.ToString());
            //    html[0] = html[0].Replace("@Nombre", nombre);
            //    html[0] = html[0].Replace("@Mensaje", mensaje);
            //    html[0] = html[0].Replace("@Firma", "");
            //    html[0] = html[0].Replace("@Folio", DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());
            //    html[0] = html[0].Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            //    html[0] = html[0].Replace("@Logo", "Mateo Jordan");
            //}
            //else
            //{
            //    int i = 0;
            //    foreach (string s in datos)
            //    {
            //        html.Add(plantilla);
            //        html[i] = html[i].Replace("@Tabla", s);
            //        html[i] = html[i].Replace("@Dia", DateTime.Now.Day.ToString());
            //        html[i] = html[i].Replace("@Mes", DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month));
            //        html[i] = html[i].Replace("@Año", DateTime.Now.Year.ToString());
            //        html[i] = html[i].Replace("@Nombre", nombre);
            //        html[i] = html[i].Replace("@Mensaje", mensaje);
            //        html[i] = html[i].Replace("@Firma", "");
            //        html[i] = html[i].Replace("@Folio", DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());
            //        html[i] = html[i].Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            //        html[i] = html[i].Replace("@Logo", "Mateo Jordan");
            //        i++;
            //    }
            //}

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writter = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //foreach (string s in html)
                    //{

                    //using (StringReader sr = new StringReader(s))
                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writter, pdfDoc, sr);
                    }
                    //pdfDoc.NewPage(); // Agrega una nueva página al documento
                    //}
                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }

        public static string Formatear<T>(IEnumerable<T> datos)
        {
            string tabla = "<table><tr>";
            string pattern = @"<(.*?)>";

            if (datos.Count() > 13)
            {

            }
            // Cabecera de la table
            T firstItem = datos.FirstOrDefault();
            if (firstItem != null)
            {
                foreach (var field in firstItem.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    Match match = Regex.Match(field.Name, pattern);
                    string valorEntreSimbolos = match.Success ? match.Groups[1].Value : "";
                    if (valorEntreSimbolos != "")
                        tabla += "<th>" + valorEntreSimbolos + "</th>";
                }
            }
            tabla += "</tr>";
            // Datos de la tabla
            foreach (var item in datos)
            {
                tabla += "<tr>";
                foreach (var field in item.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    tabla += "<td>" + field.GetValue(item) + "</td>";
                }
                tabla += "</tr>";
            }
            return tabla + "</table>";
        }

        public static List<string> Adaptar<T>(IEnumerable<T> datos)
        {
            List<string> tablas = new List<string>();

            if (datos.Count() < 13)
            {
                tablas.Add(ImpresorPdf.Formatear(datos));
            }
            else
            {
                int tamañoParte = 10;
                IEnumerable<IEnumerable<T>> partes = datos
                    .Select((dato, indice) => new { dato, indice })
                    .GroupBy(x => x.indice / tamañoParte)
                    .Select(g => g.Select(x => x.dato));
                foreach (IEnumerable<T> parte in partes)
                {
                    tablas.Add(ImpresorPdf.Formatear(datos));
                }
            }
            return tablas;
        }

        public static void generarReporte(string html, string plantilla, string titulo, string mensaje)
        {
            string nuevohtml = plantilla;
            nuevohtml = nuevohtml.Replace("@Tabla", html);
            nuevohtml = nuevohtml.Replace("@Dia", DateTime.Now.Day.ToString());
            nuevohtml = nuevohtml.Replace("@Mes", DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month));
            nuevohtml = nuevohtml.Replace("@Año", DateTime.Now.Year.ToString());
            nuevohtml = nuevohtml.Replace("@Nombre", titulo);
            nuevohtml = nuevohtml.Replace("@Mensaje", mensaje);
            nuevohtml = nuevohtml.Replace("@Firma", "");
            nuevohtml = nuevohtml.Replace("@Folio", DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());
            nuevohtml = nuevohtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            //nuevohtml = nuevohtml.Replace("@Logo", "Mateo Jordan");

            string contenidoHTML = nuevohtml;
            string nombreArchivo = "reporte.html";
            string rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo);
            File.WriteAllText(rutaArchivo, contenidoHTML);

        }
    }
}
