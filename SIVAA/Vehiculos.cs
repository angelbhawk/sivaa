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
    public partial class Vehiculos : Form
    {
        private SIVAA mainForm;
        private string id;
        readonly VehiculoLog vehiculo = new VehiculoLog();

        public Vehiculos(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        List<Vehiculo> listas;
        private void Vehiculos_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Vehiculo> pro = vehiculo.ListadoAll();
            listas = pro;
            dataGridView1.Rows.Clear();
            foreach (Vehiculo x in pro)
            {
                dataGridView1.Rows.Add(x.IDVehiculo, x.Nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspVehiculo(mainForm, 0, ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                mainForm.cambiarPantalla(new EspVehiculo(mainForm, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona un Vehiculo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(listas);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de Vehiculos", "Vehiculos Registrados");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de Vehiculos"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }
            else
            {
                MostrarEsp(txtBuscar.Text, cbFiltro.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo.Eliminar(id);
                Mostrar();
                MessageBox.Show("Eliminado con exito", "Mensaje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible eliminar la tabla", "ERROR");
            }
        }


        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            List<Vehiculo> pro = vehiculo.ListadoEsp(busqueda, filtro);
            foreach (Vehiculo x in pro)
            {
                dataGridView1.Rows.Add(x.IDVehiculo, x.Nombre);
            }
        }


        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            List<Vehiculo> pro = vehiculo.ListadoAll();
            foreach (Vehiculo x in pro)
            {
                dataGridView1.Rows.Add(x.IDVehiculo, x.Nombre);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1[0, i].Value.ToString();
            }
        }
    }
}