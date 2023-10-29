using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ManejoAlquiler
    {
        private List<Propiedad> propiedades;
        private List<Cliente> clientes;
        private List<Reserva> reservas;
        public ManejoAlquiler()
        {
            propiedades = new List<Propiedad>();
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
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
        public List<string> GetStringClientes()
        {
            List<string> datosClientes = new List<string>();
            foreach (Cliente unCliente in clientes)
            {
                datosClientes.Add(unCliente.ToString());
            }
            return datosClientes;
        }
        public List<string> GetStringReservas()
        {
            List<string> datosReservas = new List<string>();
            foreach (Reserva unaReserva in reservas )
            {
                datosReservas.Add(unaReserva.ToString());
            }
            return datosReservas;
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