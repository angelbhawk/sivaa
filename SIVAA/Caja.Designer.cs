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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            paneltipooperacion = new Panel();
            panelcodigodepago = new Panel();
            btnBuscar = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            panelformadepago = new Panel();
            cbFiltro = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            paneltipooperacion.SuspendLayout();
            panelcodigodepago.SuspendLayout();
            panelformadepago.SuspendLayout();
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
            button1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(761, 16);
            button1.Name = "button1";
            button1.Size = new Size(147, 28);
            button1.TabIndex = 96;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(20, 57);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Pago al contado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(146, 57);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 21);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Mensualidad";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(257, 57);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(87, 21);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Anualidad";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(350, 57);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(87, 21);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Enganche";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // paneltipooperacion
            // 
            paneltipooperacion.Controls.Add(label3);
            paneltipooperacion.Controls.Add(checkBox4);
            paneltipooperacion.Controls.Add(checkBox1);
            paneltipooperacion.Controls.Add(checkBox3);
            paneltipooperacion.Controls.Add(checkBox2);
            paneltipooperacion.Dock = DockStyle.Top;
            paneltipooperacion.Location = new Point(0, 60);
            paneltipooperacion.Name = "paneltipooperacion";
            paneltipooperacion.Size = new Size(920, 100);
            paneltipooperacion.TabIndex = 12;
            paneltipooperacion.Paint += paneltipooperacion_Paint;
            // 
            // panelcodigodepago
            // 
            panelcodigodepago.Controls.Add(btnBuscar);
            panelcodigodepago.Controls.Add(textBox3);
            panelcodigodepago.Controls.Add(textBox2);
            panelcodigodepago.Controls.Add(textBox1);
            panelcodigodepago.Controls.Add(textBox5);
            panelcodigodepago.Controls.Add(label4);
            panelcodigodepago.Dock = DockStyle.Top;
            panelcodigodepago.Location = new Point(0, 160);
            panelcodigodepago.Name = "panelcodigodepago";
            panelcodigodepago.Size = new Size(920, 100);
            panelcodigodepago.TabIndex = 13;
            panelcodigodepago.Paint += panelcodigodepago_Paint;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(761, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(147, 28);
            btnBuscar.TabIndex = 95;
            btnBuscar.Text = "Cargar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(607, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 28);
            textBox3.TabIndex = 94;
            textBox3.Text = "Version";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(454, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 28);
            textBox2.TabIndex = 93;
            textBox2.Text = "Vehiculo";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(212, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 28);
            textBox1.TabIndex = 92;
            textBox1.Text = "Cliente";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(20, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 28);
            textBox5.TabIndex = 91;
            textBox5.Text = "Código de pago";
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
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(212, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 28);
            textBox4.TabIndex = 95;
            textBox4.Text = "Monto a pagar";
            // 
            // panelformadepago
            // 
            panelformadepago.Controls.Add(textBox4);
            panelformadepago.Controls.Add(cbFiltro);
            panelformadepago.Controls.Add(label5);
            panelformadepago.Dock = DockStyle.Top;
            panelformadepago.Location = new Point(0, 260);
            panelformadepago.Name = "panelformadepago";
            panelformadepago.Size = new Size(920, 100);
            panelformadepago.TabIndex = 14;
            panelformadepago.Paint += panelformadepago_Paint;
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Items.AddRange(new object[] { "Contado", "Tarjeta" });
            cbFiltro.Location = new Point(20, 56);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(186, 25);
            cbFiltro.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 23);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 3;
            label5.Text = "Selecione la forma de pago";
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 687);
            Controls.Add(panelformadepago);
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
            panelformadepago.ResumeLayout(false);
            panelformadepago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Panel paneltipooperacion;
        private Panel panelcodigodepago;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Panel panelformadepago;
        private Label label5;
        private ComboBox cbFiltro;
        private Button btnBuscar;
        private Button button1;
    }
}