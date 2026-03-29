using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Discos_App
{
    public partial class Form_AltaDisco : Form
    {
        private Label lblTitulo;
        private Label lblArtista;
        private Label lblCantidadCanciones;
        private TextBox tbxTitulo;
        private TextBox tbxArtista;
        private TextBox tbxCantidadCanciones;
        private Button btnAceptar;
        private Button btnCancelar;

        public Form_AltaDisco()
        {
            InitializeComponent();
        }

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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(96, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(96, 91);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(36, 13);
            this.lblArtista.TabIndex = 1;
            this.lblArtista.Text = "Artista";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(15, 137);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(117, 13);
            this.lblCantidadCanciones.TabIndex = 2;
            this.lblCantidadCanciones.Text = "Cantidad de Canciones";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitulo.Location = new System.Drawing.Point(135, 44);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(187, 20);
            this.tbxTitulo.TabIndex = 3;
            // 
            // tbxArtista
            // 
            this.tbxArtista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxArtista.Location = new System.Drawing.Point(135, 88);
            this.tbxArtista.Name = "tbxArtista";
            this.tbxArtista.Size = new System.Drawing.Size(187, 20);
            this.tbxArtista.TabIndex = 4;
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(135, 134);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(187, 20);
            this.tbxCantidadCanciones.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(116, 183);
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
            this.btnCancelar.Location = new System.Drawing.Point(228, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form_AltaDisco
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 295);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.tbxArtista);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form_AltaDisco";
            this.Text = "Nuevo Ingreso_Disco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco nuevoDisco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                nuevoDisco.Titulo = tbxTitulo.Text;
                nuevoDisco.Artista.Nombre = tbxArtista.Text; //PROBLEMA DE REFERENCIA
                nuevoDisco.cantidadCanciones = int.Parse(tbxCantidadCanciones.Text);

                negocio.agregarDisco(nuevoDisco);
                MessageBox.Show("Agregado exitoso.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
