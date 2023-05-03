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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVAA
{
    public partial class EspProveedor : Form
    {
        private SIVAA mainForm;
        private int modo;
        private string id;
        readonly ProveedorLog proveedores = new ProveedorLog();
        private Proveedor proveedor = new Proveedor();


        public EspProveedor(SIVAA mainForm, int modo, string id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.modo = modo;
            this.id = id;
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
            mainForm.cambiarPantalla(new Proveedores(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<Proveedor> em = proveedores.ListadoAll();
                    string i = "P" + (em.Count + 1).ToString();
                    proveedor.IDProveedor = i;
                    proveedor.Nombre = txtNombre.Text;
                    proveedor.NoExterior = txtNoExterior.Text;
                    proveedor.Ciudad = txtCiudad.Text;
                    proveedor.Estado = txtEstado.Text;
                    proveedor.Colonia = txtColonia.Text;
                    proveedor.RFC = txtRFC.Text;

                    proveedores.Registrar(proveedor);

                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    proveedor.IDProveedor = id;
                    proveedor.Nombre = txtNombre.Text;
                    proveedor.NoExterior = txtNoExterior.Text;
                    proveedor.Ciudad = txtCiudad.Text;
                    proveedor.Estado = txtEstado.Text;
                    proveedor.Colonia = txtColonia.Text;
                    proveedor.RFC = txtRFC.Text;

                    proveedores.Modificar(proveedor);

                    MessageBox.Show("Actualizado con exito", "Mensaje");
                }
                mainForm.cambiarPantalla(new Proveedores(mainForm));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        private void Datos(string id)
        {
            List<Proveedor> pro = proveedores.ListadoAll();
            foreach (Proveedor x in pro)
            {
                if (x.IDProveedor.Trim() == id)
                {
                    txtNombre.Text = x.Nombre;
                    txtNoExterior.Text = x.NoExterior;
                    txtRFC.Text = x.RFC;
                    txtEstado.Text = x.Estado;
                    txtColonia.Text = x.Colonia;
                    txtCiudad.Text = x.Ciudad;
                }
            }
        }
    }
}
