using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
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
        public int Estrella { get; private set; }
        public int Simple { get; private set; }
        public int Doble { get; private set; }
        public int Triple { get; private set; }
        
        public Hotel(int id, string nombre, string ubicacion, int plazas, List<string> servicios, int estrella) : base(id, nombre, ubicacion, plazas, servicios)
        {
            Estrella = estrella;
        }
        public void ModificarDatos(string nombre, string ubicacion, int estrella, int simples, int dobles, int triples)
        {
            Nombre = nombre;
            Ciudad = ubicacion;
            Estrella = estrella;
            Plazas = simples + dobles + triples;
            CargarHabitaciones(simples, dobles, triples);
        }
        public void CargarHabitaciones(int simple, int doble, int triple)
        {
            Simple = simple;
            Doble = doble;
            Triple = triple;
        }
        public override void EstablecerCosto(double costo)
        {
            Precio = costo;
        }
        public override double Costo(int dias)
        {
            return Precio * (dias * 1.03); // 3% adicional por cada dia | Implementar el resto
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>
            {
                idPropiedad.ToString(),
                Nombre,
                "Hotel",
                Ciudad,
                "-",
                string.Join(", ",Servicios),
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
