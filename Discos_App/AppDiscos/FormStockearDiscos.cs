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
    public partial class FormStockearDiscos : Form
    {
        private List<Disco> listaDiscoFaltante;
        private Disco seleccionado;

        public FormStockearDiscos()
        {
            InitializeComponent();
        }

        public FormStockearDiscos(Disco seleccionado)
        {
            this.seleccionado = seleccionado;
        }

        private void FormStockearDiscos_Load(object sender, EventArgs e)
        {
            cargarFaltantes();
        }

        private void cargarFaltantes()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDiscoFaltante = negocio.listarFaltantes();
                dgvStockearDiscos.DataSource = listaDiscoFaltante;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvStockearDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvStockearDiscos.Columns["Id"].Visible = false;
            dgvStockearDiscos.Columns["EnStock"].Visible = false;
        }

        private void btnStockear_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                Disco seleccionado;
                seleccionado = (Disco)dgvStockearDiscos.CurrentRow.DataBoundItem;
                FormStockearDiscos stockear = new FormStockearDiscos(seleccionado);

                negocio.modificarDiscoFaltante(seleccionado);
                MessageBox.Show("Stockeado exitoso.");
                cargarFaltantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarStock_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
