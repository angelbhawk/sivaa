namespace SIVAA
{
    partial class Recuperar
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
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 65);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 101;
            label1.Text = "Correo electronico";
            // 
            // panel5
            // 
            panel5.Location = new Point(39, 262);
            panel5.Name = "panel5";
            panel5.Size = new Size(326, 40);
            panel5.TabIndex = 103;
            panel5.Paint += panel5_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(40, 44, 70);
            label3.Location = new Point(152, 341);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 102;
            label3.Text = "Iniciar sesion";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 212);
            button1.Name = "button1";
            button1.Size = new Size(198, 33);
            button1.TabIndex = 100;
            button1.Text = "Recuperar contraseña";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = Color.White;
            textBox6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(103, 88);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(198, 32);
            textBox6.TabIndex = 99;
            // 
            // Recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(404, 427);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recuperar";
            Text = "Recuperar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label3;
        private Button button1;
        private TextBox textBox6;
    }
}