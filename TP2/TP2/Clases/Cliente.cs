using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP2
{
    [Serializable]
    public class Cliente
    {
        private List<int> idReservas = null;
        public int Dni { get; private set; }
        public int Telefono { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public Cliente(int dni, string nombres, string apellidos, int nroTelefono)
        {
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = nroTelefono;
            idReservas = new List<int>();
        }
        public void AgregarReserva(int idReserva)
        {
            idReservas.Add(idReserva);
        }
    }
}
