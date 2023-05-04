namespace SIVAA
{
    partial class EspVersion
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
            cbVehiculo = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            txtVersion = new TextBox();
            cbRines = new ComboBox();
            label3 = new Label();
            cbCilindros = new ComboBox();
            label5 = new Label();
            cbLlantas = new ComboBox();
            label6 = new Label();
            cbAsientos = new ComboBox();
            label7 = new Label();
            cbCombustibles = new ComboBox();
            label9 = new Label();
            cbNumPuertas = new ComboBox();
            label10 = new Label();
            cbEngranajes = new ComboBox();
            label11 = new Label();
            cbTransmision = new ComboBox();
            label12 = new Label();
            cbTipoTransmision = new ComboBox();
            label13 = new Label();
            cbFrenosD = new ComboBox();
            label14 = new Label();
            cbFrenosT = new ComboBox();
            label15 = new Label();
            cbSuspensionD = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            txtCombustible = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label22 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            chTrasera = new CheckBox();
            chPantalla = new CheckBox();
            chHal = new CheckBox();
            cbLed = new CheckBox();
            chAudio = new CheckBox();
            chTomaC = new CheckBox();
            chEspejosDir = new CheckBox();
            chEspejosLAE = new CheckBox();
            label26 = new Label();
            txtCosto = new TextBox();
            cbSuspensionT = new ComboBox();
            label27 = new Label();
            label28 = new Label();
            txtCapacidadC = new TextBox();
            label29 = new Label();
            txtDistanciaEjes = new TextBox();
            label30 = new Label();
            txtAnchura = new TextBox();
            label31 = new Label();
            txtAltura = new TextBox();
            label32 = new Label();
            cbModelo = new ComboBox();
            chAuto = new CheckBox();
            label33 = new Label();
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
            panel1.Size = new Size(999, 60);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 20);
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
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Version /";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(750, 547);
            button1.Name = "button1";
            button1.Size = new Size(174, 33);
            button1.TabIndex = 16;
            button1.Text = "Listo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbVehiculo
            // 
            cbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehiculo.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbVehiculo.FormattingEnabled = true;
            cbVehiculo.Location = new Point(33, 118);
            cbVehiculo.Name = "cbVehiculo";
            cbVehiculo.Size = new Size(199, 31);
            cbVehiculo.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 95);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 35;
            label8.Text = "Vehiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(258, 94);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 38;
            label4.Text = "Version";
            // 
            // txtVersion
            // 
            txtVersion.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVersion.Location = new Point(258, 117);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(199, 32);
            txtVersion.TabIndex = 37;
            // 
            // cbRines
            // 
            cbRines.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRines.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbRines.FormattingEnabled = true;
            cbRines.Items.AddRange(new object[] { "Rines de aleacion", "Rines de aluminio" });
            cbRines.Location = new Point(33, 187);
            cbRines.Name = "cbRines";
            cbRines.Size = new Size(199, 31);
            cbRines.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 164);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 39;
            label3.Text = "Rines";
            // 
            // cbCilindros
            // 
            cbCilindros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCilindros.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCilindros.FormattingEnabled = true;
            cbCilindros.Items.AddRange(new object[] { "4 ", "6 ", "8 " });
            cbCilindros.Location = new Point(33, 257);
            cbCilindros.Name = "cbCilindros";
            cbCilindros.Size = new Size(199, 31);
            cbCilindros.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 234);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 41;
            label5.Text = "Cilindros";
            // 
            // cbLlantas
            // 
            cbLlantas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLlantas.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbLlantas.FormattingEnabled = true;
            cbLlantas.Items.AddRange(new object[] { "155/70 R13", "155/80 R13", "165/65 R14", "165/70 R14", "175/65 R15", "185/60 R15" });
            cbLlantas.Location = new Point(33, 328);
            cbLlantas.Name = "cbLlantas";
            cbLlantas.Size = new Size(199, 31);
            cbLlantas.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 305);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 43;
            label6.Text = "Llantas";
            // 
            // cbAsientos
            // 
            cbAsientos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAsientos.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbAsientos.FormattingEnabled = true;
            cbAsientos.Items.AddRange(new object[] { "Tela Normal", "Tela arabe", "Piel sintetica", "Piel de mamut" });
            cbAsientos.Location = new Point(33, 401);
            cbAsientos.Name = "cbAsientos";
            cbAsientos.Size = new Size(199, 31);
            cbAsientos.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 378);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 45;
            label7.Text = "Asientos";
            // 
            // cbCombustibles
            // 
            cbCombustibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCombustibles.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCombustibles.FormattingEnabled = true;
            cbCombustibles.Items.AddRange(new object[] { "Regular", "Premium" });
            cbCombustibles.Location = new Point(258, 187);
            cbCombustibles.Name = "cbCombustibles";
            cbCombustibles.Size = new Size(199, 31);
            cbCombustibles.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(258, 164);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 47;
            label9.Text = "Combustible";
            // 
            // cbNumPuertas
            // 
            cbNumPuertas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumPuertas.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbNumPuertas.FormattingEnabled = true;
            cbNumPuertas.Items.AddRange(new object[] { "2", "4", "6" });
            cbNumPuertas.Location = new Point(258, 398);
            cbNumPuertas.Name = "cbNumPuertas";
            cbNumPuertas.Size = new Size(199, 31);
            cbNumPuertas.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(258, 375);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 49;
            label10.Text = "Numero de puertas";
            // 
            // cbEngranajes
            // 
            cbEngranajes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEngranajes.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEngranajes.FormattingEnabled = true;
            cbEngranajes.Items.AddRange(new object[] { "4", "5", "6", "7" });
            cbEngranajes.Location = new Point(258, 257);
            cbEngranajes.Name = "cbEngranajes";
            cbEngranajes.Size = new Size(199, 31);
            cbEngranajes.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(258, 234);
            label11.Name = "label11";
            label11.Size = new Size(163, 20);
            label11.TabIndex = 51;
            label11.Text = "Numero de engranajes";
            // 
            // cbTransmision
            // 
            cbTransmision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransmision.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTransmision.FormattingEnabled = true;
            cbTransmision.Items.AddRange(new object[] { "Manual", "Automatico" });
            cbTransmision.Location = new Point(258, 328);
            cbTransmision.Name = "cbTransmision";
            cbTransmision.Size = new Size(199, 31);
            cbTransmision.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(258, 305);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 53;
            label12.Text = "Transmision";
            // 
            // cbTipoTransmision
            // 
            cbTipoTransmision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTransmision.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoTransmision.FormattingEnabled = true;
            cbTipoTransmision.Items.AddRange(new object[] { "Delantera", "Trasera" });
            cbTipoTransmision.Location = new Point(475, 187);
            cbTipoTransmision.Name = "cbTipoTransmision";
            cbTipoTransmision.Size = new Size(199, 31);
            cbTipoTransmision.TabIndex = 56;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(475, 164);
            label13.Name = "label13";
            label13.Size = new Size(145, 20);
            label13.TabIndex = 55;
            label13.Text = "Tipo de transmision";
            // 
            // cbFrenosD
            // 
            cbFrenosD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrenosD.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFrenosD.FormattingEnabled = true;
            cbFrenosD.Items.AddRange(new object[] { "Tambor", "Discos", "Discos solidos" });
            cbFrenosD.Location = new Point(475, 257);
            cbFrenosD.Name = "cbFrenosD";
            cbFrenosD.Size = new Size(199, 31);
            cbFrenosD.TabIndex = 58;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(475, 234);
            label14.Name = "label14";
            label14.Size = new Size(131, 20);
            label14.TabIndex = 57;
            label14.Text = "Frenos delanteros";
            // 
            // cbFrenosT
            // 
            cbFrenosT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrenosT.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFrenosT.FormattingEnabled = true;
            cbFrenosT.Items.AddRange(new object[] { "Tambor", "Discos", "Discos solidos" });
            cbFrenosT.Location = new Point(475, 327);
            cbFrenosT.Name = "cbFrenosT";
            cbFrenosT.Size = new Size(199, 31);
            cbFrenosT.TabIndex = 60;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(475, 304);
            label15.Name = "label15";
            label15.Size = new Size(114, 20);
            label15.TabIndex = 59;
            label15.Text = "Frenos traseros";
            // 
            // cbSuspensionD
            // 
            cbSuspensionD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuspensionD.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbSuspensionD.FormattingEnabled = true;
            cbSuspensionD.Items.AddRange(new object[] { "Eje oscilante", "Brazos tirados", "Sistema PcPherson", "Triángulos superpuestos", "Rígida", "Semirígida" });
            cbSuspensionD.Location = new Point(475, 398);
            cbSuspensionD.Name = "cbSuspensionD";
            cbSuspensionD.Size = new Size(199, 31);
            cbSuspensionD.TabIndex = 62;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(475, 375);
            label16.Name = "label16";
            label16.Size = new Size(158, 20);
            label16.TabIndex = 61;
            label16.Text = "Suspension delantera";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(475, 525);
            label17.Name = "label17";
            label17.Size = new Size(206, 20);
            label17.TabIndex = 64;
            label17.Text = "Rendimiento de combustible";
            // 
            // txtCombustible
            // 
            txtCombustible.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCombustible.Location = new Point(475, 548);
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(199, 32);
            txtCombustible.TabIndex = 63;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(761, 95);
            label18.Name = "label18";
            label18.Size = new Size(112, 20);
            label18.TabIndex = 65;
            label18.Text = "Camara trasera";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(761, 129);
            label19.Name = "label19";
            label19.Size = new Size(65, 20);
            label19.TabIndex = 66;
            label19.Text = "Pantalla";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(761, 163);
            label20.Name = "label20";
            label20.Size = new Size(80, 20);
            label20.TabIndex = 67;
            label20.Text = "Faros HAL";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(761, 197);
            label22.Name = "label22";
            label22.Size = new Size(79, 20);
            label22.TabIndex = 69;
            label22.Text = "Faros LED";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(761, 231);
            label21.Name = "label21";
            label21.Size = new Size(80, 20);
            label21.TabIndex = 70;
            label21.Text = "AudioVelC";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(761, 265);
            label23.Name = "label23";
            label23.Size = new Size(109, 20);
            label23.TabIndex = 71;
            label23.Text = "Toma corriente";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(764, 299);
            label24.Name = "label24";
            label24.Size = new Size(115, 20);
            label24.TabIndex = 72;
            label24.Text = "EspejosLatDirC";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(764, 333);
            label25.Name = "label25";
            label25.Size = new Size(104, 20);
            label25.TabIndex = 73;
            label25.Text = "EspejosLatAE";
            // 
            // chTrasera
            // 
            chTrasera.AutoSize = true;
            chTrasera.Location = new Point(900, 98);
            chTrasera.Name = "chTrasera";
            chTrasera.Size = new Size(15, 14);
            chTrasera.TabIndex = 74;
            chTrasera.UseVisualStyleBackColor = true;
            // 
            // chPantalla
            // 
            chPantalla.AutoSize = true;
            chPantalla.Location = new Point(900, 132);
            chPantalla.Name = "chPantalla";
            chPantalla.Size = new Size(15, 14);
            chPantalla.TabIndex = 75;
            chPantalla.UseVisualStyleBackColor = true;
            // 
            // chHal
            // 
            chHal.AutoSize = true;
            chHal.Location = new Point(900, 166);
            chHal.Name = "chHal";
            chHal.Size = new Size(15, 14);
            chHal.TabIndex = 76;
            chHal.UseVisualStyleBackColor = true;
            // 
            // cbLed
            // 
            cbLed.AutoSize = true;
            cbLed.Location = new Point(900, 201);
            cbLed.Name = "cbLed";
            cbLed.Size = new Size(15, 14);
            cbLed.TabIndex = 77;
            cbLed.UseVisualStyleBackColor = true;
            // 
            // chAudio
            // 
            chAudio.AutoSize = true;
            chAudio.Location = new Point(900, 234);
            chAudio.Name = "chAudio";
            chAudio.Size = new Size(15, 14);
            chAudio.TabIndex = 78;
            chAudio.UseVisualStyleBackColor = true;
            // 
            // chTomaC
            // 
            chTomaC.AutoSize = true;
            chTomaC.Location = new Point(900, 268);
            chTomaC.Name = "chTomaC";
            chTomaC.Size = new Size(15, 14);
            chTomaC.TabIndex = 79;
            chTomaC.UseVisualStyleBackColor = true;
            // 
            // chEspejosDir
            // 
            chEspejosDir.AutoSize = true;
            chEspejosDir.Location = new Point(900, 302);
            chEspejosDir.Name = "chEspejosDir";
            chEspejosDir.Size = new Size(15, 14);
            chEspejosDir.TabIndex = 80;
            chEspejosDir.UseVisualStyleBackColor = true;
            // 
            // chEspejosLAE
            // 
            chEspejosLAE.AutoSize = true;
            chEspejosLAE.Location = new Point(900, 336);
            chEspejosLAE.Name = "chEspejosLAE";
            chEspejosLAE.Size = new Size(15, 14);
            chEspejosLAE.TabIndex = 81;
            chEspejosLAE.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(741, 425);
            label26.Name = "label26";
            label26.Size = new Size(48, 20);
            label26.TabIndex = 83;
            label26.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(741, 448);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(199, 32);
            txtCosto.TabIndex = 82;
            // 
            // cbSuspensionT
            // 
            cbSuspensionT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuspensionT.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbSuspensionT.FormattingEnabled = true;
            cbSuspensionT.Items.AddRange(new object[] { "Eje oscilante", "Brazos tirados", "Sistema PcPherson", "Triángulos superpuestos", "Rígida", "Semirígida" });
            cbSuspensionT.Location = new Point(475, 471);
            cbSuspensionT.Name = "cbSuspensionT";
            cbSuspensionT.Size = new Size(199, 31);
            cbSuspensionT.TabIndex = 85;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(475, 448);
            label27.Name = "label27";
            label27.Size = new Size(143, 20);
            label27.TabIndex = 84;
            label27.Text = "Suspension Trasera";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(33, 448);
            label28.Name = "label28";
            label28.Size = new Size(156, 20);
            label28.TabIndex = 87;
            label28.Text = "Capacidad de cajuela";
            // 
            // txtCapacidadC
            // 
            txtCapacidadC.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidadC.Location = new Point(33, 471);
            txtCapacidadC.Name = "txtCapacidadC";
            txtCapacidadC.Size = new Size(199, 32);
            txtCapacidadC.TabIndex = 86;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(258, 448);
            label29.Name = "label29";
            label29.Size = new Size(107, 20);
            label29.TabIndex = 89;
            label29.Text = "Distancia Ejes";
            // 
            // txtDistanciaEjes
            // 
            txtDistanciaEjes.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDistanciaEjes.Location = new Point(258, 471);
            txtDistanciaEjes.Name = "txtDistanciaEjes";
            txtDistanciaEjes.Size = new Size(199, 32);
            txtDistanciaEjes.TabIndex = 88;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(258, 524);
            label30.Name = "label30";
            label30.Size = new Size(67, 20);
            label30.TabIndex = 91;
            label30.Text = "Anchura";
            // 
            // txtAnchura
            // 
            txtAnchura.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnchura.Location = new Point(258, 547);
            txtAnchura.Name = "txtAnchura";
            txtAnchura.Size = new Size(199, 32);
            txtAnchura.TabIndex = 90;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(33, 525);
            label31.Name = "label31";
            label31.Size = new Size(50, 20);
            label31.TabIndex = 93;
            label31.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(33, 548);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(199, 32);
            txtAltura.TabIndex = 92;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label32.Location = new Point(475, 95);
            label32.Name = "label32";
            label32.Size = new Size(60, 20);
            label32.TabIndex = 95;
            label32.Text = "Modelo";
            // 
            // cbModelo
            // 
            cbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModelo.Font = new Font("Yu Gothic", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbModelo.FormattingEnabled = true;
            cbModelo.Location = new Point(475, 118);
            cbModelo.Name = "cbModelo";
            cbModelo.Size = new Size(199, 31);
            cbModelo.TabIndex = 96;
            // 
            // chAuto
            // 
            chAuto.AutoSize = true;
            chAuto.Location = new Point(900, 369);
            chAuto.Name = "chAuto";
            chAuto.Size = new Size(15, 14);
            chAuto.TabIndex = 98;
            chAuto.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(764, 366);
            label33.Name = "label33";
            label33.Size = new Size(74, 20);
            label33.TabIndex = 97;
            label33.Text = "ACAutom";
            // 
            // EspVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 614);
            Controls.Add(chAuto);
            Controls.Add(label33);
            Controls.Add(cbModelo);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(txtAltura);
            Controls.Add(label30);
            Controls.Add(txtAnchura);
            Controls.Add(label29);
            Controls.Add(txtDistanciaEjes);
            Controls.Add(label28);
            Controls.Add(txtCapacidadC);
            Controls.Add(cbSuspensionT);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(txtCosto);
            Controls.Add(chEspejosLAE);
            Controls.Add(chEspejosDir);
            Controls.Add(chTomaC);
            Controls.Add(chAudio);
            Controls.Add(cbLed);
            Controls.Add(chHal);
            Controls.Add(chPantalla);
            Controls.Add(chTrasera);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(txtCombustible);
            Controls.Add(cbSuspensionD);
            Controls.Add(label16);
            Controls.Add(cbFrenosT);
            Controls.Add(label15);
            Controls.Add(cbFrenosD);
            Controls.Add(label14);
            Controls.Add(cbTipoTransmision);
            Controls.Add(label13);
            Controls.Add(cbTransmision);
            Controls.Add(label12);
            Controls.Add(cbEngranajes);
            Controls.Add(label11);
            Controls.Add(cbNumPuertas);
            Controls.Add(label10);
            Controls.Add(cbCombustibles);
            Controls.Add(label9);
            Controls.Add(cbAsientos);
            Controls.Add(label7);
            Controls.Add(cbLlantas);
            Controls.Add(label6);
            Controls.Add(cbCilindros);
            Controls.Add(label5);
            Controls.Add(cbRines);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtVersion);
            Controls.Add(cbVehiculo);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspVersion";
            Text = "EspVersion";
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
        private ComboBox cbVehiculo;
        private Label label8;
        private Label label4;
        private TextBox txtVersion;
        private ComboBox cbRines;
        private Label label3;
        private ComboBox cbCilindros;
        private Label label5;
        private ComboBox cbLlantas;
        private Label label6;
        private ComboBox cbAsientos;
        private Label label7;
        private ComboBox cbCombustibles;
        private Label label9;
        private ComboBox cbNumPuertas;
        private Label label10;
        private ComboBox cbEngranajes;
        private Label label11;
        private ComboBox cbTransmision;
        private Label label12;
        private ComboBox cbTipoTransmision;
        private Label label13;
        private ComboBox cbFrenosD;
        private Label label14;
        private ComboBox cbFrenosT;
        private Label label15;
        private ComboBox cbSuspensionD;
        private Label label16;
        private Label label17;
        private TextBox txtCombustible;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label22;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
        private CheckBox chTrasera;
        private CheckBox chPantalla;
        private CheckBox chHal;
        private CheckBox cbLed;
        private CheckBox chAudio;
        private CheckBox chTomaC;
        private CheckBox chEspejosDir;
        private CheckBox chEspejosLAE;
        private Label label26;
        private TextBox txtCosto;
        private ComboBox cbSuspensionT;
        private Label label27;
        private Label label28;
        private TextBox txtCapacidadC;
        private Label label29;
        private TextBox txtDistanciaEjes;
        private Label label30;
        private TextBox txtAnchura;
        private Label label31;
        private TextBox txtAltura;
        private Label label32;
        private ComboBox cbModelo;
        private CheckBox chAuto;
        private Label label33;
    }
}