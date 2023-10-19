using Biblioteca;
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
    public partial class NuevaPropiedad : Form
    {
        private List<Propiedad> propiedades = null;
        public NuevaPropiedad()
        {
            InitializeComponent();
        }
        private void NuevaPropiedad_Load(object sender, EventArgs e)
        {
            List<string[]> datosPropiedad = null;
            try
            {
                datosPropiedad = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//propiedades.csv", ";");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo de clientes");
            }
            if (datosPropiedad != null)
            {
                propiedades = new List<Propiedad>();
                Propiedad unaPropiedad = null;
                List<string> Servicios;
                string[] aux;
                foreach (string[] datoPropiedad in datosPropiedad)
                {
                    Servicios = new List<string>();
                    aux = datoPropiedad[4].Split('-');
                    if (Servicios.Count != 0)
                    {
                        foreach (string unServicio in aux)
                        {
                            Servicios.Add(unServicio);
                        }
                    }
                    if (datoPropiedad[0] == "Casa")
                    {
                        unaPropiedad = new Casa(datoPropiedad[2], datoPropiedad[3], Convert.ToInt32(datoPropiedad[4]),Servicios, datoPropiedad[6]);
                    }
                    else
                    {
                        if (datoPropiedad[0] == "Hotel")
                        {
                            unaPropiedad = new CasaFinSemana(datoPropiedad[2], datoPropiedad[3], Convert.ToInt32(datoPropiedad[4]), Servicios, datoPropiedad[6]);
                        }
                        else
                        {

                        }
                    }
                    propiedades.Add(unaPropiedad);
                }
            }
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {

        }
        private void CambiarGroupBox(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Hotel":
                    gbCasa.Enabled = false;
                    gbHotel.Enabled = true;
                    break;
                default:
                    gbCasa.Enabled = true;
                    gbHotel.Enabled = false;
                    break;
            }
        }
        public List<string> ObtenerServicios()
        {
            List<string> list = new List<string>();
            foreach (Control c in gbServicios.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        list.Add(c.Text);
                    }
                }
            }
            return list;
        }
    }
}
