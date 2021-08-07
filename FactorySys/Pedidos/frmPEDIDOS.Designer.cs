namespace FactorySys
{
    partial class frmPEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPEDIDOS));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvPEDIDOS = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEDIDOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBUSCAR);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.btnSALIR);
            this.groupBox2.Controls.Add(this.btnMODIFICAR);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.dgvPEDIDOS);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 442);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::FactorySys.Properties.Resources.find;
            this.btnBUSCAR.Location = new System.Drawing.Point(6, 384);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(110, 45);
            this.btnBUSCAR.TabIndex = 4;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::FactorySys.Properties.Resources.delete;
            this.btnELIMINAR.Location = new System.Drawing.Point(354, 384);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(110, 45);
            this.btnELIMINAR.TabIndex = 6;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.Location = new System.Drawing.Point(737, 384);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(110, 45);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::FactorySys.Properties.Resources.file_edit;
            this.btnMODIFICAR.Location = new System.Drawing.Point(238, 384);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(110, 45);
            this.btnMODIFICAR.TabIndex = 4;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::FactorySys.Properties.Resources.add;
            this.btnAGREGAR.Location = new System.Drawing.Point(122, 384);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(110, 45);
            this.btnAGREGAR.TabIndex = 3;
            this.btnAGREGAR.Text = "Nuevo";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvPEDIDOS
            // 
            this.dgvPEDIDOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPEDIDOS.Location = new System.Drawing.Point(6, 19);
            this.dgvPEDIDOS.Name = "dgvPEDIDOS";
            this.dgvPEDIDOS.Size = new System.Drawing.Size(839, 359);
            this.dgvPEDIDOS.TabIndex = 2;
            // 
            // frmPEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 467);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPEDIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEDIDOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvPEDIDOS;
    }
}