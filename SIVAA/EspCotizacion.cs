using Datos;
using Entidades;
using iTextSharp.text.pdf;
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
    public partial class EspCotizacion : Form
    {
        private SIVAA mainForm;
        private int modo;
        private string id;
        CotizacionLog cotizacion = new CotizacionLog();
        EmpleadoLog empleado = new EmpleadoLog();
        ClienteLog cliente = new ClienteLog();
        CotizacionCreditoLog creditoLog = new CotizacionCreditoLog();
        CotizacionContadoLog contadoLog = new CotizacionContadoLog();
        CotizacionUsar coti = new CotizacionUsar();
        CotizacionContado contado = new CotizacionContado();
        CotizacionCredito credito = new CotizacionCredito();
        CotiVh cotiVh = new CotiVh();


        public EspCotizacion(SIVAA mainForm, int modo, string id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.modo = modo;
            this.id = id;
            cargarDatos();
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
            mainForm.cambiarPantalla(new Cotizaciones(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<CotizacionUsar> x = cotizacion.ListadoAll();
                    string i = "CO" + (x.Count + 2).ToString();
                    if (cbTipo.Text == "Contado")
                    {
                        coti.IDCotizacion = i;
                        coti.IDVersion = texto(cbVersion.Text, 1);
                        coti.IDEmpleado = iD(cbEmpleado.Text, 0);
                        coti.IDCliente = iD(cbCliente.Text, 1);
                        coti.PrecioInicial = Convert.ToDouble(txtPrecioInicial.Text);
                        coti.Dia = dateTimer.Value.Day;
                        coti.Mes = dateTimer.Value.Month;
                        coti.Año = dateTimer.Value.Year;
                        coti.TipoPago = "Contado";

                        cotizacion.Registrar(coti);

                        contado.IDCotizacion = i;
                        contadoLog.Registrar(contado);
                    }
                    else
                    {
                        coti.IDCotizacion = i;
                        coti.IDVersion = texto(cbVersion.Text, 1);
                        coti.IDEmpleado = iD(cbEmpleado.Text, 0);
                        coti.IDCliente = iD(cbCliente.Text, 1);
                        coti.PrecioInicial = Convert.ToDouble(txtPrecioInicial.Text);
                        coti.Dia = dateTimer.Value.Day;
                        coti.Mes = dateTimer.Value.Month;
                        coti.Año = dateTimer.Value.Year;
                        coti.TipoPago = "Credito";

                        cotizacion.Registrar(coti);

                        credito.IDCotizacion = i;
                        credito.Financiamiento = Convert.ToDouble(txtFinanciamiento.Text);
                        credito.Enganche = Convert.ToDouble(txtEnganche.Text);
                        credito.PorcentajeEnganche = txtPorcentaje.Text;
                        credito.Interes = txtInteres.Text;
                        credito.Anualidad = Convert.ToDouble(txtAnualidad.Text);
                        credito.Plazo = Convert.ToInt16(nudPlazo.Value);
                        credito.Mensualidad = Convert.ToDouble(txtMensualidad.Text);
                        credito.Precio = Convert.ToDouble(txtPrecio.Text);

                        creditoLog.Registrar(credito);

                    }

                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    if (cbTipo.Text == "Contado")
                    {
                        coti.IDCotizacion = id;
                        coti.IDVersion = texto(cbVersion.Text, 1);
                        coti.IDEmpleado = iD(cbEmpleado.Text, 0);
                        coti.IDCliente = iD(cbCliente.Text, 1);
                        coti.PrecioInicial = Convert.ToDouble(txtPrecioInicial.Text);
                        coti.Dia = dateTimer.Value.Day;
                        coti.Mes = dateTimer.Value.Month;
                        coti.Año = dateTimer.Value.Year;
                        coti.TipoPago = "Contado";

                        cotizacion.Modificar(coti);

                        contado.IDCotizacion = id;
                        contadoLog.Modificar(contado);
                    }
                    else
                    {
                        List<CotizacionUsar> x = cotizacion.ListadoAll();
                        string i = "CO" + (x.Count + 1).ToString();
                        coti.IDCotizacion = id;
                        coti.IDVersion = texto(cbVersion.Text, 1);
                        coti.IDEmpleado = iD(cbEmpleado.Text, 0);
                        coti.IDCliente = iD(cbCliente.Text, 1);
                        coti.PrecioInicial = Convert.ToDouble(txtPrecioInicial.Text);
                        coti.Dia = dateTimer.Value.Day;
                        coti.Mes = dateTimer.Value.Month;
                        coti.Año = dateTimer.Value.Year;
                        coti.TipoPago = "Credito";

                        cotizacion.Modificar(coti);

                        credito.IDCotizacion = id;
                        credito.Financiamiento = Convert.ToDouble(txtFinanciamiento.Text);
                        credito.Enganche = Convert.ToDouble(txtEnganche.Text);
                        credito.PorcentajeEnganche = txtPorcentaje.Text;
                        credito.Interes = txtInteres.Text;
                        credito.Anualidad = Convert.ToDouble(txtAnualidad.Text);
                        credito.Plazo = Convert.ToInt16(nudPlazo.Value);
                        credito.Mensualidad = Convert.ToDouble(txtMensualidad.Text);
                        credito.Precio = Convert.ToDouble(txtPrecio.Text);

                        creditoLog.Modificar(credito);

                    }

                    MessageBox.Show("Actualizado con exito", "Mensaje");
                }
                mainForm.cambiarPantalla(new Cotizaciones(mainForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visible(cbTipo.Text);
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecioInicial.Text = texto(cbVersion.Text, 0);
        }

        #region Metodos
        private void cargarDatos()
        {
            List<Empleado> em = empleado.ListaEsp("Vendedor");
            foreach (Empleado x in em)
            {
                cbEmpleado.Items.Add(x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim());
            }
            List<Cliente> cl = cliente.ListadoAll();
            foreach (Cliente x in cl)
            {
                cbCliente.Items.Add(x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim());
            }
            List<CotiVh> cv = cotizacion.ListaDis();
            foreach (CotiVh x in cv)
            {
                cbVersion.Items.Add(x.Nombre.Trim() + " " + x.Version.Trim() + " " + x.Año.Trim());
            }
        }

        private string texto(string texto, int modo)
        {
            List<CotiVh> refVersions = cotizacion.ListaDis();
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
                        return x.IDVersion.Trim();
                    }
                }
            }
            return null;
        }

        private void Datos(string id)
        {
            string tipo = null;
            List<CotizacionUsar> ct = cotizacion.ListadoAll();
            List<CotizacionCredito> cc = creditoLog.ListadoAll();
            foreach(CotizacionUsar x in ct)
            {
                if (x.IDCotizacion.Trim() == id)
                {
                    cbCliente.Text = Nombre(x.IDCliente.Trim(), 1);
                    cbEmpleado.Text = Nombre(x.IDEmpleado.Trim(), 0);
                    cbVersion.Text = Nombre(x.IDVersion.Trim(), 2);
                    txtPrecioInicial.Text = x.PrecioInicial.ToString();
                    dateTimer.Value = new DateTime(x.Año, x.Mes, x.Dia);
                    cbTipo.Text = x.TipoPago.Trim();
                    tipo = x.TipoPago.Trim();
                }
            }
            if(tipo == "Credito")
            {
                Visible("Credito");
                foreach (CotizacionCredito x in cc)
                {
                    if (x.IDCotizacion.Trim() == id)
                    {
                        txtAnualidad.Text = x.Anualidad.ToString();
                        txtEnganche.Text = x.Enganche.ToString();
                        txtFinanciamiento.Text = x.Financiamiento.ToString();
                        txtInteres.Text = x.Interes.ToString();
                        txtMensualidad.Text = x.Anualidad.ToString();
                        txtPorcentaje.Text = x.PorcentajeEnganche.ToString();
                        txtPrecio.Text = x.Precio.ToString();
                        nudPlazo.Value = x.Plazo;
                    }
                }
            }
        }


        private string iD(string nombre, int tipo)
        {
            if (tipo == 0)
            {
                List<Empleado> em = empleado.ListaEsp("Vendedor");

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
                List<Cliente> cl = cliente.ListadoAll();
                foreach (Cliente x in cl)
                {
                    string j = x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    if (j == nombre)
                    {
                        return x.IDCliente;
                    }
                }
            }
            return null;
        }

        private string Nombre(string id, int tipo)
        {
            if (tipo == 0)
            {
                List<Empleado> em = empleado.ListaEsp("Vendedor");
                foreach (Empleado x in em)
                {
                    if (x.IDEmpleado.Trim() == id)
                    {
                        return x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    }
                }
            }
            if (tipo == 1)
            {
                List<Cliente> cl = cliente.ListadoAll();
                foreach (Cliente x in cl)
                {
                    if (x.IDCliente.Trim() == id)
                    {
                        return x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    }
                }
            }
            if (tipo == 2)
            {
                List<CotiVh> refVersions = cotizacion.ListaDis();
                foreach (CotiVh x in refVersions)
                {
                    if (x.IDVersion.Trim() == id)
                    {
                        return x.Nombre.Trim() + " " + x.Version.Trim() + " " + x.Año.Trim();
                    }
                }
            }
            return null;
        }

        private void Visible(string texto)
        {
            if (texto == "Credito")
            {
                txtAnualidad.Visible = true;
                txtEnganche.Visible = true;
                txtFinanciamiento.Visible = true;
                txtInteres.Visible = true;
                txtMensualidad.Visible = true;
                txtPorcentaje.Visible = true;
                txtPrecio.Visible = true;
                lblAnualidad.Visible = true;
                lblEnganche.Visible = true;
                lblFinanciamiento.Visible = true;
                lblInteres.Visible = true;
                lblMensualidad.Visible = true;
                lblPorcentaje.Visible = true;
                lblPrecio.Visible = true;
                nudPlazo.Visible = true;
                lblPlazo.Visible = true;

            }
            else
            {
                txtAnualidad.Visible = false;
                txtEnganche.Visible = false;
                txtFinanciamiento.Visible = false;
                txtInteres.Visible = false;
                txtMensualidad.Visible = false;
                txtPorcentaje.Visible = false;
                txtPrecio.Visible = false;
                lblAnualidad.Visible = false;
                lblEnganche.Visible = false;
                lblFinanciamiento.Visible = false;
                lblInteres.Visible = false;
                lblMensualidad.Visible = false;
                lblPorcentaje.Visible = false;
                lblPrecio.Visible = false;
                nudPlazo.Visible = false;
                lblPlazo.Visible = false;
            }
        }
        #endregion

    }
}
