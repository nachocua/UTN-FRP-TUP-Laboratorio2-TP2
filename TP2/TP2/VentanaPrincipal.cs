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
                                           "..//..//Data//reservas.csv");
            loginSistema = new SistemaLogin("..//..//Data//UsPa.dat");
            UsuarioActivo = null;
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
                fileUserActivo.Close();
            }
            BarraMenuSinLoguear();
            sbPropiedades.Text += elSistema.CantidadPropiedades.ToString();
            sbClientes.Text += elSistema.CantidadClientes().ToString();
            sbReservas.Text += elSistema.cantidadReservas().ToString();
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
            ToolStripMenuItem ayudaMenuItem = new ToolStripMenuItem("Ayuda");
            ToolStripMenuItem loginMenuItem = new ToolStripMenuItem("Login");
            ayudaMenuItem.DropDownItems.Add(loginMenuItem);
            loginMenuItem.Click += loginMenuItem_Click;

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

            //  ******  Reservas
            ToolStripMenuItem reservasMenuItem = new ToolStripMenuItem("Reservas");
            ToolStripMenuItem verReservasMenuItem = new ToolStripMenuItem("Ver Reservas");            
            verReservasMenuItem.ShortcutKeys = Keys.F3;
            reservasMenuItem.DropDownItems.Add(verReservasMenuItem);
            //verReservasMenuItem.Click += MenuItem_Click;

            ToolStripMenuItem altaReservaMenuItem = new ToolStripMenuItem("Alta Reserva");
            reservasMenuItem.DropDownItems.Add(altaReservaMenuItem);
            altaReservaMenuItem.Click += altaReservaMenuItem_Click;

            ToolStripMenuItem verGraficosMenuItem = new ToolStripMenuItem("Ver Graficos");
            reservasMenuItem.DropDownItems.Add(verGraficosMenuItem);
            verGraficosMenuItem.Click += verGraficosMenuItem_Click;

            menuStrip1.Items.Add(reservasMenuItem);

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

                // Cientes 
                ToolStripMenuItem clientesMenuItem = new ToolStripMenuItem("Clientes");
                ToolStripMenuItem verClientesMenuItem = new ToolStripMenuItem("Ver Clientes");
                clientesMenuItem.DropDownItems.Add(verClientesMenuItem);
                //verClientesMenuItem.Click += MenuItem_Click;

                ToolStripMenuItem nuevoClientesMenuItem = new ToolStripMenuItem("Nuevo Cliente");
                clientesMenuItem.DropDownItems.Add(nuevoClientesMenuItem);
                nuevoClientesMenuItem.Click += nuevoClientesMenuItem_Click;

                ToolStripMenuItem exportarClientesMenuItem = new ToolStripMenuItem("Exportar Clientes");
                clientesMenuItem.DropDownItems.Add(exportarClientesMenuItem);
                //exportarClientesMenuItem.Click += exportarClientesMenuItem_Click;

                menuStrip1.Items.Add(clientesMenuItem);

                // Propiedades
                ToolStripMenuItem propiedadesMenuItem = new ToolStripMenuItem("Propiedades");
                ToolStripMenuItem consultarPropiedadesMenuItem = new ToolStripMenuItem("Consultar Propiedades");
                propiedadesMenuItem.DropDownItems.Add(consultarPropiedadesMenuItem);
                consultarPropiedadesMenuItem.Click += consultarPropiedadesMenuItem_Click;

                ToolStripMenuItem nuevaPropiedadItem = new ToolStripMenuItem("Nueva Propiedad");
                propiedadesMenuItem.DropDownItems.Add(nuevaPropiedadItem);
                nuevaPropiedadItem.Click += nuevaPropiedadItem_Click;

                menuStrip1.Items.Add(propiedadesMenuItem);
            }

            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            menuStrip1.Items.Add(configuracionMenuItem);

            // Asignar el control MenuStrip al formulario
            this.MainMenuStrip = menuStrip1;

            // Asociar el evento MouseHover a cada elemento de menú
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseHover += MenuItem_MouseHover;
            }

        }

        private void CambiarContrasenaMenuItem_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Ventana_Crear_Usuario ventanaLogin = new Ventana_Crear_Usuario();
            ventanaLogin.cbAdmin.Visible = false;
            ventanaLogin.btnIngresar.Location = new Point(64, 90);
            ventanaLogin.Size = new Size(ventanaLogin.Size.Width, 160);
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

        // ************ Metodos de MENU ************
        private void MenuItem_MouseHover(object sender, EventArgs e)
        {
            // Mostrar el menú desplegable al pasar el mouse sobre el elemento de menú
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.ShowDropDown();
        }

        //  ************ MTD Ayuda
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

            // Crear un nuevo Label
            Label labelRecuadro = new Label();

            // Configura la posición del Label en el centro del formulario
            labelRecuadro.Location = new System.Drawing.Point(
                (ventanaAcercaDe.ClientSize.Width - labelRecuadro.Width) / 2 - 30,
                (ventanaAcercaDe.ClientSize.Height - labelRecuadro.Height) / 2 - 30);

            //Establecer propiedades del Label
            labelRecuadro.BackColor = Color.Green;
            labelRecuadro.Text = "Texto en el recuadro, todo esto \n no lo se \n no lo se \n no lo se \n no lo se";
            labelRecuadro.BorderStyle = BorderStyle.FixedSingle;

            labelRecuadro.AutoSize = true;
            //Agrega relleno alrededor del texto
            labelRecuadro.Padding = new Padding(10);

            // Agregar el Label al formulario
            ventanaAcercaDe.Controls.Add(labelRecuadro);
            ventanaAcercaDe.Show();
        }

        // ************ MTD Configuracion
        private void nuevoUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            // Aca crear ventana para Agregar Nuevo Usuario
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

        // ************ MTD Reservas
        private void altaReservaMenuItem_Click(object sender, EventArgs e)
        {
            labPrecio ventanaAlquiler = new labPrecio(elSistema);
            ventanaAlquiler.ShowDialog();
            ventanaAlquiler.Dispose();
            sbReservas.Text = "Reservas: " + elSistema.cantidadReservas().ToString();
        }

        private void verGraficosMenuItem_Click(object sender, EventArgs e)
        {
            VentanaGraficos ventanaGraficos = new VentanaGraficos();
            ventanaGraficos.Show();

        }

        // ************ MTD Propiedades
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

        //  ************ MTD Clientes
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

        // ************ FIN Metodos de MENU ************
        private void ExportarCalendarioPropiedad(Propiedad unaPropiedad)
        {
            if (unaPropiedad == null)
            {
                MessageBox.Show("No hay una propiedad seleccionada para ser exportada");
            }
            else
            {
                if (unaPropiedad.getReservas().Count == 0)
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
                        foreach (int unId in unaPropiedad.getReservas())
                        {
                            Reserva unaReserva = new Reserva(unId, 0, 0, DateTime.Now, DateTime.Now, 0);
                            string[] datosReserva = elSistema.InfoReserva(elSistema.BuscarReserva(unaReserva));
                            sw.WriteLine(unId + ";" + datosReserva[5] + ";" + datosReserva[6]);
                        }
                        sw.Close();
                    }
                }
            }
        }
        private void ImportarCalendarioPropiedad(Propiedad unaPropiedad)
        {
            if (unaPropiedad == null)
            {
                MessageBox.Show("No hay una propiedad seleccionada para ser exportada");
            }
            else
            {
                OpenFileDialog unOpenfileDialog = new OpenFileDialog();
                unOpenfileDialog.Filter = "Archivo separado por comas|*.csv";
                unOpenfileDialog.Title = "Exportar datos de propiedad";
                unOpenfileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (unOpenfileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string[]> datosImportados = Funciones_Adicionales.LeerSeparandoArchivo(unOpenfileDialog.FileName, ";");
                }
            }
        }
    }
}
