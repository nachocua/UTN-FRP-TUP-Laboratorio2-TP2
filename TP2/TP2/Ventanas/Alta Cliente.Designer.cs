﻿namespace TP2
{
    partial class Alta_Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.leApellido = new System.Windows.Forms.TextBox();
            this.leNombre = new System.Windows.Forms.TextBox();
            this.leTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoUsuario);
            this.groupBox1.Controls.Add(this.leApellido);
            this.groupBox1.Controls.Add(this.leNombre);
            this.groupBox1.Controls.Add(this.leTelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.leDni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(215, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(47, 180);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(113, 30);
            this.btnNuevoUsuario.TabIndex = 10;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // leApellido
            // 
            this.leApellido.Location = new System.Drawing.Point(102, 37);
            this.leApellido.Margin = new System.Windows.Forms.Padding(2);
            this.leApellido.Name = "leApellido";
            this.leApellido.Size = new System.Drawing.Size(76, 20);
            this.leApellido.TabIndex = 9;
            // 
            // leNombre
            // 
            this.leNombre.Location = new System.Drawing.Point(102, 74);
            this.leNombre.Margin = new System.Windows.Forms.Padding(2);
            this.leNombre.Name = "leNombre";
            this.leNombre.Size = new System.Drawing.Size(76, 20);
            this.leNombre.TabIndex = 8;
            // 
            // leTelefono
            // 
            this.leTelefono.Location = new System.Drawing.Point(102, 108);
            this.leTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.leTelefono.MaxLength = 16;
            this.leTelefono.Name = "leTelefono";
            this.leTelefono.Size = new System.Drawing.Size(76, 20);
            this.leTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // leDni
            // 
            this.leDni.Location = new System.Drawing.Point(102, 140);
            this.leDni.Margin = new System.Windows.Forms.Padding(2);
            this.leDni.MaxLength = 8;
            this.leDni.Name = "leDni";
            this.leDni.Size = new System.Drawing.Size(76, 20);
            this.leDni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 247);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alta_Cliente";
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoUsuario;
        public System.Windows.Forms.TextBox leDni;
        public System.Windows.Forms.TextBox leApellido;
        public System.Windows.Forms.TextBox leNombre;
        public System.Windows.Forms.TextBox leTelefono;
    }
}