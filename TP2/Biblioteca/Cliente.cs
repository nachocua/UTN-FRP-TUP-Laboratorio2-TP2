using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                if (value < 1000000 || value > 99999999)
                {
                    throw new ArgumentException("DNI inválido");
                }
            }
        }
        public Cliente()
        {

        }
    }
}
