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
            btnAceptar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCancelar = new Button();
            cbEmpleado = new ComboBox();
            label3 = new Label();
            date = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cbProveedor = new ComboBox();
            txtImporte = new TextBox();
            label6 = new Label();
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
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Location = new Point(504, 435);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(166, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Location = new Point(182, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(103, 133);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(229, 23);
            cbEmpleado.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(103, 115);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre de Empleado";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            date.Location = new Point(474, 133);
            date.Name = "date";
            date.Size = new Size(229, 23);
            date.TabIndex = 6;
            date.Value = new DateTime(2023, 4, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(474, 115);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(103, 179);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre de Proveedor";
            // 
            // cbProveedor
            // 
            cbProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(103, 197);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(229, 23);
            cbProveedor.TabIndex = 8;
            // 
            // txtImporte
            // 
            txtImporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtImporte.Location = new Point(474, 195);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(229, 23);
            txtImporte.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(474, 177);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 11;
            label6.Text = "Importe ($)";
            // 
            // EspPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 481);
            Controls.Add(label6);
            Controls.Add(txtImporte);
            Controls.Add(label5);
            Controls.Add(cbProveedor);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(cbEmpleado);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
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
        private Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCancelar;
        private ComboBox cbEmpleado;
        private Label label3;
        private DateTimePicker date;
        private Label label4;
        private Label label5;
        private ComboBox cbProveedor;
        private TextBox txtImporte;
        private Label label6;
    }
}