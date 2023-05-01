namespace SIVAA
{
    partial class Citas
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            txtBuscar = new TextBox();
            cbFiltro = new ComboBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 421);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(241, 241, 241);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(10, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(900, 399);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 60);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(cbFiltro);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(179, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 60);
            panel3.TabIndex = 2;
            panel3.Paint += panel1_Paint;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(537, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(109, 23);
            txtBuscar.TabIndex = 12;
            // 
            // cbFiltro
            // 
            cbFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Items.AddRange(new object[] { "Todos", "idPedido", "Nombre", "Apellido Materno", "Apellido Paterno", "Proveedor", "Dia", "Mes", "Año", "Importe" });
            cbFiltro.Location = new Point(410, 19);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(121, 24);
            cbFiltro.TabIndex = 11;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(234, 19);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(146, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(58, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(322, 19);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 1;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(652, 19);
            button1.Name = "button1";
            button1.Size = new Size(77, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Citas";
            // 
            // Column5
            // 
            Column5.HeaderText = "#";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Empleado";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Cliente";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Fecha";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Hora";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Citas";
            Text = "Citas";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private ComboBox cbFiltro;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}