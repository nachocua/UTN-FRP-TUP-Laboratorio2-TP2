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
        public int CantidadPropiedades
        {
            get
            {
                return propiedades.Count;
            }
        }
        public void AgregarPropiedad(Propiedad propiedad)
        {
            propiedades.Add(propiedad);
        }
        public Propiedad GetPropiedad(int i)
        {
            return propiedades[i];
        }
        public int BuscarCliente(Cliente unCliente)
        {
            int indx = -1, i = 0;
            while (indx == -1 && i < clientes.Count)
            {
                if (clientes[i].Dni == unCliente.Dni)
                {
                    indx = i;
                }
                i++;
            }
            return indx;
        }
        public Propiedad BuscarPropiedad(int id)
        {
            Propiedad unaPropiedad = null;
            foreach (Propiedad p in propiedades)
            {
                if (p.idPropiedad == id)
                {
                    unaPropiedad = p;
                    break;
                }
            }
            return unaPropiedad;
        }
        public void AgregarCliente(Cliente unCliente)
        {
            clientes.Add(unCliente);
        }
        public List<Propiedad> GetPropiedades() // Posible funcion a borrar
        {
            return propiedades;
        }
        public string[] InfoCliente(int indx)
        {
            return clientes[indx].ToString().Split(';');
        }
        public string[] InfoReserva(int indx)
        {
            return reservas[indx].ToString().Split(';');
        }
        public int BuscarReserva(Reserva unaReserva)
        {
            int indx = -1, i = 0;
            while (indx == -1 && i < reservas.Count)
            {
                if (reservas[i].NroReserva == unaReserva.NroReserva)
                {
                    indx = i;
                }
                i++;
            }
            return indx;
        }
    }
}