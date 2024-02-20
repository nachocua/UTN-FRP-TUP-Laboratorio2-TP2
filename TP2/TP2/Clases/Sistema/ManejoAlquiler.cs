using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Clases;

namespace TP2
{
    public class ManejoAlquiler : IExportable
    {
        private List<Propiedad> propiedades;
        private List<Cliente> clientes;
        private List<Reserva> reservas;
        private string FilePropiedades;
        private string FileClientes;
        private string FileReservas;
        public int[] CantidadPersonas { get; private set; }
        public int[] CantidadPorTipoPropiedad { get; private set; }
        public int CantidadPropiedades
        {
            get
            {
                return propiedades.Count;
            }
        }
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
            //Deserealizar Reservas
            bf = new BinaryFormatter();
            fs = new FileStream(FileReservas, FileMode.OpenOrCreate);
            try
            {
                reservas = (List<Reserva>)bf.Deserialize(fs);
            }
            catch
            {
            }
            fs.Close();
            //Conteo de propiedades
            ContarPropiedades();
            ContarClientes();
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
            //Serealizar Clientess
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
            //Serealizar Reservas
            bf = new BinaryFormatter();
            fs = new FileStream(FileReservas, FileMode.OpenOrCreate);
            try
            {
                bf.Serialize(fs, reservas);
            }
            catch
            {

            }
            fs.Close();
        }
        public void AgregarPropiedad(Propiedad propiedad)
        {
            propiedades.Add(propiedad);
        }
        public void ContarPropiedades() // PARCHE PARA CONTAR LAS PROPIEDADES YA CARGADAS
        {
            CantidadPorTipoPropiedad = new int[2];
            foreach (Reserva unaReserva in reservas)
            {
                switch (propiedades[unaReserva.NroPropiedad].GetType().Name)
                {
                    case "Hotel":
                        CantidadPorTipoPropiedad[0]++;
                        break;
                    default:
                        CantidadPorTipoPropiedad[1]++;
                        break;
                }
            }
        }
        private void ContarClientes()
        {
            CantidadPersonas = new int[5];
            foreach (Reserva unaReserva in reservas)
            {
                if (unaReserva.NrosClientes.Count >= 6)
                {
                    CantidadPersonas[4]++;
                }
                else
                {
                    if (unaReserva.NrosClientes.Count > 1)
                    {
                        CantidadPersonas[unaReserva.NrosClientes.Count - 2]++;
                    }
                }
            }
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
        public Cliente GetCliente(int idx)
        {
            return clientes[idx];
        }
        public Reserva GetReserva(int idx)
        {
            return reservas[idx];
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
        public int cantidadReservas()
        {
            return reservas.Count;
        }
        public void NuevaReserva(Reserva unaReserva, bool noImport = true)
        {
            reservas.Add(unaReserva);
            if (noImport)
            {
                int i = 0;
                bool noEncontrado = true;
                foreach (int NroCliente in unaReserva.NrosClientes)
                {
                    while (i < clientes.Count && noEncontrado)
                    {

                        if (clientes[i].Dni == NroCliente)
                        {
                            clientes[i].AgregarReserva(unaReserva.NroReserva);
                            noEncontrado = false;
                        }
                        i++;
                    }
                }
                noEncontrado = true;
                i = 0;
                while (i < propiedades.Count && noEncontrado)
                {
                    if (propiedades[i].idPropiedad == unaReserva.NroPropiedad)
                    {
                        propiedades[i].AgregarReserva(unaReserva.NroReserva);
                        noEncontrado = false;
                    }
                    i++;
                }
            }
            if (unaReserva.NrosClientes.Count >= 6)
            {
                CantidadPersonas[4]++;
            }
            else
            {
                if (unaReserva.NrosClientes.Count > 1)
                {
                    CantidadPersonas[unaReserva.NrosClientes.Count - 2]++;
                }
            }
            if (propiedades[unaReserva.NroPropiedad].GetType().Name == "Hotel")
            {
                CantidadPorTipoPropiedad[0]++;
            }
            else
            {
                CantidadPorTipoPropiedad[1]++;
            }
        }
        public int CantidadClientes()
        {
            return clientes.Count;
        }
        public void Exportable()
        {
            string[] datos = null;
            SaveFileDialog unSaveFileDialog = new SaveFileDialog();
            unSaveFileDialog.Filter = "Archivo separado por comas|*.csv";
            unSaveFileDialog.Title = "Exportar datos de propiedad";
            if (unSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(unSaveFileDialog.FileName);
                for (int i = 0; i < clientes.Count; i++)
                {
                    datos = InfoCliente(i);
                    sr.WriteLine("c;" + datos[0] + ";" + datos[2] + ";" + datos[3]);
                }
                for (int i = 0; i < reservas.Count; i++)
                {
                    datos = InfoReserva(i);
                    sr.WriteLine("r;" + datos[0] + ";" + datos[1] + ";" + datos[3] + ";" + datos[4]);
                }
                sr.Close();
            }
        }
        public void EliminarReserva(Reserva reservaARemover)
        {
            reservas.Remove(reservaARemover);
            propiedades[reservaARemover.NroPropiedad].Clean(reservaARemover.NroReserva);
            Cliente clienteABuscar = null;
            foreach(int idCliente in reservaARemover.NrosClientes) 
            {
                clienteABuscar = new Cliente(idCliente, "", "", 0, DateTime.Now);
                clientes[BuscarCliente(clienteABuscar)].Clean(reservaARemover.NroReserva);
            }
            
        }
    }
}