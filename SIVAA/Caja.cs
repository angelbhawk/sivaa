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
    public partial class Caja : Form
    {
        private SIVAA mainForm;

        readonly VentaLog logventa;
        readonly VersionLog logver;
        readonly UnidadLog loguni;
        readonly PagoLog logpago;
        readonly VentaContadoLog logvencon;
        readonly VentaCreditoLog logvencred;
        readonly AbonoLog logabo;
        readonly CotizacionCreditoLog logcoticred;
        readonly CotizacionLog logcot;

        private Entidades.Venta eventa;
        private Entidades.Versiones ver;
        private Entidades.Unidad uni;
        private Entidades.VentaCredito vencred;
        private Entidades.VentaContado vencon;
        private Entidades.Abono abo;
        private Entidades.CotizacionCredito coticred;
        private Entidades.CotizacionUsar cotizacion;

        private Entidades.Pago pago;
        private Entidades.Abono abono;

        public Caja(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            logventa = new VentaLog();
            logver = new VersionLog();
            loguni = new UnidadLog();
            logpago = new PagoLog();
            logvencon = new VentaContadoLog();
            logvencred = new VentaCreditoLog();
            logabo = new AbonoLog();
            logcoticred = new CotizacionCreditoLog();
            logcot = new CotizacionLog();
        }

        private void paneltipooperacion_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, paneltipooperacion.Height - 1, paneltipooperacion.Width, paneltipooperacion.Height - 1);
        }

        private void panelcodigodepago_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panelcodigodepago.Height - 1, panelcodigodepago.Width, panelcodigodepago.Height - 1);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbpago.Checked == true)
                {
                    if (logvencon.existe(tbxidventa.Text))
                    {
                        eventa = logventa.LeerPorClave(tbxidventa.Text);
                        Entidades.Pago p = new Entidades.Pago();
                        List<Entidades.Pago> pagos = logpago.ListadoAll();
                        vencon = logvencon.LeerPorClave(eventa.IDVenta);
                        cotizacion = logcot.LeerPorClave(vencon.IDCotizacion);
                        uni = loguni.LeerPorClave(eventa.NoSerie);
                        ver = logver.LeerPorClave(uni.IDVersion);

                        p.IDPago = "PA" + (pagos.Count + 2).ToString();
                        p.IDVenta = eventa.IDVenta;
                        p.FormaPago = "CONTADO";
                        p.Dia = DateTime.Now.Day;
                        p.Mes = DateTime.Now.Month;
                        p.Año = DateTime.Now.Year;
                        //p.Monto = Convert.ToDouble(tbxMonto.Text);
                        //logpago.Registrar(p);
                        pago = p;

                        tbxVehiculo.Text = eventa.NoSerie;
                        tbxMonto.Text = cotizacion.PrecioInicial.ToString();
                        tbxVersion.Text = ver.Version.ToString();
                        //MessageBox.Show("Pago registrado");
                        //mainForm.cambiarPantalla(new Cobro(mainForm));
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un id valido");
                    }
                }
                else if (cbanualidad.Checked == true)
                {
                    if (logvencred.existe(tbxidventa.Text))
                    {
                        eventa = logventa.LeerPorClave(tbxidventa.Text);
                        vencred = logvencred.LeerPorClave(tbxidventa.Text);
                        Entidades.Abono a = new Entidades.Abono();
                        List<Entidades.Abono> abonos = logabo.ListadoAll();
                        coticred = logcoticred.LeerPorClave(vencred.IDCotizacion);
                        uni = loguni.LeerPorClave(eventa.NoSerie);
                        ver = logver.LeerPorClave(uni.IDVersion);

                        a.IDAbono = "AB" + (abonos.Count + 2).ToString();
                        a.IDVenta = eventa.IDVenta;
                        a.IDEmpleado = mainForm.empleado.IDEmpleado;
                        a.SaldoActual = coticred.Precio - coticred.Anualidad;
                        a.SaldoActual = coticred.Precio;
                        a.Monto = coticred.Anualidad;
                        a.FormaPago = "CONTADO";
                        a.Dia = DateTime.Now.Day;
                        a.Mes = DateTime.Now.Month;
                        a.Año = DateTime.Now.Year;
                        a.Tipo = "Anualidad";
                        abono = a;

                        tbxVehiculo.Text = eventa.NoSerie;//eventa.NoSerie;
                        tbxMonto.Text = coticred.Anualidad.ToString();//cotizacion.PrecioInicial.ToString();
                        tbxVersion.Text = ver.Version.ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un id valido");
                    }
                }
                else if (cbmensualidad.Checked == true)
                {
                    if (logvencred.existe(tbxidventa.Text))
                    {
                        eventa = logventa.LeerPorClave(tbxidventa.Text);
                        vencred = logvencred.LeerPorClave(tbxidventa.Text);
                        Entidades.Abono a = new Entidades.Abono();
                        List<Entidades.Abono> abonos = logabo.ListadoAll();
                        coticred = logcoticred.LeerPorClave(vencred.IDCotizacion);
                        uni = loguni.LeerPorClave(eventa.NoSerie);
                        ver = logver.LeerPorClave(uni.IDVersion);

                        a.IDAbono = "AB" + (abonos.Count + 2).ToString();
                        a.IDVenta = eventa.IDVenta;
                        a.IDEmpleado = mainForm.empleado.IDEmpleado;
                        a.SaldoActual = coticred.Precio - coticred.Mensualidad;
                        a.SaldoActual = coticred.Precio;
                        a.Monto = coticred.Mensualidad;
                        a.FormaPago = "CONTADO";
                        a.Dia = DateTime.Now.Day;
                        a.Mes = DateTime.Now.Month;
                        a.Año = DateTime.Now.Year;
                        a.Tipo = "Mensualidad";
                        abono = a;

                        tbxVehiculo.Text = eventa.NoSerie;//eventa.NoSerie;
                        tbxMonto.Text = coticred.Mensualidad.ToString();//cotizacion.PrecioInicial.ToString();
                        tbxVersion.Text = ver.Version.ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un id valido");
                    }
                }
                else if (cbenganche.Checked == true)
                {
                    if (logvencred.existe(tbxidventa.Text))
                    {
                        eventa = logventa.LeerPorClave(tbxidventa.Text);
                        vencred = logvencred.LeerPorClave(tbxidventa.Text);
                        Entidades.Abono a = new Entidades.Abono();
                        List<Entidades.Abono> abonos = logabo.ListadoAll();
                        coticred = logcoticred.LeerPorClave(vencred.IDCotizacion);
                        uni = loguni.LeerPorClave(eventa.NoSerie);
                        ver = logver.LeerPorClave(uni.IDVersion);

                        a.IDAbono = "AB" + (abonos.Count + 2).ToString();
                        a.IDVenta = eventa.IDVenta;
                        a.IDEmpleado = mainForm.empleado.IDEmpleado;
                        a.SaldoActual = coticred.Precio - coticred.Enganche;
                        a.SaldoActual = coticred.Precio;
                        a.Monto = coticred.Enganche;
                        a.FormaPago = "CONTADO";
                        a.Dia = DateTime.Now.Day;
                        a.Mes = DateTime.Now.Month;
                        a.Año = DateTime.Now.Year;
                        a.Tipo = "Enganche";
                        abono = a;

                        tbxVehiculo.Text = eventa.NoSerie;//eventa.NoSerie;
                        tbxMonto.Text = coticred.Enganche.ToString();//cotizacion.PrecioInicial.ToString();
                        tbxVersion.Text = ver.Version.ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un id valido");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione un tipo de transaccion");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
            //eventa = logventa.LeerPorClave(tbxidventa.Text);
            //    if (eventa != null)
            //{
            //uni = loguni.LeerPorClave(eventa.NoSerie);
            //ver = logver.LeerPorClave(uni.IDVersion);
            //tbxVehiculo.Text = uni.NoSerie;
            //tbxVersion.Text = ver.Version;
            ////tbxMonto.Text = ver.Costo.ToString();

            //if (cbpago.Checked == true)
            //{
            //    Entidades.Pago p = new Entidades.Pago();
            //    List<Entidades.Pago> pagos = logpago.ListadoAll();

            //    p.IDPago = (pagos.Count + 2).ToString();
            //    p.IDVenta = eventa.IDVenta;
            //    p.FormaPago = "CONTADO";
            //    p.Dia = DateTime.Now.Day;
            //    p.Mes = DateTime.Now.Month;
            //    p.Año = DateTime.Now.Year;
            //    p.Monto = Convert.ToDouble(tbxMonto.Text);
            //    logpago.Registrar(p);
            //    MessageBox.Show("Pago registrado");
            //    mainForm.cambiarPantalla(new Cobro(mainForm));
            //}
            //else if (cbenganche.Checked == true)
            //{

            //}
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese un id valido");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // imprimir y pagar
            if (abono != null)
            {
                logabo.Registrar(abono);

                List<Entidades.Folio> rvs = new List<Entidades.Folio>();

                Entidades.Folio fol = new Entidades.Folio();
                fol.Asunto = "Recibo de " + abono.Tipo;
                fol.Codigo = abono.IDVenta;
                rvs.Add(fol);

                string html = ImpresorPdf.Formatear(rvs);
                ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Recibo de " + abono.Tipo, "Recibo de " + abono.Tipo);
                mainForm.cambiarPantalla(new Previsualizador("Recibo de " + abono.Tipo));
            }
            else if (pago != null)
            {
                logpago.Registrar(pago);

                List<Entidades.Folio> rvs = new List<Entidades.Folio>();

                Entidades.Folio fol = new Entidades.Folio();
                fol.Asunto = "Recibo de pago";
                fol.Codigo = pago.IDVenta;
                rvs.Add(fol);

                string html = ImpresorPdf.Formatear(rvs);
                ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Recibo de pago", "Recibo de pago");
                mainForm.cambiarPantalla(new Previsualizador("Recibo de pago"));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void tbxidventa_Click(object sender, EventArgs e)
        {
            tbxidventa.Text = "";
        }

        private void cbpago_CheckedChanged(object sender, EventArgs e)
        {
            cbenganche.Checked = false;
            cbanualidad.Checked = false;
            cbmensualidad.Checked = false;
        }

        private void cbmensualidad_CheckedChanged(object sender, EventArgs e)
        {
            cbenganche.Checked = false;
            cbanualidad.Checked = false;
            cbpago.Checked = false;
        }

        private void cbanualidad_CheckedChanged(object sender, EventArgs e)
        {
            cbenganche.Checked = false;
            cbmensualidad.Checked = false;
            cbpago.Checked = false;
        }

        private void cbenganche_CheckedChanged(object sender, EventArgs e)
        {
            cbanualidad.Checked = false;
            cbmensualidad.Checked = false;
            cbpago.Checked = false;
        }
    }
}
