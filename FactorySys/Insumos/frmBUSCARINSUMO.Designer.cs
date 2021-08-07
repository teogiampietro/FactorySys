namespace FactorySys.Insumos
{
    partial class frmBUSCARINSUMO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCARINSUMO));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoInsumo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.DGVBuscarInsumos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnLimpiar.Location = new System.Drawing.Point(722, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 41);
            this.btnLimpiar.TabIndex = 81;
            this.btnLimpiar.Text = "Cancelar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.Location = new System.Drawing.Point(604, 11);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 80;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Codigo de Insumo";
            // 
            // txtCodigoInsumo
            // 
            this.txtCodigoInsumo.Location = new System.Drawing.Point(330, 12);
            this.txtCodigoInsumo.Name = "txtCodigoInsumo";
            this.txtCodigoInsumo.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoInsumo.TabIndex = 78;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(123, 20);
            this.txtDescripcion.TabIndex = 77;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFiltrar.Location = new System.Drawing.Point(486, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 41);
            this.btnFiltrar.TabIndex = 76;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // DGVBuscarInsumos
            // 
            this.DGVBuscarInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscarInsumos.Location = new System.Drawing.Point(12, 70);
            this.DGVBuscarInsumos.Name = "DGVBuscarInsumos";
            this.DGVBuscarInsumos.Size = new System.Drawing.Size(822, 318);
            this.DGVBuscarInsumos.TabIndex = 75;
            this.DGVBuscarInsumos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBuscarInsumos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Descripcion";
            // 
            // frmBUSCARINSUMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 400);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoInsumo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.DGVBuscarInsumos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCARINSUMO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Insumo";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoInsumo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView DGVBuscarInsumos;
        private System.Windows.Forms.Label label1;
    }
}