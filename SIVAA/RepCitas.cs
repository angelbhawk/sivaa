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
    public partial class RepCitas : Form
    {
        private SIVAA mainForm;
        private List<Entidades.Cita> listas;
        readonly CitaLog cita = new CitaLog();

        public RepCitas(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepCita> rvs = new List<Entidades.RepCita>();

            foreach (Entidades.Cita v in listas)
            {
                Entidades.RepCita r = new Entidades.RepCita();
                r.IDCita = v.IDCita;
                r.IDCliente = v.IDCliente;
                r.IDEmpleado = v.IDEmpleado;
                r.fecha = v.Dia.ToString() + " de " + v.Mes.ToString() + " del " + v.Año.ToString();
                r.Hora = v.Hora;
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de citas", "Citas registrados");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de citas"));
        }

        private void RepCitas_Load(object sender, EventArgs e)
        {
            listas = cita.ListadoAll();

            foreach (Entidades.Cita v in listas)
            {
                dataGridView1.Rows.Add(v.IDCita, v.IDCliente, v.IDEmpleado, v.Dia.ToString() + " de " + v.Mes.ToString() + " del " + v.Año.ToString(), v.Hora);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
