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
    public partial class RepVentas : Form
    {
        private SIVAA mainForm;
        private List<Entidades.Venta> listas;
        readonly VentaLog venta = new VentaLog();

        public RepVentas(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepVenta> rvs = new List<Entidades.RepVenta>();

            foreach (Entidades.Venta v in listas)
            {
                Entidades.RepVenta r = new Entidades.RepVenta();
                r.IDVenta = v.IDVenta;
                r.IDEmpleado = v.IDEmpleado;
                r.NoSerie = v.NoSerie;
                r.Fecha = v.Dia.ToString() + " de " + v.Mes.ToString() + " del " + v.Año.ToString();
                r.Subtotal = v.Subtotal;
                r.TipoVenta = v.TipoVenta;
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de ventas", "Ventas registrados");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de ventas"));
        }

        private void RepVentas_Load(object sender, EventArgs e)
        {
            listas = venta.ListadoAll();

            foreach (Entidades.Venta v in listas)
            {
                dataGridView1.Rows.Add(v.IDVenta, v.IDEmpleado, v.NoSerie, v.Dia.ToString() + " de " + v.Mes.ToString() + " del " + v.Año.ToString(), v.Subtotal, v.TipoVenta);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
