using Datos;
using Entidades;
using iTextSharp.text.pdf;
using Logicas;
using Microsoft.VisualBasic.Logging;
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
    public partial class EspVersion : Form
    {
        private SIVAA mainForm;
        private int modo;
        private string id;
        VersionLog versiones = new VersionLog();
        VehiculoLog vehiculoLog = new VehiculoLog();
        ModeloD ModeloLog = new ModeloD();
        ModeloVersionD modeloVersionLog = new ModeloVersionD();
        Entidades.Versiones version = new Entidades.Versiones();
        ModeloVersion modeloVersion = new ModeloVersion();

        public EspVersion(SIVAA mainForm, int modo, string id)
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
            mainForm.cambiarPantalla(new Versiones(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entidades.Versiones> x = versiones.ListadoTotal();
                string i = "VR" + (x.Count + 1).ToString();
                if (modo == 0)
                {
                    version.IDVersion = i;
                    version.IDVehiculo = iD(cbVehiculo.Text.Trim(), 0);
                    version.IDModelo = iD(cbModelo.Text.Trim(), 1);
                    version.Llantas = cbLlantas.Text;
                    version.FrenosDelanteros = cbFrenosD.Text;
                    version.FrenosTraseros = cbFrenosT.Text;
                    version.Cilindraje = cbCilindros.Text;
                    version.Costo = Convert.ToDouble(txtCosto.Text);
                    version.Altura = txtAltura.Text + "mm";
                    version.Anchura = txtAnchura.Text + "mm";
                    version.DistanciaEjes = txtDistanciaEjes.Text + "mm";
                    version.RendimientoCombustible = txtCombustible.Text + "km/L";
                    version.TipoAsientos = cbAsientos.Text;
                    version.CamaraTrasera = verificacion(chTrasera);
                    version.Pantalla = verificacion(chPantalla);
                    version.TipoCombustible = cbCombustibles.Text;
                    version.Version = txtVersion.Text;
                    version.Rines = cbRines.Text;
                    version.CapacidadCajuela = txtCapacidadC.Text + "L";
                    version.AudioVelC = verificacion(chAudio);
                    version.TomaCorriente = verificacion(chTomaC);
                    version.TipoTraccion = cbTipoTransmision.Text;
                    version.NumPuertas = cbNumPuertas.Text;
                    version.Transmision = cbTransmision.Text;
                    version.FarosHal = verificacion(chHal);
                    version.FarosLED = verificacion(cbLed);
                    version.NumEngranajes = cbEngranajes.Text;
                    version.ACAutom = verificacion(chAuto);
                    version.SuspensionDelantera = cbSuspensionD.Text;
                    version.SuspensionTrasera = cbSuspensionT.Text;
                    version.EspejosLatAE = verificacion(chEspejosLAE);
                    version.EspejosLatDirC = verificacion(chEspejosDir);

                    versiones.Registrar(version);

                    modeloVersion.IDModelo = version.IDModelo;
                    modeloVersion.IDVersion = version.IDVersion;

                    modeloVersionLog.Insertar(modeloVersion);


                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    version.IDVersion = id;
                    version.IDVehiculo = iD(cbVehiculo.Text.Trim(), 0);
                    version.IDModelo = iD(cbModelo.Text.Trim(), 1);
                    version.Llantas = cbLlantas.Text;
                    version.FrenosDelanteros = cbFrenosD.Text;
                    version.FrenosTraseros = cbFrenosT.Text;
                    version.Cilindraje = cbCilindros.Text;
                    version.Costo = Convert.ToDouble(txtCosto.Text);
                    version.Altura = txtAltura.Text + "mm";
                    version.Anchura = txtAnchura.Text + "mm";
                    version.DistanciaEjes = txtDistanciaEjes.Text + "mm";
                    version.RendimientoCombustible = txtCombustible.Text + "km/L";
                    version.TipoAsientos = cbAsientos.Text;
                    version.CamaraTrasera = verificacion(chTrasera);
                    version.Pantalla = verificacion(chPantalla);
                    version.TipoCombustible = cbCombustibles.Text;
                    version.Version = txtVersion.Text;
                    version.Rines = cbRines.Text;
                    version.CapacidadCajuela = txtCapacidadC.Text + "L";
                    version.AudioVelC = verificacion(chAudio);
                    version.TomaCorriente = verificacion(chTomaC);
                    version.TipoTraccion = cbTipoTransmision.Text;
                    version.NumPuertas = cbNumPuertas.Text;
                    version.Transmision = cbTransmision.Text;
                    version.FarosHal = verificacion(chHal);
                    version.FarosLED = verificacion(cbLed);
                    version.NumEngranajes = cbEngranajes.Text;
                    version.ACAutom = verificacion(chAuto);
                    version.SuspensionDelantera = cbSuspensionD.Text;
                    version.SuspensionTrasera = cbSuspensionT.Text;
                    version.EspejosLatAE = verificacion(chEspejosLAE);
                    version.EspejosLatDirC = verificacion(chEspejosDir);

                    versiones.Modificar(version);
                    MessageBox.Show("Actualizado con exito", "Mensaje");
                }
                mainForm.cambiarPantalla(new Versiones(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "ERROR");
            }
        }

        #region Metodos
        private void cargarDatos()
        {
            List<Vehiculo> vh = vehiculoLog.ListadoAll();
            foreach (Vehiculo x in vh)
            {
                cbVehiculo.Items.Add(x.Nombre.Trim());
            }
            List<Modelo> m = ModeloLog.ListadoTotal();
            foreach (Modelo x in m)
            {
                cbModelo.Items.Add(x.Año.Trim());
            }
        }

        private string verificacion(CheckBox x)
        {
            if (x.Checked == true)
            {
                return "Si";
            }
            return "No";
        }

        private void asignar(CheckBox x, string y)
        {
            if (y == "Si")
            {
                x.Checked = true;
            }
            else
            {
                x.Checked = false;
            }

        }

        private string iD(string nombre, int tipo)
        {
            if (tipo == 0)
            {
                List<Vehiculo> em = vehiculoLog.ListadoAll();

                foreach (Vehiculo x in em)
                {
                    if (x.Nombre.Trim() == nombre)
                    {
                        return x.IDVehiculo;
                    }
                }
            }
            if (tipo == 1)
            {
                List<Modelo> pe = ModeloLog.ListadoTotal();
                foreach (Modelo x in pe)
                {
                    if (x.Año.Trim() == nombre)
                    {
                        return x.IDModelo;
                    }
                }
            }
            return null;
        }

        private string Nombre(string id, int tipo)
        {
            if (tipo == 0)
            {
                List<Vehiculo> em = vehiculoLog.ListadoAll();
                foreach (Vehiculo x in em)
                {
                    if (x.IDVehiculo.Trim() == id)
                    {
                        return x.Nombre.Trim();
                    }
                }
            }
            if (tipo == 1)
            {
                List<Modelo> pe = ModeloLog.ListadoTotal();
                foreach (Modelo x in pe)
                {
                    if (x.IDModelo.Trim() == id)
                    {
                        return x.Año;
                    }
                }
            }
            return null;
        }

        public void Datos(string id)
        {
            string modelo =null;
            List<Entidades.Versiones> ver = versiones.ListadoTotal();
            foreach (Entidades.Versiones x in ver)
            {
                if (x.IDVersion.Trim() == id)
                {
                    txtVersion.Text = x.Version.ToString();
                    txtAltura.Text = x.Altura.ToString();
                    txtAnchura.Text = x.Anchura.ToString();
                    txtCapacidadC.Text = x.CapacidadCajuela.ToString();
                    txtCosto.Text = x.Costo.ToString();
                    txtDistanciaEjes.Text = x.DistanciaEjes.ToString();
                    txtCombustible.Text = x.RendimientoCombustible.ToString();
                    cbAsientos.Text = x.TipoAsientos.ToString();
                    cbCilindros.Text = x.Cilindraje.ToString();
                    cbCombustibles.Text = x.TipoCombustible.ToString();
                    cbEngranajes.Text = x.NumEngranajes.ToString();
                    cbFrenosD.Text = x.FrenosDelanteros.ToString();
                    cbFrenosT.Text = x.FrenosTraseros.ToString();
                    cbLlantas.Text = x.Llantas.ToString();
                    cbNumPuertas.Text = x.NumPuertas.ToString();
                    cbRines.Text = x.Rines.ToString();
                    cbSuspensionD.Text = x.SuspensionDelantera.ToString();
                    cbSuspensionT.Text = x.SuspensionTrasera.ToString();
                    cbTipoTransmision.Text = x.TipoTraccion.ToString();
                    cbTransmision.Text = x.Transmision.ToString();
                    cbVehiculo.Text = Nombre(x.IDVehiculo.Trim(), 0);
                    asignar(chAuto, x.ACAutom);
                    asignar(chAudio, x.AudioVelC);
                    asignar(chTrasera, x.CamaraTrasera);
                    asignar(chEspejosLAE, x.EspejosLatAE);
                    asignar(chEspejosDir, x.EspejosLatDirC);
                    asignar(chHal, x.FarosHal);
                    asignar(cbLed, x.FarosLED);
                    asignar(chPantalla, x.Pantalla);
                    asignar(chTomaC, x.TomaCorriente);
                    modelo = x.IDModelo;
                }
            }
            List<Entidades.Modelo> modelos = ModeloLog.ListadoTotal();
            foreach (Modelo x in modelos)
            {
                if(x.IDModelo == modelo)
                {
                    cbModelo.Text = x.Año;
                }
            }
        }
        #endregion
    }
}
