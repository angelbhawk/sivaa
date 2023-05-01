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
    public partial class Previsualizador : Form
    {
        public Previsualizador(string nombre)
        {
            InitializeComponent();
            WebBrowser webBrowser1 = new WebBrowser();
            webBrowser1.Navigate("C:\\Users\\Usuario\\Desktop\\sivaa-master\\SIVAA\\bin\\Debug\\net6.0-windows\\reporte.html");
            panel3.Controls.Add(webBrowser1);
            webBrowser1.Dock = DockStyle.Fill;
            label1.Text = nombre;
        }
    }
}
