using Datos;
using Entidades;
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
    public partial class EspCliente : Form
    {
        private SIVAA mainForm;
        private int modo;
        readonly ClienteLog clientes = new ClienteLog();
        private Cliente cliente = new Cliente();

        public EspCliente(SIVAA mainForm, int modo, string id)
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
            mainForm.cambiarPantalla(new Clientes(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<Cliente> em = clientes.ListadoAll();
                    string i = "C" + (em.Count + 1).ToString();
                    cliente.IDCliente = i;
                    cliente.Nombre = txtNombre.Text;
                    cliente.ApellidoPat = txtApellidoP.Text;
                    cliente.ApellidoMat = txtApellidoM.Text;
                    cliente.NoExterior = txtNoExterior.Text;
                    cliente.RFC = txtRFC.Text;
                    cliente.Colonia = txtColonia.Text;
                    cliente.Estado = txtEstado.Text;
                    cliente.Correo = txtCorreo.Text; 
                    cliente.Ciudad = txtCiudad.Text; 
                    cliente.Telefono = txtTelefono.Text;

                    clientes.Registrar(cliente);

                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    cliente.Nombre = txtNombre.Text;
                    cliente.ApellidoPat = txtApellidoP.Text;
                    cliente.ApellidoMat = txtApellidoM.Text;
                    cliente.NoExterior = txtNoExterior.Text;
                    cliente.RFC = txtRFC.Text;
                    cliente.Colonia = txtColonia.Text;
                    cliente.Estado = txtEstado.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.Telefono = txtTelefono.Text;
                    clientes.Modificar(cliente);

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
            List<Cliente> es = clientes.ListadoAll();
            foreach (Cliente x in es)
            {
                if (x.IDCliente == id)
                {
                    cliente.IDCliente = x.IDCliente;
                    txtNombre.Text = x.Nombre;
                    txtApellidoP.Text = x.ApellidoPat;
                    txtApellidoM.Text = x.ApellidoMat;
                    txtCorreo.Text = x.Correo;
                    txtRFC.Text = x.RFC;
                    txtTelefono.Text = x.Telefono;
                    txtColonia.Text = x.Colonia;
                    txtCiudad.Text = x.Ciudad;
                    txtEstado.Text = x.Estado;
                    txtNoExterior.Text = x.NoExterior;
                }
            }
        }
    }
}
