namespace TP2
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnAlquiler = new System.Windows.Forms.Button();
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(11, 11);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(131, 43);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Location = new System.Drawing.Point(11, 78);
            this.btnAlquiler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(131, 43);
            this.btnAlquiler.TabIndex = 1;
            this.btnAlquiler.Text = "Alquilar";
            this.btnAlquiler.UseVisualStyleBackColor = true;
            this.btnAlquiler.Click += new System.EventHandler(this.btnAlquiler_Click);
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Location = new System.Drawing.Point(11, 143);
            this.btnPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(131, 43);
            this.btnPropiedad.TabIndex = 1;
            this.btnPropiedad.Text = "Nueva propiedad";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            this.btnPropiedad.Click += new System.EventHandler(this.btnAlquiler_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPropiedad);
            this.Controls.Add(this.btnAlquiler);
            this.Controls.Add(this.btnNuevoCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaPrincipal";
            this.Text = "Rentify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnAlquiler;
        private System.Windows.Forms.Button btnPropiedad;
    }
}

