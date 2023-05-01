namespace SIVAA
{
    partial class Proveedores
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            txtBuscar = new TextBox();
            cbFiltro = new ComboBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnImprimir = new Button();
            btnBuscar = new Button();
            label1 = new Label();
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
            panel2.TabIndex = 17;
            panel2.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(241, 241, 241);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3 });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(900, 401);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "RFC";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Direccion";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
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
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(cbFiltro);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(btnImprimir);
            panel3.Controls.Add(btnBuscar);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(217, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 60);
            panel3.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(499, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(109, 23);
            txtBuscar.TabIndex = 13;
            // 
            // cbFiltro
            // 
            cbFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Items.AddRange(new object[] { "Todos", "idPedido", "Nombre", "Apellido Materno", "Apellido Paterno", "Proveedor", "Dia", "Mes", "Año", "Importe" });
            cbFiltro.Location = new Point(372, 18);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(121, 24);
            cbFiltro.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(197, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button5_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(109, 18);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(21, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button3_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(284, 18);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(82, 23);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += button2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(614, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
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
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnImprimir;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtBuscar;
        private ComboBox cbFiltro;
    }
}