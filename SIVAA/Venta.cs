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
    public partial class Venta : Form
    {
        private SIVAA mainForm;
        public string total;
        public Entidades.Venta VENTA;

        public Venta(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 170)
            {
                panel3.Height = 51;
            }
            else
                panel3.Height = 170;
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

        private void label12_Click(object sender, EventArgs e)
        {
            if (panel6.Height == 234)
            {
                panel6.Height = 51;
            }
            else
                panel6.Height = 234;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel5.Height - 1, panel5.Width, panel5.Height - 1);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel10.Height - 1, panel10.Width, panel10.Height - 1);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel8.Height - 1, panel8.Width, panel8.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirCotizaciones(new BusCotizacion(this));
        }

        public void abrirCotizaciones(Form child)
        {
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            panel1.Visible = false;
            panel2.Visible = false;
            child.Dock = DockStyle.Fill;
            this.Controls.Add(child);
            child.Location = new Point(0, 0);

            child.Show();
            this.Refresh();
        }

        public void cerrarCotizaciones(Form child)
        {
            child.Close();
            panel1.Visible = true;
            panel2.Visible = true;
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VENTA.NoSerie);
        }
    }
}
