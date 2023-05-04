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
    public partial class Versiones : Form
    {
        private SIVAA mainForm;
        private string id;
        private VersionLog vehiculo = new VersionLog();

        public Versiones(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        List<Entidades.Versiones> listas;
        private void Versiones_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Entidades.Versiones> pro = vehiculo.ListadoTotal();
            listas = pro;
            dataGridView1.Rows.Clear();
            foreach (Entidades.Versiones x in pro)
            {
                dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Version, x.TipoAsientos, x.TipoCombustible, x.Cilindraje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspVersion(mainForm, 0, ""));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                mainForm.cambiarPantalla(new EspVersion(mainForm, 1, id.Trim()));
            }
            else
            {
                MessageBox.Show("Selecciona una version");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de versiones"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo.Eliminar(id);
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
            if (cbFiltro.Text == "Todos")
            {
                Mostrar();
            }
            else if (cbFiltro.SelectedIndex == 1)
            {

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
            /*
            List<PedidoEs> list = PedidoD.ListadoEspecifico(busqueda, filtro);
            foreach (PedidoEs x in list)
            {
                string fecha = x.Dia.ToString() + "/" + x.Mes.ToString() + "/" + x.Año.ToString();
                dataGridView1.Rows.Add(x.IDPedido, x.Empleado, x.Proveedor, fecha, x.Importe);
            }
            */
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            List<Entidades.Versiones> pro = vehiculo.ListadoTotal();
            foreach (Entidades.Versiones x in pro)
            {
                dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Version, x.TipoAsientos, x.TipoCombustible, x.Cilindraje);
            }
        }
    }
}
