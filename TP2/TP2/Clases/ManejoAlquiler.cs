using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ManejoAlquiler
    {
        private int ReservasTotales = 0;
        private List<Propiedad> propiedades;
        public int CantidadPropidades => propiedades.Count;
        public ManejoAlquiler() 
        {
            propiedades = new List<Propiedad>();
        }
        public void Reservar()
        {
            ReservasTotales++;
        }
        public void AgregarPropiedad(Propiedad propiedad)
        {
            propiedades.Add(propiedad);
        }
        public void AgregarHotel(Hotel unHotel)
        {
            propiedades.Add(unHotel);
        }
        public void AgregarCasa(Casa unaCasa)
        {
            propiedades.Add(unaCasa);
        }
        public Propiedad getPropiedad(int i)
        {
            return propiedades[i];
        }
    }
}