namespace SIVAA
{
    partial class EspCita
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox13 = new ComboBox();
            label16 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
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
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 20);
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
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Citas /";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 31);
            comboBox1.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 120);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 67;
            label3.Text = "Empleado";
            // 
            // comboBox13
            // 
            comboBox13.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox13.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox13.FormattingEnabled = true;
            comboBox13.Location = new Point(249, 143);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(197, 31);
            comboBox13.TabIndex = 70;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(249, 120);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 69;
            label16.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 199);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 74;
            label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(33, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(413, 32);
            dateTimePicker1.TabIndex = 73;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(361, 416);
            button1.Name = "button1";
            button1.Size = new Size(169, 33);
            button1.TabIndex = 92;
            button1.Text = "Listo";
            button1.UseVisualStyleBackColor = true;
            // 
            // EspCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox13);
            Controls.Add(label16);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspCita";
            Text = "EspCita";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox13;
        private Label label16;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}