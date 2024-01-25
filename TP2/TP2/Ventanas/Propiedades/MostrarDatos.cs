using System;
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
        string ubicacionSeleccionada = "Todas";
        public MostrarDatos(ManejoAlquiler unSistema)
        {
            InitializeComponent();
            elSistema = unSistema;
            propiedades = ExportarPropiedades(elSistema);
            comboBox1.Text = "Ubicaciones";
            CargarUbicaciones();
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
            int capacidad = Convert.ToInt32(numCapacidad.Value);
            List<Propiedad> propiedadesFiltradas = FiltrarPropiedades(tiposSeleccionados, serviciosSeleccionados, ubicacionSeleccionada, capacidad);
            foreach (Propiedad propiedad in propiedadesFiltradas)
            {
                dgView.Rows.Add(propiedad.getData());
            }
            #region FiltroPropiedades
            //foreach (Propiedad propiedad in propiedades)
            //{
            //    bool propiedadTieneServicios = true;
            //    bool todasLasCiudades = true;
            //    foreach (string servicioSeleccionado in serviciosSeleccionados)
            //    {
            //        if (!propiedad.Servicios.Contains(servicioSeleccionado))
            //        {
            //            propiedadTieneServicios = false;
            //            break;
            //        }
            //    }
            //    if (ubicacionSeleccionada != "Todas")
            //    {
            //        todasLasCiudades = false;
            //    }

            //    if (propiedadTieneServicios && todasLasCiudades)
            //    {
            //        if (tiposSeleccionados.Count > 0)
            //        {
            //            if (tiposSeleccionados.Contains("Casa"))
            //            {
            //                if (propiedad is Casa)
            //                {
            //                    if (!(propiedad is CasaFinSemana))
            //                    {
            //                        dgView.Rows.Add(propiedad.getData());
            //                    }
            //                }
            //            }
            //            if (tiposSeleccionados.Contains("Hotel"))
            //            {
            //                if (propiedad is Hotel)
            //                {
            //                    dgView.Rows.Add(propiedad.getData());
            //                }
            //            }
            //            if (tiposSeleccionados.Contains("Casa Fin de Semana"))
            //            {
            //                if (propiedad is CasaFinSemana)
            //                {
            //                    dgView.Rows.Add(propiedad.getData());
            //                }
            //            }
            //        }
            //        else
            //        {
            //            dgView.Rows.Add(propiedad.getData());
            //        }
            //    }
            //}
            #endregion
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                //propiedades.Sort();
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                NuevaPropiedad ventanaPropiedad = new NuevaPropiedad(unaPropiedad.idPropiedad);
                #region CargandoDatos
                if (unaPropiedad != null)
                {
                    ventanaPropiedad.btnNuevaPropiedad.Text = "Actualizar";
                    ventanaPropiedad.tbNombre.Text = unaPropiedad.Nombre;
                    ventanaPropiedad.tbUbicacion.Text = unaPropiedad.Ciudad;
                    string[] vServicios = string.Join(", ", unaPropiedad.Servicios.ToArray()).Split(',');
                    ventanaPropiedad.tbCosto.Text = unaPropiedad.Precio.ToString();
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
                    #endregion
                    #region CambiandoPropiedad
                    if (res == DialogResult.OK)
                    {
                        try
                        {
                            Propiedad nuevaPropiedad = ventanaPropiedad.unaPropiedad;
                            if (unaPropiedad is Hotel)
                            {
                                Hotel unHotel = unaPropiedad as Hotel;
                                Hotel otroHotel = nuevaPropiedad as Hotel;
                                int simples = Convert.ToInt32(ventanaPropiedad.numUDSimple.Value),
                                    dobles = Convert.ToInt32(ventanaPropiedad.numUDDoble.Value),
                                    triples = Convert.ToInt32(ventanaPropiedad.numUDTriple.Value);
                                unHotel.ModificarDatos(otroHotel.Nombre, otroHotel.Ciudad, otroHotel.Estrella, simples, dobles, triples);
                                unHotel.ModificarServicios(nuevaPropiedad.Servicios.ToArray());
                                unHotel.ModificarImagenes(ventanaPropiedad.ObtenerImagenes());
                                unHotel.EstablecerCosto(Convert.ToDouble(ventanaPropiedad.tbCosto.Text));
                            }
                            else
                            {
                                Casa unaCasa = unaPropiedad as Casa;
                                Casa otraCasa = nuevaPropiedad as Casa;
                                unaCasa.ModificarDatos(otraCasa.Nombre, otraCasa.Ciudad, otraCasa.Plazas, otraCasa.Propietario);
                                unaCasa.ModificarServicios(nuevaPropiedad.Servicios.ToArray());
                                unaCasa.ModificarImagenes(ventanaPropiedad.ObtenerImagenes());
                                unaCasa.EstablecerCosto(Convert.ToDouble(ventanaPropiedad.tbCosto.Text));
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Algo fallo.");
                        }
                    }
                    ventanaPropiedad.Dispose();
                }
                #endregion
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
        private List<Propiedad> ExportarPropiedades(ManejoAlquiler unSistema)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            for (int i = 0; i < unSistema.CantidadPropiedades; i++)
            {
                propiedades.Add(unSistema.GetPropiedad(i));
            }
            return propiedades;
        }
        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            if (propiedadSeleccionada != null)
            {
                FormImg ventanaImagen = new FormImg((Convert.ToInt32(propiedadSeleccionada[0])));
                ventanaImagen.ShowDialog();
                ventanaImagen.Dispose();
            }
        }
        private void CargarUbicaciones()
        {
            List<string> ubicaciones = new List<string>();
            foreach (Propiedad unaPropiedad in propiedades)
            {
                ubicaciones.Add(unaPropiedad.Ciudad);
            }
            HashSet<string> hashSet = new HashSet<string>(ubicaciones);
            comboBox1.Items.Add("Todas");
            foreach (string key in hashSet)
            {
                comboBox1.Items.Add(key);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubicacionSeleccionada = comboBox1.SelectedItem.ToString();
        }
        private List<Propiedad> FiltrarPropiedades(List<string> tipos, List<string> servicios, string ubicacion, int capacidad)
        {
            bool capacidadExacta = ContieneCapacidadExacta(propiedades, capacidad);
            List<Propiedad> propiedadesFiltradas = new List<Propiedad>();
            foreach (Propiedad propiedad in propiedades)
            {
                if (ContieneTipoSeleccionado(propiedad, tipos) && ContieneServiciosSeleccionados(propiedad, servicios) && (propiedad.Ciudad == ubicacion || ubicacion == "Todas"))
                {
                    if (capacidadExacta)
                    {
                        if (propiedad.Plazas == capacidad)
                        {
                            propiedadesFiltradas.Add(propiedad);
                        }
                    }
                    else if (propiedad.Plazas > capacidad)
                    {
                        propiedadesFiltradas.Add(propiedad);
                    }
                }
            }
            return propiedadesFiltradas;
        }
        private bool ContieneServiciosSeleccionados(Propiedad unaPropiedad, List<string> serviciosSeleccionados)
        {
            //bool ret = true;
            foreach (string servicioSeleccionado in serviciosSeleccionados)
            {
                if (!unaPropiedad.Servicios.Contains(servicioSeleccionado))
                {
                    return false;
                    //ret = false;
                    //break; 
                }
            }
            return true;
        }
        private bool ContieneTipoSeleccionado(Propiedad unaPropiedad, List<string> tiposSeleccionados)
        {
            bool ret = true;
            foreach (string tipoSeleccionado in tiposSeleccionados)
            {
                if (unaPropiedad.GetType().Name != tipoSeleccionado)
                {
                    ret = false;
                }
            }
            return ret;
        }
        private bool ContieneCapacidadExacta(List<Propiedad> propiedades, int capacidad)
        {
            bool contieneCapacidadExacta = false;
            foreach (Propiedad p in propiedades)
            {
                if (p.Plazas == capacidad)
                {
                    contieneCapacidadExacta = true;
                }
            }
            return contieneCapacidadExacta;
        }
        //private List<string> EliminarDuplicados(List<string> lista)
        //{
        //    List<string> sinDuplicados = new List<string>();

        //    foreach (string ubicacion in lista)
        //    {
        //        bool estaRepetido = false;

        //        foreach (string item in sinDuplicados)
        //        {
        //            if (ubicacion == item)
        //            {
        //                estaRepetido = true;
        //                break;
        //            }
        //        }

        //        if (!estaRepetido)
        //        {
        //            sinDuplicados.Add(ubicacion);
        //        }
        //    }

        //    return sinDuplicados;
        //}
    }
}
