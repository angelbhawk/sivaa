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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SIVAA
{
    public partial class BusCotizacion : Form
    {
        private Venta mainForm;

        ClienteLog clie;
        VersionLog ver;
        VehiculoLog veh;
        EmpleadoLog emp;
        ModeloLog mod;
        UnidadLog uni;
        CotizacionLog cot;
        VentaLog ventaLog;

        string idcotizacion;

        CotizacionContadoLog ccl;
        CotizacionCreditoLog ccrel;
        List<Entidades.ConsultaCotizacionesContado> listaContado;
        List<Entidades.ConsultaCotizacionCredito> listaCredito;
        List<Entidades.Venta> listaventa;
        VentaContadoLog ventaContadoLog = new VentaContadoLog();
        VentaCreditoLog ventaCreditoLog = new VentaCreditoLog();

        Entidades.Cliente C;
        Entidades.Versiones V;
        Entidades.Empleado E;
        Entidades.Vehiculo VE;
        Entidades.Modelo M;
        Entidades.Unidad U;
        Entidades.CotizacionUsar CO;
        Entidades.Venta venta;

        VentaContado ventaContado;
        VentaCredito ventaCredito;

        public BusCotizacion(Venta mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
            ///
            this.ccl = new CotizacionContadoLog();
            this.ccrel = new CotizacionCreditoLog();
            this.clie = new ClienteLog();
            this.ver = new VersionLog();
            this.veh = new VehiculoLog();
            this.emp = new EmpleadoLog();
            this.mod = new ModeloLog();
            this.uni = new UnidadLog();
            this.cot = new CotizacionLog();
            this.ventaLog = new VentaLog();
            this.ventaContado = new VentaContado();
            this.ventaCredito = new VentaCredito();
            this.venta = new Entidades.Venta();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cerrarCotizaciones(this);
        }

        private void BusCotizacion_Load(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                List<Entidades.ConsultaCotizacionesContado> cotizacionescontado = ccl.ListadoAll();
                listaContado = cotizacionescontado;
                dataGridView1.DataSource = listaContado;
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                List<Entidades.ConsultaCotizacionCredito> cotizacionescredito = ccrel.Consulta();
                listaCredito = cotizacionescredito;
                dataGridView1.DataSource = listaCredito;
            }
            //DateTime now = DateTime.Now;
            //listaventa = ventaLog.ListadoAll();
            //string i = "V" + (listaventa.Count + 1).ToString();

            //if (cbFiltro.SelectedIndex == 0)
            //{
            //    VENTA.IDVenta = i;
            //    VENTA.IDEmpleado = idEmpleado(comboBox1.Text);
            //    VENTA.NoSerie = textBox11.Text;
            //    VENTA.Subtotal = Convert.ToDouble(textBox7.Text);
            //    VENTA.Dia = now.Day;
            //    VENTA.Mes = now.Month;
            //    VENTA.Año = now.Year;
            //    VENTA.Hora = now.Hour.ToString();
            //    VENTA.TipoVenta = "CONTADO";
            //    ventaLog.Registrar(VENTA);
            //    ventaContado.IDCotizacion = idcotizacion;
            //    ventaContado.IDVenta = i;
            //    ventaContado.Estatus = "Finalizado";
            //    ventaContadoLog.Registrar(ventaContado);

            //    MessageBox.Show("Venta Realizada");

            //}
            //if (cbFiltro.SelectedIndex == 1)
            //{
            //    VENTA.IDVenta = i;
            //    VENTA.IDEmpleado = idEmpleado(comboBox1.Text);
            //    VENTA.NoSerie = textBox11.Text;
            //    VENTA.Subtotal = Convert.ToDouble(textBox7.Text);
            //    VENTA.Dia = now.Day;
            //    VENTA.Mes = now.Month;
            //    VENTA.Año = now.Year;
            //    VENTA.Hora = now.Hour.ToString();
            //    VENTA.TipoVenta = "CREDITO";
            //    ventaLog.Registrar(VENTA);
            //    ventaCredito.IDCotizacion = idcotizacion;
            //    ventaCredito.IDVenta = i;
            //    ventaCredito.Estatus = "Finalizado";
            //    ventaCredito.TotalFinal = Convert.ToDouble(textBox7.Text);
            //    ventaCreditoLog.Registrar(ventaCredito);
            //    MessageBox.Show("Venta Realizada");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Obtener los datos de una columna por nombre
                idcotizacion = row.Cells["IDCotizacion"].Value.ToString();
                string idcliente = row.Cells["IDCliente"].Value.ToString();
                string empledo = row.Cells["IDEmpleado"].Value.ToString();
                //string version = row.Cells["IDVersion"].Value.ToString();
                string vehiculo = row.Cells["IDVehiculo"].Value.ToString();
                string año = row.Cells["año"].Value.ToString();
                string color = row.Cells["Color"].Value.ToString();
                string noserie = row.Cells["NoSerie"].Value.ToString();
                string precioinicial = row.Cells["PrecioInicial"].Value.ToString();
                double porcentaje = 0.16;

                C = clie.LeerPorClave(idcliente);
                //V = ver.LeerPorClave(version);
                VE = veh.LeerPorClave(vehiculo);
                E = emp.LeerPorClave(empledo);

                //U = uni.LeerPorClave(unidad);
                //CO = cot.LeerPorClave(cotizacion);

                mainForm.tbxIdCliente.Text = C.IDCliente;
                mainForm.tbxNombreCliente.Text = C.Nombre.Trim() + " " + C.ApellidoPat.Trim() + " " + C.ApellidoMat.Trim();
                mainForm.tbxCorreo.Text = C.Correo;

                mainForm.tbxNombreVendedor.Text = E.Nombre;

                mainForm.tbxIdVehiculo.Text = VE.IDVehiculo;
                mainForm.tbxNombreVehiculo.Text = VE.Nombre;
                mainForm.tbxModelo.Text = año.ToString();
                mainForm.tbxColor.Text = color.ToString();
                mainForm.tbxIdVendedor.Text = E.IDEmpleado.ToString();
                mainForm.tbxNoSerie.Text = noserie.ToString();
                mainForm.tbxPrecio.Text = precioinicial.ToString();
                double tot = Convert.ToDouble(precioinicial) + (Convert.ToDouble(precioinicial) * Convert.ToDouble(porcentaje));
                mainForm.tbxTotal.Text = "" + tot;

                mainForm.tipo = cbFiltro.SelectedIndex;
                mainForm.idcotizacion = idcotizacion;
                mainForm.btnImprimir.Enabled = true;
                mainForm.cerrarCotizaciones(this);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                List<Entidades.ConsultaCotizacionesContado> cotizacionescontado = ccl.ListadoAll();
                listaContado = cotizacionescontado;
                dataGridView1.DataSource = listaContado;
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                List<Entidades.ConsultaCotizacionCredito> cotizacionescredito = ccrel.Consulta();
                listaCredito = cotizacionescredito;
                dataGridView1.DataSource = listaCredito;
            }
        }
    }
}
