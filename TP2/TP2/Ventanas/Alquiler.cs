﻿using Biblioteca;
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
        ManejoAlquiler elSistema;
        List<Propiedad> propiedades;
        string[] propiedadSeleccionada = null;
        bool clienteValido = false;
        public Alquiler(ManejoAlquiler unSistema)
        {
            InitializeComponent(); elSistema = unSistema;
            propiedades = ExportarPropiedades(elSistema);
            dtFechaInicio.MinDate = DateTime.Now;
            dtFechaInicio.MaxDate = DateTime.Now.AddMonths(3);
            dtFechaHasta.MinDate = DateTime.Now;
            dtFechaHasta.MaxDate = DateTime.Now.AddMonths(3);
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
        private List<Propiedad> ExportarPropiedades(ManejoAlquiler unSistema)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            for (int i = 0; i < unSistema.CantidadPropiedades; i++)
            {
                propiedades.Add(unSistema.GetPropiedad(i));

            }
            return propiedades;
        }
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            int dni;
            if (Int32.TryParse(tbDni.Text, out dni))
            {
                lbDatosCliente.Items.Clear();
                Cliente clienteABuscar = new Cliente(dni, "", "", 0);
                int indx = elSistema.BuscarCliente(clienteABuscar);
                if (indx > -1)
                {
                    string[] datosCliente = elSistema.InfoCliente(indx);
                    lbDatosCliente.Items.Add("Dni: " + datosCliente[0]);
                    lbDatosCliente.Items.Add("Nombre: " + datosCliente[2]);
                    lbDatosCliente.Items.Add("Apellido: " + datosCliente[3]);
                    lbDatosCliente.Items.Add("Teléfono: " + datosCliente[1]);
                }
                else
                {
                    lbDatosCliente.Items.Add("Dni: ");
                    lbDatosCliente.Items.Add("Nombre: ");
                    lbDatosCliente.Items.Add("Apellido: ");
                    lbDatosCliente.Items.Add("Teléfono: ");
                    MessageBox.Show("No hay cliente con ese dni");
                }
                clienteValido = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un dni valido");
                clienteValido = false;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            propiedadSeleccionada = null;
            if (dtFechaHasta.Value.CompareTo(dtFechaInicio.Value) >= 0)
            {
                Propiedad unaPropiedad;
                List<string> serviciosSeleccionados = CargarServicios();
                List<string> tiposSeleccionados = CargarTipoSeleccionado();
                List<string[]> propsPostFiltro = new List<string[]>();
                List<int> reservas;
                string[] datosReservas;
                int indx;
                DateTime fechaDesde;
                DateTime fechaHasta;
                bool state;
                foreach (Propiedad propiedad in propiedades)
                {
                    bool propiedadTieneServicios = true;
                    bool noEncontrado = true;
                    int i = 0;
                    while(noEncontrado && (i < serviciosSeleccionados.Count))
                    {
                        if (!propiedad.Servicios.Contains(serviciosSeleccionados[i]))
                        {
                            propiedadTieneServicios = false;
                            noEncontrado = false;
                        }
                        i++;
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
                                        propsPostFiltro.Add(propiedad.getData());
                                    }
                                }
                            }
                            else
                            {
                                if (tiposSeleccionados.Contains("Hotel"))
                                {
                                    if (propiedad is Hotel)
                                    {
                                        propsPostFiltro.Add(propiedad.getData());
                                    }
                                }
                                else
                                {
                                    if (tiposSeleccionados.Contains("Casa Fin de Semana"))
                                    {
                                        if (propiedad is CasaFinSemana)
                                        {
                                            propsPostFiltro.Add(propiedad.getData());
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            propsPostFiltro.Add(propiedad.getData());
                        }
                    }
                }
                foreach (string[] datos in propsPostFiltro)
                {
                    state = true;
                    unaPropiedad = elSistema.GetPropiedad(Convert.ToInt32(datos[0]));
                    reservas = unaPropiedad.getReservas();
                    if (reservas != null)
                    {
                        foreach (int unaReserva in reservas)
                        {
                            if (state)
                            {
                                Reserva reservaABuscar = new Reserva(unaReserva, 0, 0, DateTime.Now, DateTime.Now, 0);
                                indx = elSistema.BuscarReserva(reservaABuscar);
                                if (indx != -1)
                                {
                                    datosReservas = elSistema.InfoReserva(indx);
                                    string[] fecha = datosReservas[4].Split(' ')[0].Split('/');
                                    string[] fecha2 = datosReservas[5].Split(' ')[0].Split('/');
                                    fechaDesde = new DateTime(Convert.ToInt32(fecha[2]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[0]));
                                    fechaHasta = new DateTime(Convert.ToInt32(fecha2[2]), Convert.ToInt32(fecha2[1]), Convert.ToInt32(fecha2[0]));
                                    if ((dtFechaHasta.Value > fechaDesde) && (dtFechaInicio.Value < fechaHasta))
                                    {
                                        state = false;
                                    }
                                }
                            }
                        }
                    }
                    if (state)
                    {
                        dgView.Rows.Add(unaPropiedad.getData());
                    }
                }
            }
            else
            {
                MessageBox.Show("La fecha de ingreso debe ser anterior a la fecha de partida");
            }
        }
        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                FormImg ventanaImagen = new FormImg(Convert.ToInt32(propiedadSeleccionada[0]));
                ventanaImagen.ShowDialog();
                ventanaImagen.Dispose();
            }
        }
        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex, c = e.ColumnIndex;
            if (c == 5)
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
            }
            else
            {
                propiedadSeleccionada = null;
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
        private void btnReservar_Click(object sender, EventArgs e)
        {
            bool state = false;
            if (propiedadSeleccionada != null)
            {
                if (clienteValido)
                {
                    state = true;
                }
                else
                {
                    MessageBox.Show("Debes buscar un cliente");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una propiedad");
            }
            if (state)
            {
                int idReserva = elSistema.cantidadReservas();
                int dni = Convert.ToInt32(lbDatosCliente.Items[0].ToString().Split(' ')[1]);
                int idPropiedad = Convert.ToInt32(propiedadSeleccionada[0]);
                int cantDias = (dtFechaHasta.Value - dtFechaInicio.Value).Days;
                double costo = elSistema.BuscarPropiedad(idPropiedad).Costo(cantDias);
                Reserva unaReserva = new Reserva(idReserva, dni, idPropiedad, dtFechaInicio.Value, dtFechaHasta.Value, costo);
                elSistema.NuevaReserva(unaReserva);
                MessageBox.Show("Se ha reservado con éxito");
                dgView.Rows.Clear();
                propiedadSeleccionada = null;
            }
        }
    }
}
