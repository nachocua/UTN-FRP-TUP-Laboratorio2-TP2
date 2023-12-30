using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Clases
{
    public class Login
    {
        public string Usuario { get; private set; }
        public string Password { get; private set; }
        public int RolId { get; private set; }
        public Login(string usuario, string password, int rolId)
        {
            Usuario = usuario;
            Password = password;
            RolId = rolId;
        }
    }
}
