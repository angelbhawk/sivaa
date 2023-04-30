namespace SIVAA
{
    partial class Principal
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
            label1 = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel8 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Pantalla principal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 421);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel8);
            panel9.Location = new Point(21, 19);
            panel9.Name = "panel9";
            panel9.Size = new Size(878, 382);
            panel9.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(51, 58, 86);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(605, 213);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 146);
            panel6.TabIndex = 5;
            panel6.Click += panel6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox6.Image = Properties.Resources.cotizaciones;
            pictureBox6.Location = new Point(166, 72);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 54);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 21);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 9;
            label7.Text = "Cotizaciones";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(51, 58, 86);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(312, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 146);
            panel4.TabIndex = 1;
            panel4.Click += panel4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.versiones;
            pictureBox3.Location = new Point(166, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 51);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 21);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Versiones";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.BackColor = Color.FromArgb(40, 44, 70);
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(312, 213);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 146);
            panel7.TabIndex = 4;
            panel7.Click += panel7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Image = Properties.Resources.clientes;
            pictureBox5.Location = new Point(166, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 60);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 21);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 9;
            label6.Text = "Clientes";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(40, 44, 70);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 146);
            panel3.TabIndex = 0;
            panel3.Click += panel3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.vehiculos;
            pictureBox1.Location = new Point(166, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 51);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Vehiculos";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(40, 44, 70);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(605, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 146);
            panel5.TabIndex = 2;
            panel5.Click += panel5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.empleados;
            pictureBox4.Location = new Point(166, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 51);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 21);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Empleados";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(22, 213);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 146);
            panel8.TabIndex = 3;
            panel8.Click += panel8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.proveedores;
            pictureBox2.Location = new Point(166, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 54);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Proveedores";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel8;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel9;
    }
}