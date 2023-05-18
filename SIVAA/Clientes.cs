using Datos;
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
    public partial class Clientes : Form
    {
        private SIVAA mainForm;
        readonly ClienteLog cliente = new ClienteLog();
        string id;

        public Clientes(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        List<Cliente> listas;
        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Cliente> pro = cliente.ListadoAll();
            listas = pro;
            foreach (Cliente x in pro)
            {
                dataGridView1.Rows.Add(x.IDCliente.Trim(), x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.RFC.Trim(), x.Correo.Trim(), x.Telefono.Trim(), x.Colonia.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Estado.Trim());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspCliente(mainForm, 0, ""));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                mainForm.cambiarPantalla(new EspCliente(mainForm, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona un Cliente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(listas);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de Clientes", "Clientes Registrados");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de Clientes"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Eliminar(id);
                Mostrar();
                MessageBox.Show("Eliminado con exito", "Mensaje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible eliminar la tabla", "ERROR");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }
            else if (cbFiltro.SelectedIndex == 3)
            {
                MostrarEsp(txtBuscar.Text, "ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 4)
            {
                MostrarEsp(txtBuscar.Text, "ApellidoMaterno");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, cbFiltro.Text);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1[0, i].Value.ToString();
            }
        }

        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            listas.Clear();
            List<Cliente> pro = cliente.ListadoEsp(busqueda, filtro);
            listas = pro;
            foreach (Cliente x in pro)
            {
                dataGridView1.Rows.Add(x.IDCliente.Trim(), x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.RFC.Trim(), x.Correo.Trim(), x.Telefono.Trim(), x.Colonia.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Estado.Trim());
            }
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            listas.Clear();
            List<Cliente> pro = cliente.ListadoAll();
            listas = pro;
            foreach (Cliente x in pro)
            {
                dataGridView1.Rows.Add(x.IDCliente.Trim(), x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.RFC.Trim(), x.Correo.Trim(), x.Telefono.Trim(), x.Colonia.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Estado.Trim());
            }
        }
    }
}
