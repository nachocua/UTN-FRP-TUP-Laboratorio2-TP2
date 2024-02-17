using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TP2
{
    [Serializable]
    public class Reserva : IComparable
    {
        private string[] posiblesEstados = { "Reservado", "Ocupado", "Concretado", "Cancelada" };
        public int NroReserva { get; private set; }
        public int NroPropiedad { get; private set; }
        public List<int> NrosClientes { get; private set; }
        public string Estado { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaHasta { get; private set; }
        public double Costo { get; private set; }
        public Reserva(int reservasEfectuadas, List<int> idsClientes, int idPropiedad, DateTime fechaDesde, DateTime fechaHasta, double costo)
        {
            NroReserva = reservasEfectuadas;
            NrosClientes = new List<int>();
            foreach (int id in idsClientes) 
            {
                NrosClientes.Add(id);
            }
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
            string datosReserva = NroReserva + ";" + NroPropiedad + ";";
            for (int i = 0; i < NrosClientes.Count; i++)
            {
                if (i > 0)
                {
                    datosReserva += "-";
                }
                datosReserva += NrosClientes[i];
            }
            datosReserva += ";" + Estado + ";" + FechaInicio.ToString() + ";" +
                FechaHasta.ToString() + ";" + Costo;
            return datosReserva;
        }
        public int CompareTo(Object obj)
        {
            return NroReserva.CompareTo(((Reserva)obj).NroReserva);
        }
        public string[] GetData()
        {
            return new string[] { NroReserva.ToString(), NroPropiedad.ToString(), FechaInicio.ToShortDateString(), FechaHasta.ToShortDateString(), NrosClientes.Count.ToString(), Estado };
        }
    }
}
