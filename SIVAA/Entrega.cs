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
    public partial class Entrega : Form
    {
        private SIVAA mainForm;
        readonly VentaLog logven;
        readonly UnidadLog unidadLog;
        readonly VersionLog versionLog;
        private Entidades.Unidad unidad;
        private Entidades.Venta venta;
        private Entidades.Versiones version;

        public Entrega(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            logven = new VentaLog();
            unidadLog = new UnidadLog();
            versionLog = new VersionLog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Compras(mainForm));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }


        private void label7_Click(object sender, EventArgs e)
        {
            if (panel9.Height == 170)
            {
                panel9.Height = 51;
            }
            else
                panel9.Height = 170;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel10.Height - 1, panel10.Width, panel10.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta = logven.LeerPorClave(textBox4.Text);
            if (venta != null)
            {
                unidad = unidadLog.LeerPorClave(venta.NoSerie);
                version = versionLog.LeerPorClave(unidad.IDVersion);
                tbxcolor.Text = unidad.Color;
                tbxid.Text = unidad.IDVersion;
                tbxmodelo.Text = version.Version;
                tbxnoserie.Text = unidad.NoSerie;
                button2.Enabled = true;

            }
            else
            {
                MessageBox.Show("Ingresa un codigo valido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unidad.Estatus = "Vendido";
            unidadLog.Modificar(unidad);
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
