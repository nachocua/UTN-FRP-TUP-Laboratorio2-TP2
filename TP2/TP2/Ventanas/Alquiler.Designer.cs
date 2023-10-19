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
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDías = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.gbTipoPropiedad = new System.Windows.Forms.GroupBox();
            this.rbCasaFinde = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.tbUbicación = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.gbDías.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).BeginInit();
            this.gbServicios.SuspendLayout();
            this.gbTipoPropiedad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(83, 17);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(214, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgView.Location = new System.Drawing.Point(12, 187);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(646, 162);
            this.dgView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ubicacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Propietario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Servicios";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Capacidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // gbDías
            // 
            this.gbDías.Controls.Add(this.label1);
            this.gbDías.Controls.Add(this.tbUbicación);
            this.gbDías.Controls.Add(this.label8);
            this.gbDías.Controls.Add(this.nudCantidadDias);
            this.gbDías.Controls.Add(this.label9);
            this.gbDías.Controls.Add(this.dtpFechaDesde);
            this.gbDías.Location = new System.Drawing.Point(12, 12);
            this.gbDías.Name = "gbDías";
            this.gbDías.Size = new System.Drawing.Size(303, 89);
            this.gbDías.TabIndex = 19;
            this.gbDías.TabStop = false;
            this.gbDías.Text = "Cuando y Donde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha desde";
            // 
            // nudCantidadDias
            // 
            this.nudCantidadDias.Location = new System.Drawing.Point(85, 50);
            this.nudCantidadDias.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCantidadDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadDias.Name = "nudCantidadDias";
            this.nudCantidadDias.Size = new System.Drawing.Size(41, 20);
            this.nudCantidadDias.TabIndex = 19;
            this.nudCantidadDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad días";
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.checkBox7);
            this.gbServicios.Controls.Add(this.checkBox8);
            this.gbServicios.Controls.Add(this.checkBox9);
            this.gbServicios.Controls.Add(this.checkBox10);
            this.gbServicios.Controls.Add(this.checkBox11);
            this.gbServicios.Controls.Add(this.checkBox12);
            this.gbServicios.Location = new System.Drawing.Point(355, 12);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(139, 158);
            this.gbServicios.TabIndex = 20;
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
            // gbTipoPropiedad
            // 
            this.gbTipoPropiedad.Controls.Add(this.rbCasaFinde);
            this.gbTipoPropiedad.Controls.Add(this.rbCasa);
            this.gbTipoPropiedad.Controls.Add(this.rbHotel);
            this.gbTipoPropiedad.Location = new System.Drawing.Point(12, 107);
            this.gbTipoPropiedad.Name = "gbTipoPropiedad";
            this.gbTipoPropiedad.Size = new System.Drawing.Size(303, 63);
            this.gbTipoPropiedad.TabIndex = 21;
            this.gbTipoPropiedad.TabStop = false;
            this.gbTipoPropiedad.Text = "Tipo de propiedad";
            // 
            // rbCasaFinde
            // 
            this.rbCasaFinde.AutoSize = true;
            this.rbCasaFinde.Checked = true;
            this.rbCasaFinde.Location = new System.Drawing.Point(146, 30);
            this.rbCasaFinde.Name = "rbCasaFinde";
            this.rbCasaFinde.Size = new System.Drawing.Size(118, 17);
            this.rbCasaFinde.TabIndex = 23;
            this.rbCasaFinde.TabStop = true;
            this.rbCasaFinde.Text = "Casa fin de semana";
            this.rbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(77, 30);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(49, 17);
            this.rbCasa.TabIndex = 22;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(9, 30);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(50, 17);
            this.rbHotel.TabIndex = 23;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 30);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar disponibles";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(528, 70);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(113, 30);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.Text = "Ver Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(528, 124);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(113, 30);
            this.btnReservar.TabIndex = 24;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // tbUbicación
            // 
            this.tbUbicación.Location = new System.Drawing.Point(197, 49);
            this.tbUbicación.Name = "tbUbicación";
            this.tbUbicación.Size = new System.Drawing.Size(100, 20);
            this.tbUbicación.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ubicación";
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 364);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbTipoPropiedad);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.gbDías);
            this.Controls.Add(this.dgView);
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.gbDías.ResumeLayout(false);
            this.gbDías.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).EndInit();
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            this.gbTipoPropiedad.ResumeLayout(false);
            this.gbTipoPropiedad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        public System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox gbDías;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown nudCantidadDias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.GroupBox gbTipoPropiedad;
        public System.Windows.Forms.RadioButton rbCasaFinde;
        public System.Windows.Forms.RadioButton rbCasa;
        public System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUbicación;
    }
}