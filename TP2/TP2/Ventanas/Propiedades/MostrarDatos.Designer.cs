namespace TP2
{
    partial class MostrarDatos
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVerImagenes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbUbicacion = new System.Windows.Forms.GroupBox();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.gbCapacidad = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHabilitadas = new System.Windows.Forms.GroupBox();
            this.cbMostrarTodo = new System.Windows.Forms.CheckBox();
            this.btnVerReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.gbTipoPropiedad.SuspendLayout();
            this.gbServicios.SuspendLayout();
            this.gbUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.gbCapacidad.SuspendLayout();
            this.gbHabilitadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgView.Location = new System.Drawing.Point(166, 12);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(643, 528);
            this.dgView.TabIndex = 5;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Propietario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Servicios";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Capacidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // gbTipoPropiedad
            // 
            this.gbTipoPropiedad.Controls.Add(this.cbCasaFinde);
            this.gbTipoPropiedad.Controls.Add(this.cbHotel);
            this.gbTipoPropiedad.Controls.Add(this.cbCasa);
            this.gbTipoPropiedad.Location = new System.Drawing.Point(10, 12);
            this.gbTipoPropiedad.Name = "gbTipoPropiedad";
            this.gbTipoPropiedad.Size = new System.Drawing.Size(150, 94);
            this.gbTipoPropiedad.TabIndex = 23;
            this.gbTipoPropiedad.TabStop = false;
            this.gbTipoPropiedad.Text = "Tipo de propiedad";
            // 
            // cbCasaFinde
            // 
            this.cbCasaFinde.AutoSize = true;
            this.cbCasaFinde.Location = new System.Drawing.Point(6, 65);
            this.cbCasaFinde.Name = "cbCasaFinde";
            this.cbCasaFinde.Size = new System.Drawing.Size(103, 17);
            this.cbCasaFinde.TabIndex = 2;
            this.cbCasaFinde.Text = "CasaFinSemana";
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
            this.gbServicios.Location = new System.Drawing.Point(10, 112);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(150, 158);
            this.gbServicios.TabIndex = 22;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(9, 442);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 30);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar disponibles";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(10, 476);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 30);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar Propiedad";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVerImagenes
            // 
            this.btnVerImagenes.Location = new System.Drawing.Point(10, 510);
            this.btnVerImagenes.Name = "btnVerImagenes";
            this.btnVerImagenes.Size = new System.Drawing.Size(150, 30);
            this.btnVerImagenes.TabIndex = 25;
            this.btnVerImagenes.Text = "Ver Imagenes";
            this.btnVerImagenes.UseVisualStyleBackColor = true;
            this.btnVerImagenes.Click += new System.EventHandler(this.btnVerImagenes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbUbicacion
            // 
            this.gbUbicacion.Controls.Add(this.comboBox1);
            this.gbUbicacion.Location = new System.Drawing.Point(10, 276);
            this.gbUbicacion.Name = "gbUbicacion";
            this.gbUbicacion.Size = new System.Drawing.Size(150, 54);
            this.gbUbicacion.TabIndex = 27;
            this.gbUbicacion.TabStop = false;
            this.gbUbicacion.Text = "Ubicacion";
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
            // gbCapacidad
            // 
            this.gbCapacidad.Controls.Add(this.label1);
            this.gbCapacidad.Controls.Add(this.numCapacidad);
            this.gbCapacidad.Location = new System.Drawing.Point(10, 336);
            this.gbCapacidad.Name = "gbCapacidad";
            this.gbCapacidad.Size = new System.Drawing.Size(150, 54);
            this.gbCapacidad.TabIndex = 29;
            this.gbCapacidad.TabStop = false;
            this.gbCapacidad.Text = "Capacidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cantidad personas:";
            // 
            // gbHabilitadas
            // 
            this.gbHabilitadas.Controls.Add(this.cbMostrarTodo);
            this.gbHabilitadas.Location = new System.Drawing.Point(8, 396);
            this.gbHabilitadas.Name = "gbHabilitadas";
            this.gbHabilitadas.Size = new System.Drawing.Size(152, 41);
            this.gbHabilitadas.TabIndex = 30;
            this.gbHabilitadas.TabStop = false;
            this.gbHabilitadas.Text = "Propiedades habilitadas";
            // 
            // cbMostrarTodo
            // 
            this.cbMostrarTodo.AutoSize = true;
            this.cbMostrarTodo.Location = new System.Drawing.Point(6, 19);
            this.cbMostrarTodo.Name = "cbMostrarTodo";
            this.cbMostrarTodo.Size = new System.Drawing.Size(90, 17);
            this.cbMostrarTodo.TabIndex = 31;
            this.cbMostrarTodo.Text = "Mostrar todas";
            this.cbMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Location = new System.Drawing.Point(10, 547);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(150, 30);
            this.btnVerReservas.TabIndex = 31;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = true;
            this.btnVerReservas.Visible = false;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.gbHabilitadas);
            this.Controls.Add(this.gbCapacidad);
            this.Controls.Add(this.gbUbicacion);
            this.Controls.Add(this.btnVerImagenes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbTipoPropiedad);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.dgView);
            this.Name = "MostrarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.gbTipoPropiedad.ResumeLayout(false);
            this.gbTipoPropiedad.PerformLayout();
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            this.gbUbicacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.gbCapacidad.ResumeLayout(false);
            this.gbCapacidad.PerformLayout();
            this.gbHabilitadas.ResumeLayout(false);
            this.gbHabilitadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.GroupBox gbTipoPropiedad;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbCasaFinde;
        private System.Windows.Forms.CheckBox cbCasa;
        private System.Windows.Forms.CheckBox cbHotel;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVerImagenes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbUbicacion;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.GroupBox gbCapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox gbHabilitadas;
        private System.Windows.Forms.CheckBox cbMostrarTodo;
        private System.Windows.Forms.Button btnVerReservas;
    }
}