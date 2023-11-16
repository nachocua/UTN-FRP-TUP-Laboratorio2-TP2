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
        ManejoAlquiler elSistema;
        List<Propiedad> propiedades;
        string[] propiedadSeleccionada = null;
        public Alquiler(ManejoAlquiler unSistema)
        {
            InitializeComponent(); elSistema = unSistema;
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
            }
            else
            {
                MessageBox.Show("Debe ingresar un dni valido");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            Propiedad unaPropiedad;
            List<string> serviciosSeleccionados = CargarServicios();
            List<string> tiposSeleccionados = CargarTipoSeleccionado();
            List<string[]> propsPostFiltro = new List<string[]>();
            Stack<int> reservas;
            string[] datosReservas;
            int indx;
            DateTime fechaDesde;
            int cantidadDias;
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
                            else
                            {
                                propsPostFiltro.Add(propiedad.getData());
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
                unaPropiedad = elSistema.GetPropiedad(Convert.ToInt32(datos[0]));
                reservas = unaPropiedad.getReservas();
                foreach (int unaReserva in reservas)
                {
                    Reserva reservaABuscar = new Reserva(unaReserva, 0, 0, DateTime.Now, 0, 0);
                    indx = elSistema.BuscarReserva(reservaABuscar);
                    if (indx != -1)
                    {
                        datosReservas = elSistema.InfoReserva(indx);
                        string[] fecha = datosReservas[4].Split('/');
                        fechaDesde = new DateTime(Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[2]));
                        cantidadDias = Convert.ToInt32(datosReservas[5]);
                    }
                }
                dgView.Rows.Add(datos);
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
    }
}
