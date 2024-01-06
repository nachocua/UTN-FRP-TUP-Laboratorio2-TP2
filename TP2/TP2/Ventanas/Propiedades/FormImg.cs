using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FormImg : Form
    {
        int i = 0;
        int cantidadImagenes = 0;
        string[] nombres = null;
        public FormImg(int idPropiedad)
        {
            InitializeComponent();
            string defaultPath = "..//..//Img//" + idPropiedad + "//";
            if (Directory.Exists(defaultPath))
            {
                nombres = Directory.GetFiles(defaultPath);
                if (nombres.Length > 0)
                {
                    cantidadImagenes = nombres.Length;
                    if(nombres.Length > 1) 
                    {
                        btnDerecha.Enabled = true;
                    }
                    labCantImagenes.Text = "Cantidad imagenes: " + cantidadImagenes;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    MostrarImagen(i);
                }
            }
        }
        private void MostrarImagen(int idx)
        {
            if (idx < nombres.Length && idx >= 0)
            {
                pictureBox.Image = Image.FromFile(nombres[idx]);
                labIndice.Text = "Imagen Nro: " + idx;
            }
            btnDerecha.Enabled = idx < nombres.Length - 1;
            btnIzquierda.Enabled = idx > 0;
        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            i = (i - 1 + nombres.Length) % nombres.Length;
            MostrarImagen(i);
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            i = (i + 1) % nombres.Length;
            MostrarImagen(i);
        }
    }
}
