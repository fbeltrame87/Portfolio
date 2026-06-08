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
        private List<Articulo> listaCompleta;
        private List<Articulo> listaArticulo;
        private int paginaActual = 1;      
        private int registrosPorPagina = 12;

        public FormGestorComercio()
        {
            InitializeComponent();
        }

        private void FormGestorComercio_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            cargar();
            ocultarColumnas();
            ocultarFiltroAvanzado(true);
            cboBoxCampo.Items.Add("Categoria");
            cboBoxCampo.Items.Add("Marca");
            cboBoxCampo.Items.Add("Precio");
        }

        //Método privado para cargar o recargar la grilla
        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaCompleta = articuloNegocio.listar();
                if(listaCompleta != null && listaCompleta.Count > registrosPorPagina)
                {
                    btnAnterior.Visible = true;
                    btnSiguiente.Visible = true;
                    lblPagActual.Visible = true;

                    listaArticulo = listaCompleta
                                .Skip((paginaActual - 1) * registrosPorPagina)
                                .Take(registrosPorPagina)
                                .ToList();

                    btnAnterior.Enabled = (paginaActual > 1);

                    int totalPaginas = (int)Math.Ceiling((double)listaCompleta.Count / registrosPorPagina);
                    btnSiguiente.Enabled = (paginaActual < totalPaginas);
                    lblPagActual.Text = $"Página {paginaActual} de {totalPaginas}";
                }
                else
                {
                    btnAnterior.Enabled = true;
                    btnSiguiente.Enabled = true;
                    lblPagActual.Visible = false;

                    listaArticulo = listaCompleta;
                }

                dgvGestorComercio.DataSource = listaArticulo;
                dgvGestorComercio.Columns["Precio"].DefaultCellStyle.Format = "0.00";
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
            if(dgvGestorComercio.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevoArticulo nuevo = new FormNuevoArticulo();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGestorComercio.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un artículo de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el artículo seleccionado.");
                return;
            }

            FormNuevoArticulo modificar = new FormNuevoArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarExistencia_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (dgvGestorComercio.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un artículo de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el artículo seleccionado.");
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmas que quieres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                    return;

                string campo = cboBoxCampo.SelectedItem.ToString();
                string criterio = cboBoxCriterio.SelectedItem.ToString();
                string filtro = txtBoxFiltroAvanzado.Text;
                dgvGestorComercio.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Métodos manipulación de texto filtrado, campo y criterio
        private void txtBoxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBoxFiltroRapido.Text;

            if (filtro.Length >= 3)
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.marcaArticulo.Descripcion.ToLower().Contains(filtro.ToLower()));
            else
                listaFiltrada = listaArticulo;

            dgvGestorComercio.DataSource = null;
            dgvGestorComercio.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboBoxCampo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Menor a");
                cboBoxCriterio.Items.Add("Igual a");
                cboBoxCriterio.Items.Add("Mayor a");
            }
            else
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con");
                cboBoxCriterio.Items.Add("Termina con");
                cboBoxCriterio.Items.Add("Contiene");
            }
        }

        //Métodos para posible clase Helper
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
            dgvGestorComercio.Columns["Codigo"].Visible = false;
            dgvGestorComercio.Columns["Descripcion"].Visible = false;
        }

        private void ocultarFiltroAvanzado(bool activado)
        {
            if (activado)
            {
                lblLimpiar.Visible = false;
                btnLimpiarFiltro.Visible = false;
                lblCampo.Visible = false;
                cboBoxCampo.Visible = false;
                lblCriterio.Visible = false;
                cboBoxCriterio.Visible = false;
                lblSeparador.Visible = false;
                lblFiltroAvanzado.Visible = false;
                txtBoxFiltroAvanzado.Visible = false;
            }
            else
            {
                lblLimpiar.Visible = true;
                btnLimpiarFiltro.Visible = true;
                lblCampo.Visible = true;
                cboBoxCampo.Visible = true;
                lblCriterio.Visible = true;
                cboBoxCriterio.Visible = true;
                lblSeparador.Visible = true;
                lblFiltroAvanzado.Visible = true;
                txtBoxFiltroAvanzado.Visible = true;
            }
            
        }

        //Métodos de validación/clase Helper
        private bool validarFiltro()
        {
            if (cboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, antes seleccione el campo para filtrar.");
                return true;
            }

            if (cboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, antes seleccione el criterio para filtrar.");
                return true;
            }

            if (cboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtBoxFiltroAvanzado.Text)) && decimal.Parse(txtBoxFiltroAvanzado.Text) < 0)
                {
                    MessageBox.Show("Ingrese solo números, y que estos sean positivos, como Precio, por favor.");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if(dgvGestorComercio.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;

                if(seleccionado != null)
                {
                    FormNuevoArticulo formDetalleArticulo = new FormNuevoArticulo(seleccionado, true);
                    formDetalleArticulo.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione un articulo, por favor.", "Atención");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaActual--;
            cargar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            cargar();
        }

        private void btnIrAFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ocultarFiltroAvanzado(false);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxFiltroAvanzado.Text = "";
            txtBoxFiltroRapido.Text = "";
        }

        private void FormGestorComercio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && !txtBoxFiltroAvanzado.Focused && !txtBoxFiltroRapido.Focused)
            {
                btnLimpiarFiltro_Click(sender, e);

                // Damos aviso del uso de la tecla.
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtBoxFiltroAvanzado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
