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
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de cotizaciones"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbFiltro.SelectedIndex == 0)
            {
                Mostrar();
            }else if(cbFiltro.SelectedIndex == 1)
            {
                MostrarEsp(txtBuscar.Text, "ct.IDCotizacion");
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                MostrarEsp(txtBuscar.Text, "c.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                MostrarEsp(txtBuscar.Text, "c.ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 3)
            {
                MostrarEsp(txtBuscar.Text, "c.ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 4)
            {
                MostrarEsp(txtBuscar.Text, "vh.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 5)
            {
                MostrarEsp(txtBuscar.Text, "v.[Version]");
            }
            else if (cbFiltro.SelectedIndex == 6)
            {
                MostrarEsp(txtBuscar.Text, "e.Nombre");
            }
            else if (cbFiltro.SelectedIndex == 7)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoPaterno");
            }
            else if (cbFiltro.SelectedIndex == 8)
            {
                MostrarEsp(txtBuscar.Text, "e.ApellidoMaterno");
            }
            else if (cbFiltro.SelectedIndex == 9)
            {
                MostrarEsp(txtBuscar.Text, "ct.PrecioInicial");
            }
            else
            {
                MostrarEsp(txtBuscar.Text, "ct.TipoPago");
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

        private void MostrarEsp(string busqueda, string filtro)
        {
            dataGridView1.Rows.Clear();
            
            List<CotizacionNoUsar> list = cotizacion.Tablas(busqueda, filtro);
            foreach (CotizacionNoUsar x in list)
            {
                dataGridView1.Rows.Add(x.IDCotizacion, x.Cliente.Trim(), x.Vehiculo.Trim(), x.Empleado.Trim(), x.precioInicial, x.Tipo.Trim());
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
