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
            try
            {
                if (Convert.ToInt32(leDni.Text) < 1000000 || Convert.ToInt32(leDni.Text) > 99999999)
                {
                    throw new ArgumentException("DNI inválido");
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("El DNI debe ser solo numeros");
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
