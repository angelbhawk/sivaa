namespace SIVAA
{
    partial class EspCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cbCliente = new ComboBox();
            label16 = new Label();
            cbEmpleado = new ComboBox();
            label3 = new Label();
            cbVersion = new ComboBox();
            label4 = new Label();
            dateTimer = new DateTimePicker();
            label6 = new Label();
            cbTipo = new ComboBox();
            label7 = new Label();
            nudPlazo = new NumericUpDown();
            lblPlazo = new Label();
            lblEnganche = new Label();
            txtEnganche = new TextBox();
            txtInteres = new TextBox();
            lblInteres = new Label();
            txtAnualidad = new TextBox();
            lblAnualidad = new Label();
            label13 = new Label();
            txtPrecioInicial = new TextBox();
            button1 = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblPorcentaje = new Label();
            txtPorcentaje = new TextBox();
            txtMensualidad = new TextBox();
            lblMensualidad = new Label();
            lblFinanciamiento = new Label();
            txtFinanciamiento = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Agregar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Cotizacion /";
            label1.Click += label1_Click;
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(68, 133);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(169, 31);
            cbCliente.TabIndex = 64;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(68, 110);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 63;
            label16.Text = "Cliente";
            // 
            // cbEmpleado
            // 
            cbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpleado.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(270, 133);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(169, 31);
            cbEmpleado.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(270, 110);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 65;
            label3.Text = "Empleado";
            // 
            // cbVersion
            // 
            cbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVersion.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbVersion.FormattingEnabled = true;
            cbVersion.Location = new Point(477, 134);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(169, 31);
            cbVersion.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(477, 110);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 67;
            label4.Text = "Version";
            // 
            // dateTimer
            // 
            dateTimer.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimer.Location = new Point(68, 216);
            dateTimer.Name = "dateTimer";
            dateTimer.Size = new Size(371, 32);
            dateTimer.TabIndex = 71;
            dateTimer.Value = new DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 193);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 72;
            label6.Text = "Fecha de cotización";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Contado", "Credito" });
            cbTipo.Location = new Point(477, 216);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(169, 31);
            cbTipo.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(477, 193);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 73;
            label7.Text = "Tipo de cotización";
            // 
            // nudPlazo
            // 
            nudPlazo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudPlazo.Location = new Point(684, 215);
            nudPlazo.Name = "nudPlazo";
            nudPlazo.Size = new Size(169, 32);
            nudPlazo.TabIndex = 75;
            nudPlazo.Visible = false;
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlazo.Location = new Point(684, 192);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(46, 20);
            lblPlazo.TabIndex = 76;
            lblPlazo.Text = "Plazo";
            lblPlazo.Visible = false;
            // 
            // lblEnganche
            // 
            lblEnganche.AutoSize = true;
            lblEnganche.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnganche.Location = new Point(684, 279);
            lblEnganche.Name = "lblEnganche";
            lblEnganche.Size = new Size(77, 20);
            lblEnganche.TabIndex = 77;
            lblEnganche.Text = "Enganche";
            lblEnganche.Visible = false;
            // 
            // txtEnganche
            // 
            txtEnganche.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnganche.Location = new Point(684, 302);
            txtEnganche.Name = "txtEnganche";
            txtEnganche.Size = new Size(169, 32);
            txtEnganche.TabIndex = 78;
            txtEnganche.Visible = false;
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInteres.Location = new Point(477, 302);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(169, 32);
            txtInteres.TabIndex = 80;
            txtInteres.Visible = false;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInteres.Location = new Point(477, 279);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(56, 20);
            lblInteres.TabIndex = 79;
            lblInteres.Text = "Interes";
            lblInteres.Visible = false;
            // 
            // txtAnualidad
            // 
            txtAnualidad.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnualidad.Location = new Point(477, 390);
            txtAnualidad.Name = "txtAnualidad";
            txtAnualidad.Size = new Size(169, 32);
            txtAnualidad.TabIndex = 82;
            txtAnualidad.Visible = false;
            // 
            // lblAnualidad
            // 
            lblAnualidad.AutoSize = true;
            lblAnualidad.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnualidad.Location = new Point(477, 367);
            lblAnualidad.Name = "lblAnualidad";
            lblAnualidad.Size = new Size(79, 20);
            lblAnualidad.TabIndex = 81;
            lblAnualidad.Text = "Anualidad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(684, 110);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 86;
            label13.Text = "Precio";
            // 
            // txtPrecioInicial
            // 
            txtPrecioInicial.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioInicial.Location = new Point(684, 133);
            txtPrecioInicial.Name = "txtPrecioInicial";
            txtPrecioInicial.Size = new Size(169, 32);
            txtPrecioInicial.TabIndex = 85;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(684, 387);
            button1.Name = "button1";
            button1.Size = new Size(169, 33);
            button1.TabIndex = 91;
            button1.Text = "Listo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(68, 279);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 93;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(68, 302);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(169, 32);
            txtPrecio.TabIndex = 92;
            txtPrecio.Visible = false;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(270, 279);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(82, 20);
            lblPorcentaje.TabIndex = 95;
            lblPorcentaje.Text = "Porcentaje";
            lblPorcentaje.Visible = false;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentaje.Location = new Point(270, 302);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(169, 32);
            txtPorcentaje.TabIndex = 94;
            txtPorcentaje.Visible = false;
            // 
            // txtMensualidad
            // 
            txtMensualidad.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMensualidad.Location = new Point(270, 390);
            txtMensualidad.Name = "txtMensualidad";
            txtMensualidad.Size = new Size(169, 32);
            txtMensualidad.TabIndex = 97;
            txtMensualidad.Visible = false;
            // 
            // lblMensualidad
            // 
            lblMensualidad.AutoSize = true;
            lblMensualidad.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensualidad.Location = new Point(270, 367);
            lblMensualidad.Name = "lblMensualidad";
            lblMensualidad.Size = new Size(99, 20);
            lblMensualidad.TabIndex = 96;
            lblMensualidad.Text = "Mensualidad";
            // 
            // lblFinanciamiento
            // 
            lblFinanciamiento.AutoSize = true;
            lblFinanciamiento.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinanciamiento.Location = new Point(68, 367);
            lblFinanciamiento.Name = "lblFinanciamiento";
            lblFinanciamiento.Size = new Size(115, 20);
            lblFinanciamiento.TabIndex = 99;
            lblFinanciamiento.Text = "Financiamiento";
            lblFinanciamiento.Visible = false;
            // 
            // txtFinanciamiento
            // 
            txtFinanciamiento.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFinanciamiento.Location = new Point(68, 390);
            txtFinanciamiento.Name = "txtFinanciamiento";
            txtFinanciamiento.Size = new Size(169, 32);
            txtFinanciamiento.TabIndex = 98;
            txtFinanciamiento.Visible = false;
            // 
            // EspCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(lblFinanciamiento);
            Controls.Add(txtFinanciamiento);
            Controls.Add(txtMensualidad);
            Controls.Add(lblMensualidad);
            Controls.Add(lblPorcentaje);
            Controls.Add(txtPorcentaje);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(txtPrecioInicial);
            Controls.Add(txtAnualidad);
            Controls.Add(lblAnualidad);
            Controls.Add(txtInteres);
            Controls.Add(lblInteres);
            Controls.Add(txtEnganche);
            Controls.Add(lblEnganche);
            Controls.Add(lblPlazo);
            Controls.Add(nudPlazo);
            Controls.Add(cbTipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimer);
            Controls.Add(cbVersion);
            Controls.Add(label4);
            Controls.Add(cbEmpleado);
            Controls.Add(label3);
            Controls.Add(cbCliente);
            Controls.Add(label16);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspCotizacion";
            Text = "EspCotizacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox cbCliente;
        private Label label16;
        private ComboBox cbEmpleado;
        private Label label3;
        private ComboBox cbVersion;
        private Label label4;
        private DateTimePicker dateTimer;
        private Label label6;
        private ComboBox cbTipo;
        private Label label7;
        private NumericUpDown nudPlazo;
        private Label lblPlazo;
        private Label lblEnganche;
        private TextBox txtEnganche;
        private TextBox txtInteres;
        private Label lblInteres;
        private TextBox txtAnualidad;
        private Label lblAnualidad;
        private Label label13;
        private TextBox txtPrecioInicial;
        private Button button1;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblPorcentaje;
        private TextBox txtPorcentaje;
        private TextBox txtMensualidad;
        private Label lblMensualidad;
        private Label lblFinanciamiento;
        private TextBox txtFinanciamiento;
    }
}