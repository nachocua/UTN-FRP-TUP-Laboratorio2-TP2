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
    public partial class VerClientes : Form
    {
        public string[] clienteSeleccionado = null;
        public VerClientes()
        {
            InitializeComponent();
        }
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if(clienteSeleccionado != null)
            {
                DialogResult = DialogResult.OK;
            }
        }
        private string[] GetRow(DataGridViewRow row)
        {
            List<string> data = new List<string>();
            for (int i = 0; i < row.Cells.Count; i++)
            {
                data.Add(row.Cells[i].Value.ToString());
            }
            return data.ToArray();
        }
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clienteSeleccionado = GetRow(dgView.Rows[e.RowIndex]);
            }
        }
    }
}
