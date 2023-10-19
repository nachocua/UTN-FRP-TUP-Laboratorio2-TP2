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
        public static List<string[]> SplitRenglones(string[] renglon, string delimitador)
        {
            List<string[]> renglones = null;
            if (renglon != null)
            {
                renglones = new List<string[]>();
                string[] partes;
                foreach (string unResultado in renglon)
                {
                    partes = unResultado.Split(delimitador.ToCharArray());
                    renglones.Add(partes);
                }
            }
            return renglones;
        }
        public static List<string[]> LeerSeparandoArchivo(string nombreArchivo, string delimitador)
        {
            return SplitRenglones(LeerArchivo(nombreArchivo), delimitador);
        }
    }
}
