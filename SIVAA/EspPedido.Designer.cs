namespace SIVAA
{
    partial class EspPedido
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtImporte = new TextBox();
            label11 = new Label();
            label6 = new Label();
            date = new DateTimePicker();
            cbEmpleado = new ComboBox();
            label3 = new Label();
            cbProveedor = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            label7 = new Label();
            cbVersion = new ComboBox();
            label5 = new Label();
            cbColor = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 22);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Agregar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Pedido /";
            label1.Click += label1_Click;
            // 
            // txtImporte
            // 
            txtImporte.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtImporte.Location = new Point(476, 320);
            txtImporte.MaxLength = 5;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(182, 32);
            txtImporte.TabIndex = 113;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(476, 297);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 112;
            label11.Text = "Importe ($)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 297);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 115;
            label6.Text = "Fecha";
            // 
            // date
            // 
            date.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(30, 320);
            date.Name = "date";
            date.Size = new Size(371, 32);
            date.TabIndex = 114;
            date.Value = new DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // cbEmpleado
            // 
            cbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpleado.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(28, 113);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(287, 31);
            cbEmpleado.TabIndex = 117;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 90);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 116;
            label3.Text = "Empleado";
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(28, 218);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(287, 31);
            cbProveedor.TabIndex = 119;
            cbProveedor.SelectedIndexChanged += cbProveedor_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 195);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 118;
            label4.Text = "Proveedor";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(662, 436);
            button1.Name = "button1";
            button1.Size = new Size(169, 33);
            button1.TabIndex = 120;
            button1.Text = "Listo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(476, 195);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 123;
            label7.Text = "Color";
            // 
            // cbVersion
            // 
            cbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVersion.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbVersion.FormattingEnabled = true;
            cbVersion.Location = new Point(474, 113);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(182, 31);
            cbVersion.TabIndex = 126;
            cbVersion.SelectedIndexChanged += cbVersion_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(474, 90);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 125;
            label5.Text = "Versiones";
            // 
            // cbColor
            // 
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "Azul", "Rojo", "Verde", "Negro", "Blanco", "Gris", "Plateado", "Morado", "Marron", "Rosa" });
            cbColor.Location = new Point(476, 218);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(182, 31);
            cbColor.TabIndex = 127;
            // 
            // EspPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 481);
            Controls.Add(cbColor);
            Controls.Add(cbVersion);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(cbProveedor);
            Controls.Add(label4);
            Controls.Add(cbEmpleado);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(date);
            Controls.Add(txtImporte);
            Controls.Add(label11);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspPedido";
            Text = "EspPedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtImporte;
        private Label label11;
        private Label label6;
        private DateTimePicker date;
        private ComboBox cbEmpleado;
        private Label label3;
        private ComboBox cbProveedor;
        private Label label4;
        private Button button1;
        private Label label7;
        private ComboBox cbVersion;
        private Label label5;
        private ComboBox cbColor;
    }
}