using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Ej-> Casa;0;La huerta de Tony;Parana;4;Wifi*Cochera;Tony;img1;img2;img3
//     TipoPropiedad;idPropiedad; nombre; Ciudad; Plazas; Servicios; Dueño; imagenes....

namespace TP2
{
    [Serializable]
    public class Casa : Propiedad
    {
        public string Propietario { get; protected set; }
        public Casa(int id, string nombre, string ubicacion, int plazas, List<string> servicios,
            string propietario) : base(id, nombre, ubicacion, plazas, servicios)
        {
            Propietario = propietario;
        }
        public void ModificarDatos(string nombre, string ubicacion, int plazas, string propietario)
        {
            Nombre = nombre;
            Ciudad = ubicacion;
            Plazas = plazas;
            Propietario = propietario;
        }
        public override double Costo(int dias, int observación = 0)
        {
            double costo = (Precio * Servicios.Count * Plazas);
            costo = dias > 1 ? costo * 0.10 * dias : costo;
            return costo;
        }
        public override void EstablecerCosto(double costo)
        {
            Precio = costo;
        }
        public override string[] getData()
        {
            string[] arr = new string[]
            {
                idPropiedad.ToString(),
                Nombre,
                "Casa",
                Ciudad,
                Propietario,
                string.Join(", ",Servicios),
                Plazas.ToString()
            };
            return arr;
        }
        public override string ToString()
        {
            string datos = "Casa;" + idPropiedad.ToString() + ";" + Nombre + ";" + Ciudad + ";"
                + Plazas.ToString() + ";" + Servicios[0];
            if (Servicios.Count > 1)
            {
                for (int i = 1; i < Servicios.Count; i++)
                {
                    datos += "*" + Servicios[i];
                }
            }
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
            return datos;
        }
    }
}