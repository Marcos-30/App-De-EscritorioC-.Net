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
    
    public partial class FrmApp : Form
    {
        private List<Articulos> listaArticulos;
        public FrmApp() 
        {
            InitializeComponent();
        }

        private void FrmApp_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            listaArticulos = datos.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulos agregar = new AgregarArticulos();
            agregar.ShowDialog();
        }
    }
}
