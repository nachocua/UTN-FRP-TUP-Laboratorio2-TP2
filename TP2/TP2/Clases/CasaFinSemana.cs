using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class CasaFinSemana : Casa
    {
        public CasaFinSemana(string nombre, string ubicacion, int plazas, List<string> servicios,
            string propietario) : base(nombre, ubicacion, plazas, servicios, propietario)
        {

        }
        public override double Costo(int dias)
        {
            //Implementar
            return 0;
        }
    }
}
