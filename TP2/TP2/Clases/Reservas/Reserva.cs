using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public class Reserva
    {
        private string[] posiblesEstados = { "Reservado", "Ocupado", "Concretado", "Cancelada" };
        public int NroReserva { get; private set; }
        public int NroPropiedad { get; private set; }
        public int NroCliente { get; private set; }
        public string Estado { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public int CantDias { get; private set; }
        public double Costo { get; private set; }
        public Reserva(int reservasEfectuadas, int idCliente, int idPropiedad, DateTime fechaDesde, int cantDias, double costo)
        {
            NroReserva = reservasEfectuadas;
            reservasEfectuadas++;
            NroCliente = idCliente;
            NroPropiedad = idPropiedad;
            Estado = posiblesEstados[0];
            FechaInicio = fechaDesde;
            CantDias = cantDias;
            Costo = costo;
        }
        public void CheckIn()
        {
            Estado = posiblesEstados[1];
        }
        public void Checkout()
        {
            Estado = posiblesEstados[2];
        }
        public void Cancelar()
        {
            Estado = posiblesEstados[3];
        }
        public override string ToString()
        {
            string datosReserva = NroReserva.ToString() + ";" + NroPropiedad.ToString() + ";" +
                NroCliente.ToString() + ";" + Estado + ";" + FechaInicio.ToString() + ";" +
                CantDias.ToString();
            return datosReserva;
        }
    }
}
