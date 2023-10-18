using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP2
{
    public class Casa : Propiedad
    {
        public string Propietario { get; protected set; }
        public Casa(string nombre, string ubicacion, int plazas, List<string> servicios, string propietario) : base(nombre, ubicacion,plazas,servicios)
        {
            Propietario = propietario;
        }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>();
            arr.Add(Nombre);
            arr.Add("Casa");
            arr.Add(Ubicacion);
            arr.Add(Propietario);
            arr.Add(Servicios.Count.ToString());
            arr.Add(Plazas.ToString());
            return arr.ToArray();
        }
    }
}
