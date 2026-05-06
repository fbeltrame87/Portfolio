using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Discos_App
{
    public partial class DiscosApp : Form
    {
        private List<Disco> listaDisco;

        public DiscosApp()
        {
            InitializeComponent();
        }

        private void DiscosApp_Load(object sender, EventArgs e)
        {
            cargar();
            cboBoxCampo.Items.Add("Título");
            cboBoxCampo.Items.Add("Artista");
            cboBoxCampo.Items.Add("CantidadCanciones");
        }

        private void dgvDiscos_SelectedChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        private void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDisco = negocio.listar();
                dgvDiscos.DataSource = listaDisco;
                cargarImagen(listaDisco[0].UrlImagenTapa);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["EnStock"].Visible = false;
        } 

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxDiscos.Load("https://mynoota.com/_next/image?url=%2F_static%2Fimages%2F__default.png&w=640&q=75");
            }
            
        }

        private void dgvDiscos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_AltaDisco Estilos_Disponibles = new Form_AltaDisco();

            Estilos_Disponibles.ShowDialog();
        }

        private void btn1_Agregar_Click(object sender, EventArgs e)
        {
            Form_AltaDisco alta = new Form_AltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un disco de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem; //Disco seleccionado en la línea de grilla

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el disco seleccionado.");
                return;
            }

            try
            {
                Form_AltaDisco modificar = new Form_AltaDisco(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnQuitarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnQuitarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            if (dgvDiscos.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un disco de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el disco seleccionado.");
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres quitarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.quitarDisco_Logico(seleccionado.Id);
                    else
                        negocio.quitarDisco(seleccionado.Id);

                    cargar(); //Vuelve a cargar la grilla
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if(cboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if(cboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }

            if (cboBoxCampo.SelectedItem.ToString() == "CantidadCanciones")
            {
                if (!(soloNumeros(txtBoxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo números para filtrar por un campo numerico.");
                    return true;
                }
                if (txtBoxFiltroAvanzado.Text == "")
                {
                    MessageBox.Show("Ingrese un número para este filtro.");
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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (validarFiltro())
                    return; //Return en un método void genera que no se ejecute el método más abajo.

                string campo = cboBoxCampo.SelectedItem.ToString();
                string criterio = cboBoxCriterio.SelectedItem.ToString();
                string filtro = txtBoxFiltroAvanzado.Text;
                dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtBoxFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Genero.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                /*Expresión LAMBDA que recorre la lista viendo si cumple con lo buscado
                Agregados de métodos para no requerir el nombre exactamente igual 
                y además para encontrar según partes del nombre y no necesariamente totalidad.
                También agrega la posibilidad de traer el género que contenga lo que contiene el filtro.*/
            }
            else
            {
                listaFiltrada = listaDisco;
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboBoxCampo.SelectedItem.ToString();

            if (opcion == "CantidadCanciones")
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Menor a");
                cboBoxCriterio.Items.Add("Mayor a");
                cboBoxCriterio.Items.Add("Igual a");
            }
            else if(opcion == "Artista")
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con");
                cboBoxCriterio.Items.Add("Termina con");
                cboBoxCriterio.Items.Add("Contiene");
            }
            else
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con");
                cboBoxCriterio.Items.Add("Termina con");
                cboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void btnTraerFaltante_Click(object sender, EventArgs e)
        {
            FormStockearDiscos stockear = new FormStockearDiscos();
            stockear.ShowDialog();
            cargar();
        }
    }
}
