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
        }
        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            elSistema.Export();
            loginSistema.Export();
        }

        // ************ MENU ************
        private void ConfigurarBarraMenu()
        {

            //  ******  Reservas
            ToolStripMenuItem reservasMenuItem = new ToolStripMenuItem("Reservas");
            ToolStripMenuItem verReservasMenuItem = new ToolStripMenuItem("Ver Reservas");
            verReservasMenuItem.ShortcutKeys = Keys.F3;
            ToolStripMenuItem altasMenuItem = new ToolStripMenuItem("Altas");
            reservasMenuItem.DropDownItems.Add(verReservasMenuItem);
            reservasMenuItem.DropDownItems.Add(altasMenuItem);

            //verReservasMenuItem.Click += MenuItem_Click;
            //altasMenuItem.Click += btnAltaReservas_Click_1;             
            menuStrip1.Items.Add(reservasMenuItem);

            // ******  "Configuracion"
            ToolStripMenuItem configuracionMenuItem = new ToolStripMenuItem("Configuracion");
            ToolStripMenuItem cambiarcontrasenaMenuItem = new ToolStripMenuItem("Cambiar Contraseña");
            ToolStripMenuItem logOutMenuItem = new ToolStripMenuItem("Logout");
            ToolStripMenuItem salirMenuItem = new ToolStripMenuItem("Salir");
            configuracionMenuItem.DropDownItems.Add(cambiarcontrasenaMenuItem);

            configuracionMenuItem.DropDownItems.Add(logOutMenuItem);
            logOutMenuItem.Click += logOutMenuItem_Click;

            salirMenuItem.Click += SalirMenuItem_Click;
            //cambiarcontrasenaMenuItem.Click += CambiarContrasenaMenuItem_Click;


            if (UsuarioActivo.RolId == 2)
            {
                //  elementos del menú Configuracion          
                ToolStripMenuItem nuevoUsuarioMenuItem = new ToolStripMenuItem("Nuevo Usuario");
                nuevoUsuarioMenuItem.Click += nuevoUsuarioMenuItem_Click;
                configuracionMenuItem.DropDownItems.Add(nuevoUsuarioMenuItem);

                // Cientes 
                ToolStripMenuItem clientesMenuItem = new ToolStripMenuItem("Clientes");
                ToolStripMenuItem verClientesMenuItem = new ToolStripMenuItem("Ver Clientes");
                ToolStripMenuItem nuevoClientesMenuItem = new ToolStripMenuItem("Nuevo Cliente");
                ToolStripMenuItem exportarClientesMenuItem = new ToolStripMenuItem("Exportar Clientes");

                clientesMenuItem.DropDownItems.Add(verClientesMenuItem);
                clientesMenuItem.DropDownItems.Add(nuevoClientesMenuItem);
                clientesMenuItem.DropDownItems.Add(exportarClientesMenuItem);

                //verClientesMenuItem.Click += MenuItem_Click;
                nuevoClientesMenuItem.Click += nuevoClientesMenuItem_Click;
                //exportarClientesMenuItem.Click += exportarClientesMenuItem_Click;
                menuStrip1.Items.Add(clientesMenuItem);

                // Propiedades
                ToolStripMenuItem propiedadesMenuItem = new ToolStripMenuItem("Propiedades");
                ToolStripMenuItem consultarPropiedadesMenuItem = new ToolStripMenuItem("Consultar Propiedades");
                ToolStripMenuItem nuevaPropiedadItem = new ToolStripMenuItem("Nueva Propiedad");
                ToolStripMenuItem alquilarPropiedadItem = new ToolStripMenuItem("Alquilar Propiedad");
                propiedadesMenuItem.DropDownItems.Add(consultarPropiedadesMenuItem);
                propiedadesMenuItem.DropDownItems.Add(nuevaPropiedadItem);
                propiedadesMenuItem.DropDownItems.Add(alquilarPropiedadItem);

                consultarPropiedadesMenuItem.Click += consultarPropiedadesMenuItem_Click;
                nuevaPropiedadItem.Click += nuevaPropiedadItem_Click;
                alquilarPropiedadItem.Click += alquilarPropiedadItem_Click;

                menuStrip1.Items.Add(propiedadesMenuItem);
            }

            configuracionMenuItem.DropDownItems.Add(salirMenuItem);
            menuStrip1.Items.Add(configuracionMenuItem);
            //ToolStripMenuItem rolMenuItem = new ToolStripMenuItem("Usuario: Admin");
            //menuStrip1.Items.Add(rolMenuItem);

            //  ******  Ayuda
            ToolStripMenuItem ayudaMenuItem = new ToolStripMenuItem("Ayuda");
            ToolStripMenuItem ayudaWebMenuItem = new ToolStripMenuItem("Ver Ayuda");
            ayudaWebMenuItem.ShortcutKeys = Keys.F1;
            ToolStripMenuItem acercaDeMenuItem = new ToolStripMenuItem("Acerca de");
            acercaDeMenuItem.ShortcutKeys = Keys.F12;
            ayudaMenuItem.DropDownItems.Add(ayudaWebMenuItem);
            ayudaMenuItem.DropDownItems.Add(acercaDeMenuItem);
            menuStrip1.Items.Add(ayudaMenuItem);

            // Asignar el control MenuStrip al formulario
            this.MainMenuStrip = menuStrip1;
            menuStrip1.Visible = true;

            // Asociar el evento MouseHover a cada elemento de menú
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseHover += MenuItem_MouseHover;
            }

        }

        // ************ Metodos de MENU ************
        private void MenuItem_MouseHover(object sender, EventArgs e)
        {
            // Mostrar el menú desplegable al pasar el mouse sobre el elemento de menú
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.ShowDropDown();
        }

        // ************ MTD Configuracion
        private void nuevoUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear Nuevo usuario");
            // Aca crear ventana para Agregar Nuevo Usuario
        }

        private void SalirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioActivo = null;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            menuStrip1.Visible = false;
            menuStrip1.SuspendLayout();
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
            }
            ventanaPropiedad.Dispose();
        }
        private void alquilarPropiedadItem_Click(object sender, EventArgs e)
        {
            Alquiler ventanaAlquiler = new Alquiler(elSistema);
            ventanaAlquiler.ShowDialog();
            ventanaAlquiler.Dispose();
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

        //  ************ MTD Ayuda

        private void AyudaItem_Click(object sender, EventArgs e)
        {

        }
        private void AcercaDeItem_Click(object sender, EventArgs e)
        {
            // Crear un nuevo Label
            //Label labelRecuadro = new Label();

            //Establecer propiedades del Label
            //labelRecuadro.Text = "Texto en el recuadro";
            //labelRecuadro.BorderStyle = BorderStyle.FixedSingle;
            //labelRecuadro.AutoSize = true;
            //Agrega relleno alrededor del texto
            //labelRecuadro.Padding = new Padding(10); 

            // Agregar el Label al formulario
            //Controls.Add(labelRecuadro);
        }


        // ************ FIN MENU ************

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
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
        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            Alquiler ventanaAlquiler = new Alquiler(elSistema);
            ventanaAlquiler.ShowDialog();
            ventanaAlquiler.Dispose();
        }
        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            NuevaPropiedad ventanaPropiedad = new NuevaPropiedad(elSistema.CantidadPropiedades);
            if (ventanaPropiedad.ShowDialog() == DialogResult.OK)
            {
                elSistema.AgregarPropiedad(ventanaPropiedad.unaPropiedad);
            }
            ventanaPropiedad.Dispose();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos vMostrar = new MostrarDatos(elSistema);
            vMostrar.ShowDialog();
            vMostrar.Dispose();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valido = false;
            VentanaLogin ventanaLogin = new VentanaLogin();
            DialogResult dResult;
            do
            {
                dResult = ventanaLogin.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (loginSistema.ValidarUsuario(ventanaLogin.unLogin) != -1)
                    {
                        UsuarioActivo = ventanaLogin.unLogin;
                        valido = true;
                    }
                    else
                    {
                        MessageBox.Show("Credenciales no validas");
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
                HabilitarInterfaz();
                ConfigurarBarraMenu();
            }
            ventanaLogin.Dispose();
        }
        private void btnLogout_Click(object sender, EventArgs e) // borrar mas adelante
        {
            UsuarioActivo = null;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            menuStrip1.Visible = false;
            menuStrip1.SuspendLayout();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            bool valido = false;
            VentanaLogin ventanaLogin = new VentanaLogin();
            DialogResult dResult;
            do
            {
                dResult = ventanaLogin.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (loginSistema.BuscarUsuario(ventanaLogin.unLogin) == -1)
                    {
                        loginSistema.AgregarUsuario(ventanaLogin.unLogin);
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
            ventanaLogin.Dispose();
        }
        public void HabilitarInterfaz()
        {
            btnLogin.Visible = false;
            btnLogout.Visible = true;
            btnUsuario.Visible = false; // borrar mas adelante
        }
    }
}
