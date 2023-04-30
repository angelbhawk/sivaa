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
            dataGridView1.ClearSelection();
            List<Cliente> pro = cliente.ListadoAll();
            listas = pro;
            foreach (Cliente x in pro)
            {
                dataGridView1.Rows.Add(x.IDCliente.Trim(), x.Nombre.Trim()+" "+x.ApellidoPat.Trim()+" "+x.ApellidoMat.Trim(), x.RFC.Trim(), x.Correo.Trim(), x.Telefono.Trim(), x.Estado.Trim() + ", " + x.Ciudad.Trim() + ", " + x.Colonia.Trim());
            }
        }
    }
}
