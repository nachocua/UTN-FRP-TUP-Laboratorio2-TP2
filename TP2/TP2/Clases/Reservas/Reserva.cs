using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public class Reserva : IComparable
    {
        private string[] posiblesEstados = { "Reservado", "Ocupado", "Concretado", "Cancelada" };
        public int NroReserva { get; private set; }
        public int NroPropiedad { get; private set; }
        public int NroCliente { get; private set; }
        public string Estado { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaHasta { get; private set; }
        public double Costo { get; private set; }
        public Reserva(int reservasEfectuadas, int idCliente, int idPropiedad, DateTime fechaDesde, DateTime fechaHasta, double costo)
        {
            NroReserva = reservasEfectuadas;
            NroCliente = idCliente;
            NroPropiedad = idPropiedad;
            Estado = posiblesEstados[0];
            FechaInicio = fechaDesde;
            FechaHasta = fechaHasta;
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
                FechaHasta.ToString() + ";" + Costo.ToString();
            return datosReserva;
        }
        public int CompareTo(Object obj)
        {
            return NroReserva.CompareTo(((Reserva)obj).NroReserva);
        }
    }
}
