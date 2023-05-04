namespace SIVAA
{
    partial class Caja
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cbpago = new CheckBox();
            cbmensualidad = new CheckBox();
            cbanualidad = new CheckBox();
            cbenganche = new CheckBox();
            paneltipooperacion = new Panel();
            panelcodigodepago = new Panel();
            tbxMonto = new TextBox();
            btnBuscar = new Button();
            tbxVersion = new TextBox();
            tbxVehiculo = new TextBox();
            tbxidventa = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            paneltipooperacion.SuspendLayout();
            panelcodigodepago.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Enabled = false;
            button1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(761, 16);
            button1.Name = "button1";
            button1.Size = new Size(147, 28);
            button1.TabIndex = 96;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 20);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Caja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Cobro /";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 23);
            label3.Name = "label3";
            label3.Size = new Size(213, 20);
            label3.TabIndex = 3;
            label3.Text = "Selecione el tipo de operacion";
            // 
            // cbpago
            // 
            cbpago.AutoSize = true;
            cbpago.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbpago.Location = new Point(20, 57);
            cbpago.Name = "cbpago";
            cbpago.Size = new Size(124, 21);
            cbpago.TabIndex = 8;
            cbpago.Text = "Pago al contado";
            cbpago.UseVisualStyleBackColor = true;
            cbpago.CheckedChanged += cbpago_CheckedChanged;
            // 
            // cbmensualidad
            // 
            cbmensualidad.AutoSize = true;
            cbmensualidad.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbmensualidad.Location = new Point(146, 57);
            cbmensualidad.Name = "cbmensualidad";
            cbmensualidad.Size = new Size(105, 21);
            cbmensualidad.TabIndex = 9;
            cbmensualidad.Text = "Mensualidad";
            cbmensualidad.UseVisualStyleBackColor = true;
            cbmensualidad.CheckedChanged += cbmensualidad_CheckedChanged;
            // 
            // cbanualidad
            // 
            cbanualidad.AutoSize = true;
            cbanualidad.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbanualidad.Location = new Point(257, 57);
            cbanualidad.Name = "cbanualidad";
            cbanualidad.Size = new Size(87, 21);
            cbanualidad.TabIndex = 10;
            cbanualidad.Text = "Anualidad";
            cbanualidad.UseVisualStyleBackColor = true;
            cbanualidad.CheckedChanged += cbanualidad_CheckedChanged;
            // 
            // cbenganche
            // 
            cbenganche.AutoSize = true;
            cbenganche.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbenganche.Location = new Point(350, 57);
            cbenganche.Name = "cbenganche";
            cbenganche.Size = new Size(87, 21);
            cbenganche.TabIndex = 11;
            cbenganche.Text = "Enganche";
            cbenganche.UseVisualStyleBackColor = true;
            cbenganche.CheckedChanged += cbenganche_CheckedChanged;
            // 
            // paneltipooperacion
            // 
            paneltipooperacion.Controls.Add(label3);
            paneltipooperacion.Controls.Add(cbenganche);
            paneltipooperacion.Controls.Add(cbpago);
            paneltipooperacion.Controls.Add(cbanualidad);
            paneltipooperacion.Controls.Add(cbmensualidad);
            paneltipooperacion.Dock = DockStyle.Top;
            paneltipooperacion.Location = new Point(0, 60);
            paneltipooperacion.Name = "paneltipooperacion";
            paneltipooperacion.Size = new Size(920, 100);
            paneltipooperacion.TabIndex = 12;
            paneltipooperacion.Paint += paneltipooperacion_Paint;
            // 
            // panelcodigodepago
            // 
            panelcodigodepago.Controls.Add(tbxMonto);
            panelcodigodepago.Controls.Add(btnBuscar);
            panelcodigodepago.Controls.Add(tbxVersion);
            panelcodigodepago.Controls.Add(tbxVehiculo);
            panelcodigodepago.Controls.Add(tbxidventa);
            panelcodigodepago.Controls.Add(label4);
            panelcodigodepago.Dock = DockStyle.Top;
            panelcodigodepago.Location = new Point(0, 160);
            panelcodigodepago.Name = "panelcodigodepago";
            panelcodigodepago.Size = new Size(920, 176);
            panelcodigodepago.TabIndex = 13;
            panelcodigodepago.Paint += panelcodigodepago_Paint;
            // 
            // tbxMonto
            // 
            tbxMonto.Enabled = false;
            tbxMonto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMonto.Location = new Point(20, 107);
            tbxMonto.Name = "tbxMonto";
            tbxMonto.Size = new Size(595, 28);
            tbxMonto.TabIndex = 95;
            tbxMonto.Text = "Monto a pagar";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(634, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(186, 28);
            btnBuscar.TabIndex = 95;
            btnBuscar.Text = "Cargar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbxVersion
            // 
            tbxVersion.Enabled = false;
            tbxVersion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxVersion.Location = new Point(429, 55);
            tbxVersion.Name = "tbxVersion";
            tbxVersion.Size = new Size(186, 28);
            tbxVersion.TabIndex = 94;
            tbxVersion.Text = "Version";
            // 
            // tbxVehiculo
            // 
            tbxVehiculo.Enabled = false;
            tbxVehiculo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxVehiculo.Location = new Point(224, 55);
            tbxVehiculo.Name = "tbxVehiculo";
            tbxVehiculo.Size = new Size(186, 28);
            tbxVehiculo.TabIndex = 93;
            tbxVehiculo.Text = "Vehiculo";
            // 
            // tbxidventa
            // 
            tbxidventa.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxidventa.Location = new Point(20, 55);
            tbxidventa.Name = "tbxidventa";
            tbxidventa.Size = new Size(186, 28);
            tbxidventa.TabIndex = 91;
            tbxidventa.Text = "Código de pago";
            tbxidventa.Click += tbxidventa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 23);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese el código del pago";
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 687);
            Controls.Add(panelcodigodepago);
            Controls.Add(paneltipooperacion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caja";
            Text = "Caja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paneltipooperacion.ResumeLayout(false);
            paneltipooperacion.PerformLayout();
            panelcodigodepago.ResumeLayout(false);
            panelcodigodepago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbpago;
        private CheckBox cbmensualidad;
        private CheckBox cbanualidad;
        private CheckBox cbenganche;
        private Panel paneltipooperacion;
        private Panel panelcodigodepago;
        private Label label4;
        private TextBox tbxidventa;
        private TextBox tbxVersion;
        private TextBox tbxVehiculo;
        private TextBox tbxMonto;
        private Button btnBuscar;
        private Button button1;
    }
}