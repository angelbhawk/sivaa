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
    public partial class Empleados : Form
    {
        private SIVAA mainForm;
        readonly EmpleadoLog empleado = new EmpleadoLog();


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

        List<Empleado> lista;
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
    }
}
