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
        bool clienteValido = false;
        int dias = 1;
        int observacion = 0;
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
                    while (noEncontrado && (i < serviciosSeleccionados.Count))
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
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {
                    int idReserva = elSistema.cantidadReservas();
                    int dni = Convert.ToInt32(lbDatosCliente.Items[0].ToString().Split(' ')[1]);
                    int idPropiedad = unaPropiedad.idPropiedad;
                    int cantDias = (dtFechaHasta.Value - dtFechaInicio.Value).Days;
                    double costo = unaPropiedad.Costo(cantDias);
                    Reserva unaReserva = new Reserva(idReserva, dni, idPropiedad, dtFechaInicio.Value, dtFechaHasta.Value, costo);
                    elSistema.NuevaReserva(unaReserva);
                    MessageBox.Show("Se ha reservado con éxito");
                    Imprimir();
                    dgView.Rows.Clear();
                    propiedadSeleccionada = null;
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
                    labelPrecio.Text = "Costo total: $ " + unaPropiedad.Costo(dias, observacion);
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
            dias = (dtFechaHasta.Value - dtFechaInicio.Value).Days;
            if (propiedadSeleccionada != null)
            {
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {
                    labelPrecio.Text = "Costo total: $ " + unaPropiedad.Costo(dias);
                }
            }
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            dias = (dtFechaHasta.Value - dtFechaInicio.Value).Days;
            if (propiedadSeleccionada != null)
            {
                Propiedad unaPropiedad = elSistema.BuscarPropiedad(Convert.ToInt32(propiedadSeleccionada[0]));
                if (unaPropiedad != null)
                {
                    labelPrecio.Text = "Costo total: $ " + unaPropiedad.Costo(dias);
                }
            }
        }
        private void Imprimir()
        {
            printDocument1.DefaultPageSettings.PrinterSettings.PrintFileName = "Reserva_0" + elSistema.cantidadReservas();
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDialog1.PrinterSettings.Copies = 2;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            //printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Verdana", 14);
            Brush brush = new SolidBrush(Color.Black);
            Image logo = Bitmap.FromFile("C:\\Users\\Julian\\Downloads\\logo.jpg"); // CORREGIR 
            Image imgpropiedad = Bitmap.FromFile("C:\\Users\\Julian\\Downloads\\GoletaDelMar.jpg"); // CORREGIR
            //Image logo = Bitmap.FromFile("");
            //Image imgpropiedad = Bitmap.FromFile("");
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
            g.DrawString("FACTURA/RESERVA\nNro Factura: 9032839012\nNombre_Cliente\nCUIL: xx-xxxxxxxx-x\nFECHA DE EMISION: " + DateTime.Now.ToShortDateString(), font, brush, margen + medidaAux + 20, y + 20);

            // LISTADO DE PERSONAS
            y += h1;
            g.DrawRectangle(pen, x, y, ancho, (int)font.GetHeight(e.Graphics)); // Columnas de huesped
            string[][] text = { new string[] { "Nombre", "Apellido", "Documento", "Fecha Nacimiento" },
                                new string[] {"aaaaaa","bbbbbb","22000000","01/01/01" },
                                new string[] {"eeeeee","fdsf","11111111","10/10/20"},
                                new string[] {"ssssss","asdw","22222222","01/02/03"},
                                new string[] {"dddddd","dsadas","33333333","02/03/04"},
                                new string[] {"www","eqwe","44444444","09/12/18"}};
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
            g.DrawString("Tipo_Propiedad\nNombre_Propiedad\nUbicacion_Propiedad\nCapacidad_Propiedad" +
                "\nServicios:\n->\n->\n->", font, brush, x + h3 + 10, y);
            y += h3;
            g.DrawLine(pen, x, y, ancho + x, y);
            g.DrawString("Fecha de reserva: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.AddDays(3).ToShortDateString()
                + "\nCantidad de dias: x dias\nCosto base: $ x", font, brush, x, y);
            x = margen + h3;
            y += hLinea * 2; // 2 renglones mas

            g.DrawRectangle(pen, x, y, ancho - x + margen, alto - y);
            g.DrawString("Costo total: $ x", new Font("Verdana", 14, FontStyle.Bold), brush, x + 5, y + 5);
            //MARCO
            g.DrawRectangle(pen, margen, margen, ancho, alto - margen);
        }
    }
}
