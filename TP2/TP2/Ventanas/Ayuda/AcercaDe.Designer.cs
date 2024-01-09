
namespace TP2
{
    partial class AcercaDe
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
            this.btnOkAcercaDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOkAcercaDe
            // 
            this.btnOkAcercaDe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkAcercaDe.Location = new System.Drawing.Point(196, 319);
            this.btnOkAcercaDe.Name = "btnOkAcercaDe";
            this.btnOkAcercaDe.Size = new System.Drawing.Size(94, 38);
            this.btnOkAcercaDe.TabIndex = 0;
            this.btnOkAcercaDe.Text = "Aceptar";
            this.btnOkAcercaDe.UseVisualStyleBackColor = true;
            this.btnOkAcercaDe.Click += new System.EventHandler(this.btnOkAcercaDe_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 385);
            this.Controls.Add(this.btnOkAcercaDe);
            this.Name = "AcercaDe";
            this.Text = "AcercaDe";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnOkAcercaDe;
    }
}