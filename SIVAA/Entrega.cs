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

        public Entrega(SIVAA mainForm)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel5.Height - 1, panel5.Width, panel5.Height - 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //244
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

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel10.Height - 1, panel10.Width, panel10.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
