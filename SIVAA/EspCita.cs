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
    public partial class EspCita : Form
    {
        SIVAA form;
        int modo;
        string id;
        EmpleadoLog empleados = new EmpleadoLog();
        ClienteLog clientes = new ClienteLog();
        CitaLog citas = new CitaLog();
        Cita cita = new Cita();

        public EspCita(SIVAA form, int modo, string id)
        {
            InitializeComponent();
            this.form = form;
            this.modo = modo;
            this.id = id;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == 0)
                {
                    List<Cita> x = citas.ListadoAll();
                    string i = "CT" + (x.Count + 1).ToString();
                    cita.IDCita = i;
                    cita.IDEmpleado = iD(cbEmpleado.Text, 0);
                    cita.IDCliente = iD(cbCliente.Text, 1);
                    cita.Dia = dateTimePicker1.Value.Day;
                    cita.Mes = dateTimePicker1.Value.Month;
                    cita.Año = dateTimePicker1.Value.Year;
                    cita.Hora = dateTimePicker1.Value.ToString("HH:mm:ss.fff");

                    citas.Registrar(cita);
                    MessageBox.Show("Agregado con exito", "Mensaje");
                }
                else
                {
                    cita.IDCita = id;
                    cita.IDEmpleado = iD(cbEmpleado.Text, 0);
                    cita.IDCliente = iD(cbCliente.Text, 1);
                    cita.Dia = dateTimePicker1.Value.Day;
                    cita.Mes = dateTimePicker1.Value.Month;
                    cita.Año = dateTimePicker1.Value.Year;
                    cita.Hora = dateTimePicker1.Value.ToString("HH:mm:ss.fff");

                    citas.Modificar(cita);
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

        #region
        private void CargarDatos()
        {
            List<Empleado> empleado = empleados.ListadoAll();
            foreach (Empleado x in empleado)
            {
                string nombre = x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                cbEmpleado.Items.Add(nombre);
            }
            List<Cliente> cliente = clientes.ListadoAll();
            foreach (Cliente x in cliente)
            {
                string i = x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                cbCliente.Items.Add(i);
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
                List<Cliente> pe = clientes.ListadoAll();
                foreach (Cliente x in pe)
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
                List<Cliente> pe = clientes.ListadoAll();
                foreach (Cliente x in pe)
                {
                    if (x.IDCliente == id)
                    {
                        return x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim();
                    }
                }
            }
            return null;
        }

        private void Datos(string id)
        {
            List<Cita> pe = citas.ListadoAll();
            foreach (Cita p in pe)
            {
                if (p.IDCita == id)
                {
                    cbEmpleado.Text = Nombre(p.IDEmpleado, 0);
                    cbCliente.Text = Nombre(p.IDCliente, 1);
                    dateTimePicker1.Value = new DateTime(p.Año, p.Mes, p.Dia);
                }
            }
        }
        #endregion
    }
}
