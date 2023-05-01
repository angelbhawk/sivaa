using Datos;
using Entidades;
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
        public Citas(SIVAA form)
        {
            InitializeComponent();
            this.form = form;
            mostrar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color miColor = Color.FromArgb(241, 241, 241);

            e.Graphics.DrawLine(new Pen(miColor), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            form.cambiarPantalla(this);
        }

        private void mostrar()
        {
            List<CitaM> citaMs = citaD.ListadoCitas();
            foreach(CitaM x in citaMs)
            {
                string i = x.Dia.ToString()+ "/" + x.Mes + "/" + x.Año;
                dataGridView1.Rows.Add(x.IDCita, x.Empleado, x.Cliente, i, x.Hora);
            }
        }
    }
}
