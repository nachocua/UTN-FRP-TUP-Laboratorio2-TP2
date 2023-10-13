using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    abstract class Propiedad
    {
        public string Ubicacion { get; protected set; }
        public string Nombre { get; protected set; }
        public string Propietario { get; protected set; }
        protected List<string> imagenes;
        public Propiedad(string nombre, string ubicacion, string propietario)
        {
            if (IsValidInput(nombre) && IsValidInput(ubicacion) && IsValidInput(propietario))
            {
                Nombre = nombre ?? throw new ArgumentNullException("Campo vacio.");
                Ubicacion = ubicacion ?? throw new ArgumentNullException("Campo vacio.");
                Propietario = propietario ?? throw new ArgumentNullException("Campo vacio.");
                imagenes = new List<string>();
            }
            else
            {
                throw new ArgumentException("Los campos Nombre, Ubicación y Propietario solo deben contener caracteres.");
            }
        }
        private bool IsValidInput(string input)
        {
            // [a-zA-Z ]+ permite letras mayúsculas, minúsculas y espacios.
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(input, pattern);
        }
        public abstract double Costo(int dias);
    }
}
