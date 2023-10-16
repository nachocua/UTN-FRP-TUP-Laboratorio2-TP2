using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class Funciones_Adicionales
    {
        public static string[] LeerArchivo(string nombreArchivo)
        {
            string[] resultado = null;
            if (File.Exists(nombreArchivo))
            {
                resultado = File.ReadAllLines(nombreArchivo);
            }
            return resultado;
        }
        public static List<string[]> LeerSeparandoArchivo(string nombreArchivo, string delimitador)
        {
            List<string[]> renglones = new List<string[]>();
            string[] resultado = LeerArchivo(nombreArchivo);
            string[] partes;
            foreach (string unResultado in resultado)
            {
                partes = unResultado.Split(nombreArchivo.ToCharArray());
                renglones.Add(partes);
            }
            return renglones;
        }
    }
}
