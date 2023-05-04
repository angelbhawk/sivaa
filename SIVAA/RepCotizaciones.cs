using Entidades;
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
    public partial class RepCotizaciones : Form
    {
        private SIVAA mainForm;
        private List<Entidades.CotizacionUsar> listas;
        readonly CotizacionLog cotizacion = new CotizacionLog();

        public RepCotizaciones(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepCotizacion> rvs = new List<Entidades.RepCotizacion>();

            foreach (Entidades.CotizacionUsar v in listas)
            {
                Entidades.RepCotizacion r = new Entidades.RepCotizacion();
                r.IDCotizacion = v.IDCotizacion.ToString();
                r.IDEmpleado = v.IDEmpleado.ToString();
                r.IDCliente = v.IDCliente.ToString();
                r.IDVersion = v.IDVersion.ToString();
                r.Precio = v.PrecioInicial.ToString();
                r.Tipo = v.TipoPago.ToString();
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de cotizaciones", "Cotizaciones registradas");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de cotizaciones"));
        }

        private void RepCotizaciones_Load(object sender, EventArgs e)
        {
            listas = cotizacion.ListadoAll();

            foreach (Entidades.CotizacionUsar v in listas)
            {
                dataGridView1.Rows.Add(v.IDCotizacion, v.IDEmpleado, v.IDCliente, v.IDVersion, v.PrecioInicial, v.TipoPago);
            }
        }
    }
}
