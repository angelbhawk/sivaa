﻿using Logicas;
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
    public partial class EspEmpleado : Form
    {
        private SIVAA mainForm;
        readonly EmpleadoLog empleado = new EmpleadoLog();

        public EspEmpleado(SIVAA mainForm, int modo)
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
            mainForm.cambiarPantalla(new Empleados(mainForm));
        }
    }
}
