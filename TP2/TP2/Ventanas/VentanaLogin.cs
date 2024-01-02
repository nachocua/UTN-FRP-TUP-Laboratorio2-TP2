using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Clases.Login;

namespace TP2
{
    public partial class VentanaLogin : Form
    {
        public Login unLogin = null;
        public VentanaLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(tbUsuario.Text != "" && tbPass.Text != "")
            {
                unLogin = new Login(tbUsuario.Text, tbPass.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
