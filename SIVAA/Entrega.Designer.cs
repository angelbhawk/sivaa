namespace SIVAA
{
    partial class Entrega
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
            panel8 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            label7 = new Label();
            panel11 = new Panel();
            label8 = new Label();
            tbxnoserie = new TextBox();
            label9 = new Label();
            tbxcolor = new TextBox();
            label10 = new Label();
            tbxmodelo = new TextBox();
            label11 = new Label();
            tbxid = new TextBox();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(textBox4);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(445, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(475, 60);
            panel8.TabIndex = 91;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(334, 14);
            button2.Name = "button2";
            button2.Size = new Size(131, 33);
            button2.TabIndex = 114;
            button2.Text = "Entregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(197, 14);
            button1.Name = "button1";
            button1.Size = new Size(131, 33);
            button1.TabIndex = 113;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(14, 14);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 32);
            textBox4.TabIndex = 90;
            textBox4.Text = "Folio";
            textBox4.Click += textBox4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Compras /";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 421);
            panel2.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(920, 421);
            panel7.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel11);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(920, 170);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(920, 51);
            panel10.TabIndex = 4;
            panel10.Paint += panel10_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 15);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 2;
            label7.Text = "Datos del vehiculo";
            label7.Click += label7_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(241, 241, 241);
            panel11.Controls.Add(label8);
            panel11.Controls.Add(tbxnoserie);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(tbxcolor);
            panel11.Controls.Add(label10);
            panel11.Controls.Add(tbxmodelo);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(tbxid);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(920, 170);
            panel11.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(690, 77);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 96;
            label8.Text = "No. Serie";
            // 
            // tbxnoserie
            // 
            tbxnoserie.Enabled = false;
            tbxnoserie.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxnoserie.Location = new Point(690, 100);
            tbxnoserie.Name = "tbxnoserie";
            tbxnoserie.Size = new Size(180, 32);
            tbxnoserie.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(475, 77);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 94;
            label9.Text = "Color";
            // 
            // tbxcolor
            // 
            tbxcolor.Enabled = false;
            tbxcolor.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxcolor.Location = new Point(475, 100);
            tbxcolor.Name = "tbxcolor";
            tbxcolor.Size = new Size(180, 32);
            tbxcolor.TabIndex = 93;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(261, 77);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 92;
            label10.Text = "Modelo";
            // 
            // tbxmodelo
            // 
            tbxmodelo.Enabled = false;
            tbxmodelo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxmodelo.Location = new Point(261, 100);
            tbxmodelo.Name = "tbxmodelo";
            tbxmodelo.Size = new Size(180, 32);
            tbxmodelo.TabIndex = 91;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(50, 77);
            label11.Name = "label11";
            label11.Size = new Size(22, 20);
            label11.TabIndex = 90;
            label11.Text = "Id";
            // 
            // tbxid
            // 
            tbxid.Enabled = false;
            tbxid.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxid.Location = new Point(50, 100);
            tbxid.Name = "tbxid";
            tbxid.Size = new Size(180, 32);
            tbxid.TabIndex = 89;
            // 
            // Entrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Entrega";
            Text = "Entrega";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel7;
        private TextBox textBox4;
        private Panel panel8;
        private Button button2;
        private Button button1;
        private Panel panel9;
        private Panel panel10;
        private Label label7;
        private Panel panel11;
        private Label label8;
        private TextBox tbxnoserie;
        private Label label9;
        private TextBox tbxcolor;
        private Label label10;
        private TextBox tbxmodelo;
        private Label label11;
        private TextBox tbxid;
    }
}