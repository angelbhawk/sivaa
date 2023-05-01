using iTextSharp.text.pdf.qrcode;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVAA
{
    public partial class EspProveedor : Form
    {
        private SIVAA mainForm;
        readonly ProveedorLog proveedor = new ProveedorLog();

        public EspProveedor(SIVAA mainForm, int modo)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            if (modo == 0)
            {
                label2.Text = "Agregar";
            }
            else
            {
                label2.Text = "Modificar";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Proveedores(mainForm));
        }
    }
}
