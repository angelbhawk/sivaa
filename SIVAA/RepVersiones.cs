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
    public partial class RepVersiones : Form
    {
        private SIVAA mainForm;
        private List<Entidades.Versiones> listas;
        readonly VersionLog vehiculo = new VersionLog();

        public RepVersiones(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepVersion> rvs = new List<Entidades.RepVersion>();

            foreach (Entidades.Versiones v in listas)
            {
                Entidades.RepVersion r = new Entidades.RepVersion();
                r.Version = v.Version;
                r.IDVehiculo = v.IDVehiculo;
                r.Cilindraje = v.Cilindraje;
                r.IDVersion = v.IDVersion;
                r.TipoCombustible = v.TipoCombustible;
                r.Costo = v.Costo;
                r.NumPuertas = v.NumPuertas;
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de versiones", "Versiones disponibles");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de versiones"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void RepVersiones_Load(object sender, EventArgs e)
        {
            listas = vehiculo.ListadoTotal();

            foreach(Entidades.Versiones v in listas)
            {
                dataGridView1.Rows.Add(v.IDVersion, v.IDVersion, v.Version, v.TipoAsientos, v.TipoCombustible, v.Cilindraje);
            }
        }
    }
}
