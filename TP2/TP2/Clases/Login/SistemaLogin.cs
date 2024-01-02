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
    public class SistemaLogin
    {
        private List<Login> datosLogins = null;
        private string FileUsPass;
        public SistemaLogin(string FileNameUsPass) 
        {
            datosLogins = new List<Login>();
            FileUsPass = FileNameUsPass;
            Import();
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
        public void AgregarUsuario(Login unUsuario)
        {
            datosLogins.Add(unUsuario);
        }
        public int ValidarUsuario(Login unUsuario)
        {
            int i = 0;
            int indx = -1;
            while (indx == -1 && i < datosLogins.Count)
            {
                if (datosLogins[i].Usuario == unUsuario.Usuario)
                {
                    if (datosLogins[i].Password == unUsuario.Password)
                    {
                        indx = i;
                    }
                }
                i++;
            }
            return indx;
        }
        public int GetRolId(Login unUsuario)
        {
            int idRol = 0;
            int indx = ValidarUsuario(unUsuario);
            if (indx != -1)
            {
                idRol = datosLogins[indx].RolId;
            }
            return idRol;
        }
    }
}