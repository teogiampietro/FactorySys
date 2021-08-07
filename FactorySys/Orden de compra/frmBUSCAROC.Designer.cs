namespace FactorySys.Orden_de_compra
{
    partial class frmBUSCAROC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCAROC));
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPROVEEDOR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCODIGOOC = new System.Windows.Forms.TextBox();
            this.dgvOC = new System.Windows.Forms.DataGridView();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.rbSI = new System.Windows.Forms.RadioButton();
            this.rbNO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Location = new System.Drawing.Point(58, 63);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(210, 20);
            this.dtpHASTA.TabIndex = 23;
            this.dtpHASTA.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Location = new System.Drawing.Point(58, 36);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(210, 20);
            this.dtpDESDE.TabIndex = 22;
            this.dtpDESDE.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Desde ";
            // 
            // btnPROVEEDOR
            // 
            this.btnPROVEEDOR.Image = global::FactorySys.Properties.Resources.find;
            this.btnPROVEEDOR.Location = new System.Drawing.Point(290, 22);
            this.btnPROVEEDOR.Name = "btnPROVEEDOR";
            this.btnPROVEEDOR.Size = new System.Drawing.Size(109, 47);
            this.btnPROVEEDOR.TabIndex = 19;
            this.btnPROVEEDOR.Text = "Buscar  por Proveedor";
            this.btnPROVEEDOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPROVEEDOR.UseVisualStyleBackColor = true;
            this.btnPROVEEDOR.Click += new System.EventHandler(this.btnPROVEEDOR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo Orden Compra";
            // 
            // txtCODIGOOC
            // 
            this.txtCODIGOOC.Location = new System.Drawing.Point(145, 12);
            this.txtCODIGOOC.Name = "txtCODIGOOC";
            this.txtCODIGOOC.Size = new System.Drawing.Size(123, 20);
            this.txtCODIGOOC.TabIndex = 14;
            // 
            // dgvOC
            // 
            this.dgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOC.Location = new System.Drawing.Point(3, 89);
            this.dgvOC.Name = "dgvOC";
            this.dgvOC.Size = new System.Drawing.Size(909, 298);
            this.dgvOC.TabIndex = 24;
            this.dgvOC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOC_CellDoubleClick);
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFILTRAR.Location = new System.Drawing.Point(564, 25);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(112, 41);
            this.btnFILTRAR.TabIndex = 25;
            this.btnFILTRAR.Text = "FILTRAR";
            this.btnFILTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.Location = new System.Drawing.Point(682, 25);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 26;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(800, 25);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 41);
            this.btnCANCELAR.TabIndex = 27;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Location = new System.Drawing.Point(445, 25);
            this.rbSI.Name = "rbSI";
            this.rbSI.Size = new System.Drawing.Size(72, 17);
            this.rbSI.TabIndex = 28;
            this.rbSI.TabStop = true;
            this.rbSI.Text = "Verificado";
            this.rbSI.UseVisualStyleBackColor = true;
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Location = new System.Drawing.Point(445, 48);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(89, 17);
            this.rbNO.TabIndex = 29;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "No Verificado";
            this.rbNO.UseVisualStyleBackColor = true;
            // 
            // frmBUSCAROC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 399);
            this.Controls.Add(this.rbNO);
            this.Controls.Add(this.rbSI);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.dgvOC);
            this.Controls.Add(this.dtpHASTA);
            this.Controls.Add(this.dtpDESDE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPROVEEDOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCODIGOOC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCAROC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPROVEEDOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCODIGOOC;
        private System.Windows.Forms.DataGridView dgvOC;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.RadioButton rbSI;
        private System.Windows.Forms.RadioButton rbNO;
    }
}