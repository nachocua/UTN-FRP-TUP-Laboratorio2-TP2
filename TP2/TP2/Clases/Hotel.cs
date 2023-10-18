using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Hotel : Propiedad
    {
        private List<Habitacion> habitaciones;
        public enum Tipo { Simple, Doble, Triple }
        public int Estrella {  get; protected set; }
        private List<Tipo> habs;
        public Hotel(string nombre, string ubicacion, int plazas, List<string> servicios, int estrella) : base(nombre, ubicacion, plazas, servicios)
        {
            habitaciones = new List<Habitacion>();
            habs = new List<Tipo>();
            Estrella = estrella;
        }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
        public void CargarHabitaciones(int cant, Tipo tipo)
        {
            for (int i = 0; i < cant; i++)
            {
                habs.Add(tipo);
            }
        }
        public void AgregarHabitacion(Habitacion hab)
        {
            habitaciones.Add(hab);
        }
        public void AgregarHabitacion(Tipo unaHabitacion)
        {
            habs.Add(unaHabitacion);
        }
        public Tipo GetTipoHabitacion(int idx)
        {
            return habs[idx];
        }
        public Habitacion GetHabitacion(int i)
        {
            return habitaciones[i];
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>();
            arr.Add(Nombre);
            arr.Add("Hotel");
            arr.Add(Ubicacion);
            arr.Add("-");
            arr.Add(Servicios.Count.ToString());
            arr.Add(Plazas.ToString());
            return arr.ToArray();
        }
    }
}
