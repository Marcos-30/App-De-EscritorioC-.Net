using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class AgregarArticulos : Form
    {
        public AgregarArticulos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos artclo = new Articulos();
            Datos datos = new Datos();

            try
            {
                artclo.Codigo = txtCodigo.Text;
                artclo.Nombre = txtNombre.Text;
                artclo.Descripcion = txtDescripcion.Text;

                datos.agregar(artclo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
