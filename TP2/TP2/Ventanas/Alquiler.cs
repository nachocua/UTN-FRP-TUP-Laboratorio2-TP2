using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
        }
        private void Alquiler_Load(object sender, EventArgs e)
        {
            List<string[]> renglones = null;
            try
            {
                renglones = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//propiedades.csv", ";");
            }
            catch 
            {
                MessageBox.Show("No se encontró el archivo propiedades.csv");
            }
            foreach (string[] unRenglon in renglones) 
            {
                dgView.Rows.Add(unRenglon);
            }
        }
    }
}
