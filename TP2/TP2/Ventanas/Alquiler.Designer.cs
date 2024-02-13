namespace TP2
{
    partial class Alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alquiler));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbTipoPropiedad = new System.Windows.Forms.GroupBox();
            this.cbCasaFinde = new System.Windows.Forms.CheckBox();
            this.cbHotel = new System.Windows.Forms.CheckBox();
            this.cbCasa = new System.Windows.Forms.CheckBox();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.IDPropiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.gbFechaReservA = new System.Windows.Forms.GroupBox();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lbDatosCliente = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labTriple = new System.Windows.Forms.Label();
            this.labSimple = new System.Windows.Forms.Label();
            this.labDoble = new System.Windows.Forms.Label();
            this.gbTipoHabitacion = new System.Windows.Forms.GroupBox();
            this.rbTriple = new System.Windows.Forms.RadioButton();
            this.rbDoble = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.gbUbicacion = new System.Windows.Forms.GroupBox();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.gbCapacidad = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.btnVerImagenes = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gbTipoPropiedad.SuspendLayout();
            this.gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.gbFechaReservA.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbTipoHabitacion.SuspendLayout();
            this.gbUbicacion.SuspendLayout();
            this.gbCapacidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 30);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar disponibles";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbTipoPropiedad
            // 
            this.gbTipoPropiedad.Controls.Add(this.cbCasaFinde);
            this.gbTipoPropiedad.Controls.Add(this.cbHotel);
            this.gbTipoPropiedad.Controls.Add(this.cbCasa);
            this.gbTipoPropiedad.Location = new System.Drawing.Point(8, 19);
            this.gbTipoPropiedad.Name = "gbTipoPropiedad";
            this.gbTipoPropiedad.Size = new System.Drawing.Size(157, 94);
            this.gbTipoPropiedad.TabIndex = 28;
            this.gbTipoPropiedad.TabStop = false;
            this.gbTipoPropiedad.Text = "Tipo de propiedad";
            // 
            // cbCasaFinde
            // 
            this.cbCasaFinde.AutoSize = true;
            this.cbCasaFinde.Location = new System.Drawing.Point(6, 65);
            this.cbCasaFinde.Name = "cbCasaFinde";
            this.cbCasaFinde.Size = new System.Drawing.Size(124, 17);
            this.cbCasaFinde.TabIndex = 2;
            this.cbCasaFinde.Text = "Casa Fin de Semana";
            this.cbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // cbHotel
            // 
            this.cbHotel.AutoSize = true;
            this.cbHotel.Location = new System.Drawing.Point(6, 19);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.Size = new System.Drawing.Size(51, 17);
            this.cbHotel.TabIndex = 0;
            this.cbHotel.Text = "Hotel";
            this.cbHotel.UseVisualStyleBackColor = true;
            // 
            // cbCasa
            // 
            this.cbCasa.AutoSize = true;
            this.cbCasa.Location = new System.Drawing.Point(6, 42);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(50, 17);
            this.cbCasa.TabIndex = 1;
            this.cbCasa.Text = "Casa";
            this.cbCasa.UseVisualStyleBackColor = true;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.checkBox7);
            this.gbServicios.Controls.Add(this.checkBox8);
            this.gbServicios.Controls.Add(this.checkBox9);
            this.gbServicios.Controls.Add(this.checkBox10);
            this.gbServicios.Controls.Add(this.checkBox11);
            this.gbServicios.Controls.Add(this.checkBox12);
            this.gbServicios.Location = new System.Drawing.Point(8, 119);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(157, 156);
            this.gbServicios.TabIndex = 27;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Servicios";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(8, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 17);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Cochera";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(8, 66);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(50, 17);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "Wi-Fi";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(8, 135);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(78, 17);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "PetFriendly";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(8, 112);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(74, 17);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Text = "Desayuno";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(8, 43);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(60, 17);
            this.checkBox11.TabIndex = 16;
            this.checkBox11.Text = "Piscina";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(8, 89);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(123, 17);
            this.checkBox12.TabIndex = 16;
            this.checkBox12.Text = "Servicio de Limpieza";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPropiedad,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgView.Location = new System.Drawing.Point(191, 181);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 51;
            this.dgView.Size = new System.Drawing.Size(852, 436);
            this.dgView.TabIndex = 26;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            // 
            // IDPropiedad
            // 
            this.IDPropiedad.HeaderText = "ID";
            this.IDPropiedad.MinimumWidth = 6;
            this.IDPropiedad.Name = "IDPropiedad";
            this.IDPropiedad.ReadOnly = true;
            this.IDPropiedad.Visible = false;
            this.IDPropiedad.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Propietario";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Servicios";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Capacidad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(8, 36);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicio.TabIndex = 32;
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // gbFechaReservA
            // 
            this.gbFechaReservA.Controls.Add(this.lbFechaHasta);
            this.gbFechaReservA.Controls.Add(this.lbFechaDesde);
            this.gbFechaReservA.Controls.Add(this.dtFechaHasta);
            this.gbFechaReservA.Controls.Add(this.dtFechaInicio);
            this.gbFechaReservA.Location = new System.Drawing.Point(652, 12);
            this.gbFechaReservA.Name = "gbFechaReservA";
            this.gbFechaReservA.Size = new System.Drawing.Size(215, 113);
            this.gbFechaReservA.TabIndex = 33;
            this.gbFechaReservA.TabStop = false;
            this.gbFechaReservA.Text = "Fecha de reserva";
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(8, 65);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(66, 13);
            this.lbFechaHasta.TabIndex = 34;
            this.lbFechaHasta.Text = "Fecha hasta";
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(8, 20);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lbFechaDesde.TabIndex = 0;
            this.lbFechaDesde.Text = "Fecha desde";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(8, 81);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHasta.TabIndex = 35;
            this.dtFechaHasta.ValueChanged += new System.EventHandler(this.dtFechaHasta_ValueChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gbCliente.Controls.Add(this.btnBuscarDni);
            this.gbCliente.Controls.Add(this.tbDni);
            this.gbCliente.Controls.Add(this.DNI);
            this.gbCliente.Location = new System.Drawing.Point(7, 25);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(217, 130);
            this.gbCliente.TabIndex = 34;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Buscar Cliente";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.Location = new System.Drawing.Point(31, 84);
            this.btnBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(139, 30);
            this.btnBuscarDni.TabIndex = 31;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = true;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(99, 44);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 2;
            this.tbDni.Text = "11111111";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(17, 47);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(57, 13);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "Dni cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.lbDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(230, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 130);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(39, 94);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(139, 30);
            this.btnQuitar.TabIndex = 32;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lbDatosCliente
            // 
            this.lbDatosCliente.FormattingEnabled = true;
            this.lbDatosCliente.Location = new System.Drawing.Point(6, 24);
            this.lbDatosCliente.Name = "lbDatosCliente";
            this.lbDatosCliente.Size = new System.Drawing.Size(205, 69);
            this.lbDatosCliente.TabIndex = 2;
            this.lbDatosCliente.SelectedIndexChanged += new System.EventHandler(this.lbDatosCliente_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.gbCliente);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 163);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.gbTipoHabitacion);
            this.groupBox3.Controls.Add(this.gbTipoPropiedad);
            this.groupBox3.Controls.Add(this.gbUbicacion);
            this.groupBox3.Controls.Add(this.gbCapacidad);
            this.groupBox3.Controls.Add(this.gbServicios);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 605);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propiedad";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labTriple);
            this.groupBox6.Controls.Add(this.labSimple);
            this.groupBox6.Controls.Add(this.labDoble);
            this.groupBox6.Location = new System.Drawing.Point(8, 502);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 91);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Habitaciones disponibles";
            // 
            // labTriple
            // 
            this.labTriple.AutoSize = true;
            this.labTriple.Location = new System.Drawing.Point(14, 65);
            this.labTriple.Name = "labTriple";
            this.labTriple.Size = new System.Drawing.Size(47, 13);
            this.labTriple.TabIndex = 2;
            this.labTriple.Text = "Triples: -";
            // 
            // labSimple
            // 
            this.labSimple.AutoSize = true;
            this.labSimple.Location = new System.Drawing.Point(9, 21);
            this.labSimple.Name = "labSimple";
            this.labSimple.Size = new System.Drawing.Size(52, 13);
            this.labSimple.TabIndex = 0;
            this.labSimple.Text = "Simples: -";
            // 
            // labDoble
            // 
            this.labDoble.AutoSize = true;
            this.labDoble.Location = new System.Drawing.Point(12, 43);
            this.labDoble.Name = "labDoble";
            this.labDoble.Size = new System.Drawing.Size(49, 13);
            this.labDoble.TabIndex = 1;
            this.labDoble.Text = "Dobles: -";
            // 
            // gbTipoHabitacion
            // 
            this.gbTipoHabitacion.Controls.Add(this.rbTriple);
            this.gbTipoHabitacion.Controls.Add(this.rbDoble);
            this.gbTipoHabitacion.Controls.Add(this.rbSimple);
            this.gbTipoHabitacion.Enabled = false;
            this.gbTipoHabitacion.Location = new System.Drawing.Point(8, 405);
            this.gbTipoHabitacion.Name = "gbTipoHabitacion";
            this.gbTipoHabitacion.Size = new System.Drawing.Size(157, 91);
            this.gbTipoHabitacion.TabIndex = 41;
            this.gbTipoHabitacion.TabStop = false;
            this.gbTipoHabitacion.Text = "Tipo de habitacion";
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.Location = new System.Drawing.Point(10, 67);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(51, 17);
            this.rbTriple.TabIndex = 2;
            this.rbTriple.Text = "Triple";
            this.rbTriple.UseVisualStyleBackColor = true;
            this.rbTriple.CheckedChanged += new System.EventHandler(this.CambiarGroupBox);
            // 
            // rbDoble
            // 
            this.rbDoble.AutoSize = true;
            this.rbDoble.Location = new System.Drawing.Point(10, 43);
            this.rbDoble.Name = "rbDoble";
            this.rbDoble.Size = new System.Drawing.Size(53, 17);
            this.rbDoble.TabIndex = 1;
            this.rbDoble.Text = "Doble";
            this.rbDoble.UseVisualStyleBackColor = true;
            this.rbDoble.CheckedChanged += new System.EventHandler(this.CambiarGroupBox);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.Location = new System.Drawing.Point(10, 19);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(56, 17);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.CambiarGroupBox);
            // 
            // gbUbicacion
            // 
            this.gbUbicacion.Controls.Add(this.cbUbicacion);
            this.gbUbicacion.Location = new System.Drawing.Point(8, 281);
            this.gbUbicacion.Name = "gbUbicacion";
            this.gbUbicacion.Size = new System.Drawing.Size(157, 54);
            this.gbUbicacion.TabIndex = 40;
            this.gbUbicacion.TabStop = false;
            this.gbUbicacion.Text = "Ubicacion";
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Location = new System.Drawing.Point(10, 17);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(137, 21);
            this.cbUbicacion.TabIndex = 26;
            this.cbUbicacion.SelectedIndexChanged += new System.EventHandler(this.cbUbicacion_SelectedIndexChanged_1);
            // 
            // gbCapacidad
            // 
            this.gbCapacidad.Controls.Add(this.label2);
            this.gbCapacidad.Controls.Add(this.numCapacidad);
            this.gbCapacidad.Location = new System.Drawing.Point(8, 341);
            this.gbCapacidad.Name = "gbCapacidad";
            this.gbCapacidad.Size = new System.Drawing.Size(157, 54);
            this.gbCapacidad.TabIndex = 41;
            this.gbCapacidad.TabStop = false;
            this.gbCapacidad.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cantidad personas:";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(107, 19);
            this.numCapacidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(37, 20);
            this.numCapacidad.TabIndex = 28;
            this.numCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnVerImagenes
            // 
            this.btnVerImagenes.Location = new System.Drawing.Point(16, 59);
            this.btnVerImagenes.Name = "btnVerImagenes";
            this.btnVerImagenes.Size = new System.Drawing.Size(139, 30);
            this.btnVerImagenes.TabIndex = 31;
            this.btnVerImagenes.Text = "Ver Imagenes";
            this.btnVerImagenes.UseVisualStyleBackColor = true;
            this.btnVerImagenes.Click += new System.EventHandler(this.btnVerImagenes_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(889, 137);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(139, 30);
            this.btnReservar.TabIndex = 38;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(31, 14);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(107, 16);
            this.labelPrecio.TabIndex = 39;
            this.labelPrecio.Text = "Costo Total: $ ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.btnVerImagenes);
            this.groupBox4.Location = new System.Drawing.Point(873, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 113);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de propiedades";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelPrecio);
            this.groupBox5.Location = new System.Drawing.Point(652, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 44);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 629);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFechaReservA);
            this.Controls.Add(this.dgView);
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.gbTipoPropiedad.ResumeLayout(false);
            this.gbTipoPropiedad.PerformLayout();
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.gbFechaReservA.ResumeLayout(false);
            this.gbFechaReservA.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbTipoHabitacion.ResumeLayout(false);
            this.gbTipoHabitacion.PerformLayout();
            this.gbUbicacion.ResumeLayout(false);
            this.gbCapacidad.ResumeLayout(false);
            this.gbCapacidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbTipoPropiedad;
        private System.Windows.Forms.CheckBox cbCasaFinde;
        private System.Windows.Forms.CheckBox cbHotel;
        private System.Windows.Forms.CheckBox cbCasa;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        public System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.GroupBox gbFechaReservA;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDatosCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerImagenes;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.GroupBox gbCapacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.GroupBox gbUbicacion;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.GroupBox gbTipoHabitacion;
        private System.Windows.Forms.RadioButton rbTriple;
        private System.Windows.Forms.RadioButton rbDoble;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labTriple;
        private System.Windows.Forms.Label labSimple;
        private System.Windows.Forms.Label labDoble;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnQuitar;
    }
}