using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Ej-> 0;La huerta de Tony;Parana;4;Wifi*Cochera;Tony;img1;img2;img3
//     idPropiedad; nombre; Ciudad; Plazas; Servicios; Dueño; imagenes....

namespace TP2
{
    public class Casa : Propiedad
    {
        public string Propietario { get; protected set; }
        public Casa(string nombre, string ubicacion, int plazas, List<string> servicios,
            string propietario) : base(nombre, ubicacion, plazas, servicios)
        {
            Propietario = propietario;
        }
        public override double Costo(int dias)
        {
            //Implementar
            return 0;
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>();
            arr.Add(Nombre);
            arr.Add("Casa");
            arr.Add(Ciudad);
            arr.Add(Propietario);
            arr.Add(Servicios.Count.ToString());
            arr.Add(Plazas.ToString());
            return arr.ToArray();
        }
    }
}
