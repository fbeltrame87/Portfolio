namespace Gestor_de_Comercio_App
{
    partial class FormGestorComercio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGestorComercio = new System.Windows.Forms.DataGridView();
            this.pBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGestorComercio
            // 
            this.dgvGestorComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestorComercio.Location = new System.Drawing.Point(12, 34);
            this.dgvGestorComercio.Name = "dgvGestorComercio";
            this.dgvGestorComercio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestorComercio.Size = new System.Drawing.Size(459, 275);
            this.dgvGestorComercio.TabIndex = 1;
            this.dgvGestorComercio.SelectionChanged += new System.EventHandler(this.dgvGestorComercio_SelectionChanged);
            // 
            // pBoxImagenArticulo
            // 
            this.pBoxImagenArticulo.Location = new System.Drawing.Point(477, 34);
            this.pBoxImagenArticulo.Name = "pBoxImagenArticulo";
            this.pBoxImagenArticulo.Size = new System.Drawing.Size(290, 275);
            this.pBoxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagenArticulo.TabIndex = 2;
            this.pBoxImagenArticulo.TabStop = false;
            // 
            // FormGestorComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxImagenArticulo);
            this.Controls.Add(this.dgvGestorComercio);
            this.Name = "FormGestorComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Comercio";
            this.Load += new System.EventHandler(this.FormGestorComercio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGestorComercio;
        private System.Windows.Forms.PictureBox pBoxImagenArticulo;
    }
}

