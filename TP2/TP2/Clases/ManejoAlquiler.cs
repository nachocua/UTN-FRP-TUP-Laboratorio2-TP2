using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ManejoAlquiler
    {
        //private int ReservasTotales = 0;
        private List<Propiedad> propiedades;
        private List<Cliente> clientes;
        private List<Reserva> reservas;
        public ManejoAlquiler()
        {
            propiedades = new List<Propiedad>();
            clientes = new List<Cliente>();
        }
        public int CantidadPropidades()
        {
            return propiedades.Count;
        }
        public List<string> GetStringPropiedades()
        {
            List<string> datosPropiedades = new List<string>();
            foreach (Propiedad unaPropiedad in propiedades)
            {
                datosPropiedades.Add(unaPropiedad.ToString());
            }
            return datosPropiedades;
        }
        public List<Propiedad> GetPropiedades()
        {
            return propiedades;
        }
        public void AgregarPropiedad(Propiedad propiedad)
        {
            propiedades.Add(propiedad);
        }
        public Propiedad getPropiedad(int i)
        {
            StringBuilder datosAExportar = new StringBuilder();
            foreach (Propiedad unaPropiedad in propiedades)
            {

            }
            return propiedades[i];
        }
    }
}