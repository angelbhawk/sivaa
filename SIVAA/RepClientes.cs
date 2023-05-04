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
    public partial class RepClientes : Form
    {
        private SIVAA mainForm;
        private List<Entidades.Cliente> listas;
        readonly ClienteLog cliente = new ClienteLog();

        public RepClientes(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Entidades.RepCliente> rvs = new List<Entidades.RepCliente>();

            foreach (Entidades.Cliente v in listas)
            {
                Entidades.RepCliente r = new Entidades.RepCliente();
                r.IDCliente = v.IDCliente;
                r.Nombre = v.Nombre.Trim()+" "+v.ApellidoPat.Trim()+" "+v.ApellidoMat.Trim();
                r.RFC = v.RFC;
                r.Correo = v.Correo;
                r.Telefono = v.Telefono;
                r.Direccion = v.Estado.Trim() + ", " + v.Ciudad.Trim()+", "+v.Colonia.Trim();
                rvs.Add(r);
            }

            string html = ImpresorPdf.Formatear(rvs);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de clientes", "Clientes registrados");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de clientes"));
        }

        private void RepClientes_Load(object sender, EventArgs e)
        {
            listas = cliente.ListadoAll();

            foreach (Entidades.Cliente v in listas)
            {
                dataGridView1.Rows.Add(v.IDCliente, v.Nombre.Trim()+" "+v.ApellidoPat.Trim()+" "+v.ApellidoMat.Trim(), v.RFC, v.Correo.Trim(), v.Telefono, v.Estado.Trim() + ", " + v.Ciudad.Trim() + ", " + v.Colonia.Trim());
            }
        }
    }
}
