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
            dataGridView1.ClearSelection();
            List<Proveedor> pro = proveedor.ListadoAll();
            listas = pro;
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor.Trim(), x.Nombre.Trim(), x.RFC.Trim(), x.Estado.Trim()+", "+ x.Ciudad.Trim() + ", "+x.Colonia.Trim());
            }
        }
    }
}
