using Entidades;
using iTextSharp.text;
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
    public partial class Vehiculos : Form
    {
        private SIVAA mainForm;
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
            mainForm.cambiarPantalla(new EspVehiculo(mainForm, 0));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new EspVehiculo(mainForm, 1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de vehiculo"));
        }
    }
}