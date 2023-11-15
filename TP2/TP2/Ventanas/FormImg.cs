using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FormImg : Form
    {
        Propiedad unaPropiedad = null;
        int i = 0;
        public FormImg(Propiedad unaPropiedad)
        {
            InitializeComponent();
            this.unaPropiedad = unaPropiedad;
            btnIzquierda.Enabled = false;
            labCantImagenes.Text = "Cantidad imagenes: " + this.unaPropiedad.CantidadImagenes;
            if (this.unaPropiedad.CantidadImagenes > 0)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(this.unaPropiedad.ObtenerImagen(i++));
                MessageBox.Show(this.unaPropiedad.ObtenerImagen(i++));
                if (this.unaPropiedad.CantidadImagenes == 1) // Si es solo una img
                {
                    btnDerecha.Enabled = false;
                }
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox.Image = Image.FromFile(unaPropiedad.ObtenerImagen(--i));
                if (i == 0)
                {
                    btnIzquierda.Enabled = false;
                    btnDerecha.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (unaPropiedad.CantidadImagenes == i) // Si llego al final
                {
                    btnDerecha.Enabled = false;
                }
                else
                {
                    pictureBox.Image = Image.FromFile(unaPropiedad.ObtenerImagen(i++));
                    btnIzquierda.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
