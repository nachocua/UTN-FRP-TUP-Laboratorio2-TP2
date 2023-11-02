using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2;

//Ej-> Hotel;2; Palms Springs; Parana; 100; Wifi* Cochera*Desayuno*Pet-Friendly; 2; 
//     TipoPropiedad; idPropiedad; nombre; Ciudad; Plazas; Servicios; Dueño; Estrellas; 

namespace TP2
{
    [Serializable]
    public class Hotel : Propiedad
    {
        public enum Tipo { Simple, Doble, Triple }
        private int[] TipoHab = null;
        public int Estrella { get; protected set; }
        private List<Tipo> habs;
        public Hotel(string nombre, string ubicacion, int plazas, List<string> servicios, int estrella) : base(nombre, ubicacion, plazas, servicios)
        {
            TipoHab = new int[3];
            habs = new List<Tipo>();
            Estrella = estrella;
        }
        public override double Costo(int dias)
        {
            //Implementar
            return 0;
        }
        public void CargarHabitaciones(int cant, Tipo tipo)
        {
            for (int i = 0; i < cant; i++)
            {
                habs.Add(tipo);
            }
        }
        public void AgregarHabitacion(Tipo unaHabitacion)
        {
            habs.Add(unaHabitacion);
        }
        public Tipo GetTipoHabitacion(int idx)
        {
            return habs[idx];
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>
            {
                Nombre,
                "Hotel",
                Ciudad,
                "-",
                Servicios.Count.ToString(),
                Plazas.ToString()
            };
            return arr.ToArray();
        }
        public override string ToString()
        {
            string datos = "Hotel;" + idPropiedad.ToString() + ";" + Nombre + ";" + Ciudad
                + ";" + Plazas.ToString() + ";" + Servicios[0];
            if (Servicios.Count > 1)
            {
                for (int i = 1; i < Servicios.Count; i++)
                {
                    datos += "*" + Servicios[i];
                }
            }
            //Incompleto
            /*
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
            */
            return datos;
        }
    }
}
