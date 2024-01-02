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
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAlquiler = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Enabled = false;
            this.btnNuevoCliente.Location = new System.Drawing.Point(260, 165);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(209, 78);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Enabled = false;
            this.btnPropiedad.Location = new System.Drawing.Point(505, 166);
            this.btnPropiedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(209, 76);
            this.btnPropiedad.TabIndex = 1;
            this.btnPropiedad.Text = "Nueva propiedad";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            this.btnPropiedad.Click += new System.EventHandler(this.btnPropiedad_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(15, 274);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(209, 76);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar propiedades";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(768, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Enabled = false;
            this.btnAlquiler.Location = new System.Drawing.Point(505, 274);
            this.btnAlquiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(209, 78);
            this.btnAlquiler.TabIndex = 1;
            this.btnAlquiler.Text = "Alquilar";
            this.btnAlquiler.UseVisualStyleBackColor = true;
            this.btnAlquiler.Click += new System.EventHandler(this.btnAlquiler_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(260, 57);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 78);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(260, 57);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(209, 78);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Enabled = false;
            this.btnUsuario.Location = new System.Drawing.Point(15, 165);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(209, 78);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Nuevo Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 415);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnPropiedad);
            this.Controls.Add(this.btnAlquiler);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaPrincipal";
            this.Text = "Rentify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnPropiedad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAlquiler;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUsuario;
    }
}

