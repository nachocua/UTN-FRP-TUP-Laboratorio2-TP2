﻿using Biblioteca;
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
            Alquiler ventanaAlquiler = new Alquiler();
            if (ventanaAlquiler.ShowDialog() == DialogResult.OK)
            {

            }
            ventanaAlquiler.Dispose();
        }
        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad();
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
                    Casa unaCasa = new Casa(nombre, ubicacion, plazas, servicios, propietario);
                    elSistema.AgregarPropiedad(unaCasa);
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
                    Hotel unHotel = new Hotel(nombre, ubicacion, plazas, servicios, estrellas);
                    unHotel.CargarHabitaciones(simples, Hotel.Tipo.Simple);
                    unHotel.CargarHabitaciones(dobles, Hotel.Tipo.Doble);
                    unHotel.CargarHabitaciones(triples, Hotel.Tipo.Triple);
                    elSistema.AgregarPropiedad(unHotel);
                }
            }
            ventanaPropiedad.Dispose();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos vMostrar = new MostrarDatos();
            for (int i = 0; i < elSistema.CantidadPropidades; i++)
            {
                string[] arr = (elSistema.getPropiedad(i)).getData();
                vMostrar.dataGridView1.Rows.Add(arr);
            }
            vMostrar.ShowDialog();
            vMostrar.Dispose();
        }
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            if (!File.Exists("..//..//Data//propiedades.csv"))
            {
                File.Create("..//..//Data//propiedades.csv");
            }
            if (!File.Exists("..//..//Data//clientes.csv"))
            {
                File.Create("..//..//Data//clientes.csv");
            }
            if (!File.Exists("..//..//Data//reservas.csv"))
            {
                File.Create("..//..//Data//reservas.csv");
            }
        }
    }
}
