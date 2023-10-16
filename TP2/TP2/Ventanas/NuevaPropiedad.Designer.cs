namespace TP2
{
    partial class NuevaPropiedad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbPropietario = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.gbCasa = new System.Windows.Forms.GroupBox();
            this.numUpDown_Camas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.gbPropiedad = new System.Windows.Forms.GroupBox();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Camas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbPropiedad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Propietario:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(83, 19);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(83, 45);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(100, 20);
            this.tbUbicacion.TabIndex = 5;
            // 
            // tbPropietario
            // 
            this.tbPropietario.Location = new System.Drawing.Point(83, 71);
            this.tbPropietario.Name = "tbPropietario";
            this.tbPropietario.Size = new System.Drawing.Size(100, 20);
            this.tbPropietario.TabIndex = 6;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(153, 360);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(113, 30);
            this.btnNuevoUsuario.TabIndex = 11;
            this.btnNuevoUsuario.Text = "Nueva propiedad";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(189, 22);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 65);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "Agregar Imagenes";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.numUpDown_Camas);
            this.gbCasa.Controls.Add(this.label4);
            this.gbCasa.Controls.Add(this.groupBox3);
            this.gbCasa.Location = new System.Drawing.Point(116, 131);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Size = new System.Drawing.Size(200, 212);
            this.gbCasa.TabIndex = 13;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            // 
            // numUpDown_Camas
            // 
            this.numUpDown_Camas.Location = new System.Drawing.Point(125, 14);
            this.numUpDown_Camas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Camas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Camas.Name = "numUpDown_Camas";
            this.numUpDown_Camas.Size = new System.Drawing.Size(41, 20);
            this.numUpDown_Camas.TabIndex = 19;
            this.numUpDown_Camas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad de Camas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Location = new System.Drawing.Point(22, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 158);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Cochera";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Wi-Fi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 135);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "PetFriendly";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 17);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Desayuno";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 43);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Piscina";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 89);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(123, 17);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Servicio de Limpieza";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // gbHotel
            // 
            this.gbHotel.Location = new System.Drawing.Point(116, 131);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(200, 212);
            this.gbHotel.TabIndex = 14;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // gbPropiedad
            // 
            this.gbPropiedad.Controls.Add(this.tbNombre);
            this.gbPropiedad.Controls.Add(this.label1);
            this.gbPropiedad.Controls.Add(this.label2);
            this.gbPropiedad.Controls.Add(this.btnImagen);
            this.gbPropiedad.Controls.Add(this.label3);
            this.gbPropiedad.Controls.Add(this.tbUbicacion);
            this.gbPropiedad.Controls.Add(this.tbPropietario);
            this.gbPropiedad.Location = new System.Drawing.Point(12, 12);
            this.gbPropiedad.Name = "gbPropiedad";
            this.gbPropiedad.Size = new System.Drawing.Size(271, 111);
            this.gbPropiedad.TabIndex = 15;
            this.gbPropiedad.TabStop = false;
            this.gbPropiedad.Text = "Datos";
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Checked = true;
            this.rbCasa.Location = new System.Drawing.Point(6, 18);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(49, 17);
            this.rbCasa.TabIndex = 16;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.CambiarGroupBox);
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(6, 41);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(50, 17);
            this.rbHotel.TabIndex = 17;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            this.rbHotel.CheckedChanged += new System.EventHandler(this.CambiarGroupBox);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCasa);
            this.groupBox2.Controls.Add(this.rbHotel);
            this.groupBox2.Location = new System.Drawing.Point(289, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 65);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de propiedad";
            // 
            // NuevaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 401);
            this.Controls.Add(this.gbCasa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPropiedad);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Name = "NuevaPropiedad";
            this.Text = "NuevaPropiedad";
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Camas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbPropiedad.ResumeLayout(false);
            this.gbPropiedad.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnImagen;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbUbicacion;
        public System.Windows.Forms.TextBox tbPropietario;
        private System.Windows.Forms.GroupBox gbCasa;
        private System.Windows.Forms.GroupBox gbHotel;
        private System.Windows.Forms.GroupBox gbPropiedad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numUpDown_Camas;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}