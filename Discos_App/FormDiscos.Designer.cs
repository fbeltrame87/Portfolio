namespace Discos_App
{
    partial class DiscosApp
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDiscos = new System.Windows.Forms.PictureBox();
            this.btn1_Agregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitarFisico = new System.Windows.Forms.Button();
            this.btnQuitarLogico = new System.Windows.Forms.Button();
            this.btnStockear = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBoxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboBoxCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDiscos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(12, 36);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(558, 338);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscos_CellDoubleClick);
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectedChanged);
            // 
            // pbxDiscos
            // 
            this.pbxDiscos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbxDiscos.Location = new System.Drawing.Point(576, 36);
            this.pbxDiscos.Name = "pbxDiscos";
            this.pbxDiscos.Size = new System.Drawing.Size(378, 378);
            this.pbxDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiscos.TabIndex = 1;
            this.pbxDiscos.TabStop = false;
            // 
            // btn1_Agregar
            // 
            this.btn1_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1_Agregar.Location = new System.Drawing.Point(12, 380);
            this.btn1_Agregar.Name = "btn1_Agregar";
            this.btn1_Agregar.Size = new System.Drawing.Size(91, 28);
            this.btn1_Agregar.TabIndex = 2;
            this.btn1_Agregar.Text = "Agregar";
            this.btn1_Agregar.UseVisualStyleBackColor = true;
            this.btn1_Agregar.Click += new System.EventHandler(this.btn1_Agregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(109, 380);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 28);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitarFisico
            // 
            this.btnQuitarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarFisico.Location = new System.Drawing.Point(206, 380);
            this.btnQuitarFisico.Name = "btnQuitarFisico";
            this.btnQuitarFisico.Size = new System.Drawing.Size(91, 28);
            this.btnQuitarFisico.TabIndex = 4;
            this.btnQuitarFisico.Text = "Quitar Fisico";
            this.btnQuitarFisico.UseVisualStyleBackColor = true;
            this.btnQuitarFisico.Click += new System.EventHandler(this.btnQuitarFisico_Click);
            // 
            // btnQuitarLogico
            // 
            this.btnQuitarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarLogico.Location = new System.Drawing.Point(303, 380);
            this.btnQuitarLogico.Name = "btnQuitarLogico";
            this.btnQuitarLogico.Size = new System.Drawing.Size(91, 28);
            this.btnQuitarLogico.TabIndex = 5;
            this.btnQuitarLogico.Text = "Quitar Lógico";
            this.btnQuitarLogico.UseVisualStyleBackColor = true;
            this.btnQuitarLogico.Click += new System.EventHandler(this.btnQuitarLogico_Click);
            // 
            // btnStockear
            // 
            this.btnStockear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockear.Location = new System.Drawing.Point(400, 380);
            this.btnStockear.Name = "btnStockear";
            this.btnStockear.Size = new System.Drawing.Size(91, 28);
            this.btnStockear.TabIndex = 6;
            this.btnStockear.Text = "Stockear Disco";
            this.btnStockear.UseVisualStyleBackColor = true;
            this.btnStockear.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(13, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(66, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro Rápido";
            // 
            // txtBoxFiltro
            // 
            this.txtBoxFiltro.Location = new System.Drawing.Point(85, 10);
            this.txtBoxFiltro.Name = "txtBoxFiltro";
            this.txtBoxFiltro.Size = new System.Drawing.Size(157, 20);
            this.txtBoxFiltro.TabIndex = 8;
            this.txtBoxFiltro.TextChanged += new System.EventHandler(this.txtBoxFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(510, 429);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(60, 22);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(13, 434);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // cboBoxCampo
            // 
            this.cboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCampo.FormattingEnabled = true;
            this.cboBoxCampo.Location = new System.Drawing.Point(53, 430);
            this.cboBoxCampo.Name = "cboBoxCampo";
            this.cboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCampo.TabIndex = 11;
            this.cboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.cboBoxCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(180, 434);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboBoxCriterio
            // 
            this.cboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCriterio.FormattingEnabled = true;
            this.cboBoxCriterio.Location = new System.Drawing.Point(221, 430);
            this.cboBoxCriterio.Name = "cboBoxCriterio";
            this.cboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCriterio.TabIndex = 13;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(348, 434);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroAvanzado.TabIndex = 14;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // txtBoxFiltroAvanzado
            // 
            this.txtBoxFiltroAvanzado.Location = new System.Drawing.Point(383, 430);
            this.txtBoxFiltroAvanzado.Name = "txtBoxFiltroAvanzado";
            this.txtBoxFiltroAvanzado.Size = new System.Drawing.Size(121, 20);
            this.txtBoxFiltroAvanzado.TabIndex = 15;
            // 
            // DiscosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 474);
            this.Controls.Add(this.txtBoxFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboBoxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboBoxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnStockear);
            this.Controls.Add(this.btnQuitarLogico);
            this.Controls.Add(this.btnQuitarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btn1_Agregar);
            this.Controls.Add(this.pbxDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "DiscosApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscosApp";
            this.Load += new System.EventHandler(this.DiscosApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbxDiscos;
        private System.Windows.Forms.Button btn1_Agregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitarFisico;
        private System.Windows.Forms.Button btnQuitarLogico;
        private System.Windows.Forms.Button btnStockear;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBoxFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboBoxCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboBoxCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtBoxFiltroAvanzado;
    }
}

