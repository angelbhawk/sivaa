using Datos;
using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
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
    public partial class EspEmpleado : Form
    {
        private SIVAA mainForm;
        private int modo;
        readonly EmpleadoLog empleados = new EmpleadoLog();
        private Empleado empleado = new Empleado();


        public EspEmpleado(SIVAA mainForm, int modo, string id)
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

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Empleados(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<Empleado> em = empleados.ListadoAll();
                    string i = "E" + (em.Count + 1).ToString();
                    empleado.IDEmpleado = i;
                    empleado.Nombre = txtNombre.Text;
                    empleado.ApellidoPat = txtApellidoP.Text;
                    empleado.ApellidoMat = txtApellidoM.Text;
                    empleado.Correo = txtCorreo.Text.Trim();
                    empleado.Telefono = txtTelefono.Text;
                    empleado.Contraseña = txtContraseña.Text;
                    empleado.RFC = txtRFC.Text.Trim();
                    empleado.Tipo = cbPuesto.Text;

                    empleados.Registrar(empleado);

                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    empleado.Nombre = txtNombre.Text;
                    empleado.ApellidoPat = txtApellidoP.Text;
                    empleado.ApellidoMat = txtApellidoM.Text;
                    empleado.Correo = txtCorreo.Text.Trim();
                    empleado.Telefono = txtTelefono.Text;
                    empleado.Contraseña = txtContraseña.Text;
                    empleado.RFC = txtRFC.Text.Trim();
                    empleado.Tipo = cbPuesto.Text;
                    empleados.Modificar(empleado);
                    MessageBox.Show("Actualizado con exito", "Mensaje");
                }
                mainForm.cambiarPantalla(new Empleados(mainForm));
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        private void Datos(string id)
        {
            List<Empleado> em = empleados.ListadoAll();
            foreach (Empleado x in em)
            {
                if (x.IDEmpleado == id)
                {
                    empleado.IDEmpleado = x.IDEmpleado;
                    txtNombre.Text = x.Nombre;
                    txtApellidoP.Text = x.ApellidoPat;
                    txtApellidoM.Text = x.ApellidoMat;
                    txtCorreo.Text = x.Correo;
                    txtRFC.Text = x.RFC;
                    txtTelefono.Text = x.Telefono;
                    txtContraseña.Text = x.Contraseña;
                    cbPuesto.Text = x.Tipo.Trim();
                }
            }
        }
    }
}
