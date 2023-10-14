using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
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
                Regex expRegular = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                if (expRegular.IsMatch(value))
                {
                    email = value;
                }
                else
                {
                    throw new InvalidCredentialException("El correo no tiene el formato correcto");
                }
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
                if (value.ToString().Length == 16)
                {
                    telefono = value;
                }
                else
                {
                    throw new InvalidCredentialException("El número de telefono debe tener 16 digitos");
                }
            }
        }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public Cliente(int dni)
        {
            Dni = dni;
            idReservas = new List<int>();
        }
        public void AgregarReserva(int idReserva)
        {
            idReservas.Add(idReserva);
        }
    }
}
