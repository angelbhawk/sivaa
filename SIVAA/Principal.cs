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
    public partial class Principal : Form
    {
        private SIVAA mainForm;

        public Principal(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Vehiculos(mainForm));
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Versiones(mainForm));
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Empleados(mainForm));
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Proveedores(mainForm));
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Clientes(mainForm));
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Cotizaciones(mainForm));
        }
    }
}
