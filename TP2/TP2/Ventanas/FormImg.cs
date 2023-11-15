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
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarImagen(i);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                i = (i - 1 + unaPropiedad.CantidadImagenes) % unaPropiedad.CantidadImagenes;
                MostrarImagen(i);
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
                i = (i + 1) % unaPropiedad.CantidadImagenes;
                MostrarImagen(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MostrarImagen(int idx)
        {
            if (idx < unaPropiedad.CantidadImagenes && idx >= 0)
            {
                pictureBox.Image = Image.FromFile(this.unaPropiedad.ObtenerImagen(i));
                labIndice.Text = "Imagen Nro: " + idx;
            }
            btnDerecha.Enabled = idx < unaPropiedad.CantidadImagenes - 1;
            btnIzquierda.Enabled = idx > 0;
        }
    }
}
