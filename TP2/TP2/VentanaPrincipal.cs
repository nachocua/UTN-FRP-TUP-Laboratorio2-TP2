using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class VentanaPrincipal : Form
    {
        ManejoAlquiler elSistema;

        int i = 0; // Contador Temporal
        public VentanaPrincipal()
        {
            InitializeComponent();
            elSistema = new ManejoAlquiler();
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            Alta_Cliente ventanaCliente = new Alta_Cliente();
            if (ventanaCliente.ShowDialog() == DialogResult.OK)
            {

            }
            ventanaCliente.Dispose();
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {

        }
        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad();
            if (ventanaPropiedad.ShowDialog() == DialogResult.OK)
            {
                // Nombre de la propiedad, Ubicacion, Plazas, Servicios

                string nombre = ventanaPropiedad.tbNombre.Text, ubicacion = ventanaPropiedad.tbUbicacion.Text;
                int plazas = Convert.ToInt32(ventanaPropiedad.numUpDown_Plazas.Value);
                List<string> servicios = ventanaPropiedad.ObtenerServicios();
                if (ventanaPropiedad.rbCasa.Checked)
                {
                    string propietario = ventanaPropiedad.tbPropietario.Text;
                    Casa unaCasa = new Casa(nombre, ubicacion, plazas, servicios, propietario);
                }
                else
                {
                    //Hotel
                    if (ventanaPropiedad.rb2Estrellas.Checked)
                    {

                    }
                }
                string[] arr = (elSistema.getPropiedad(i++)).getData();
                dataGridView1.Rows.Add(arr);
            }
            ventanaPropiedad.Dispose();
        }
    }
}
