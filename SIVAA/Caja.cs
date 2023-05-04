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
    public partial class Caja : Form
    {
        private SIVAA mainForm;

        public Caja(SIVAA mainForm)
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            this.mainForm = mainForm;
        }

        private void paneltipooperacion_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, paneltipooperacion.Height - 1, paneltipooperacion.Width, paneltipooperacion.Height - 1);
        }

        private void panelcodigodepago_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panelcodigodepago.Height - 1, panelcodigodepago.Width, panelcodigodepago.Height - 1);
        }

        private void panelformadepago_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panelformadepago.Height - 1, panelformadepago.Width, panelformadepago.Height - 1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Cobro(mainForm));
        }
    }
}
