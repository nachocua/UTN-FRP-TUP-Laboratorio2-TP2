using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Clases.Login
{
    public class SistemaLogin
    {
        private List<Login> datosLogins;
        public SistemaLogin() 
        {
            datosLogins = new List<Login>();
        }
        public void AgregarUsuario(Login unUsuario)
        {
            datosLogins.Add(unUsuario);
        }
        public void Import()
        {

        }
        public void Export() 
        {

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
        public int BuscarIdRol(Login unLogin)
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
