using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TP2
{
    [Serializable]
    public abstract class Propiedad : IComparable
    {
        public int idPropiedad { get; protected set; }
        public string Ciudad { get; protected set; }
        public string Nombre { get; protected set; }
        public int Plazas { get; protected set; }
        public List<string> Servicios { get; protected set; }
        protected List<string> imagenes;
        protected List<int> IdReservas { get; }
        public double Precio { get; protected set; }
        public Propiedad(int id, string nombre, string ubicacion, int plazas, List<string> servicios)
        {
            idPropiedad = id;
            Nombre = nombre;
            Ciudad = ubicacion;
            Plazas = plazas;
            Servicios = servicios;
            imagenes = new List<string>();
            IdReservas = new List<int>();
        }
        public void ModificarServicios(string[] servicios)
        {
            Servicios = servicios.ToList();
        }
        public void AgregarReserva(int idReserva)
        {
            IdReservas.Add(idReserva);
        }
        public abstract double Costo(int dias);
        public abstract string[] getData();
        public int CompareTo(object obj)
        {
            return idPropiedad.CompareTo(((Propiedad)obj).idPropiedad);
        }
        public abstract void EstablecerCosto(double costo);
    }
}
