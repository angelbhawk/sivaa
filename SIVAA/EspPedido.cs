﻿using Datos;
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
        UnidadLog Unidades = new UnidadLog();
        Unidad unidad = new Unidad();
        VersionLog versionLog = new VersionLog();

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

                    unidad.IDPedido = i;
                    unidad.Color = cbColor.Text;
                    unidad.IDVersion = texto(cbVersion.Text, 1);
                    unidad.NoSerie = check(Aletorio());
                    unidad.Estatus = "En camino";

                    Unidades.Registrar(unidad);

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

                    unidad.IDPedido = pedido.IDPedido;
                    unidad.Color = cbColor.Text;
                    unidad.IDVersion = texto(cbVersion.Text, 1);
                    unidad.NoSerie = regreso(pedido.IDPedido);
                    unidad.Estatus = "En camino";

                    Unidades.Modificar(unidad);

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

        private string Aletorio()
        {
            Random random = new Random();
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int longitudTexto = 9;
            string textoAleatorio = "";

            for (int i = 0; i < longitudTexto; i++)
            {
                int indiceCaracter = random.Next(caracteresPermitidos.Length);
                textoAleatorio += caracteresPermitidos[indiceCaracter];
            }
            return textoAleatorio;
        }

        private void CargarDatos()
        {
            List<Empleado> empleado = empleados.ListaEsp("Supervisor");
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
            if (tipo == 2)
            {
                List<CotiVh> refVersions = PedidoLog.ReferenciaV(iD(cbProveedor.Text, 1));
                foreach (CotiVh x in refVersions)
                {
                    if (x.IDVersion == id)
                    {
                        return x.Nombre.Trim() + " " + x.Version.Trim() + " " + x.Año.Trim();
                    }
                }
            }
            return null;
        }

        private void Datos(string id)
        {
            List<Pedido> pe = PedidoLog.ListadoTotal();
            List<Unidad> un = Unidades.ListadoAll();
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
            foreach (Unidad x in un)
            {
                if (x.IDPedido == id)
                {
                    cbVersion.Text = Nombre(x.IDVersion, 2);
                    cbColor.Text = x.Color.Trim();
                }
            }
        }

        private string check(string noserie)
        {
            List<Unidad> uni = Unidades.ListadoAll();
            foreach (Unidad x in uni)
            {
                if (x.NoSerie != noserie)
                {
                    return noserie;
                }
            }
            return check(Aletorio());
        }

        private string regreso(string id)
        {
            List<Unidad> unidad = Unidades.ListadoAll();
            foreach (Unidad x in unidad)
            {
                if (x.IDPedido == id)
                {
                    return x.NoSerie;
                }
            }
            return null;
        }

        private string texto(string texto, int modo)
        {
            List<CotiVh> refVersions = PedidoLog.ReferenciaV(iD(cbProveedor.Text, 1));
            foreach (CotiVh x in refVersions)
            {
                string i = x.Nombre.Trim() + " " + x.Version.Trim() + " " + x.Año.Trim();
                if (texto == i)
                {
                    if (modo == 0)
                    {
                        return x.Costo.ToString();
                    }
                    else
                    {
                        return x.IDVersion;
                    }
                }
            }
            return null;
        }

        #endregion



        private void label1_Click(object sender, EventArgs e)
        {
            form.cambiarPantalla(new Pedidos(form));
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CotiVh> refVersions = PedidoLog.ReferenciaV(iD(cbProveedor.Text, 1));
            foreach (CotiVh x in refVersions)
            {
                cbVersion.Items.Add(x.Nombre.Trim() + " " + x.Version.Trim() + " " + x.Año.Trim());
            }
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtImporte.Text = texto(cbVersion.Text, 0);
        }
    }
}
