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
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.listar();
            dgvDiscos.DataSource = listaDisco;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            cargarImagen(listaDisco[0].UrlImagenTapa);
        }

        private void dgvDiscos_SelectedChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
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
            Form2.InitializeComponent();
        }
    }
}
