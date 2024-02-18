namespace TP2.Ventanas
{
    partial class AnularReserva
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
            this.btnAnularReserva = new System.Windows.Forms.Button();
            this.dgPropiedades = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnularReserva
            // 
            this.btnAnularReserva.Enabled = false;
            this.btnAnularReserva.Location = new System.Drawing.Point(368, 366);
            this.btnAnularReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnularReserva.Name = "btnAnularReserva";
            this.btnAnularReserva.Size = new System.Drawing.Size(151, 30);
            this.btnAnularReserva.TabIndex = 27;
            this.btnAnularReserva.Text = "Anular Reserva";
            this.btnAnularReserva.UseVisualStyleBackColor = true;
            // 
            // dgPropiedades
            // 
            this.dgPropiedades.AllowUserToAddRows = false;
            this.dgPropiedades.AllowUserToDeleteRows = false;
            this.dgPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgPropiedades.Location = new System.Drawing.Point(12, 12);
            this.dgPropiedades.Name = "dgPropiedades";
            this.dgPropiedades.ReadOnly = true;
            this.dgPropiedades.Size = new System.Drawing.Size(644, 337);
            this.dgPropiedades.TabIndex = 26;
            this.dgPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPropiedades_CellClick);
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
            // btnBuscarReservas
            // 
            this.btnBuscarReservas.Location = new System.Drawing.Point(123, 366);
            this.btnBuscarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarReservas.Name = "btnBuscarReservas";
            this.btnBuscarReservas.Size = new System.Drawing.Size(151, 30);
            this.btnBuscarReservas.TabIndex = 28;
            this.btnBuscarReservas.Text = "Ver Reservas";
            this.btnBuscarReservas.UseVisualStyleBackColor = true;
            this.btnBuscarReservas.Click += new System.EventHandler(this.btnBuscarReservas_Click);
            // 
            // AnularReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 407);
            this.Controls.Add(this.btnBuscarReservas);
            this.Controls.Add(this.btnAnularReserva);
            this.Controls.Add(this.dgPropiedades);
            this.Name = "AnularReserva";
            this.Text = "AnularReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgPropiedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAnularReserva;
        public System.Windows.Forms.DataGridView dgPropiedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.Button btnBuscarReservas;
    }
}