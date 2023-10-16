using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Habitacion
    {
        Caracteristicas caracteristicas;
        public Habitacion(int capacidadPersonas)
        {
            caracteristicas = new Caracteristicas(capacidadPersonas);
        }
        public void AgregarServicio(string servicio)
        {
            caracteristicas.AgregarServicio(servicio);
        }
        public string GetServicio(int i)
        {
            return caracteristicas.GetServicio(i);
        }
    }
}
