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
    public partial class Recuperar : Form
    {
        private Autenticacion mainForm;

        public Recuperar(Autenticacion mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);
            e.Graphics.DrawLine(new Pen(miColor), 0, panel5.Height - 1, panel5.Width, panel5.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recuperacion.recuperarContraseña(textBox6.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainForm.cerrarRecuperar(this);
        }
    }
}
