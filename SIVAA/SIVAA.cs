using System.Windows.Forms;

namespace SIVAA
{
    public partial class SIVAA : Form
    {
        public Entidades.Empleado empleado;
        public double abertura = 0;
        public string abertura_string = "";
        public bool estado_de_caja = false;

        public SIVAA(Entidades.Empleado empleado)
        {
            InitializeComponent();
            cambiarPantalla(new Principal(this));
            this.empleado = empleado;

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
            cambiarPantalla(new Pedidos());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Citas(this));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Compras(this));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Cobro(this));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cambiarPantalla(new Reportes(this));
        }

        private void SIVAA_Load(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                label7.Text = empleado.Nombre.Trim() + " " + empleado.ApellidoPat.Trim();
                label8.Text = empleado.Tipo.Trim();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == true)
                panel8.Visible = false;
            else
                panel8.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            Autenticacion auth = new Autenticacion();
            auth.Show();
        }
    }
}