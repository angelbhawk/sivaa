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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIVAA
{
    public partial class Autenticacion : Form
    {
        private readonly EmpleadoLog PqteLog = new EmpleadoLog();

        public static SIVAA SIVAA = new SIVAA(null);

        public Autenticacion()
        {
            InitializeComponent();
            textBox6.Text = "j@gmail.mx";
            textBox1.Text = "password1";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);
            e.Graphics.DrawLine(new Pen(miColor), 0, panel3.Height - 1, panel3.Width, panel3.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cd = "", Con = "";

            try
            {
                Con = textBox1.Text;
                Cd = textBox6.Text;
                Empleado pqt = PqteLog.LeerPorClave(Cd, Con);
                if (pqt != null)
                {
                    if (pqt.Tipo.Trim() == "Atencion")
                    {
                        //MessageBox.Show("Atencion a clientes");
                        SIVAA AteSIVAA = new SIVAA(pqt);
                        this.Hide();
                        AteSIVAA.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Vendedor")
                    {
                        //MessageBox.Show("Vendedor");
                        SIVAA VenSIVAA = new SIVAA(pqt);
                        this.Hide();
                        VenSIVAA.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Cajero")
                    {
                        //MessageBox.Show("Cajero");
                        SIVAA CajSIVAA = new SIVAA(pqt);
                        this.Hide();
                        CajSIVAA.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Supervisor")
                    {
                        //MessageBox.Show("Supervisor");
                        SIVAA SupSIVAA = new SIVAA(pqt);
                        this.Hide();
                        SupSIVAA.Show();
                    }
                    //else
                    //MessageBox.Show("SIVAA de sesion erroneo: "+ pqt.Tipo);
                }
                else
                    MessageBox.Show("fallo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);
            e.Graphics.DrawLine(new Pen(miColor), 0, panel5.Height - 1, panel5.Width, panel5.Height - 1);
        }

        public void abrirRecuperar(Form child)
        {
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            panel7.Visible = false;
            child.Dock = DockStyle.Fill;
            panel6.Controls.Add(child);
            child.Location = new Point(0, 0);

            child.Show();
            this.Refresh();
        }

        public void cerrarRecuperar(Form child)
        {
            child.Close();
            panel7.Visible = true;
            this.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            abrirRecuperar(new Recuperar(this));
        }
    }
}
