using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2.Ventanas
{
    public partial class AnularReserva : Form
    {
        public int idPropiedad;
        public AnularReserva()
        {
            InitializeComponent();
        }
        private void btnBuscarReservas_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void dgPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBuscarReservas.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idPropiedad = Convert.ToInt32(dgPropiedades[0, e.RowIndex].Value.ToString());
            }
        }

        private void dgReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAnularReserva.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idPropiedad = Convert.ToInt32(dgReservas[0, e.RowIndex].Value.ToString());
            }
        }

        private void btnAnularReserva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
