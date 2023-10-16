using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Reserva
    {
        private int nroPropiedad;
        private int nroReserva;
        private int nroCliente;
        private string estado;
        private string[] posiblesEstados = {"Reservado","Ocupado","Concretado"};
        public int NroReserva
        {
            get
            {
                return nroReserva;
            }
            private set
            {
                nroReserva = value + 1;
            }
        }
        public int NroPropiedadd
        {
            get
            {
                return nroPropiedad;
            }
            private set
            {
                NroPropiedadd = value;
            }
        }
        public int NroCliente
        {
            get
            {
                return nroCliente;
            }
            private set
            {
                nroCliente = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            private set
            {
                if (posiblesEstados.Contains(value))
                {
                    estado = value;
                }
                else
                {
                    throw new Exception("No es un estado posible");
                }
            }
        }
        public Reserva(int ultimaReserva, Cliente cliente, Propiedad propiedad)
        {
            NroReserva = ultimaReserva;
            if (cliente == null)
            {
                throw new ArgumentNullException("Debe asignar un cliente valido");
            }
            else
            {
                NroCliente = cliente.Dni;
            }
            if (propiedad == null)
            {
                throw new ArgumentNullException("Debe asignar una propiedad valida");
            }
            else
            {
                NroCliente = cliente.Dni;
            }
            Estado = posiblesEstados[0];

        }
        public void CheckIn()
        {
            Estado = posiblesEstados[1];
        }
        public void Checkout()
        {
            Estado = posiblesEstados[2];
        }
    }
}
