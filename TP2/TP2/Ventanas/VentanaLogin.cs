using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Clases;

namespace TP2
{
    public partial class VentanaLogin : Form
    {
        private List<Login> listaUsuarios = new List<Login>();
        public VentanaLogin()
        {
            InitializeComponent();
            listaUsuarios = new List<Login>();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            Login unLogin = new Login(tbUsuario.Text, tbPass.Text, 0);
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
        }
        public int BuscarUser(Login unLogin)
        {
            int indx = -1, i = 0;
            while (indx == -1 && i < listaUsuarios.Count)
            {
                if (listaUsuarios[i].Usuario == unLogin.Usuario)
                {
                    indx = i;
                }
                i++;
            }
            return indx;
        }
        public int BuscarPassword(Login unLogin)
        {
            int indx = -1, i = 0;
            while (indx == -1 && i < listaUsuarios.Count)
            {
                if (listaUsuarios[i].Password == unLogin.Password)
                {
                    indx = i;
                }
                i++;
            }
            return indx;
        }
    }
}
