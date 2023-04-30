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
        List<CotizacionUsar> listas;
        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<CotizacionUsar> pro = cotizacion.ListadoAll();
            listas = pro;
            foreach (CotizacionUsar x in pro)
            {
                dataGridView1.Rows.Add(x.IDCotizacion.Trim(), x.IDCliente.Trim(), x.IDVersion.Trim(),x.IDEmpleado.Trim(), x.PrecioInicial, x.TipoPago.Trim());
            }
        }
    }
}
