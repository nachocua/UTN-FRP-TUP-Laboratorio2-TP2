﻿using Biblioteca;
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
        public int[] CantidadPersonas { get; private set; }
        public int CantidadCasas { get; private set; }
        public int CantidadHoteles { get; private set; }
        public int CantidadCasasFinde { get; private set; }
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
            /*
            CantidadCasas = 0;
            CantidadCasasFinde = 0;
            CantidadHoteles = 0;
            */
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
            /*
            List<string[]> datosReservas = Funciones_Adicionales.LeerSeparandoArchivo(FileReservas, ";");
            foreach (string[] unDato in datosReservas)
            {
                int idReserva = Convert.ToInt32(unDato[0]);
                int idPropiedad = Convert.ToInt32(unDato[1]);
                string[] dnis = unDato[2].Split('-');
                List<int> idsClientes = new List<int>();
                for (int i = 0; i < dnis.Length; i++)
                {
                    idsClientes.Add(Convert.ToInt32(dnis[i]));
                }
                string[] fecha = unDato[4].Split(' ')[0].Split('/');
                string[] fecha2 = unDato[5].Split(' ')[0].Split('/');
                DateTime fechaDesde = new DateTime(Convert.ToInt32(fecha[2]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[0]));
                DateTime fechaHasta = new DateTime(Convert.ToInt32(fecha2[2]), Convert.ToInt32(fecha2[1]), Convert.ToInt32(fecha2[0]));
                int cantDias = (fechaHasta - fechaDesde).Days;
                double costo = Convert.ToInt32(unDato[6]);
                Reserva unaReserva = new Reserva(idReserva, idsClientes, idPropiedad, fechaDesde, fechaHasta, costo);
                switch (unDato[3])
                {
                    case "Ocupado":
                        unaReserva.CheckIn();
                        break;
                    case "Concretado":
                        unaReserva.Checkout();
                        break;
                    case "Cancelada":
                        unaReserva.Cancelar();
                        break;
                }
                NuevaReserva(unaReserva, false);
            }
            */
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
            //Exportar Reservas
            /*StreamWriter sw = new StreamWriter(FileReservas, true);
            foreach (Reserva unaReserva in reservas)
            {
                sw.WriteLine(unaReserva.ToString());
            }
            sw.Close();*/
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
            switch (propiedad.GetType().Name)
            {
                case "Casa":
                    CantidadCasas++;
                    break;
                case "Hotel":
                    CantidadHoteles++;
                    break;
                case "CasaFinSemana":
                    CantidadCasasFinde++;
                    break;
                default:
                    break;
            }
        }
        public void ContarPropiedades() // PARCHE PARA CONTAR LAS PROPIEDADES YA CARGADAS
        {
            CantidadCasas = 0;
            CantidadCasasFinde = 0;
            CantidadHoteles = 0;
            foreach (Propiedad unaPropiedad in propiedades)
            {
                switch (unaPropiedad.GetType().Name)
                {
                    case "Casa":
                        CantidadCasas++;
                        break;
                    case "Hotel":
                        CantidadHoteles++;
                        break;
                    case "CasaFinSemana":
                        CantidadCasasFinde++;
                        break;
                    default:
                        break;
                }
            }
        }
        private void ContarClientes()
        {
            CantidadPersonas = new int[5];
            for (int i = 0; i < 5; i++)
            {
                CantidadPersonas[i] = 0;
            }
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
        public List<Propiedad> GetPropiedades() // Posible funcion a borrar
        {
            return propiedades;
        }
        public Cliente GetCliente(int idx)
        {
            return clientes[idx];
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
        }
        public int CantidadClientes()
        {
            return clientes.Count;
        }
    }
}