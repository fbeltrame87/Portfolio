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
    public partial class FormNuevoArticulo : Form
    {
        public FormNuevoArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevoArticulo.Codigo = txtBoxCodigo.Text;
                nuevoArticulo.Nombre = txtBoxNombre.Text;
                nuevoArticulo.Descripcion = txtBoxDescripcion.Text;
                nuevoArticulo.categoriaArticulo = (Categoria)cboBoxCategoria.SelectedItem;
                nuevoArticulo.marcaArticulo = (Marca)cboBoxMarca.SelectedItem;

                nuevoArticulo.ImagenUrl = txtBoxImagenUrl.Text;

                nuevoArticulo.Precio = decimal.Parse(txtBoxPrecio.Text);

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("¡Agregado exitoso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormNuevoArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();

            try
            {
                cboBoxCategoria.DataSource = negocioCategoria.listar();
                cboBoxMarca.DataSource = negocioMarca.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxNuevaImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxNuevaImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTFlhSWwrzGBZnqDlW7uLEEJWBhFc8sW_Ruw&s");
            }
        }
    }
}
