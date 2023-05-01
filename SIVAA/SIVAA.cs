using System.Windows.Forms;

namespace SIVAA
{
    public partial class SIVAA : Form
    {
        public SIVAA()
        {
            InitializeComponent();
            cambiarPantalla(new Principal(this));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Principal(this));
        }

        public void cambiarPantalla(Form child)
        {
            pnlDerecho.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            pnlDerecho.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.Show();
            pnlDerecho.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Inventario());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Pedidos(this));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Citas());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Compras());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Cobro());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Reportes());
        }
    }
}