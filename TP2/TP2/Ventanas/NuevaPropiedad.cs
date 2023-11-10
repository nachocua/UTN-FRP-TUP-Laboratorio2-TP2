using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class NuevaPropiedad : Form
    {
        //private List<Propiedad> propiedades = null;
        public Propiedad unaPropiedad = null;
        int cantidadPropiedades;
        public NuevaPropiedad(int cantidadPropiedades)
        {
            InitializeComponent();
            this.cantidadPropiedades = cantidadPropiedades;
        }
        //public int CantidadPropiedades { get; set; }
        private void NuevaPropiedad_Load(object sender, EventArgs e)
        {
            #region CargaDeArchivosCSV_Propiedad
            /*List<string[]> datosPropiedad = null;
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
                        unaPropiedad = new Casa(id, datoPropiedad[2], datoPropiedad[3], Convert.ToInt32(datoPropiedad[4]),Servicios, datoPropiedad[6]);
                    }
                    else
                    {
                        if (datoPropiedad[0] == "Hotel")
                        {
                            unaPropiedad = new CasaFinSemana(datoPropiedad[2], datoPropiedad[3], Convert.ToInt32(datoPropiedad[4]), Servicios, datoPropiedad[6]);
                        }
                    }
                    propiedades.Add(unaPropiedad);
                }
            }*/
            #endregion
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

        private void btnNuevaPropiedad_Click(object sender, EventArgs e)
        {
            bool state = true;
            int tipo = 1;
            string nombre = "", ubicacion = "", propietario = "";
            int plazas = 0, simples = 0, dobles = 0, triples = 0, estrellas = 0;
            List<string> servicios = new List<string>();
            try
            {
                if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbUbicacion.Text))
                {
                    throw new ArgumentException("Campo vacio.");
                }
                if (IsValidInput(tbNombre.Text) && IsValidInput(tbUbicacion.Text))
                {
                    nombre = tbNombre.Text;
                    ubicacion = tbUbicacion.Text;
                    servicios = ObtenerServicios();
                    if (rbCasa.Checked)
                    {
                        plazas = Convert.ToInt32(numUpDown_Plazas.Value);
                        if (string.IsNullOrEmpty(tbPropietario.Text))
                        {
                            throw new ArgumentException("Campo vacio.");
                        }
                        else
                        {
                            if (IsValidInput(tbPropietario.Text))
                            {
                                propietario = tbPropietario.Text;
                            }
                            else
                            {
                                throw new ArgumentException("El campo Propietario solo debe contener caracteres.");
                            }
                        }
                        if (cbCasaFinde.Checked)
                        {
                            tipo = 3;

                        }
                    }
                    else
                    {
                        tipo = 2;
                        simples = Convert.ToInt32(numUDSimple.Value);
                        dobles = Convert.ToInt32(numUDDoble.Value);
                        triples = Convert.ToInt32(numUDTriple.Value);
                        plazas = simples + dobles + triples;
                        estrellas = 3;
                        if (rb2Estrellas.Checked)
                        {
                            estrellas = 2;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Los campos Nombre y Ubicación solo deben contener caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state = false;
            }
            if (state)
            {
                switch (tipo)
                {
                    case 1:
                        unaPropiedad = new Casa(cantidadPropiedades, nombre, ubicacion, plazas, servicios, propietario);
                        break;
                    case 2:
                        unaPropiedad = new Hotel(cantidadPropiedades, nombre, ubicacion, plazas, servicios, estrellas);
                        ((Hotel)unaPropiedad).CargarHabitaciones(simples, Hotel.Tipo.Simple);
                        ((Hotel)unaPropiedad).CargarHabitaciones(dobles, Hotel.Tipo.Doble);
                        ((Hotel)unaPropiedad).CargarHabitaciones(triples, Hotel.Tipo.Triple);
                        break;
                    case 3:
                        unaPropiedad = new CasaFinSemana(cantidadPropiedades, nombre, ubicacion, plazas, servicios, propietario);
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool IsValidInput(string input)
        {
            // [a-zA-Z ]+ permite letras mayúsculas, minúsculas y espacios.
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
