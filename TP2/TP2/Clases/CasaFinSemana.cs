using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class CasaFinSemana : Casa
    {
        public CasaFinSemana(string nombre, string ubicacion, string propietario, List<string> servicios, int cantCamas) : base(nombre, ubicacion, propietario, servicios, cantCamas)
        {

        }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
    }
}
