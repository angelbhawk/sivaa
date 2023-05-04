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
    public partial class Cierre : Form
    {
        private SIVAA mainForm;
        private int uno = 0, dos = 0, cinco = 0, diez = 0, veinte = 0, cincuenta = 0, cien = 0, dosientos = 0, quinientos = 0, mil = 0;
        private double sumareal = 0, total = 0, pagosefectivo = 0, abonoefectivo = 0, pagostarjeta = 0, abonostarjeta = 0, totalefectivo = 0, totaltarjeta = 0;

        public Cierre(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            lblinicial.Text = mainForm.abertura_string;
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel4.Height - 1, panel4.Width, panel4.Height - 1);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel5.Height - 1, panel5.Width, panel5.Height - 1);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel6.Height - 1, panel6.Width, panel6.Height - 1);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(51, 58, 86);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel7.Height - 1, panel7.Width, panel7.Height - 1);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            mil++;
            lbln1000.Text = mil.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //-1000
            if (mil > 0)
            {


                mil -= Convert.ToInt32(nud1000.Value);
                lbln1000.Text = mil.ToString();
                sumareal -= Convert.ToInt32(nud1000.Value) * 1000;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");

            totalFinal();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //+1000
            mil += Convert.ToInt32(nud1000.Value);
            lbln1000.Text = mil.ToString();
            sumareal += Convert.ToInt32(nud1000.Value) * 1000;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //+200
            dosientos += Convert.ToInt32(nud200.Value);
            lbln200.Text = dosientos.ToString();
            sumareal += Convert.ToInt32(nud200.Value) * 200;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //-200
            if (dosientos > 0)
            {


                dosientos -= Convert.ToInt32(nud200.Value);
                lbln200.Text = dosientos.ToString();
                sumareal -= Convert.ToInt32(nud200.Value) * 200;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //+50
            cincuenta += Convert.ToInt32(nud50.Value);
            lbln50.Text = cincuenta.ToString();
            sumareal += Convert.ToInt32(nud50.Value) * 50;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //-50
            if (cincuenta > 0)
            {

                cincuenta -= Convert.ToInt32(nud50.Value);
                lbln50.Text = cincuenta.ToString();
                sumareal -= Convert.ToInt32(nud50.Value) * 50;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //+10
            diez += Convert.ToInt32(nud10.Value);
            lbln10.Text = diez.ToString();
            sumareal += Convert.ToInt32(nud10.Value) * 10;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //-10
            if (diez > 0)
            {

                diez -= Convert.ToInt32(nud10.Value);
                lbln10.Text = diez.ToString();
                sumareal -= Convert.ToInt32(nud10.Value) * 10;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //+2
            dos += Convert.ToInt32(nud2.Value);
            lbln2.Text = dos.ToString();
            sumareal += Convert.ToInt32(nud2.Value) * 2;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //-2
            if (dos > 0)
            {

                dos -= Convert.ToInt32(nud2.Value);
                lbln2.Text = dos.ToString();
                sumareal -= Convert.ToInt32(nud2.Value) * 2;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            //+500
            quinientos += Convert.ToInt32(nud500.Value);
            lbln500.Text = quinientos.ToString();
            sumareal += Convert.ToInt32(nud500.Value) * 500;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            //-500
            if (quinientos > 0)
            {

                quinientos -= Convert.ToInt32(nud500.Value);
                lbln500.Text = quinientos.ToString();
                sumareal -= Convert.ToInt32(nud500.Value) * 500;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            //+100
            cien += Convert.ToInt32(nud100.Value);
            lbln100.Text = cien.ToString();
            sumareal += Convert.ToInt32(nud100.Value) * 100;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            //-100
            if (cien > 0)
            {

                cien -= Convert.ToInt32(nud100.Value);
                lbln100.Text = cien.ToString();
                sumareal -= Convert.ToInt32(nud100.Value) * 100;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            //+20
            veinte += Convert.ToInt32(nud20.Value);
            lbln20.Text = veinte.ToString();
            sumareal += Convert.ToInt32(nud20.Value) * 20;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            //-20
            if (veinte > 0)
            {

                veinte -= Convert.ToInt32(nud20.Value);
                lbln20.Text = veinte.ToString();
                sumareal -= Convert.ToInt32(nud20.Value) * 20;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //+5
            cinco += Convert.ToInt32(nud5.Value);
            lbln5.Text = cinco.ToString();
            sumareal += Convert.ToInt32(nud5.Value) * 5;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //-5
            if (cinco > 0)
            {

                cinco -= Convert.ToInt32(nud5.Value);
                lbln5.Text = cinco.ToString();
                sumareal -= Convert.ToInt32(nud5.Value) * 5;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //+1
            uno += Convert.ToInt32(nud1.Value);
            lbln1.Text = uno.ToString();
            sumareal += Convert.ToInt32(nud1.Value) * 1;
            lbltotalreal.Text = sumareal.ToString();
            totalFinal();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //-1
            if (uno > 0)
            {

                uno -= Convert.ToInt32(nud1.Value);
                lbln1.Text = uno.ToString();
                sumareal -= Convert.ToInt32(nud1.Value) * 1;
                lbltotalreal.Text = sumareal.ToString();
            }

            else
                MessageBox.Show("El valor ingresado es mayor al valor registrado");
            totalFinal();
        }

        private void totalFinal()
        {
            total = totalefectivo + mainForm.abertura;
            lbltotalefectivo.Text = totalefectivo.ToString();
            lbltotaltarjeta.Text = totaltarjeta.ToString();
            blbtotalcaja.Text = total.ToString();
            
        }
    }
}
