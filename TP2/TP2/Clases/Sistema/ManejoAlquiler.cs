using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public class ManejoAlquiler
    {
        private List<Propiedad> propiedades;
        private List<Cliente> clientes;
        private List<Reserva> reservas;
        private string FilePropiedades;
        private string FileClientes;
        private string FileReservas;
        public ManejoAlquiler(string FileNamePropiedades, string FileNameClientes, string FileNameReservas)
        {
            propiedades = new List<Propiedad>();
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
            BinaryFormatter bf;
            FileStream fs;
            FilePropiedades = FileNamePropiedades;
            FileClientes = FileNameClientes;
            FileReservas = FileNameReservas;
            //Deserealizar Propiedades
            bf = new BinaryFormatter();
            fs = new FileStream(FilePropiedades, FileMode.OpenOrCreate);
            try
            {
                propiedades = (List<Propiedad>)bf.Deserialize(fs);
            }
            catch
            {
            }
            fs.Close();
            //Deserealizar Clientes
            bf = new BinaryFormatter();
            fs = new FileStream(FileClientes, FileMode.OpenOrCreate);
            try
            {
                clientes = (List<Cliente>)bf.Deserialize(fs);
            }
            catch
            {
            }
            fs.Close();
            //Importar Reservas
            //....
        }
        public void Export()
        {
            BinaryFormatter bf;
            FileStream fs;
            //Serealizar Propiedades
            bf = new BinaryFormatter();
            fs = new FileStream(FilePropiedades, FileMode.OpenOrCreate);
            try
            {
                bf.Serialize(fs, propiedades);
            }
            catch
            {

            }
            fs.Close();
            //Serealizar Propiedades
            bf = new BinaryFormatter();
            fs = new FileStream(FileClientes, FileMode.OpenOrCreate);
            try
            {
                bf.Serialize(fs, clientes);
            }
            catch
            {

            }
            fs.Close();
            //Exportar Reservas
            //....
        }
        public int CantidadPropiedades()
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
        public int BuscarCliente(Cliente unCliente)
        {
            return clientes.IndexOf(unCliente);
        }
        public void AgregarCliente(Cliente unCliente)
        {
            clientes.Add(unCliente);
        }
    }
}