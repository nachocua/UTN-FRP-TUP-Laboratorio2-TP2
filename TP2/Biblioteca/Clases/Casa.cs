using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Casa : Propiedad
    {
        public Casa(string nombre, string ubicacion, string propietario) : base(nombre,ubicacion, propietario)
        {

        }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
    }
}
