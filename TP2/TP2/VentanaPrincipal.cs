using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace TP2
{
    public partial class VentanaPrincipal : Form
    {
        ManejoAlquiler elSistema;
        public VentanaPrincipal()
        {
            InitializeComponent();
            elSistema = new ManejoAlquiler();
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            Alta_Cliente ventanaCliente = new Alta_Cliente();
            if (ventanaCliente.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
