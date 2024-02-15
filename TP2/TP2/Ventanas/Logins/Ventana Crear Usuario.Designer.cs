namespace TP2
{
    partial class Ventana_Crear_Usuario
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(16, 20);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(16, 58);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(61, 13);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(64, 120);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 23);
            this.btnIngresar.TabIndex = 100;
            this.btnIngresar.Text = "Crear Usuario";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(100, 17);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(100, 55);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 2;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(83, 93);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(55, 17);
            this.cbAdmin.TabIndex = 3;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // Ventana_Crear_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 157);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsuario);
            this.Name = "Ventana_Crear_Usuario";
            this.Text = "VentanaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox cbAdmin;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label lbPass;
        public System.Windows.Forms.TextBox tbUsuario;
        public System.Windows.Forms.TextBox tbPass;
    }
}