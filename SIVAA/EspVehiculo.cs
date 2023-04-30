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
    public partial class EspVehiculo : Form
    {
        private SIVAA mainForm;
        readonly VehiculoLog vehiculo = new VehiculoLog();

        public EspVehiculo(SIVAA mainForm, int modo)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            if (modo == 0)
            {
                label2.Text = "Agregar";
                tbxId.Enabled = true;
                tbxNombre.Enabled = true;
            }
            else
            {
                label2.Text = "Modificar";
                tbxId.Enabled = false;
                tbxNombre.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Vehiculos(mainForm));
        }
    }
}
