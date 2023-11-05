using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TP2
{
    [Serializable]
    public abstract class Propiedad
    {
        private static int propiedadesTotales = 0;
        public static int idPropiedad { get; private set; }
        public string Ciudad { get; protected set; }
        public string Nombre { get; protected set; }
        public int Plazas { get; protected set; }
        public List<string> Servicios { get; protected set; }
        protected List<string> imagenes;
        public Propiedad(string nombre, string ubicacion, int plazas, List<string> servicios)
        {
            idPropiedad = propiedadesTotales;
            propiedadesTotales++;
            if (IsValidInput(nombre) && IsValidInput(ubicacion))
            {
                Nombre = nombre ?? throw new ArgumentNullException("Campo vacio.");
                Ciudad = ubicacion ?? throw new ArgumentNullException("Campo vacio.");
                Plazas = plazas;
                Servicios = servicios;
                imagenes = new List<string>();
            }
            else
            {
                throw new ArgumentException("Los campos Nombre y Ubicación solo deben contener caracteres.");
            }
        }
        private bool IsValidInput(string input)
        {
            // [a-zA-Z ]+ permite letras mayúsculas, minúsculas y espacios.
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(input, pattern);
        }
        public void ModificarServicios(string[] servicios)
        {
            Servicios = servicios.ToList();
        }
        public abstract double Costo(int dias);
        public abstract string[] getData();
    }
}
