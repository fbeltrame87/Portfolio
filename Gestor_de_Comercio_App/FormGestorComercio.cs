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
using CapaNegocio;

namespace Gestor_de_Comercio_App
{
    public partial class FormGestorComercio : Form
    {
        private List<Articulo> listaArticulo;

        public FormGestorComercio()
        {
            InitializeComponent();
        }

        private void FormGestorComercio_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = articuloNegocio.listar();
                dgvGestorComercio.DataSource = listaArticulo;
                cargarImagen(listaArticulo[0].ImagenUrl);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvGestorComercio_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxImagenArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTFlhSWwrzGBZnqDlW7uLEEJWBhFc8sW_Ruw&s");
            }
        }

        private void ocultarColumnas()
        {
            dgvGestorComercio.Columns["ImagenUrl"].Visible = false;
            dgvGestorComercio.Columns["Id"].Visible = false;
        }
    }
}
