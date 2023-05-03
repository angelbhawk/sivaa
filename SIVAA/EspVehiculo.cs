using Datos;
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
        private int modo;
        readonly VehiculoLog vehiculos = new VehiculoLog();
        private Vehiculo vehiculo = new Vehiculo();
        

        public EspVehiculo(SIVAA mainForm, int modo, string id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.modo = modo;
            if (modo == 0)
            {
                label2.Text = "Agregar";
            }
            else
            {
                label2.Text = "Modificar";
                Datos(id);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    if (Verificacion(tbxNombre.Text) != false)
                    {
                        List<Vehiculo> vh = vehiculos.ListadoAll();
                        string i = "VH" + (vh.Count + 1).ToString();
                        vehiculo.IDVehiculo = i;
                        vehiculo.Nombre = tbxNombre.Text;
                        vehiculos.Registrar(vehiculo);

                        MessageBox.Show("Agregado con exito", "Mensaje");
                        mainForm.cambiarPantalla(new Vehiculos(mainForm));
                    }
                    else
                    {
                        MessageBox.Show("Vehiculo ya existente", "Aviso");
                    }
                }
                else
                {
                    vehiculo.Nombre = tbxNombre.Text;
                    vehiculos.Modificar(vehiculo);
                    MessageBox.Show("Actualizado con exito", "Mensaje");
                    mainForm.cambiarPantalla(new Vehiculos(mainForm));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        private bool Verificacion(string nombre)
        {
            List<Vehiculo> vh = vehiculos.ListadoAll();
            foreach (Vehiculo x in vh)
            {
                if (x.Nombre.Trim() == nombre)
                {
                    return false;
                }
            }
            return true;
        }

        private void Datos(string id)
        {
            List<Vehiculo> vh = vehiculos.ListadoAll();
            foreach(Vehiculo x in vh)
            {
                if(x.IDVehiculo == id)
                {
                    vehiculo.IDVehiculo = x.IDVehiculo;
                    tbxNombre.Text = x.Nombre;
                }
            }
        }
    }
}
