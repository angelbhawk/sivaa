﻿using System;
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
    public partial class RepVersiones : Form
    {
        private SIVAA mainForm;

        public RepVersiones(SIVAA mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cbFiltro.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            mainForm.cambiarPantalla(new Previsualizador("Previsualización del reporte de clientes"));
        }
    }
}
