namespace FactorySys.Remitos
{
    partial class frmBUSCARREMITO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCARREMITO));
            this.dgvLISTA = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.btnBUSCAR_PROV = new System.Windows.Forms.Button();
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCODIGO_REMITO = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLISTA
            // 
            this.dgvLISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA.Location = new System.Drawing.Point(18, 106);
            this.dgvLISTA.Name = "dgvLISTA";
            this.dgvLISTA.Size = new System.Drawing.Size(761, 298);
            this.dgvLISTA.TabIndex = 37;
            this.dgvLISTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTA_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Desde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo Remito";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(667, 59);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 41);
            this.btnCANCELAR.TabIndex = 43;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.Location = new System.Drawing.Point(667, 12);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 42;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFILTRAR.Location = new System.Drawing.Point(549, 12);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(112, 41);
            this.btnFILTRAR.TabIndex = 41;
            this.btnFILTRAR.Text = "FILTRAR";
            this.btnFILTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Location = new System.Drawing.Point(319, 39);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(210, 20);
            this.dtpHASTA.TabIndex = 47;
            this.dtpHASTA.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Location = new System.Drawing.Point(319, 12);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(210, 20);
            this.dtpDESDE.TabIndex = 46;
            this.dtpDESDE.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // btnBUSCAR_PROV
            // 
            this.btnBUSCAR_PROV.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR_PROV.Image")));
            this.btnBUSCAR_PROV.Location = new System.Drawing.Point(226, 35);
            this.btnBUSCAR_PROV.Name = "btnBUSCAR_PROV";
            this.btnBUSCAR_PROV.Size = new System.Drawing.Size(25, 25);
            this.btnBUSCAR_PROV.TabIndex = 103;
            this.btnBUSCAR_PROV.UseVisualStyleBackColor = true;
            this.btnBUSCAR_PROV.Click += new System.EventHandler(this.btnBUSCAR_PROV_Click);
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.Location = new System.Drawing.Point(97, 38);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(123, 20);
            this.txtPROVEEDOR.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Proveedor";
            // 
            // txtCODIGO_REMITO
            // 
            this.txtCODIGO_REMITO.Location = new System.Drawing.Point(97, 12);
            this.txtCODIGO_REMITO.Mask = "99999";
            this.txtCODIGO_REMITO.Name = "txtCODIGO_REMITO";
            this.txtCODIGO_REMITO.PromptChar = ' ';
            this.txtCODIGO_REMITO.Size = new System.Drawing.Size(100, 20);
            this.txtCODIGO_REMITO.TabIndex = 104;
            this.txtCODIGO_REMITO.ValidatingType = typeof(int);
            // 
            // frmBUSCARREMITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 423);
            this.Controls.Add(this.txtCODIGO_REMITO);
            this.Controls.Add(this.btnBUSCAR_PROV);
            this.Controls.Add(this.txtPROVEEDOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHASTA);
            this.Controls.Add(this.dtpDESDE);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.dgvLISTA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCARREMITO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Remito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLISTA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.Button btnBUSCAR_PROV;
        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCODIGO_REMITO;
    }
}