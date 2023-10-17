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
        public int CantCamas { get; protected set; }
        public Casa(string nombre, string ubicacion, string propietario, List<string> servicios, int cantCamas) : base(nombre, ubicacion, propietario)
        {
            Servicios = servicios;
            CantCamas = cantCamas;
        }
        public List<string> Servicios { get; protected set; }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
        public override string[] getData()
        {
            List<string> arr = new List<string>();
            arr.Add(Nombre);
            arr.Add(Ubicacion);
            arr.Add(Propietario);
            arr.Add(Servicios.Count.ToString());
            arr.Add(CantCamas.ToString());
            return arr.ToArray();
        }
    }
}
