namespace SIVAA
{
    partial class EspEmpleado
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
            button1 = new Button();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtApellidoP = new TextBox();
            label5 = new Label();
            txtApellidoM = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtRFC = new TextBox();
            label10 = new Label();
            txtContraseña = new TextBox();
            cbPuesto = new ComboBox();
            panel1.SuspendLayout();
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
            label2.Location = new Point(103, 20);
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
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Empleado /";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(693, 413);
            button1.Name = "button1";
            button1.Size = new Size(195, 37);
            button1.TabIndex = 15;
            button1.Text = "Listo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 95);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 19;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(33, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 32);
            txtNombre.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(270, 95);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 21;
            label4.Text = "Apellido paterno";
            // 
            // txtApellidoP
            // 
            txtApellidoP.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoP.Location = new Point(270, 118);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(199, 32);
            txtApellidoP.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(505, 95);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 23;
            label5.Text = "Apellido materno";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoM.Location = new Point(505, 118);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(199, 32);
            txtApellidoM.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 176);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 25;
            label6.Text = "Correo electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(33, 199);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(436, 32);
            txtCorreo.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(505, 176);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 27;
            label7.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(505, 199);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(199, 32);
            txtTelefono.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(505, 267);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 33;
            label8.Text = "Puesto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(270, 267);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 31;
            label9.Text = "RFC";
            // 
            // txtRFC
            // 
            txtRFC.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRFC.Location = new Point(270, 290);
            txtRFC.MaxLength = 10;
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(199, 32);
            txtRFC.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(33, 267);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 29;
            label10.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(33, 290);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(199, 32);
            txtContraseña.TabIndex = 28;
            // 
            // cbPuesto
            // 
            cbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPuesto.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbPuesto.FormattingEnabled = true;
            cbPuesto.Items.AddRange(new object[] { "Atencion", "Cajero", "Vendedor", "Supervisor" });
            cbPuesto.Location = new Point(505, 290);
            cbPuesto.Name = "cbPuesto";
            cbPuesto.Size = new Size(199, 31);
            cbPuesto.TabIndex = 34;
            // 
            // EspEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(cbPuesto);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtRFC);
            Controls.Add(label10);
            Controls.Add(txtContraseña);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtApellidoM);
            Controls.Add(label4);
            Controls.Add(txtApellidoP);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspEmpleado";
            Text = "EspEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtApellidoP;
        private Label label5;
        private TextBox txtApellidoM;
        private Label label6;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtTelefono;
        private Label label8;
        private Label label9;
        private TextBox txtRFC;
        private Label label10;
        private TextBox txtContraseña;
        private ComboBox cbPuesto;
    }
}