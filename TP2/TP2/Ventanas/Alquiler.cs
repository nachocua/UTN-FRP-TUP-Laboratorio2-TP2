using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP2
{
    public partial class Alquiler : Form
    {
        ManejoAlquiler elSistema;
        List<Propiedad> propiedades;
        string[] propiedadSeleccionada = null;
        bool clienteValido = false;
        int dias = 1;
        int observacion = 0;
        private List<int> idsClientes = null;
        string ubicacionSeleccionada = "Todas";
        public Alquiler(ManejoAlquiler unSistema)
        {
            InitializeComponent(); elSistema = unSistema;
            propiedades = ExportarPropiedades(elSistema);
            dtFechaInicio.MinDate = DateTime.Now;
            dtFechaInicio.MaxDate = DateTime.Now.AddMonths(3);
            dtFechaHasta.MinDate = DateTime.Now;
            dtFechaHasta.MaxDate = DateTime.Now.AddMonths(3);
            idsClientes = new List<int>();
            cbUbicacion.Text = "Ubicaciones";
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
            bool repetido = false;
            int i = 0;
            if (Int32.TryParse(tbDni.Text, out dni))
            {
                while (repetido == false && i < idsClientes.Count)
                {
                    if (idsClientes[i] == dni)
                    {
                        repetido = true;
                    }
                    i++;
                }
                if (!repetido)
                {
                    Cliente clienteABuscar = new Cliente(dni, "", "", 0, DateTime.Now);
                    int indx = elSistema.BuscarCliente(clienteABuscar);
                    if (indx > -1)
                    {
                        string[] datosCliente = elSistema.InfoCliente(indx);
                        if (MessageBox.Show("¿Desea agregar a " + datosCliente[3] + " " + datosCliente[2] + "como huesped?",
                            "¿Agregar huesped?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            lbDatosCliente.Items.Add(datosCliente[3] + ", " + datosCliente[2]);
                            idsClientes.Add(dni);
                        }
                        /*lbDatosCliente.Items.Add("Dni: " + datosCliente[0]);
                        lbDatosCliente.Items.Add("Nombre: " + datosCliente[2]);
                        lbDatosCliente.Items.Add("Apellido: " + datosCliente[3]);
                        lbDatosCliente.Items.Add("Teléfono: " + datosCliente[1]);*/
                    }
                    else
                    {
                        /*lbDatosCliente.Items.Add("Dni: ");
                        lbDatosCliente.Items.Add("Nombre: ");
                        lbDatosCliente.Items.Add("Apellido: ");
                        lbDatosCliente.Items.Add("Teléfono: ");*/
                        MessageBox.Show("No hay cliente con ese dni");
                    }
                    clienteValido = true;
                }
                else
                {
                    MessageBox.Show("Ya agregó como huesped a este cliente");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un dni valido");
                clienteValido = false;
            }
        }
        private List<Propiedad> FiltrarPropiedades(List<string> tipos, List<string> servicios, string ubicacion, int capacidad)
        {
            bool capacidadExacta = ContieneCapacidadExacta(propiedades, capacidad);
            List<Propiedad> propiedadesFiltradas = new List<Propiedad>();

            foreach (Propiedad propiedad in propiedades)
            {
                if (ContieneTipoSeleccionado(propiedad, tipos) && ContieneServiciosSeleccionados(propiedad, servicios) && (propiedad.Ciudad == ubicacion || ubicacion == "Todas") && (propiedad.Habilitada))
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
        private void CargarUbicaciones()
        {
            List<string> ubicaciones = new List<string>();
            foreach (Propiedad unaPropiedad in propiedades)
            {
                ubicaciones.Add(unaPropiedad.Ciudad);
            }
            HashSet<string> hashSet = new HashSet<string>(ubicaciones);
            cbUbicacion.Items.Add("Todas");
            foreach (string key in hashSet)
            {
                cbUbicacion.Items.Add(key);
            }
        }
        private bool VerificacionFecha()
        {
            bool state = false;
            if (dtFechaInicio.Value.Month == dtFechaHasta.Value.Month)
            {
                state = dtFechaHasta.Value.Day - dtFechaInicio.Value.Day > 0;
            }
            else
            {
                int mes = (dtFechaHasta.Value.Month - dtFechaInicio.Value.Month) * 30;
                int dias = dtFechaHasta.Value.Day - dtFechaInicio.Value.Day;
                state = (mes + dias) > 0;
            }
            return state;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            propiedadSeleccionada = null;
            //if (dtFechaHasta.Value.CompareTo(dtFechaInicio.Value) >= 0) // IF VIEJO, LO DEJO POR LAS DUDAS (CAMBIADO EL 16/02 A LAS 2 32 AM)
            if(VerificacionFecha())
            {
                List<string> serviciosSeleccionados = CargarServicios();
                List<string> tiposSeleccionados = CargarTipoSeleccionado();
                int capacidad = Convert.ToInt32(numCapacidad.Value);
                List<Propiedad> propiedadesFiltradas = FiltrarPropiedades(tiposSeleccionados, serviciosSeleccionados, ubicacionSeleccionada, capacidad);
                List<int> reservas;
                string[] datosReservas;
                int indx;
                DateTime fechaDesde;
                DateTime fechaHasta;
                bool state;
                foreach (Propiedad unaPropiedad in propiedadesFiltradas)
                {
                    state = true;
                    reservas = unaPropiedad.getReservas();
                    if (reservas != null)
                    {
                        foreach (int unaReserva in reservas)
                        {
                            if (state)
                            {
                                Reserva reservaABuscar = new Reserva(unaReserva, new List<int>(), 0, DateTime.Now, DateTime.Now, 0);
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
                List<Cliente> huespedes = ObtenerHuespedes();
                if (huespedes.Count > 0)
                {
                    state = true;
                }
                else
                {
                    MessageBox.Show("Debes tener un huesped para asignarle una reserva");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una propiedad");
            }
            if (state)
            {
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {
                    int idReserva = elSistema.cantidadReservas();
                    int idPropiedad = unaPropiedad.idPropiedad;
                    int cantDias = (dtFechaHasta.Value - dtFechaInicio.Value).Days + 1;
                    double costo = unaPropiedad.Costo(cantDias);
                    bool estado = Imprimir();
                    if (estado)
                    {
                        Reserva unaReserva = new Reserva(idReserva, idsClientes, idPropiedad, dtFechaInicio.Value, dtFechaHasta.Value, costo);
                        elSistema.NuevaReserva(unaReserva);
                        dgView.Rows.Clear();
                        propiedadSeleccionada = null;
                        lbDatosCliente.Items.Clear();
                        idsClientes.Clear();
                        MessageBox.Show("Se ha reservado con éxito");
                    }
                }
            }
        }
        private void CambiarGroupBox(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Simple":
                    observacion = 1;
                    break;
                case "Doble":
                    observacion = 2;
                    break;
                case "Triple":
                    observacion = 3;
                    break;
            }
            if (propiedadSeleccionada != null)
            {
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {
                    labelPrecio.Text = "Costo Total: $ " + unaPropiedad.Costo(dias, observacion);
                }
            }
        }
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                propiedadSeleccionada = GetRow(dgView.Rows[e.RowIndex]);
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {

                    if (unaPropiedad is Hotel)
                    {
                        gbTipoHabitacion.Enabled = true;
                        labSimple.Text = "Simples: " + ((Hotel)unaPropiedad).Simple;
                        labDoble.Text = "Dobles: " + ((Hotel)unaPropiedad).Doble;
                        labTriple.Text = "Triples: " + ((Hotel)unaPropiedad).Triple;
                        labelPrecio.Text = "Costo Total: $ " + unaPropiedad.Costo(dias, observacion);
                    }
                    else
                    {
                        labSimple.Text = "Simples: -";
                        labDoble.Text = "Dobles: -";
                        labTriple.Text = "Triples: -";
                        gbTipoHabitacion.Enabled = false;
                        labelPrecio.Text = "Costo Total: $ " + unaPropiedad.Costo(dias);
                    }
                }
            }
            else
            {
                propiedadSeleccionada = null;
            }
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dias = (dtFechaHasta.Value - dtFechaInicio.Value).Days + 1;
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            dias = (dtFechaHasta.Value - dtFechaInicio.Value).Days + 1;
        }
        private bool Imprimir()
        {
            bool state = false;
            printPreviewDialog1.Document = printDocument1;
            printDialog1.PrinterSettings.Copies = 2;
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.DefaultPageSettings.PrinterSettings.PrintFileName = "Reserva_0" + elSistema.cantidadReservas();
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                state = true;
            }
            return state;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Verdana", 14);
            Brush brush = new SolidBrush(Color.Black);
            Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
            if (unaPropiedad != null)
            {
                string rutaImg = "..//..//Img//" + unaPropiedad.idPropiedad + "//img0.jpg";
                Image logo = Bitmap.FromFile("..//..//assets//logo.jpg");
                Image imgpropiedad = null;
                List<Cliente> huespedes = ObtenerHuespedes();
                Cliente unCliente = huespedes.FirstOrDefault();
                List<string[]> text = new List<string[]>();
                if (File.Exists(rutaImg))
                {
                    imgpropiedad = Bitmap.FromFile(rutaImg);
                }
                float x, y;
                int margen = 50, columnaX = 180;
                int ancho = e.PageBounds.Width - margen, alto = e.PageBounds.Height - margen;
                int h1 = 200, h2 = 300, h3 = 400;
                int hLinea = (int)font.GetHeight(e.Graphics);
                x = y = margen;

                // Encabezado
                int medidaAux = e.PageBounds.Width / 3;
                g.DrawImage(logo, x, y, medidaAux, h1);
                ancho -= margen;
                g.DrawRectangle(pen, x, y, ancho, h1);
                g.DrawRectangle(pen, x, y, medidaAux, h1);
                g.DrawString("Rentify S.A. - UTN FRP", font, brush, x + 20, h1 + y / 2);
                g.DrawString(string.Format("FACTURA / RESERVA\n" +
                    "Nro Factura: {0:D6}\n" +
                    "Cliente: {1} {2}\n" +
                    "FECHA DE EMISION: {3}",
                    elSistema.cantidadReservas() + 1,
                    unCliente.Nombres, unCliente.Apellidos, DateTime.Now.ToShortDateString()),
                    font, brush, margen + medidaAux + 20, y + 20);
                // LISTADO DE PERSONAS
                y += h1;
                g.DrawRectangle(pen, x, y, ancho, (int)font.GetHeight(e.Graphics)); // Columnas de huesped
                text.Add(new string[] { "Nombre", "Apellido", "Documento", "Fecha Nacimiento" });
                foreach (Cliente cliente in huespedes)
                {
                    text.Add(cliente.GetData());
                }
                foreach (string[] s in text)
                {
                    x = margen + 5;
                    foreach (string txt in s)
                    {
                        g.DrawString(txt, font, brush, x, y);
                        x += columnaX;
                    }
                    y += hLinea;
                }
                y = margen + h1 + hLinea;
                x = margen;
                g.DrawRectangle(pen, x, y, ancho, h2); // Fin lista de huespedes

                //DATOS DE LA PROPIEDAD RESERVADA
                y += h2;
                g.DrawImage(imgpropiedad, x, y, h3, h3);
                g.DrawRectangle(pen, x, y, h3, h3);
                string txtPropiedad = string.Format("[ {0} ]\nNombre:{1}\nUbicacion:{2}\nCapacidad:{3}" +
                    "\nServicios:\n", unaPropiedad.GetType().Name, unaPropiedad.Nombre, unaPropiedad.Ciudad, unaPropiedad.Plazas);
                string txtServicios = "";
                foreach (string s in unaPropiedad.Servicios)
                {
                    txtServicios += "□ " + s + "\n";
                }
                txtPropiedad += txtServicios;
                g.DrawString(txtPropiedad, font, brush, x + h3 + 10, y);
                y += h3;
                g.DrawLine(pen, x, y, ancho + x, y);
                g.DrawString("Fecha de reserva: " + dtFechaInicio.Value.ToShortDateString() + " - " + dtFechaHasta.Value.ToShortDateString()
                    + "\nCantidad de dias: " + ((dtFechaHasta.Value - dtFechaInicio.Value).Days + 1) + " dias\nCosto base: $ " + unaPropiedad.Precio, font, brush, x, y);
                x = margen + h3;
                y += hLinea * 2; // 2 renglones mas

                g.DrawRectangle(pen, x, y, ancho - x + margen, alto - y);
                g.DrawString("Costo total: $ " + unaPropiedad.Costo(dias), new Font("Verdana", 14, FontStyle.Bold), brush, x + 5, y + 5);
                //MARCO
                g.DrawRectangle(pen, margen, margen, ancho, alto - margen);
            }
        }
        private List<Cliente> ObtenerHuespedes()
        {
            List<Cliente> huespedes = new List<Cliente>();
            foreach (int id in idsClientes)
            {
                int idx = elSistema.BuscarCliente(new Cliente(id, "", "", 0, DateTime.Now));
                if (idx > -1)
                {
                    Cliente unCliente = elSistema.GetCliente(idx);
                    huespedes.Add(unCliente);
                }
            }
            return huespedes;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lbDatosCliente.SelectedItem != null)
            {
                idsClientes.RemoveAt(lbDatosCliente.SelectedIndex);
                lbDatosCliente.Items.RemoveAt(lbDatosCliente.SelectedIndex);
                lbDatosCliente.SelectedItem = null;
                btnQuitar.Enabled = false;
            }
        }

        private void lbDatosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDatosCliente.SelectedItems != null)
            {
                btnQuitar.Enabled = true;
            }
        }

        private void cbUbicacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ubicacionSeleccionada = cbUbicacion.SelectedItem.ToString();
        }
    }
}
