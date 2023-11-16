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
            this.lbDatosCliente = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerImagenes = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.gbTipoPropiedad.SuspendLayout();
            this.gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.gbFechaReservA.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(49, 358);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 37);
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
            this.gbTipoPropiedad.Location = new System.Drawing.Point(8, 23);
            this.gbTipoPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.gbTipoPropiedad.Name = "gbTipoPropiedad";
            this.gbTipoPropiedad.Padding = new System.Windows.Forms.Padding(4);
            this.gbTipoPropiedad.Size = new System.Drawing.Size(285, 116);
            this.gbTipoPropiedad.TabIndex = 28;
            this.gbTipoPropiedad.TabStop = false;
            this.gbTipoPropiedad.Text = "Tipo de propiedad";
            // 
            // cbCasaFinde
            // 
            this.cbCasaFinde.AutoSize = true;
            this.cbCasaFinde.Location = new System.Drawing.Point(8, 80);
            this.cbCasaFinde.Margin = new System.Windows.Forms.Padding(4);
            this.cbCasaFinde.Name = "cbCasaFinde";
            this.cbCasaFinde.Size = new System.Drawing.Size(155, 20);
            this.cbCasaFinde.TabIndex = 2;
            this.cbCasaFinde.Text = "Casa Fin de Semana";
            this.cbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // cbHotel
            // 
            this.cbHotel.AutoSize = true;
            this.cbHotel.Location = new System.Drawing.Point(8, 23);
            this.cbHotel.Margin = new System.Windows.Forms.Padding(4);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.Size = new System.Drawing.Size(61, 20);
            this.cbHotel.TabIndex = 0;
            this.cbHotel.Text = "Hotel";
            this.cbHotel.UseVisualStyleBackColor = true;
            // 
            // cbCasa
            // 
            this.cbCasa.AutoSize = true;
            this.cbCasa.Location = new System.Drawing.Point(8, 52);
            this.cbCasa.Margin = new System.Windows.Forms.Padding(4);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(61, 20);
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
            this.gbServicios.Location = new System.Drawing.Point(5, 146);
            this.gbServicios.Margin = new System.Windows.Forms.Padding(4);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Padding = new System.Windows.Forms.Padding(4);
            this.gbServicios.Size = new System.Drawing.Size(288, 194);
            this.gbServicios.TabIndex = 27;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Servicios";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(11, 23);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 20);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Cochera";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(11, 81);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(60, 20);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "Wi-Fi";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(11, 166);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(97, 20);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "PetFriendly";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(11, 138);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(91, 20);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Text = "Desayuno";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(11, 53);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(73, 20);
            this.checkBox11.TabIndex = 16;
            this.checkBox11.Text = "Piscina";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(11, 110);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(154, 20);
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
            this.dgView.Location = new System.Drawing.Point(653, 15);
            this.dgView.Margin = new System.Windows.Forms.Padding(4);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 51;
            this.dgView.Size = new System.Drawing.Size(921, 521);
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
            this.IDPropiedad.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            this.dtFechaInicio.Location = new System.Drawing.Point(11, 44);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtFechaInicio.TabIndex = 32;
            // 
            // gbFechaReservA
            // 
            this.gbFechaReservA.Controls.Add(this.lbFechaHasta);
            this.gbFechaReservA.Controls.Add(this.lbFechaDesde);
            this.gbFechaReservA.Controls.Add(this.dtFechaHasta);
            this.gbFechaReservA.Controls.Add(this.dtFechaInicio);
            this.gbFechaReservA.Location = new System.Drawing.Point(16, 341);
            this.gbFechaReservA.Margin = new System.Windows.Forms.Padding(4);
            this.gbFechaReservA.Name = "gbFechaReservA";
            this.gbFechaReservA.Padding = new System.Windows.Forms.Padding(4);
            this.gbFechaReservA.Size = new System.Drawing.Size(288, 142);
            this.gbFechaReservA.TabIndex = 33;
            this.gbFechaReservA.TabStop = false;
            this.gbFechaReservA.Text = "Tipo de propiedad";
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(11, 80);
            this.lbFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(81, 16);
            this.lbFechaHasta.TabIndex = 34;
            this.lbFechaHasta.Text = "Fecha hasta";
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(11, 25);
            this.lbFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(87, 16);
            this.lbFechaDesde.TabIndex = 0;
            this.lbFechaDesde.Text = "Fecha desde";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(11, 100);
            this.dtFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.dtFechaHasta.TabIndex = 35;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gbCliente.Controls.Add(this.btnBuscarDni);
            this.gbCliente.Controls.Add(this.tbDni);
            this.gbCliente.Controls.Add(this.DNI);
            this.gbCliente.Location = new System.Drawing.Point(8, 23);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbCliente.Size = new System.Drawing.Size(289, 139);
            this.gbCliente.TabIndex = 34;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Buscar Cliente";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.Location = new System.Drawing.Point(40, 79);
            this.btnBuscarDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(185, 37);
            this.btnBuscarDni.TabIndex = 31;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = true;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(105, 36);
            this.tbDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(132, 22);
            this.tbDni.TabIndex = 2;
            this.tbDni.Text = "11111111";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(21, 39);
            this.DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(69, 16);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "Dni cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lbDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(8, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(289, 135);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // lbDatosCliente
            // 
            this.lbDatosCliente.Enabled = false;
            this.lbDatosCliente.FormattingEnabled = true;
            this.lbDatosCliente.ItemHeight = 16;
            this.lbDatosCliente.Items.AddRange(new object[] {
            "Dni: ",
            "Nombre: ",
            "Apellido: ",
            "Teléfono: "});
            this.lbDatosCliente.Location = new System.Drawing.Point(8, 30);
            this.lbDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lbDatosCliente.Name = "lbDatosCliente";
            this.lbDatosCliente.Size = new System.Drawing.Size(272, 84);
            this.lbDatosCliente.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.gbCliente);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(311, 319);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnVerImagenes);
            this.groupBox3.Controls.Add(this.gbTipoPropiedad);
            this.groupBox3.Controls.Add(this.gbServicios);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Location = new System.Drawing.Point(335, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(311, 468);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // btnVerImagenes
            // 
            this.btnVerImagenes.Location = new System.Drawing.Point(49, 406);
            this.btnVerImagenes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerImagenes.Name = "btnVerImagenes";
            this.btnVerImagenes.Size = new System.Drawing.Size(185, 37);
            this.btnVerImagenes.TabIndex = 31;
            this.btnVerImagenes.Text = "Ver Imagenes";
            this.btnVerImagenes.UseVisualStyleBackColor = true;
            this.btnVerImagenes.Click += new System.EventHandler(this.btnVerImagenes_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(232, 498);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(185, 37);
            this.btnReservar.TabIndex = 38;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 550);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFechaReservA);
            this.Controls.Add(this.dgView);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
    }
}