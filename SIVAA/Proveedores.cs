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
    public partial class Proveedores : Form
    {
        private SIVAA mainForm;
        private string id;
        readonly ProveedorLog proveedor = new ProveedorLog();


        public Proveedores(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }
        List<Proveedor> listas;
        private void Proveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Proveedor> pro = proveedor.ListadoAll();
            listas = pro;
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor.Trim(), x.Nombre.Trim(), x.RFC.Trim(), x.Estado.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Colonia.Trim());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspProveedor(mainForm, 0, ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                mainForm.cambiarPantalla(new EspProveedor(mainForm, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona un Proveedor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de proveedores"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedor.Eliminar(id);
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
            else if (cbFiltro.SelectedIndex == 1)
            {
                MostrarEsp(txtBuscar.Text, "IDProovedor");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, cbFiltro.Text);
            }
        }


        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            List<Proveedor> pro = proveedor.ListadoEspecifico(busqueda, filtro);
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor.Trim(), x.Nombre.Trim(), x.RFC.Trim(), x.Estado.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Colonia.Trim());
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

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            List<Proveedor> pro = proveedor.ListadoAll();
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor.Trim(), x.Nombre.Trim(), x.RFC.Trim(), x.Estado.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Colonia.Trim());
            }
        }

    }
}
