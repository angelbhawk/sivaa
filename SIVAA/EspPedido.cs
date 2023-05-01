using Datos;
using Entidades;
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
    public partial class EspPedido : Form
    {
        SIVAA form;
        int modo;
        PedidoD PedidoLog = new PedidoD();
        Pedido pedido = new Pedido();
        EmpleadoLog empleados = new EmpleadoLog();
        ProveedorLog proveedores = new ProveedorLog();

        public EspPedido(SIVAA form, int modo, string id)
        {
            InitializeComponent();
            this.form = form;
            this.modo = modo;
            CargarDatos();
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


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<Pedido> x = PedidoLog.ListadoTotal();
                    string i = "PD" + (x.Count + 1).ToString();
                    pedido.IDPedido = i;
                    pedido.IDEmpleado = iD(cbEmpleado.Text, 0);
                    pedido.IDProveedor = iD(cbProveedor.Text, 1);
                    pedido.Dia = date.Value.Day;
                    pedido.Mes = date.Value.Month;
                    pedido.Año = date.Value.Year;
                    pedido.Importe = Convert.ToDouble(txtImporte.Text);
                    PedidoLog.Insertar(pedido);

                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    pedido.IDEmpleado = iD(cbEmpleado.Text, 0);
                    pedido.IDProveedor = iD(cbProveedor.Text, 1);
                    pedido.Dia = date.Value.Day;
                    pedido.Mes = date.Value.Month;
                    pedido.Año = date.Value.Year;
                    pedido.Importe = Convert.ToDouble(txtImporte.Text);
                    PedidoLog.Actualizar(pedido);

                    MessageBox.Show("Actualizado con exito", "Mensaje");
                }
                form.cambiarPantalla(new Pedidos(form));
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        #region Metodos

        private void CargarDatos()
        {
            List<Empleado> empleado = empleados.ListadoAll();
            foreach (Empleado x in empleado)
            {
                string nombre = x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                cbEmpleado.Items.Add(nombre);
            }
            List<Proveedor> proveedor = proveedores.ListadoAll();
            foreach (Proveedor x in proveedor)
            {
                cbProveedor.Items.Add(x.Nombre);
            }
        }

        private string iD(string nombre, int tipo)
        {
            if (tipo == 0)
            {
                List<Empleado> em = empleados.ListadoAll();

                foreach (Empleado x in em)
                {
                    string i = x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    if (i == nombre)
                    {
                        return x.IDEmpleado;
                    }
                }
            }
            if (tipo == 1)
            {
                List<Proveedor> pe = proveedores.ListadoAll();
                foreach (Proveedor x in pe)
                {
                    if (x.Nombre == nombre)
                    {
                        return x.IDProveedor;
                    }
                }
            }
            return null;
        }

        private string Nombre(string id, int tipo)
        {
            if (tipo == 0)
            {
                List<Empleado> em = empleados.ListadoAll();
                foreach (Empleado x in em)
                {
                    if (x.IDEmpleado == id)
                    {
                        return x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    }
                }
            }
            if (tipo == 1)
            {
                List<Proveedor> pe = proveedores.ListadoAll();
                foreach (Proveedor x in pe)
                {
                    if (x.IDProveedor == id)
                    {
                        return x.Nombre;
                    }
                }
            }
            return null;
        }
        private void Datos(string id)
        {
            List<Pedido> pe = PedidoLog.ListadoTotal();
            foreach (Pedido p in pe)
            {
                if (p.IDPedido == id)
                {
                    pedido.IDPedido = p.IDPedido;
                    cbEmpleado.Text = Nombre(p.IDEmpleado, 0);
                    cbProveedor.Text = Nombre(p.IDProveedor, 1);
                    txtImporte.Text = p.Importe.ToString();
                    date.Value = new DateTime(p.Año, p.Mes, p.Dia);

                }
            }
        }
        #endregion


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            form.cambiarPantalla(new Pedidos(form));
        }
    }
}
