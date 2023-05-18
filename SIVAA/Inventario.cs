using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVAA
{
    public partial class Inventario : Form
    {
        SIVAA form;
        UnidadLog unidadLog = new UnidadLog();
        List<UnidadNoUsar> unidades = new List<UnidadNoUsar>();
        List<UnidadNoUsar> lista = new List<UnidadNoUsar>();

        public Inventario(SIVAA form)
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            this.form = form;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (cbFiltro.SelectedIndex == 0)
                Mostrar();
            if (cbFiltro.SelectedIndex == 1)
                Filtro("Disponible");
            if (cbFiltro.SelectedIndex == 2)
                Filtro("Vendido");
            if (cbFiltro.SelectedIndex == 3)
                Filtro("En camino");
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Mostrar();
            lista = unidadLog.Inventario();
        }

        private void Mostrar()
        {
            unidades.Clear();
            lista.Clear();
            unidades = unidadLog.Inventario();
            lista = unidades;
            foreach (UnidadNoUsar x in unidades)
            {
                dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Modelo, x.Color, x.Estatus);
            }
        }

        private void Filtro(string filtro)
        {
            unidades.Clear();
            lista.Clear();
            unidades = unidadLog.InventarioFiltro(filtro);
            lista = unidades;
            foreach (UnidadNoUsar x in unidades)
            {
                dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Modelo, x.Color, x.Estatus);
            }
        }

        private void actualizar(string deam)
        {
            List<Unidad> uni = unidadLog.ListadoAll();
            foreach (Unidad x in uni)
            {
                if (x.NoSerie == deam)
                {
                    x.Estatus = "Disponible";
                    unidadLog.Modificar(x);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1[5, i].Value.ToString() == "En camino")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres hacer esto?", "Confirmar acción", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dataGridView1[5, i].Value = "Disponible";
                    actualizar(dataGridView1[0, i].Value.ToString());
                    dataGridView1.Refresh();
                }
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string html = ImpresorPdf.Formatear(lista);
            ImpresorPdf.generarReporte(html, Properties.Resources.plantilla_reporte.ToString(), "Reporte de inventario", "Inventario");
            form.cambiarPantalla(new Previsualizador("Reporte de inventarios"));
        }
    }
}
