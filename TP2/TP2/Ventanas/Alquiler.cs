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
        private List<string[]> renglones = null;
        public Alquiler()
        {
            InitializeComponent();
        }
        private void Alquiler_Load(object sender, EventArgs e)
        {
            try
            {
                renglones = Funciones_Adicionales.LeerSeparandoArchivo("..//..//Data//propiedades.csv", ";");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo propiedades.csv");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgView.RowCount = 0;
            foreach (string[] unRenglon in renglones)
            {
                dgView.Rows.Add(unRenglon);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
