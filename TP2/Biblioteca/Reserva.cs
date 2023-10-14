using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Reserva
    {
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
        public int NroCliente
        {
            get
            {
                return nroCliente;
            }
            private set
            {
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
        public Reserva(int nroReserva, Cliente cliente, Propiedad propiedad)
        {
            NroReserva = nroReserva;
            if(cliente == null)
            {
                throw new ArgumentNullException("Debe asignar un cliente valido");
            }
            else
            {
                NroCliente = cliente.Dni;
            }
            Estado = "Reservada";

        }
        public void CheckIn()
        {
            Estado = "Ocupado";
        }
        public void Checkout()
        {
            Estado = "Concretado";
        }
    }
}
