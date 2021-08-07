namespace FactorySys
{
    partial class frmBUSCARPEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCARPEDIDOS));
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.dgvLISTA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.btnCLIENTE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(126, 35);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(123, 20);
            this.txtCLIENTE.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Cliente";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(126, 9);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(123, 20);
            this.txtCODIGO.TabIndex = 92;
            // 
            // dgvLISTA
            // 
            this.dgvLISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA.Location = new System.Drawing.Point(12, 67);
            this.dgvLISTA.Name = "dgvLISTA";
            this.dgvLISTA.Size = new System.Drawing.Size(827, 318);
            this.dgvLISTA.TabIndex = 90;
            this.dgvLISTA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTA_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Codigo Pedido";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(727, 15);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 40);
            this.btnCANCELAR.TabIndex = 94;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(609, 15);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 93;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFILTRAR.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFILTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFILTRAR.Location = new System.Drawing.Point(491, 15);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(112, 41);
            this.btnFILTRAR.TabIndex = 91;
            this.btnFILTRAR.Text = "FILTRAR";
            this.btnFILTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // btnCLIENTE
            // 
            this.btnCLIENTE.Image = ((System.Drawing.Image)(resources.GetObject("btnCLIENTE.Image")));
            this.btnCLIENTE.Location = new System.Drawing.Point(255, 32);
            this.btnCLIENTE.Name = "btnCLIENTE";
            this.btnCLIENTE.Size = new System.Drawing.Size(25, 25);
            this.btnCLIENTE.TabIndex = 97;
            this.btnCLIENTE.UseVisualStyleBackColor = true;
            this.btnCLIENTE.Click += new System.EventHandler(this.btnCLIENTE_Click);
            // 
            // frmBUSCARPEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 400);
            this.Controls.Add(this.btnCLIENTE);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.dgvLISTA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCARPEDIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.DataGridView dgvLISTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCLIENTE;
    }
}