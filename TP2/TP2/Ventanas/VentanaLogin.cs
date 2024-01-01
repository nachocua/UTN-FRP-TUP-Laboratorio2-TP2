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
        private List<Login> listaUsuarios = new List<Login>();
        public Login unLogin = null;
        public VentanaLogin()
        {
            InitializeComponent();
            listaUsuarios = new List<Login>();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            unLogin = new Login(tbUsuario.Text, tbPass.Text, 0);
            if (BuscarUser(unLogin) > 0)
            {
                if (BuscarPassword(unLogin) > 0)
                {
                    valido = true;
                }
            }
            if (!valido)
            {
                MessageBox.Show("Credenciales invalidas");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
