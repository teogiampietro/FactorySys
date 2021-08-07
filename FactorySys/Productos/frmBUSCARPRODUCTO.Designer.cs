namespace FactorySys
{
    partial class frmBUSCARPRODUCTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCARPRODUCTO));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.dgvLISTA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(727, 12);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 40);
            this.btnCANCELAR.TabIndex = 86;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(609, 12);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 85;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(126, 6);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(123, 20);
            this.txtCODIGO.TabIndex = 80;
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFILTRAR.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFILTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFILTRAR.Location = new System.Drawing.Point(491, 12);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(112, 41);
            this.btnFILTRAR.TabIndex = 79;
            this.btnFILTRAR.Text = "FILTRAR";
            this.btnFILTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // dgvLISTA
            // 
            this.dgvLISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA.Location = new System.Drawing.Point(12, 64);
            this.dgvLISTA.Name = "dgvLISTA";
            this.dgvLISTA.Size = new System.Drawing.Size(827, 318);
            this.dgvLISTA.TabIndex = 78;
            this.dgvLISTA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTA_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Codigo Producto";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(126, 32);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(123, 20);
            this.txtDESCRIPCION.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Descripcion";
            // 
            // frmBUSCARPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 392);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.dgvLISTA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCARPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.DataGridView dgvLISTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label2;
    }
}