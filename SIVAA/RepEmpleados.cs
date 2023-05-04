using Datos;
using Entidades;
using iTextSharp.text;
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
    public partial class RepEmpleados : Form
    {
        private SIVAA mainForm;
        readonly EmpleadoLog empleado = new EmpleadoLog();
        List<Empleado> lista;

        public RepEmpleados(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepEmpleado> rvs = new List<Entidades.RepEmpleado>();

            foreach (Empleado v in lista)
            {
                Entidades.RepEmpleado r = new Entidades.RepEmpleado();
                r.IDEmpleado = v.IDEmpleado;
                r.Nombre = v.Nombre.Trim()+" "+v.ApellidoPat.Trim()+" "+v.ApellidoMat.Trim();
                r.Telefono = v.Telefono.Trim();
                r.Correo = v.Correo.Trim();
                r.Tipo = v.Tipo.Trim();
                r.RFC = v.RFC.Trim();
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de empleados", "Empleados registradas");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de empleados"));
        }

        private void RepEmpleados_Load(object sender, EventArgs e)
        {
            lista = empleado.ListadoAll();

            foreach (Entidades.Empleado v in lista)
            {
                dataGridView1.Rows.Add(v.IDEmpleado, v.Nombre.Trim()+" "+v.ApellidoPat.Trim()+" "+v.ApellidoMat.Trim(), v.Telefono, v.Correo, v.RFC, v.Tipo);
            }
        }
    }
}
