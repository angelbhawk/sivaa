using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVAA
{
    public partial class Previsualizador : Form
    {
        private string reporte, nombre;

        public Previsualizador(string nombre)
        {
            InitializeComponent();
            cargar(nombre);
        }

        private void cargar(string nombre)
        {
            WebBrowser webBrowser1 = new WebBrowser();
            string rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "reporte.html");
            webBrowser1.Navigate(@"file:///" + rutaArchivo);
            panel3.Controls.Add(webBrowser1);
            webBrowser1.Dock = DockStyle.Fill;
            label1.Text = "Previsualizador de " + nombre;
            this.nombre = nombre;
            reporte = File.ReadAllText(rutaArchivo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImpresorPdf.Imprimir(nombre, reporte);
        }
    }
}
