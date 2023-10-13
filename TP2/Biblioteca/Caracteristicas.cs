using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Caracteristicas
    {
        private List<string> servicios;
        public int Capacidad { get; private set; }
        public Caracteristicas(int capacidad)
        {
            if (capacidad <= 0)
                throw new ArgumentException("La capacidad no puede ser negativa");
            else
            {
                Capacidad = capacidad;
            }
        }
        public void AgregarServicio(string servicio)
        {
            servicios.Add(servicio);
        }
        public string GetServicio(int i)
        {
            return servicios[i];
        }
    }
}
