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
    public partial class Citas : Form
    {
        SIVAA form;
        CitaD citaD = new CitaD();
        string id;
        List<CitaM> lista =new List<CitaM>();
        public Citas(SIVAA form)
        {
            InitializeComponent();
            this.form = form;
            Mostrar();
            lista = citaD.ListadoCitas();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            form.cambiarPantalla(new EspCita(form, 0, ""));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                form.cambiarPantalla(new EspCita(form, 1, id));
            }
            else
            {
                MessageBox.Show("Selecciona una cita");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                citaD.Eliminar(id);
                Mostrar();
                MessageBox.Show("Eliminado con exito", "Mensaje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible eliminar la tabla", "ERROR");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            string html = ImpresorPdf.Formatear(lista);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de Citas", "Citas Registrados");
            form.cambiarPantalla(new Previsualizador("Reporte de Citas"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                MostrarEsp(txtBuscar.Text, "c.IDCita");
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                MostrarEsp(txtBuscar.Text, "e.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 3)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 4)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 5)
            {
                MostrarEsp(txtBuscar.Text, "cl.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 6)
            {
                MostrarEsp(txtBuscar.Text, "cl.ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 7)
            {
                MostrarEsp(txtBuscar.Text, "cl.ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 8)
            {
                MostrarEsp(txtBuscar.Text, " c.Dia");
            }
            else if (cbFiltro.SelectedIndex == 9)
            {
                MostrarEsp(txtBuscar.Text, " c.Mes");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, " c.Año");
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


        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            List<CitaM> list = citaD.ListadoEspecifico(busqueda, filtro);
            foreach (CitaM x in list)
            {
                string i = x.Dia.ToString() + "/" + x.Mes + "/" + x.Año;
                dataGridView1.Rows.Add(x.IDCita, x.Empleado, x.Cliente, i, x.Hora);
            }
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            List<CitaM> citaMs = citaD.ListadoCitas();
            foreach (CitaM x in citaMs)
            {
                string i = x.Dia.ToString() + "/" + x.Mes + "/" + x.Año;
                dataGridView1.Rows.Add(x.IDCita, x.Empleado, x.Cliente, i, x.Hora);
            }
        }

    }
}
