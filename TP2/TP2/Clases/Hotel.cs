using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Hotel : Propiedad
    {
        List<Habitacion> habitaciones;
        public Hotel(string nombre, string ubicacion, int plazas, List<string> servicios) : base(nombre, ubicacion,plazas,servicios)
        {
            habitaciones = new List<Habitacion>();
        }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
        public void AgregarHabitacion(Habitacion hab)
        {
            habitaciones.Add(hab);
        }
        public Habitacion GetHabitacion(int i) 
        {
            return habitaciones[i];
        }
        public override string[] getData()
        {
            throw new NotImplementedException();
        }
    }
}
