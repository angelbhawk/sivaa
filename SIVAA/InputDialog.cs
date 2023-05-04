using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SIVAA
{
    public class InputDialog : Form
    {
        private Label label;
        private TextBox textBox;
        private Button okButton;
        private Button cancelButton;
        public string s = "";

        public InputDialog(string prompt, string title)
        {
            
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(300, 120);

            this.label = new Label();
            this.label.AutoSize = true;
            this.label.Location = new Point(20, 20);
            this.label.Text = prompt;

            this.textBox = new TextBox();
            this.textBox.Location = new Point(20, 50);
            this.textBox.Size = new Size(260, 20);

            this.okButton = new Button();
            this.okButton.DialogResult = DialogResult.OK;
            this.okButton.Location = new Point(110, 80);
            this.okButton.Text = "OK";
            this.okButton.Click += (sender, e) => { s = this.textBox.Text; };

            this.cancelButton = new Button();
            this.cancelButton.DialogResult = DialogResult.Cancel;
            this.cancelButton.Location = new Point(190, 80);
            this.cancelButton.Text = "Cancel";

            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
        }

        public static DialogResult ShowDialog(string prompt, string title, ref string input)
        {
            InputDialog dialog = new InputDialog(prompt, title);
            return dialog.ShowDialog();
        }
    }
}
