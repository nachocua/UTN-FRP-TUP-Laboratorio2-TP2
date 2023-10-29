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
        public override string ToString()
        {
            string datos = "Casa Finde;" + idPropiedad.ToString() + ";" + Nombre + ";" + Ciudad + ";"
                + Plazas.ToString() + ";" + Servicios[0];
            if (Servicios.Count > 1)
            {
                for (int i = 1; i < Servicios.Count; i++)
                {
                    datos += "*" + Servicios[i];
                }
            }
            datos += ";" + Propietario + ";";
            if (imagenes.Count > 0)
            {
                datos += imagenes[0];
                if (imagenes.Count > 1)
                {
                    datos += "*" + imagenes[1];
                }
            }
            else
            {
                datos += "ninguna";
            }
            return datos;
        }
    }
}
