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
    public partial class Alta_Cliente : Form
    {
        public Alta_Cliente()
        {
            InitializeComponent();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            bool state = true;
            int dni, tel;
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
            catch (FormatException ex)
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
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
