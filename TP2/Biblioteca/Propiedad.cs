using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    abstract class Propiedad
    {
        public string Ubicacion {  get; protected set; }
        public string Nombre {  get; protected set; }
        public string Propietario { get; protected set; }
        protected List<string> imagenes;
        public Propiedad(string nombre, string ubicacion, string propietario)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            Propietario = propietario;
            imagenes = new List<string>();
        }
        public abstract double Costo(int dias);
    }
}
