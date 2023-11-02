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
    public partial class Alquiler : Form
    {
        private List<Propiedad> propiedades;
        public Alquiler()
        {
            InitializeComponent();
            propiedades = new List<Propiedad>();
        }
        private void Alquiler_Load(object sender, EventArgs e)
        {
            List<string[]> datosPropiedades = null;
            List<string[]> datosReservas = null;
            try
            {
                datosPropiedades = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//propiedades.csv", ";");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo de propiedades");
            }
            try
            {
                datosReservas = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//reservas.csv", ";");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo de reservas");
            }
            if (datosPropiedades != null && datosReservas != null)
            {
                foreach (string[] unDato in datosPropiedades)
                {
                    Propiedad unaPropiedad = null;
                    List<string> servicios = null;
                    if (unDato[1] == "casa")
                    {
                        unaPropiedad = new Casa("a", "a", 1, servicios, "a");
                    }
                    else
                    {
                        if (unDato[1] == "hotel")
                        {
                            //unaPropiedad = new Hotel("", "", 1, servicios, 1);
                        }
                        else
                        {
                            unaPropiedad = new CasaFinSemana("a", "a", 1, servicios, "a");
                        }
                    }
                    propiedades.Add(unaPropiedad);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.RowCount = 0;
            string[] datos = null;
            foreach (Propiedad unaPropiedad in propiedades)
            {
                datos = unaPropiedad.getData();
                //if(datos)
                //dgView.Rows.Add(unRenglon);
            }
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
