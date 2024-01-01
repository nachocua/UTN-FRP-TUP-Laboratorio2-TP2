using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Clases.Login
{
    [Serializable]
    public class SistemaLogin
    {
        private List<Login> datosLogins;
        private string FileUsPass;
        public SistemaLogin(string FileNameUsPass) 
        {
            datosLogins = new List<Login>();
            FileUsPass = FileNameUsPass;
            Import();
        }
        public void AgregarUsuario(Login unUsuario)
        {
            datosLogins.Add(unUsuario);
        }
        public void Import()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(FileUsPass, FileMode.OpenOrCreate);
            try
            {
                datosLogins = (List<Login>)bf.Deserialize(fs);
            }
            catch
            {

            }
            fs.Close();
        }
        public void Export() 
        {
            BinaryFormatter bf;
            FileStream fs;
            bf = new BinaryFormatter();
            fs = new FileStream(FileUsPass, FileMode.OpenOrCreate);
            try
            {
                bf.Serialize(fs, datosLogins);
            }
            catch
            {

            }
            fs.Close();
        }
        public int ValidarUsuario (Login unUsuario)
        {
            int idRol = 0; 
            int indx = -1, i = 0;
            while (indx == -1 && i < datosLogins.Count)
            {
                if (datosLogins[i].Usuario == unUsuario.Usuario)
                {
                    indx = i;
                    if (datosLogins[indx].Password == unUsuario.Password)
                    {
                        idRol = datosLogins[indx].RolId;
                    }
                }
                i++;
            }
            return idRol;
        }
    }
}