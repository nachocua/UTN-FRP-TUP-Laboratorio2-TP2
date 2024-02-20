using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TP2.Clases;
using TP2.Clases.Login;
using Biblioteca;
using TP2.Ventanas;

namespace TP2
{
    public partial class VentanaPrincipal : Form
    {
        private ManejoAlquiler elSistema;
        private SistemaLogin loginSistema;
        private Login UsuarioActivo;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            elSistema = new ManejoAlquiler("..//..//Data//propiedades.dat",
                                           "..//..//Data//clientes.dat",
                                           "..//..//Data//reservas.dat");
            loginSistema = new SistemaLogin("..//..//Data//UsPa.dat");
            UsuarioActivo = null;
            //Si se cerró la app mientras estaba logeado, se recarga el usuario
            if (File.Exists("..//..//Data//ActiveData.csv"))
            {
                StreamReader fileUserActivo = new StreamReader("..//..//Data//ActiveData.csv");
                int indx = Convert.ToInt32(fileUserActivo.ReadLine());
                if (indx != -1)
                {
                    UsuarioActivo = loginSistema.GetUser(indx);
                    BarraMenuLogueado();
                    sbUsuario.Text = UsuarioActivo.Usuario + "(" + UsuarioActivo.RolId + ")";
                }
                else
                {
                    BarraMenuSinLoguear();
                }
                fileUserActivo.Close();
            }
            //Agrega datos a la barra
            sbPropiedades.Text += elSistema.CantidadPropiedades.ToString();
            sbClientes.Text += elSistema.CantidadClientes().ToString();
            sbReservas.Text += elSistema.cantidadReservas().ToString();


            /*
            elSistema.limpiar();
            sbReservas.Text = "Reservas: " + elSistema.cantidadReservas().ToString();
            */
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            elSistema.Export();
            loginSistema.Export();
            //Exportar usuario activo
            StreamWriter sw = new StreamWriter("..//..//Data//ActiveData.csv");
            if (UsuarioActivo != null)
            {
                sw.WriteLine(loginSistema.BuscarUsuario(UsuarioActivo));
            }
            else
            {
                sw.WriteLine("-1");
            }
            sw.Close();
        }

        // ************ MENU ************
        private void BarraMenuSinLoguear()
        {
            menuStrip1.Items.Clear();

            // ******  "Configuracion"
            ToolStripMenuItem configuracionMenuItem = new ToolStripMenuItem("Configuracion");
            ToolStripMenuItem salirMenuItem = new ToolStripMenuItem("Salir");
            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            salirMenuItem.Click += SalirMenuItem_Click;

            ToolStripMenuItem loginMenuItem = new ToolStripMenuItem("Login");
            configuracionMenuItem.DropDownItems.Add(loginMenuItem);
            loginMenuItem.Click += loginMenuItem_Click;

            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            menuStrip1.Items.Add(configuracionMenuItem);

            // ******  "Ayuda"

            ToolStripMenuItem ayudaMenuItem = new ToolStripMenuItem("Ayuda");

            ToolStripMenuItem ayudaWebMenuItem = new ToolStripMenuItem("Ver Ayuda");
            ayudaWebMenuItem.ShortcutKeys = Keys.F1;
            ayudaWebMenuItem.Click += AyudaItem_Click;

            ToolStripMenuItem acercaDeMenuItem = new ToolStripMenuItem("Acerca de");
            acercaDeMenuItem.ShortcutKeys = Keys.F12;
            acercaDeMenuItem.Click += AcercaDeItem_Click;

            ayudaMenuItem.DropDownItems.Add(ayudaWebMenuItem);
            ayudaMenuItem.DropDownItems.Add(acercaDeMenuItem);
            menuStrip1.Items.Add(ayudaMenuItem);

            this.MainMenuStrip = menuStrip1;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseHover += MenuItem_MouseHover;
            }
        }

        private void BarraMenuLogueado()
        {
            menuStrip1.Items.Clear();

            //  ******  Reservas
            ToolStripMenuItem reservasMenuItem = new ToolStripMenuItem("Reservas");

            ToolStripMenuItem nuevaReservaMenuItem = new ToolStripMenuItem("Nueva Reserva");
            reservasMenuItem.DropDownItems.Add(nuevaReservaMenuItem);
            nuevaReservaMenuItem.Click += altaReservaMenuItem_Click;

            ToolStripMenuItem ExportarReservasItem = new ToolStripMenuItem("Exportar Reservas y Clientes");
            reservasMenuItem.DropDownItems.Add(ExportarReservasItem);
            ExportarReservasItem.Click += ExportarReservasClienteMenuItem_Click;

            // ******  "Configuracion"
            ToolStripMenuItem configuracionMenuItem = new ToolStripMenuItem("Configuracion");
            ToolStripMenuItem cambiarcontrasenaMenuItem = new ToolStripMenuItem("Cambiar Contraseña");
            configuracionMenuItem.DropDownItems.Add(cambiarcontrasenaMenuItem);
            cambiarcontrasenaMenuItem.Click += CambiarContrasenaMenuItem_Click;

            ToolStripMenuItem salirMenuItem = new ToolStripMenuItem("Salir");
            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            salirMenuItem.Click += SalirMenuItem_Click;

            ToolStripMenuItem logOutMenuItem = new ToolStripMenuItem("Logout");
            configuracionMenuItem.DropDownItems.Add(logOutMenuItem);
            logOutMenuItem.Click += logOutMenuItem_Click;

            if (UsuarioActivo.RolId == 2)
            {
                //  elementos del menú Configuracion          
                ToolStripMenuItem nuevoUsuarioMenuItem = new ToolStripMenuItem("Nuevo Usuario");
                nuevoUsuarioMenuItem.Click += nuevoUsuarioMenuItem_Click;
                configuracionMenuItem.DropDownItems.Add(nuevoUsuarioMenuItem);

                //  ******  Reservas
                ToolStripMenuItem anularReservasMenuItem = new ToolStripMenuItem("Anular Reservas");
                anularReservasMenuItem.ShortcutKeys = Keys.F3;
                reservasMenuItem.DropDownItems.Add(anularReservasMenuItem);
                anularReservasMenuItem.Click += anularReservasMenuItem_Click;

                ToolStripMenuItem verGraficosMenuItem = new ToolStripMenuItem("Ver Graficos");
                reservasMenuItem.DropDownItems.Add(verGraficosMenuItem);
                verGraficosMenuItem.Click += verGraficosMenuItem_Click;
            }

            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            menuStrip1.Items.Add(configuracionMenuItem);

            menuStrip1.Items.Add(reservasMenuItem);

            if (UsuarioActivo.RolId == 2)
            {
                // Cientes 
                ToolStripMenuItem clientesMenuItem = new ToolStripMenuItem("Clientes");
                ToolStripMenuItem verClientesMenuItem = new ToolStripMenuItem("Ver Clientes");
                clientesMenuItem.DropDownItems.Add(verClientesMenuItem);
                verClientesMenuItem.Click += VerClientesMenuItem_Click;

                ToolStripMenuItem nuevoClientesMenuItem = new ToolStripMenuItem("Nuevo Cliente");
                clientesMenuItem.DropDownItems.Add(nuevoClientesMenuItem);
                nuevoClientesMenuItem.Click += nuevoClientesMenuItem_Click;

                ToolStripMenuItem exportarClientesMenuItem = new ToolStripMenuItem("Exportar Clientes");
                clientesMenuItem.DropDownItems.Add(exportarClientesMenuItem);

                menuStrip1.Items.Add(clientesMenuItem);

                // Propiedades
                ToolStripMenuItem propiedadesMenuItem = new ToolStripMenuItem("Propiedades");
                ToolStripMenuItem consultarPropiedadesMenuItem = new ToolStripMenuItem("Consultar Propiedades");
                propiedadesMenuItem.DropDownItems.Add(consultarPropiedadesMenuItem);
                consultarPropiedadesMenuItem.Click += consultarPropiedadesMenuItem_Click;

                ToolStripMenuItem nuevaPropiedadItem = new ToolStripMenuItem("Nueva Propiedad");
                propiedadesMenuItem.DropDownItems.Add(nuevaPropiedadItem);
                nuevaPropiedadItem.Click += nuevaPropiedadItem_Click;

                ToolStripMenuItem ExportarCalendarioReservasItem = new ToolStripMenuItem("Exportar Calendario Reservas");
                propiedadesMenuItem.DropDownItems.Add(ExportarCalendarioReservasItem);
                ExportarCalendarioReservasItem.Click += ExportarCalendarioItem_Click;

                ToolStripMenuItem ImportarCalendarioReservasItem = new ToolStripMenuItem("Importar Calendario Reservas");
                propiedadesMenuItem.DropDownItems.Add(ImportarCalendarioReservasItem);
                ImportarCalendarioReservasItem.Click += ImportarCalendarioItem_Click;

                menuStrip1.Items.Add(propiedadesMenuItem);

            }

            //  ******  Ayuda
            ToolStripMenuItem ayudaMenuItem = new ToolStripMenuItem("Ayuda");
            ToolStripMenuItem ayudaWebMenuItem = new ToolStripMenuItem("Ver Ayuda");
            ayudaWebMenuItem.ShortcutKeys = Keys.F1;
            ayudaWebMenuItem.Click += AyudaItem_Click;

            ToolStripMenuItem acercaDeMenuItem = new ToolStripMenuItem("Acerca de");
            acercaDeMenuItem.ShortcutKeys = Keys.F12;
            acercaDeMenuItem.Click += AcercaDeItem_Click;
            ayudaMenuItem.DropDownItems.Add(ayudaWebMenuItem);
            ayudaMenuItem.DropDownItems.Add(acercaDeMenuItem);
            menuStrip1.Items.Add(ayudaMenuItem);

            // Asignar el control MenuStrip al formulario
            this.MainMenuStrip = menuStrip1;

            // Asociar el evento MouseHover a cada elemento de menú
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseHover += MenuItem_MouseHover;
            }
        }

        private void VerClientesMenuItem_Click(object sender, EventArgs e)
        {
            VerClientes unaVentana = new VerClientes();
            unaVentana.dgView.Rows.Clear();
            for (int i = 0; i < elSistema.CantidadClientes(); i++)
            {
                Cliente unCliente = elSistema.GetCliente(i);
                string[] txt = unCliente.ObtenerDatos();
                unaVentana.dgView.Rows.Add(txt);
            }
            if (unaVentana.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("¿Desea borrar a " + unaVentana.clienteSeleccionado[0] + " " + unaVentana.clienteSeleccionado[1] + "?", "¿Borrar cliente?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int dni = Convert.ToInt32(unaVentana.clienteSeleccionado[2]);
                    int idx = elSistema.BuscarCliente(new Cliente(dni,"","",0,DateTime.Now));
                    if(idx != -1)
                    {
                        Cliente unCliente = elSistema.GetCliente(idx);
                        elSistema.EliminarCliente(unCliente);
                        MessageBox.Show("Cliente eliminado");
                    }
                }
            }
            unaVentana.Dispose();
        }

        private void CambiarContrasenaMenuItem_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Ventana_Crear_Usuario ventanaLogin = new Ventana_Crear_Usuario();
            ventanaLogin.Text = "Cambiar contraseña";
            ventanaLogin.cbAdmin.Visible = false;
            ventanaLogin.btnIngresar.Location = new Point(64, 90);
            ventanaLogin.Size = new Size(ventanaLogin.Size.Width + 60, 160);
            ventanaLogin.tbUsuario.Location = new Point(ventanaLogin.tbUsuario.Location.X + 25, ventanaLogin.tbUsuario.Location.Y);
            ventanaLogin.tbPass.Location = new Point(ventanaLogin.tbPass.Location.X + 25, ventanaLogin.tbPass.Location.Y);
            ventanaLogin.tbUsuario.Width += 40;
            ventanaLogin.tbPass.Width += 40;
            ventanaLogin.lbUsuario.Text = "Contraseña";
            ventanaLogin.lbPass.Text = "Confirmar Contraseña";
            ventanaLogin.btnIngresar.Text = "Cambiar contraseña";
            DialogResult dResult;
            do
            {
                dResult = ventanaLogin.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (ventanaLogin.unLogin.Usuario != ventanaLogin.unLogin.Password)
                    {
                        MessageBox.Show("Las contraseñas deben coincidir");
                    }
                    else
                    {
                        loginSistema.CambiarPassword(loginSistema.BuscarUsuario(UsuarioActivo), ventanaLogin.unLogin.Usuario);
                        valido = true;
                        MessageBox.Show("Se ha realizado el cambio");
                    }
                }
                else
                {
                    if (dResult == DialogResult.Cancel)
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            ventanaLogin.Dispose();
        }

        // ************ FIN MENU ************

        private void MenuItem_MouseHover(object sender, EventArgs e)
        {
            // Mostrar el menú desplegable al pasar el mouse sobre el elemento de menú
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.ShowDropDown();
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Ventana_Crear_Usuario ventanaLogin = new Ventana_Crear_Usuario();
            ventanaLogin.cbAdmin.Visible = false;
            ventanaLogin.btnIngresar.Location = new Point(64, 90);
            ventanaLogin.Size = new Size(ventanaLogin.Size.Width, 160);
            Login unLogin = null;
            DialogResult dResult;
            do
            {
                dResult = ventanaLogin.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    int rolID = loginSistema.ValidarUsuario(ventanaLogin.unLogin);
                    if (rolID == -1)
                    {
                        MessageBox.Show("Credenciales no validas");
                    }
                    else
                    {
                        if (rolID == 2)
                        {
                            unLogin = new Login(ventanaLogin.unLogin.Usuario, ventanaLogin.unLogin.Password, true);
                        }
                        else
                        {
                            unLogin = new Login(ventanaLogin.unLogin.Usuario, ventanaLogin.unLogin.Password);
                        }
                        UsuarioActivo = unLogin;
                        valido = true;
                    }
                }
                else
                {
                    if (dResult == DialogResult.Cancel)
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            if (UsuarioActivo != null)
            {
                BarraMenuLogueado();
                sbUsuario.Text = UsuarioActivo.Usuario + "(" + UsuarioActivo.RolId + ")";
            }
            ventanaLogin.Dispose();
        }

        private void AyudaItem_Click(object sender, EventArgs e)
        {
            Ayuda ventanaAyuda = new Ayuda();
            ventanaAyuda.Height = 650;
            ventanaAyuda.Width = 790;
            ventanaAyuda.Show();
        }

        private void AcercaDeItem_Click(object sender, EventArgs e)
        {
            AcercaDe ventanaAcercaDe = new AcercaDe();
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose();
        }

        private void nuevoUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Ventana_Crear_Usuario unaVentanaCrearUsuario = new Ventana_Crear_Usuario();
            DialogResult dResult;
            do
            {
                dResult = unaVentanaCrearUsuario.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (loginSistema.BuscarUsuario(unaVentanaCrearUsuario.unLogin) == -1)
                    {
                        loginSistema.AgregarUsuario(unaVentanaCrearUsuario.unLogin);
                        valido = true;
                        MessageBox.Show("Usuario creado correctamente");
                        sbClientes.Text = "Clientes: " + elSistema.CantidadClientes().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Existe un usuario con ese nombre");
                    }
                }
                else
                {
                    if (dResult == DialogResult.Cancel)
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            unaVentanaCrearUsuario.Dispose();
        }

        private void SalirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioActivo = null;
            menuStrip1.Items.Clear();
            BarraMenuSinLoguear();
            sbUsuario.Text = "Sin logear";
        }

        private void altaReservaMenuItem_Click(object sender, EventArgs e)
        {
            Alquiler ventanaAlquiler = new Alquiler(elSistema);
            ventanaAlquiler.ShowDialog();
            ventanaAlquiler.Dispose();
            sbReservas.Text = "Reservas: " + elSistema.cantidadReservas().ToString();
        }

        private void verGraficosMenuItem_Click(object sender, EventArgs e)
        {
            VentanaGraficos ventanaGraficos = new VentanaGraficos(elSistema.CantidadPersonas, elSistema.CantidadPorTipoPropiedad);
            ventanaGraficos.Show();
        }

        private void consultarPropiedadesMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDatos vMostrar = new MostrarDatos(elSistema);
            vMostrar.ShowDialog();
            vMostrar.Dispose();
        }

        private void nuevaPropiedadItem_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad(elSistema.CantidadPropiedades);
            if (ventanaPropiedad.ShowDialog() == DialogResult.OK)
            {
                elSistema.AgregarPropiedad(ventanaPropiedad.unaPropiedad);
                sbPropiedades.Text = "Propiedades: " + elSistema.CantidadPropiedades.ToString();
            }
            ventanaPropiedad.Dispose();
        }

        private void nuevoClientesMenuItem_Click(object sender, EventArgs e)
        {
            bool repetido = true;
            Alta_Cliente ventanaCliente = new Alta_Cliente();
            do
            {
                if (ventanaCliente.ShowDialog() == DialogResult.OK)
                {
                    if (elSistema.BuscarCliente(ventanaCliente.unCliente) < 0)
                    {
                        elSistema.AgregarCliente(ventanaCliente.unCliente);
                        repetido = false;
                        sbClientes.Text = "Clientes: " + elSistema.CantidadClientes().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con este DNI.\n Verifique el DNI o busquelo en el sistema");
                    }
                }
                else
                {
                    repetido = false;
                }
            } while (repetido);
            ventanaCliente.Dispose();
        }

        private void anularReservasMenuItem_Click(object sender, EventArgs e)
        {
            Propiedad unaPropiedad = null;
            Reserva unaReserva = null;
            AnularReserva unaVentana = new AnularReserva();
            bool valido = false;
            for (int i = 0; i < elSistema.CantidadPropiedades; i++)
            {
                valido = false;
                unaPropiedad = elSistema.GetPropiedad(i);
                if (unaPropiedad.Habilitada == true)
                {
                    if (unaPropiedad.getReservas().Count() > 0)
                    {
                        int j = 0;
                        do
                        {
                            if (elSistema.GetReserva(unaPropiedad.getReservas()[j]).Estado == "Reservado")
                            {
                                valido = true;
                            }
                            j++;
                        } while (j < unaPropiedad.getReservas().Count());
                        if (valido)
                        {
                            unaVentana.dgPropiedades.Rows.Add(unaPropiedad.getData());
                        }
                    }
                }
            }
            if (unaVentana.ShowDialog() == DialogResult.Yes)
            {
                unaVentana.dgPropiedades.Rows.Clear();
                unaVentana.btnBuscarReservas.Enabled = false;
                unaPropiedad = elSistema.GetPropiedad(unaVentana.idPropiedad);
                foreach (int idReserva in unaPropiedad.getReservas())
                {
                    unaReserva = elSistema.GetReserva(idReserva);
                    if (unaReserva.Estado == "Reservado")
                    {
                        unaVentana.dgReservas.Rows.Add(unaReserva.ToString().Split(';'));
                    }
                }
                unaVentana.dgPropiedades.Visible = false;
                unaVentana.dgReservas.Visible = true;
                if (unaVentana.ShowDialog() == DialogResult.OK)
                {
                    elSistema.GetReserva(unaVentana.idPropiedad).Cancelar();
                    MessageBox.Show("Reserva anulada");
                }
            }
            unaVentana.Dispose();
        }
        private void ExportarReservasClienteMenuItem_Click(object sender, EventArgs e)
        {
            elSistema.Exportable();
        }
        private void ExportarCalendarioPropiedad(int idPropiedad)
        {
            if (idPropiedad < 0)
            {
                MessageBox.Show("No hay una propiedad seleccionada para ser exportada");
            }
            else
            {
                if (elSistema.GetPropiedad(idPropiedad).getReservas().Count() == 0)
                {
                    MessageBox.Show("No hay datos para exportar");
                }
                else
                {
                    SaveFileDialog unSaveFileDialog = new SaveFileDialog();
                    unSaveFileDialog.Filter = "Archivo separado por comas|*.csv";
                    unSaveFileDialog.Title = "Exportar datos de propiedad";
                    unSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (unSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(unSaveFileDialog.FileName);
                        foreach (int unIdReserva in elSistema.GetPropiedad(idPropiedad).getReservas())
                        {
                            Reserva unaReserva = elSistema.GetReserva(unIdReserva);
                            sw.WriteLine(unaReserva.NroReserva + ";" + unaReserva.FechaInicio.ToShortDateString() + ";" + unaReserva.FechaHasta.ToShortDateString());
                        }
                        sw.Close();
                    }
                }
            }
        }
        private void ExportarCalendarioItem_Click(object sender, EventArgs e)
        {
            Propiedad unaPropiedad = null;
            VentanaExportImportProps unaVentana = new VentanaExportImportProps();
            for (int i = 0; i < elSistema.CantidadPropiedades; i++)
            {
                unaPropiedad = elSistema.GetPropiedad(i);
                if (unaPropiedad.Habilitada == true)
                {
                    unaVentana.dgPropiedades.Rows.Add(unaPropiedad.getData());
                }
            }
            if (unaVentana.ShowDialog() == DialogResult.OK)
            {
                ExportarCalendarioPropiedad(Convert.ToInt32(unaVentana.dgPropiedades[0, unaVentana.numeroFila].Value.ToString()));
            }
            unaVentana.Dispose();
        }
        private void ImportarCalendarioItem_Click(object sender, EventArgs e)
        {
            Propiedad unaPropiedad = null;
            VentanaExportImportProps unaVentana = new VentanaExportImportProps();
            unaVentana.btnExportar.Text = "Importar";
            for (int i = 0; i < elSistema.CantidadPropiedades; i++)
            {
                unaPropiedad = elSistema.GetPropiedad(i);
                if (unaPropiedad.Habilitada == true)
                {
                    unaVentana.dgPropiedades.Rows.Add(unaPropiedad.getData());
                }
            }
            if (unaVentana.ShowDialog() == DialogResult.OK)
            {
                ImportarCalendarioPropiedad(Convert.ToInt32(unaVentana.dgPropiedades[0, unaVentana.numeroFila].Value.ToString()));
            }
            unaVentana.Dispose();
        }
        private void ImportarCalendarioPropiedad(int idPropiedad)
        {
            OpenFileDialog unOpenFileDialog = new OpenFileDialog();
            unOpenFileDialog.Filter = "Archivo separado por comas|*.csv";
            unOpenFileDialog.Title = "Exportar datos de propiedad";
            unOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (unOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string[]> datos = Funciones_Adicionales.LeerSeparandoArchivo(unOpenFileDialog.FileName, ";");
                if (datos.Count > 0)
                {
                    bool valido = true;
                    Reserva reservaBuscada = null;
                    int i = 0;
                    do
                    {

                        reservaBuscada = new Reserva(Convert.ToInt32(datos[i][0].Split('\t')[0]), new List<int>(), 0, DateTime.Now, DateTime.Now, 0);
                        if (elSistema.BuscarReserva(reservaBuscada) == -1)
                        {
                            valido = false;
                        }
                        i++;
                    } while (i < datos.Count && valido);
                    if (!valido)
                    {
                        MessageBox.Show("Los datos a importar no coinciden con la propiedad seleccionada");
                    }
                    else
                    {
                        foreach (string[] datosReserva in datos)
                        {
                            Reserva unaReserva = elSistema.GetReserva(Convert.ToInt32(datosReserva[0].Split('\t')[0]));
                            string[] fecha = datosReserva[0].Split('\t')[1].Split('/');
                            DateTime fechaDesde = new DateTime(Convert.ToInt32(fecha[2]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[0]));
                            fecha = datosReserva[0].Split('\t')[2].Split('/');
                            DateTime fechaHasta = new DateTime(Convert.ToInt32(fecha[2]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[0]));
                            Reserva nuevaReserva = new Reserva(unaReserva.NroReserva, unaReserva.NrosClientes, unaReserva.NroPropiedad, fechaDesde, fechaHasta, unaReserva.Costo);
                            if (unaReserva.Estado == "Cancelada")
                            {
                                nuevaReserva.Cancelar();
                            }
                            elSistema.EliminarReserva(unaReserva);
                            elSistema.NuevaReserva(nuevaReserva);
                        }
                    }
                }
            }
        }
    }
}