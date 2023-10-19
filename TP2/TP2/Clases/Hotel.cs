using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2;


//Ej-> 2; Palms Springs; Parana; 100; Wifi* Cochera*Desayuno*Pet-Friendly; 2; 
//     idPropiedad; nombre; Ciudad; Plazas; Servicios; Dueño; Estrellas; 

namespace TP2
{
    public class Hotel : Propiedad
    {
        public enum Tipo { Simple, Doble, Triple }
        private int[] TipoHab = null;
        public int Estrella {  get; protected set; }
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
            List<string> arr = new List<string>();
            arr.Add(Nombre);
            arr.Add("Hotel");
            arr.Add(Ciudad);
            arr.Add("-");
            arr.Add(Servicios.Count.ToString());
            arr.Add(Plazas.ToString());
            return arr.ToArray();
        }
    }
}
