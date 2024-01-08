using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Clases.Login
{
    [Serializable]
    public class Login
    {
        public string Usuario { get; private set; }
        public string Password { get; private set; }
        public int RolId { get; private set; }
        public Login(string usuario, string password, bool admin = false)
        {
            Usuario = usuario;
            Password = password;
            if (admin)
            {
                RolId = 2;
            }
            else
            {
                RolId = 1;
            }
        }
    }
}
