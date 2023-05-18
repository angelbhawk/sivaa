using Datos;
using Entidades;
using iTextSharp.text;
using Logicas;
using System;
using System.Collections;
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
    public partial class Empleados : Form
    {
        private SIVAA mainForm;
        readonly EmpleadoLog empleado = new EmpleadoLog();
        List<Empleado> lista;
        string id;

        public Empleados(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Empleado> em = empleado.ListadoAll();
            lista = em;
            foreach (Empleado x in em)
            {
                dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.Correo, x.Telefono, x.RFC, x.Tipo);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspEmpleado(mainForm, 0, ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                mainForm.cambiarPantalla(new EspEmpleado(mainForm, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona un Empleado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(lista);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de Empleados", "Empleados Registrados");
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de empleados"));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1[0, i].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.Eliminar(id);
                Mostrar();
                MessageBox.Show("Eliminado con exito", "Mensaje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible eliminar la tabla", "ERROR");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                MostrarEsp(txtBuscar.Text, "IDEmpleado");
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                MostrarEsp(txtBuscar.Text, "Nombre");
            }
            else if (cbFiltro.SelectedIndex == 3)
            {
                MostrarEsp(txtBuscar.Text, "ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 4)
            {
                MostrarEsp(txtBuscar.Text, "ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 5)
            {
                MostrarEsp(txtBuscar.Text, "Correo");
            }
            else if (cbFiltro.SelectedIndex == 6)
            {
                MostrarEsp(txtBuscar.Text, "Telefono");
            }
            else if (cbFiltro.SelectedIndex == 7)
            {
                MostrarEsp(txtBuscar.Text, "RFC");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, "Tipo");
            }
        }

        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            List<Empleado> em = empleado.ListadoEsp(busqueda, filtro);
            lista.Clear();
            lista = em;
            foreach (Empleado x in em)
            {
                dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.Correo, x.Telefono, x.RFC, x.Tipo);
            }
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            lista.Clear();
            List<Empleado> em = empleado.ListadoAll();
            lista = em;
            foreach (Empleado x in em)
            {
                dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre.Trim() + " " + x.ApellidoPat.Trim() + " " + x.ApellidoMat.Trim(), x.Correo, x.Telefono, x.RFC, x.Tipo);
            }
        }
    }
}
