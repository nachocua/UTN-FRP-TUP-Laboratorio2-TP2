﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP2
{
    public class Casa : Propiedad
    {
        public int CantCamas { get; protected set; }
        public Casa(string nombre, string ubicacion, string propietario, List<string> servicios, int cantCamas) : base(nombre, ubicacion, propietario)
        {
            Servicios = servicios;
            CantCamas = cantCamas;
        }
        public List<string> Servicios { get; protected set; }
        public override double Costo(int dias)
        {
            throw new NotImplementedException();
        }
        public override string[] getData()
        {
            throw new NotImplementedException();
        }
    }
}
