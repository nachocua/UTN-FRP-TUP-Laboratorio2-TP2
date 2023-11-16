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
        private void button1_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                FormImg ventanaImagen = new FormImg(Convert.ToInt32(propiedadSeleccionada[0]));
                ventanaImagen.ShowDialog();
                ventanaImagen.Dispose();
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
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
    }
}
