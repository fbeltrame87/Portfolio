namespace Discos_App
{
    partial class FormStockearDiscos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStockearDiscos = new System.Windows.Forms.DataGridView();
            this.btnStockear = new System.Windows.Forms.Button();
            this.btnCancelarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockearDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockearDiscos
            // 
            this.dgvStockearDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockearDiscos.Location = new System.Drawing.Point(12, 25);
            this.dgvStockearDiscos.Name = "dgvStockearDiscos";
            this.dgvStockearDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockearDiscos.Size = new System.Drawing.Size(547, 241);
            this.dgvStockearDiscos.TabIndex = 0;
            // 
            // btnStockear
            // 
            this.btnStockear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockear.Location = new System.Drawing.Point(370, 272);
            this.btnStockear.Name = "btnStockear";
            this.btnStockear.Size = new System.Drawing.Size(91, 28);
            this.btnStockear.TabIndex = 7;
            this.btnStockear.Text = "Stockear Disco";
            this.btnStockear.UseVisualStyleBackColor = true;
            this.btnStockear.Click += new System.EventHandler(this.btnStockear_Click);
            // 
            // btnCancelarStock
            // 
            this.btnCancelarStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarStock.Location = new System.Drawing.Point(467, 272);
            this.btnCancelarStock.Name = "btnCancelarStock";
            this.btnCancelarStock.Size = new System.Drawing.Size(91, 28);
            this.btnCancelarStock.TabIndex = 8;
            this.btnCancelarStock.Text = "Cancelar";
            this.btnCancelarStock.UseVisualStyleBackColor = true;
            this.btnCancelarStock.Click += new System.EventHandler(this.btnCancelarStock_Click);
            // 
            // FormStockearDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 326);
            this.Controls.Add(this.btnCancelarStock);
            this.Controls.Add(this.btnStockear);
            this.Controls.Add(this.dgvStockearDiscos);
            this.Name = "FormStockearDiscos";
            this.Text = "Faltantes - Stockear Discos";
            this.Load += new System.EventHandler(this.FormStockearDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockearDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockearDiscos;
        private System.Windows.Forms.Button btnStockear;
        private System.Windows.Forms.Button btnCancelarStock;
    }
}