using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
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
        public Propiedad unaPropiedad = null;
        List<string> imagenes = new List<string>();
        int idPropiedad;
        public NuevaPropiedad(int idPropiedad)
        {
            InitializeComponent();
            this.idPropiedad = idPropiedad;
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagenes.Add(ofd.FileName);
            }
            ofd.Dispose();
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
        public string[] ObtenerImagenes()
        {
            return imagenes.ToArray();
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
                        unaPropiedad = new Casa(idPropiedad, nombre, ubicacion, plazas, servicios, propietario);
                        break;
                    case 2:
                        unaPropiedad = new Hotel(idPropiedad, nombre, ubicacion, plazas, servicios, estrellas);
                        ((Hotel)unaPropiedad).CargarHabitaciones(simples, Hotel.Tipo.Simple);
                        ((Hotel)unaPropiedad).CargarHabitaciones(dobles, Hotel.Tipo.Doble);
                        ((Hotel)unaPropiedad).CargarHabitaciones(triples, Hotel.Tipo.Triple);
                        break;
                    case 3:
                        unaPropiedad = new CasaFinSemana(idPropiedad, nombre, ubicacion, plazas, servicios, propietario);
                        break;
                }
                string defaultPath = "..//..//Img//" + unaPropiedad.idPropiedad + "//";
                Directory.CreateDirectory(defaultPath);
                string[] nombres = Directory.GetFiles(defaultPath);
                if (nombres.Length > 0)
                {
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        File.Move(defaultPath + nombres[i], defaultPath + (10000+i));
                    }
                    for(int i = 10000; i < 10000+nombres.Length; i++)
                    {
                        File.Move(defaultPath + i, defaultPath + "img" + (i-10000) + ".jpg");
                    }
                }
                for (int i = 0; i < imagenes.Count; i++)
                {
                    File.Move(imagenes[i], defaultPath + "img" + (i + nombres.Length) + ".jpg");
                }
                imagenes.Clear();
                imagenes.AddRange(nombres);
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
