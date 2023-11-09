using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP2
{
    public partial class VentanaPrincipal : Form
    {
        ManejoAlquiler elSistema;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            elSistema = new ManejoAlquiler("..//..//Data//propiedades.dat",
                                           "..//..//Data//clientes.dat",
                                           "..//..//Data//reservas.csv");
        }
        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            elSistema.Export();
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            bool repetido = true;
            Alta_Cliente ventanaCliente = new Alta_Cliente();
            do
            {
                if (ventanaCliente.ShowDialog() == DialogResult.OK)
                {
                    if (elSistema.BuscarCliente(ventanaCliente.unCliente) < 0)
                    {
                        elSistema.AgregarCliente(ventanaCliente.unCliente);
                        repetido = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con este DNI.\n Verifique el DNI o busquelo en el sistema");
                    }
                }
                else
                {
                    repetido = false;
                }
            }while (repetido);
            ventanaCliente.Dispose();
        }
        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            Alquiler ventanaAlquiler = new Alquiler();
            if (ventanaAlquiler.ShowDialog() == DialogResult.OK)
            {

            }
            ventanaAlquiler.Dispose();
        }
        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad();
            try
            {
                if (ventanaPropiedad.ShowDialog() == DialogResult.OK)
                {
                    // Nombre de la propiedad, Ubicacion, Plazas, Servicios
                    string nombre = ventanaPropiedad.tbNombre.Text, ubicacion = ventanaPropiedad.tbUbicacion.Text;
                    int plazas;
                    List<string> servicios = ventanaPropiedad.ObtenerServicios();
                    if (ventanaPropiedad.rbCasa.Checked)
                    {
                        plazas = Convert.ToInt32(ventanaPropiedad.numUpDown_Plazas.Value);
                        string propietario = ventanaPropiedad.tbPropietario.Text;
                        if (ventanaPropiedad.cbCasaFinde.Checked)
                        {
                            CasaFinSemana unaCasa = new CasaFinSemana(elSistema.CantidadPropiedades, nombre, ubicacion, plazas, servicios, propietario);
                            elSistema.AgregarPropiedad(unaCasa);
                        }
                        else
                        {
                            Casa unaCasa = new Casa(elSistema.CantidadPropiedades, nombre, ubicacion, plazas, servicios, propietario);
                            elSistema.AgregarPropiedad(unaCasa);
                        }
                    }
                    else
                    {
                        int simples = Convert.ToInt32(ventanaPropiedad.numUDSimple.Value), dobles = Convert.ToInt32(ventanaPropiedad.numUDDoble.Value), triples = Convert.ToInt32(ventanaPropiedad.numUDTriple.Value);
                        plazas = simples + dobles + triples;
                        int estrellas = 3;
                        if (ventanaPropiedad.rb2Estrellas.Checked)
                        {
                            estrellas = 2;
                        }
                        Hotel unHotel = new Hotel(elSistema.CantidadPropiedades, nombre, ubicacion, plazas, servicios, estrellas);
                        unHotel.CargarHabitaciones(simples, Hotel.Tipo.Simple);
                        unHotel.CargarHabitaciones(dobles, Hotel.Tipo.Doble);
                        unHotel.CargarHabitaciones(triples, Hotel.Tipo.Triple);
                        elSistema.AgregarPropiedad(unHotel);
                    }
                }
            }
            catch
            {

            }
            ventanaPropiedad.Dispose();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos vMostrar = new MostrarDatos(elSistema);
            vMostrar.ShowDialog();
            vMostrar.Dispose();
        }
    }
}
