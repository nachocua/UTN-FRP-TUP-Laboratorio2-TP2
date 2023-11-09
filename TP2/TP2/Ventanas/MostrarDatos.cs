﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TP2
{
    public partial class MostrarDatos : Form
    {
        //enum Columnas { Id, Nombre, Tipo, Ubicacion, Propietario, Servicios, Capacidad };
        ManejoAlquiler elSistema;
        List<Propiedad> propiedades;
        string[] propiedadSeleccionada = null;
        public MostrarDatos(ManejoAlquiler unSistema)
        {
            InitializeComponent();
            elSistema = unSistema;
            propiedades = ExportarPropiedades(elSistema);
        }
        private List<string> CargarServicios()
        {
            // Filtro las propiedades segun los servicios seleccionados desde los CheckBox
            List<string> serviciosSeleccionados = new List<string>();
            foreach (Control control in gbServicios.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (checkBox.Checked)
                    {
                        serviciosSeleccionados.Add(checkBox.Text);
                    }
                }
            }
            return serviciosSeleccionados;
        }
        private List<string> CargarTipoSeleccionado()
        {
            //Filtro propiedades segun el tipo
            List<string> tiposSeleccionados = new List<string>();
            foreach (Control control in gbTipoPropiedad.Controls)
            {
                if (((CheckBox)control).Checked)
                {
                    tiposSeleccionados.Add(control.Text);
                }
            }
            return tiposSeleccionados;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            List<string> serviciosSeleccionados = CargarServicios();
            List<string> tiposSeleccionados = CargarTipoSeleccionado();
            foreach (Propiedad propiedad in propiedades)
            {
                bool propiedadTieneServicios = true;
                foreach (string servicioSeleccionado in serviciosSeleccionados)
                {
                    if (!propiedad.Servicios.Contains(servicioSeleccionado))
                    {
                        propiedadTieneServicios = false;
                        break;
                    }
                }
                if (propiedadTieneServicios)
                {
                    if (tiposSeleccionados.Count > 0)
                    {
                        if (tiposSeleccionados.Contains("Casa"))
                        {
                            if (propiedad is Casa)
                            {
                                if (!(propiedad is CasaFinSemana))
                                {
                                    dgView.Rows.Add(propiedad.getData());
                                }
                            }
                        }
                        if (tiposSeleccionados.Contains("Hotel"))
                        {
                            if (propiedad is Hotel)
                            {
                                dgView.Rows.Add(propiedad.getData());
                            }
                        }
                        if (tiposSeleccionados.Contains("Casa Fin de Semana"))
                        {
                            if (propiedad is CasaFinSemana)
                            {
                                dgView.Rows.Add(propiedad.getData());
                            }
                        }
                    }
                    else
                    {
                        dgView.Rows.Add(propiedad.getData());
                    }
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                propiedades.Sort();
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                //MessageBox.Show(string.Join(", ",propiedadSeleccionada));
                NuevaPropiedad ventanaPropiedad = new NuevaPropiedad();
                #region CargandoDatos
                if (unaPropiedad != null)
                {
                    ventanaPropiedad.tbNombre.Text = unaPropiedad.Nombre;
                    ventanaPropiedad.tbUbicacion.Text = unaPropiedad.Ciudad;
                    string[] vServicios = string.Join(", ", unaPropiedad.Servicios.ToArray()).Split(',');
                    for (int i = 0; i < vServicios.Length; i++)
                    {
                        vServicios[i] = vServicios[i].Trim();
                    }
                    foreach (Control control in ventanaPropiedad.gbServicios.Controls)
                    {
                        if (control is CheckBox)
                        {
                            CheckBox c = (CheckBox)control;
                            foreach (string s in vServicios)
                            {
                                if (s == c.Text)
                                {
                                    c.Checked = true;
                                }
                            }
                        }
                    }
                    if (unaPropiedad is Hotel)
                    {
                        ventanaPropiedad.rbHotel.Checked = true;

                    }
                    else
                    {
                        ventanaPropiedad.rbCasa.Checked = true;
                        ventanaPropiedad.tbPropietario.Text = ((Casa)unaPropiedad).Propietario;
                        ventanaPropiedad.numUpDown_Plazas.Value = unaPropiedad.Plazas;
                        if (unaPropiedad is CasaFinSemana)
                        {
                            ventanaPropiedad.cbCasaFinde.Checked = true;
                        }
                    }
                    DialogResult res = ventanaPropiedad.ShowDialog();
                    ventanaPropiedad.Dispose();
                    #endregion
                    #region CambiandoPropiedad
                    if (res == DialogResult.OK)
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
                                //CasaFinSemana unaCasa = new CasaFinSemana(nombre, ubicacion, plazas, servicios, propietario);
                                //unaPropiedad = unaCasa;
                                //elSistema.AgregarPropiedad(unaCasa);
                                //CasaFinSemana unaCasa = unaPropiedad as CasaFinSemana;
                            }
                            else
                            {
                                //Casa unaCasa = new Casa(nombre, ubicacion, plazas, servicios, propietario);
                                //unaPropiedad = unaCasa;
                                //elSistema.AgregarPropiedad(unaCasa);
                                Casa unaCasa = unaPropiedad as Casa;
                                unaCasa.ModificarDatos(nombre,ubicacion,plazas,propietario);
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
                            //Hotel unHotel = new Hotel(nombre, ubicacion, plazas, servicios, estrellas);
                            //unHotel.CargarHabitaciones(simples, Hotel.Tipo.Simple);
                            //unHotel.CargarHabitaciones(dobles, Hotel.Tipo.Doble);
                            //unHotel.CargarHabitaciones(triples, Hotel.Tipo.Triple);
                            //unaPropiedad = unHotel;
                            //elSistema.AgregarPropiedad(unHotel);
                            Hotel unHotel = unaPropiedad as Hotel;
                            unHotel.ModificarDatos(nombre,ubicacion,estrellas,simples,dobles,triples);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ninguna propiedad fue seleccionada");
                    }

                }
                #endregion
            }
        }
        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex, c = e.ColumnIndex;
            if (c == 5) // Servicios
            {
                string text = dgView[c, f].Value.ToString();
                MessageBox.Show(text, "Servicios Disponibles");
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                propiedadSeleccionada = GetRow(dgView.Rows[e.RowIndex]);
                //string[] servicios = propiedadSeleccionada[5].Split(',');
                //for(int i = 0; i < servicios.Length; i++)
                //{
                //    servicios[i] = servicios[i].Trim();
                //}
                //MessageBox.Show(string.Join("-",servicios));
            }
        }
        private string[] GetRow(DataGridViewRow row)
        {
            List<string> data = new List<string>();
            for (int i = 0; i < row.Cells.Count; i++)
            {
                data.Add(row.Cells[i].Value.ToString());
            }
            return data.ToArray();
        }
        private List<Propiedad> ExportarPropiedades(ManejoAlquiler unSistema)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            for (int i = 0; i < unSistema.CantidadPropiedades; i++)
            {
                propiedades.Add(unSistema.GetPropiedad(i));

            }
            return propiedades;
        }
        private void MostrarPropiedad(Propiedad unaPropiedad)
        {
            foreach (string s in unaPropiedad.getData())
            {
                MessageBox.Show(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                MostrarPropiedad(unaPropiedad);

            }
        }
    }
}
