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
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                btnNuevoCliente.Enabled = true;
                btnAlquiler.Enabled = true;
                btnConsultar.Enabled = true;
                if (UsuarioActivo.RolId == 2)
                {
                    btnPropiedad.Enabled = true;
                }
            }
            ventanaLogin.Dispose();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            UsuarioActivo = null;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            btnNuevoCliente.Enabled = false;
            btnAlquiler.Enabled = false;
            btnConsultar.Enabled = false;
            btnPropiedad.Enabled = false;
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Login unLogin = new Login("admin", "admin");
            loginSistema.AgregarUsuario(unLogin);
        }
    }
}
