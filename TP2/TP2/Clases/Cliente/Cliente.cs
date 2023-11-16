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
    public class Cliente : IComparable
    {
        public Stack<int> IdReservas { get; }
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
            IdReservas = new Stack<int>();
        }
        public void AgregarReserva(int idReserva)
        {
            IdReservas.Push(idReserva);
        }
        public override string ToString()
        {
            int[] arr = IdReservas.ToArray();
            string datosCliente = Dni.ToString() + ";" +
                Telefono.ToString() + ";" +
                Nombres + ";" +
                Apellidos + ";";
            if (arr.Length > 0)
            {
                datosCliente += arr[0];
                if (arr.Length > 1)
                {
                    foreach (int id in arr)
                    {
                        datosCliente += "*" + id;
                    }
                }
            }
            return datosCliente;
        }
        public int CompareTo(Object obj)
        {
            return Dni.CompareTo(((Cliente)obj).Dni);
        }
    }
}
