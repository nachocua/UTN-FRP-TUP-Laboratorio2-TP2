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
    public partial class MostrarDatos : Form
    {
        List<Propiedad> propiedades;
        public MostrarDatos(ManejoAlquiler unSistema)
        {
            InitializeComponent();
            propiedades = unSistema.Propiedades;
        }
        private void BuscarPropiedadesConServicios()
        {
            // Obtén los servicios seleccionados desde los CheckBox.
            List<string> serviciosSeleccionados = new List<string>();

            foreach (Control control in gbServicios.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (checkBox.Checked)
                    {
                        serviciosSeleccionados.Add(checkBox.Text);
                    }
                }
            }

            // Utiliza LINQ para filtrar las propiedades que tienen los servicios seleccionados.
            var propiedadesFiltradas = propiedades.Where(propiedad => propiedad.Servicios.All(servicio => serviciosSeleccionados.Contains(servicio)));

            // Limpia el DataGridView.
            dgView.Rows.Clear();

            // Agrega las propiedades filtradas al DataGridView.
            foreach (var propiedad in propiedadesFiltradas)
            {
                dgView.Rows.Add(propiedad.Nombre, " - ", propiedad.Ciudad, " - ", string.Join(", ", propiedad.Servicios), propiedad.Plazas.ToString());
            }
        }

        //private void BuscarPropiedadesConServicios()
        //{
        //    // Obtén los servicios seleccionados desde los CheckBox.
        //    List<string> serviciosSeleccionados = new List<string>();

        //    foreach (Control control in gbServicios.Controls)
        //    {
        //        if (control is CheckBox)
        //        {
        //            CheckBox checkBox = (CheckBox)control;
        //            if (checkBox.Checked)
        //            {
        //                serviciosSeleccionados.Add(checkBox.Text);
        //            }
        //        }
        //    }

        //    // Utiliza LINQ para filtrar las propiedades que tienen los servicios seleccionados.
        //    var propiedadesFiltradas = propiedades.Where(propiedad => propiedad.Servicios.All(servicio => serviciosSeleccionados.Contains(servicio)));

        //    // Limpia el DataGridView.
        //    dgView.Rows.Clear();

        //    // Agrega las propiedades filtradas al DataGridView.
        //    foreach (var propiedad in propiedadesFiltradas)
        //    {
        //        dgView.Rows.Add(propiedad.Nombre," - ", propiedad.Ciudad," - ", string.Join(", ", propiedad.Servicios), propiedad.Plazas.ToString());
        //    }
        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPropiedadesConServicios();
        }
    }
}
