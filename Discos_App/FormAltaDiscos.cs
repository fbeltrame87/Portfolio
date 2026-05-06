using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.IO;
using System.Configuration;

namespace Discos_App
{
    public partial class Form_AltaDisco : Form
    {
        private Disco disco = null; //Disco que arranca nulo de origen y que luego carga con el disco a manipular
        private Label label1;
        private OpenFileDialog archivo = null; // FileDialog nulo para agregar archivo imagen desde url o local luego

        public Form_AltaDisco()
        {
            InitializeComponent();
        }

        public Form_AltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private Label lblTitulo;
        private Label lblArtista;
        private Label lblCantidadCanciones;
        private TextBox tbxTitulo;
        private TextBox tbxArtista;
        private TextBox tbxCantidadCanciones;
        private Button btnAceptar;
        private ComboBox cBoxGenero;
        private ComboBox cBoxEdicion;
        private Label lblGenero;
        private Label lblEdicion;
        private TextBox txtBoxUrlImagen;
        private Label lblUrlImagen;
        private PictureBox pBoxDisco;
        private Button btnAgregarImagen;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxArtista = new System.Windows.Forms.TextBox();
            this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cBoxGenero = new System.Windows.Forms.ComboBox();
            this.cBoxEdicion = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pBoxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(96, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo*";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(93, 53);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(40, 13);
            this.lblArtista.TabIndex = 1;
            this.lblArtista.Text = "Artista*";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(12, 79);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(121, 13);
            this.lblCantidadCanciones.TabIndex = 2;
            this.lblCantidadCanciones.Text = "Cantidad de Canciones*";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxTitulo.Location = new System.Drawing.Point(135, 24);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(187, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // tbxArtista
            // 
            this.tbxArtista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxArtista.Location = new System.Drawing.Point(135, 50);
            this.tbxArtista.Name = "tbxArtista";
            this.tbxArtista.Size = new System.Drawing.Size(187, 20);
            this.tbxArtista.TabIndex = 1;
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(135, 76);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(187, 20);
            this.tbxCantidadCanciones.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(135, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(247, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cBoxGenero
            // 
            this.cBoxGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGenero.FormattingEnabled = true;
            this.cBoxGenero.Location = new System.Drawing.Point(135, 128);
            this.cBoxGenero.Name = "cBoxGenero";
            this.cBoxGenero.Size = new System.Drawing.Size(187, 21);
            this.cBoxGenero.TabIndex = 8;
            // 
            // cBoxEdicion
            // 
            this.cBoxEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEdicion.FormattingEnabled = true;
            this.cBoxEdicion.Location = new System.Drawing.Point(135, 156);
            this.cBoxEdicion.Name = "cBoxEdicion";
            this.cBoxEdicion.Size = new System.Drawing.Size(187, 21);
            this.cBoxEdicion.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(87, 131);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(46, 13);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Género*";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(87, 159);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(46, 13);
            this.lblEdicion.TabIndex = 11;
            this.lblEdicion.Text = "Edición*";
            // 
            // txtBoxUrlImagen
            // 
            this.txtBoxUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxUrlImagen.Location = new System.Drawing.Point(135, 102);
            this.txtBoxUrlImagen.Name = "txtBoxUrlImagen";
            this.txtBoxUrlImagen.Size = new System.Drawing.Size(187, 20);
            this.txtBoxUrlImagen.TabIndex = 3;
            this.txtBoxUrlImagen.Leave += new System.EventHandler(this.tBoxUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(71, 105);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // pBoxDisco
            // 
            this.pBoxDisco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pBoxDisco.Location = new System.Drawing.Point(354, 24);
            this.pBoxDisco.Name = "pBoxDisco";
            this.pBoxDisco.Size = new System.Drawing.Size(211, 211);
            this.pBoxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDisco.TabIndex = 14;
            this.pBoxDisco.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarImagen.Location = new System.Drawing.Point(328, 102);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(20, 20);
            this.btnAgregarImagen.TabIndex = 15;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(135, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "( * = campos obligatorios)";
            // 
            // Form_AltaDisco
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pBoxDisco);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txtBoxUrlImagen);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cBoxEdicion);
            this.Controls.Add(this.cBoxGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.tbxArtista);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form_AltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Disco";
            this.Load += new System.EventHandler(this.Form_AltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form_AltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();

            try
            {
                cBoxGenero.DataSource = estiloNegocio.listar();
                cBoxGenero.ValueMember = "Id";
                cBoxGenero.DisplayMember = "Descripcion";
                cBoxEdicion.DataSource = edicionNegocio.listar();
                cBoxEdicion.ValueMember = "Id";
                cBoxEdicion.DisplayMember = "Descripcion";

                //Validación de si es inserción o modificación
                if (disco != null)
                {
                    tbxTitulo.Text = disco.Titulo;
                    tbxArtista.Text = disco.Artista.Nombre;
                    tbxCantidadCanciones.Text = disco.cantidadCanciones.ToString();
                    txtBoxUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cBoxGenero.SelectedValue = disco.Genero.Id;
                    cBoxEdicion.SelectedValue = disco.Tipo.Id;
                }
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                if (disco == null) //Condición para determinar si al "Aceptar" es un Insertar o Modificar disco existente
                    disco = new Disco(); 

                disco.Titulo = tbxTitulo.Text;
                disco.Artista = new Artista();
                disco.Artista.Nombre = tbxArtista.Text;
                disco.cantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
                disco.UrlImagenTapa = txtBoxUrlImagen.Text;
                disco.Genero = (Estilo)cBoxGenero.SelectedItem;
                disco.Tipo = (Edicion)cBoxEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    negocio.modificarDisco(disco);
                    MessageBox.Show("Modificado exitoso.");
                }
                else
                {
                    negocio.agregarDisco(disco);
                    MessageBox.Show("Agregado exitoso.");
                }

                //Guardo imagen si la levantó localmente
                if(archivo != null && !(txtBoxUrlImagen.Text.Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }   

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        //Este método es una copia, para mejorar el diseño ´podría estar en una nueva clase, por ejemplo "Helper"
        {
            try
            {
                pBoxDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxDisco.Load("https://mynoota.com/_next/image?url=%2F_static%2Fimages%2F__default.png&w=640&q=75");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            string imagen = "";

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                //carga de imagen en form
                txtBoxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen en carpeta hecha para la app
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
            else
            {
                txtBoxUrlImagen.Text = imagen;
                cargarImagen(imagen);
            }
        }
    }
}
