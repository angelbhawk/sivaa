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
    public partial class Cotizaciones : Form
    {
        private SIVAA mainForm;
        private string id;
        readonly CotizacionLog cotizacion = new CotizacionLog();

        public Cotizaciones(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }
        List<CotizacionNoUsar> listas;
        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<CotizacionNoUsar> pro = cotizacion.Tabla();
            listas = pro;
            foreach (CotizacionNoUsar x in pro)
            {
                dataGridView1.Rows.Add(x.IDCotizacion.Trim(), x.Cliente.Trim(), x.Vehiculo.Trim(), x.Empleado.Trim(), x.precioInicial, x.Tipo.Trim());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspCotizacion(mainForm, 0, ""));
        }


        private void button5_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspCotizacion(mainForm, 1, id.Trim()));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(listas);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de Cotizaciones", "Cotizaciones Registradas");
            mainForm.cambiarPantalla(new Previsualizador("Reporte de Cotizaciones"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }else if(cbFiltro.SelectedIndex == 1)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cotizacion.Eliminar(id);
                Mostrar();
                MessageBox.Show("Eliminado con exito", "Mensaje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible eliminar la tabla", "ERROR");
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

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            List<CotizacionNoUsar> pro = cotizacion.Tabla();
            foreach (CotizacionNoUsar x in pro)
            {
                dataGridView1.Rows.Add(x.IDCotizacion, x.Cliente.Trim(), x.Vehiculo.Trim(), x.Empleado.Trim(), x.precioInicial, x.Tipo.Trim());
            }
        }
    }
}
