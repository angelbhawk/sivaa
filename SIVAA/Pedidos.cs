using Datos;
using Entidades;
using iTextSharp.text;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVAA
{
    public partial class Pedidos : Form
    {
        private SIVAA form;
        List<PedidoEs> pedidoEs = new List<PedidoEs>();
        PedidoD PedidoD = new PedidoD();
        List<PedidoEs> lista = new List<PedidoEs>();
        string id = null;

        public Pedidos(SIVAA form)
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            this.form = form;
            Mostrar();
            lista = PedidoD.ListaPedidos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            form.cambiarPantalla(new EspPedido(form, 0, ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                form.cambiarPantalla(new EspPedido(form, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona un Pedido");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoD.Eliminar(id);
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
                MostrarEsp(txtBuscar.Text, "p.IDPedido");
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                MostrarEsp(txtBuscar.Text, "e.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 3)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 4)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 5)
            {
                MostrarEsp(txtBuscar.Text, "po.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 6)
            {
                MostrarEsp(txtBuscar.Text, "p.Dia");
            }
            else if (cbFiltro.SelectedIndex == 7)
            {
                MostrarEsp(txtBuscar.Text, "p.Mes");
            }
            else if (cbFiltro.SelectedIndex == 8)
            {
                MostrarEsp(txtBuscar.Text, "p.Año");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, "p.Importe");
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(lista);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de pedidos", "Pedidos registrados");
            form.cambiarPantalla(new Previsualizador("Reporte de Pedidos"));
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
            List<PedidoEs> list = PedidoD.ListadoEspecifico(busqueda, filtro);
            foreach (PedidoEs x in list)
            {
                string fecha = x.Dia.ToString() + "/" + x.Mes.ToString() + "/" + x.Año.ToString();
                dataGridView1.Rows.Add(x.IDPedido, x.Empleado, x.Proveedor, fecha, x.Importe);
            }
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            pedidoEs.Clear();
            pedidoEs = PedidoD.ListaPedidos();
            foreach (PedidoEs x in pedidoEs)
            {
                string fecha = x.Dia.ToString() + "/" + x.Mes.ToString() + "/" + x.Año.ToString();
                dataGridView1.Rows.Add(x.IDPedido, x.Empleado, x.Proveedor, fecha, x.Importe);
            }
        }

    }
}
