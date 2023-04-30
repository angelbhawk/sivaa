using Datos;
using Entidades;
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
    public partial class Pedidos : Form
    {
        List<PedidoEs> pedido = new List<PedidoEs>();
        PedidoD PedidoD = new PedidoD();

        public Pedidos()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            pedido.Clear();
            pedido = PedidoD.ListaPedidos();
            foreach (PedidoEs x in pedido)
            {
                string fecha = x.Dia.ToString() + "/" + x.Mes.ToString() + "/" + x.Año.ToString();
                dataGridView1.Rows.Add(x.IDPedido, x.Empleado, x.Proveedor, fecha, x.Importe);
            }
        }
    }
}
