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
        public Cliente unCliente = null;
        public Alta_Cliente()
        {
            InitializeComponent();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            bool state = true;
            int dni = 0;
            long tel = 0;
            try
            {
                dni = Convert.ToInt32(leDni.Text);
                tel = Convert.ToInt64(leTelefono.Text);
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
            if(state)
            {
                unCliente = new Cliente(dni, leNombre.Text, leApellido.Text, tel, dtFechaNacimiento.Value);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
