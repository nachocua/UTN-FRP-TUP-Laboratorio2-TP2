using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private int dni;
        private int telefono;
        private string email;
        private List<int> idReservas = null;
        public int Dni
        {
            get
            {
                return dni;
            }
            private set
            {
                if (value < 1000000 || value > 99999999)
                {
                    throw new ArgumentException("DNI inválido");
                }
                else
                {
                    dni = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            private set
            {
            }
        }
        public int Telefono
        {
            get
            {
                return telefono;
            }
            private set
            {
            }
        }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public Cliente(int dni)
        {
            Dni = dni;
            List<int> idReserva = new List<int>();
        }
        public void AgregarReserva(int idReserva)
        {
            idReservas.Add(idReserva);
        }
    }
}
