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
            this.pBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblBarraSuperior = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarLogica = new System.Windows.Forms.Button();
            this.btnEliminarExistencia = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtBoxFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblEncabezadoDgv = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboBoxCampo = new System.Windows.Forms.ComboBox();
            this.cboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.dgvGestorComercio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxImagenArticulo
            // 
            this.pBoxImagenArticulo.Location = new System.Drawing.Point(483, 64);
            this.pBoxImagenArticulo.Name = "pBoxImagenArticulo";
            this.pBoxImagenArticulo.Size = new System.Drawing.Size(311, 309);
            this.pBoxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagenArticulo.TabIndex = 2;
            this.pBoxImagenArticulo.TabStop = false;
            // 
            // lblBarraSuperior
            // 
            this.lblBarraSuperior.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblBarraSuperior.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblBarraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarraSuperior.Location = new System.Drawing.Point(-2, 0);
            this.lblBarraSuperior.Name = "lblBarraSuperior";
            this.lblBarraSuperior.Size = new System.Drawing.Size(805, 40);
            this.lblBarraSuperior.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(1, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 40);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(107, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 40);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLogica
            // 
            this.btnEliminarLogica.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarLogica.Location = new System.Drawing.Point(213, 0);
            this.btnEliminarLogica.Name = "btnEliminarLogica";
            this.btnEliminarLogica.Size = new System.Drawing.Size(105, 40);
            this.btnEliminarLogica.TabIndex = 6;
            this.btnEliminarLogica.Text = "Eliminar Lógica";
            this.btnEliminarLogica.UseVisualStyleBackColor = true;
            // 
            // btnEliminarExistencia
            // 
            this.btnEliminarExistencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarExistencia.Location = new System.Drawing.Point(319, 0);
            this.btnEliminarExistencia.Name = "btnEliminarExistencia";
            this.btnEliminarExistencia.Size = new System.Drawing.Size(105, 40);
            this.btnEliminarExistencia.TabIndex = 7;
            this.btnEliminarExistencia.Text = "Eliminar Existencia";
            this.btnEliminarExistencia.UseVisualStyleBackColor = true;
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(1, 382);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroRapido.TabIndex = 8;
            this.lblFiltroRapido.Text = "Filtro Rápido:";
            // 
            // txtBoxFiltroRapido
            // 
            this.txtBoxFiltroRapido.Location = new System.Drawing.Point(70, 379);
            this.txtBoxFiltroRapido.Name = "txtBoxFiltroRapido";
            this.txtBoxFiltroRapido.Size = new System.Drawing.Size(137, 20);
            this.txtBoxFiltroRapido.TabIndex = 9;
            // 
            // lblEncabezadoDgv
            // 
            this.lblEncabezadoDgv.AutoSize = true;
            this.lblEncabezadoDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEncabezadoDgv.Location = new System.Drawing.Point(1, 44);
            this.lblEncabezadoDgv.Name = "lblEncabezadoDgv";
            this.lblEncabezadoDgv.Size = new System.Drawing.Size(141, 17);
            this.lblEncabezadoDgv.TabIndex = 10;
            this.lblEncabezadoDgv.Text = "Artículos disponibles:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(392, 403);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(95, 13);
            this.lblFiltroAvanzado.TabIndex = 11;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado >>";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(27, 403);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(55, 13);
            this.lblCampo.TabIndex = 13;
            this.lblCampo.Text = "Campo >>";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(210, 403);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(54, 13);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio >>";
            // 
            // txtBoxFiltroAvanzado
            // 
            this.txtBoxFiltroAvanzado.Location = new System.Drawing.Point(473, 418);
            this.txtBoxFiltroAvanzado.Name = "txtBoxFiltroAvanzado";
            this.txtBoxFiltroAvanzado.Size = new System.Drawing.Size(137, 20);
            this.txtBoxFiltroAvanzado.TabIndex = 15;
            // 
            // cboBoxCampo
            // 
            this.cboBoxCampo.FormattingEnabled = true;
            this.cboBoxCampo.Location = new System.Drawing.Point(70, 417);
            this.cboBoxCampo.Name = "cboBoxCampo";
            this.cboBoxCampo.Size = new System.Drawing.Size(137, 21);
            this.cboBoxCampo.TabIndex = 16;
            // 
            // cboBoxCriterio
            // 
            this.cboBoxCriterio.FormattingEnabled = true;
            this.cboBoxCriterio.Location = new System.Drawing.Point(249, 417);
            this.cboBoxCriterio.Name = "cboBoxCriterio";
            this.cboBoxCriterio.Size = new System.Drawing.Size(137, 21);
            this.cboBoxCriterio.TabIndex = 17;
            // 
            // dgvGestorComercio
            // 
            this.dgvGestorComercio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGestorComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestorComercio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGestorComercio.Location = new System.Drawing.Point(4, 64);
            this.dgvGestorComercio.MultiSelect = false;
            this.dgvGestorComercio.Name = "dgvGestorComercio";
            this.dgvGestorComercio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestorComercio.Size = new System.Drawing.Size(473, 309);
            this.dgvGestorComercio.TabIndex = 1;
            this.dgvGestorComercio.SelectionChanged += new System.EventHandler(this.dgvGestorComercio_SelectionChanged);
            // 
            // FormGestorComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboBoxCriterio);
            this.Controls.Add(this.cboBoxCampo);
            this.Controls.Add(this.txtBoxFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblEncabezadoDgv);
            this.Controls.Add(this.txtBoxFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminarExistencia);
            this.Controls.Add(this.btnEliminarLogica);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBarraSuperior);
            this.Controls.Add(this.pBoxImagenArticulo);
            this.Controls.Add(this.dgvGestorComercio);
            this.Name = "FormGestorComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Comercio";
            this.Load += new System.EventHandler(this.FormGestorComercio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxImagenArticulo;
        private System.Windows.Forms.Label lblBarraSuperior;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarLogica;
        private System.Windows.Forms.Button btnEliminarExistencia;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtBoxFiltroRapido;
        private System.Windows.Forms.Label lblEncabezadoDgv;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtBoxFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboBoxCampo;
        private System.Windows.Forms.ComboBox cboBoxCriterio;
        private System.Windows.Forms.DataGridView dgvGestorComercio;
    }
}

