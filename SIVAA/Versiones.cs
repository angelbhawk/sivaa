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
        readonly VersionLog vehiculo = new VersionLog();

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
                dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Version,x.TipoAsientos, x.TipoCombustible, x.Cilindraje);
            }
        }
    }
}
