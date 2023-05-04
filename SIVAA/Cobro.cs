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
    public partial class Cobro : Form
    {
        private SIVAA mainForm;
        

        public Cobro(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!mainForm.estado_de_caja)
            {
                MessageBox.Show("La caja no esta abierta", "Cerrar caja");
            }
            else
            {
                mainForm.cambiarPantalla(new Caja(mainForm));
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!mainForm.estado_de_caja)
            {
                InputDialog a = new InputDialog("Ingrese el valor de apertura:", "Abrir caja");
                DialogResult dialogResult = a.ShowDialog();
                mainForm.abertura_string = a.s;

                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show($"Ha abierto la caja con: {mainForm.abertura_string}", "Abrir caja");
                    mainForm.abertura = Convert.ToDouble(mainForm.abertura_string);
                    mainForm.estado_de_caja = true;
                }
            }
            else
            {
                MessageBox.Show("La caja ya esta abierta", "Abrir caja");
            }

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!mainForm.estado_de_caja)
            {
                MessageBox.Show("La caja no esta abierta", "Cerrar caja");
            }
            else
            {
                mainForm.cambiarPantalla(new Cierre(mainForm));
            }    
        }
    }
}