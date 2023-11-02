using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ManejoAlquiler
    {
        private List<Propiedad> propiedades;
        private List<Cliente> clientes;
        private List<Reserva> reservas;
        public ManejoAlquiler(string FileNamePropiedades = null, string FileNameClientes = null, string FileNameReservas = null)
        {
            if (FileNamePropiedades != null)
            {
                InitPropiedades(FileNamePropiedades);
            }
            else
            {
                propiedades = new List<Propiedad>();
            }
            if (FileNameClientes != null)
            {
                InitClientes(FileNameClientes);
            }
            else
            {
                clientes = new List<Cliente>();
            }
            if (FileNameReservas != null)
            {
                InitPropiedades(FileNameReservas);
            }
            else
            {
                reservas = new List<Reserva>();
            }
        }
        private void InitPropiedades(string nameFilePropiedades)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(nameFilePropiedades, FileMode.Open))
            {
                propiedades = (List<Propiedad>)bf.Deserialize(fs);
            }
        }
        private void InitClientes(string nameFileClientes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(nameFileClientes, FileMode.Open))
            {
                clientes = (List<Cliente>)bf.Deserialize(fs);
            }
        }
        private void InitReservas(string nameFileClientes)
        {
            // Completar por csv
        }
        public int CantidadPropidades()
        {
            return propiedades.Count;
        }
        public List<string> GetStringPropiedades()
        {
            List<string> datosPropiedades = new List<string>();
            foreach (Propiedad unaPropiedad in propiedades)
            {
                datosPropiedades.Add(unaPropiedad.ToString());
            }
            return datosPropiedades;
        }
        public List<string> GetStringClientes()
        {
            List<string> datosClientes = new List<string>();
            foreach (Cliente unCliente in clientes)
            {
                datosClientes.Add(unCliente.ToString());
            }
            return datosClientes;
        }
        public List<string> GetStringReservas()
        {
            List<string> datosReservas = new List<string>();
            foreach (Reserva unaReserva in reservas)
            {
                datosReservas.Add(unaReserva.ToString());
            }
            return datosReservas;
        }
        public List<Propiedad> GetPropiedades()
        {
            return propiedades;
        }
        public void AgregarPropiedad(Propiedad propiedad)
        {
            propiedades.Add(propiedad);
        }
        public Propiedad getPropiedad(int i)
        {
            StringBuilder datosAExportar = new StringBuilder();
            foreach (Propiedad unaPropiedad in propiedades)
            {

            }
            return propiedades[i];
        }
    }
}