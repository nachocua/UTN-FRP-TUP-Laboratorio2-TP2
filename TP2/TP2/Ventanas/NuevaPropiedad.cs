﻿using System;
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
            gbCasa.Enabled = true;
            gbHotel.Enabled = false;
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
                    gbCasa.Enabled = false;
                    gbHotel.Enabled = true;
                    break;
                default:
                    gbCasa.Enabled = true;
                    gbHotel.Enabled = false;
                    break;
            }

        }
        public List<string> ObtenerServicios()
        {
            List<string> list = new List<string>();
            foreach (Control c in gbServicios.Controls)
            {
                if (c is CheckBox)
                {
                    if ( ( (CheckBox) c ).Checked)
                    {
                        list.Add(c.Text);
                    }
                }
            }
            return list;
        }
    }
}
