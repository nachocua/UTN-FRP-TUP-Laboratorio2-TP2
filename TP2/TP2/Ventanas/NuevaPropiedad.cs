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
    public partial class NuevaPropiedad : Form
    {
        public NuevaPropiedad()
        {
            InitializeComponent();
            gbCasa.Visible = true;
            gbHotel.Visible = false;
            rbCasa.Checked = true;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

        }
        private void CambiarGroupBox(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Hotel":
                    gbCasa.Visible = false;
                    gbHotel.Visible = true;
                    break;
                default:
                    gbCasa.Visible = true;
                    gbHotel.Visible = false;
                    break;
            }

        }
    }
}
