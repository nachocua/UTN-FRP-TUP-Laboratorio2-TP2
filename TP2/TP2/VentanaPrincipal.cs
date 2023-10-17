﻿using System;
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
    public partial class VentanaPrincipal : Form
    {
        ManejoAlquiler elSistema;
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
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad();
            if (ventanaPropiedad.ShowDialog() == DialogResult.OK)
            {
                string nombre = ventanaPropiedad.tbNombre.Text, ubicacion = ventanaPropiedad.tbUbicacion.Text, propietario = ventanaPropiedad.tbPropietario.Text;
                if (ventanaPropiedad.rbCasa.Checked)
                {
                    List<string> servicios = ventanaPropiedad.ObtenerServicios();
                    Casa unaCasa = new Casa(nombre, ubicacion, propietario, servicios, Convert.ToInt32(ventanaPropiedad.numUpDown_Camas.Value));
                    elSistema.AgregarCasa(unaCasa);
                }
                else
                {
                    //Hotel
                }
            }

        }
    }
}
