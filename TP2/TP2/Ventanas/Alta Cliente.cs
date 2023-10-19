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

namespace TP2
{
    public partial class Alta_Cliente : Form
    {
        private List<Cliente> clientes = null;
        public Alta_Cliente()
        {
            InitializeComponent();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            bool state = true;
            int dni, tel;
            bool encontrado = false;
            try
            {
                dni = Convert.ToInt32(leDni.Text);
                tel = Convert.ToInt32(leTelefono.Text);
                if (!(leDni.Text.Length == 8))
                {
                    throw new Exception("El dni debe contener 8 digitos. Si su dni tiene 7 digitos agregue un 0 al inicio");
                }
                if (!(leTelefono.Text.Length == 10))
                {
                    throw new Exception("El Número de Teléfono debe tener 10 digitos");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dni y Telefono deben ser numéricos");
                state = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state = false;
            }
            if (state)
            {
                int i = 0;
                while ((i < clientes.Count) && (encontrado == false))
                {
                    if (clientes[i].Dni == Convert.ToInt32(leDni.Text))
                    {
                        encontrado = true;
                    }
                    i++;
                }
                if (!encontrado)
                {
                    Cliente unCliente;
                    unCliente = new Cliente(Convert.ToInt32(leDni.Text), leNombre.Text, leApellido.Text, Convert.ToInt32(leTelefono.Text));
                    clientes.Add(unCliente);
                    StreamWriter sw = new StreamWriter("..//..//Data//clientes.csv", true);
                    sw.Write(unCliente.Dni + ";");
                    sw.Write(unCliente.Nombres + ";");
                    sw.Write(unCliente.Apellidos + ";");
                    sw.Write(unCliente.Telefono + ";");
                    bool esPrimero = true;
                    foreach (int idReserva in unCliente.IdReservas)
                    {
                        if (!esPrimero)
                        {
                            sw.Write("-");
                        }
                        else
                        {
                            esPrimero = false;
                        }
                        sw.Write(idReserva);
                    }
                    sw.Write('\n');
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("El usuario se ha cargado en el sistema con anterioridad");
                }
                this.DialogResult = DialogResult.OK;
            }
        }
        private void Alta_Cliente_Load(object sender, EventArgs e)
        {
            List<string[]> datosClientes = null;
            try
            {
                datosClientes = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//clientes.csv", ";");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo de clientes");
            }
            if (datosClientes != null)
            {
                clientes = new List<Cliente>();
                Cliente unCliente;
                string[] idReservas;
                foreach (string[] datoCliente in datosClientes)
                {
                    unCliente = new Cliente(Convert.ToInt32(datoCliente[0]), datoCliente[1], datoCliente[2], Convert.ToInt32(datoCliente[3]));
                    idReservas = datoCliente[4].Split('-');
                    if (idReservas[0] != "")
                    {
                        foreach (string unaReserva in idReservas)
                        {
                            unCliente.AgregarReserva(Convert.ToInt32(unaReserva));
                        }
                    }
                    clientes.Add(unCliente);
                }
            }
        }
    }
}
