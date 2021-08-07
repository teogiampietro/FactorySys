namespace FactorySys.Usuarios
{
    partial class frmBUSCARUSUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUSCARUSUARIO));
            this.label10 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.dgvLISTA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Email";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(62, 9);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(123, 20);
            this.txtUSUARIO.TabIndex = 51;
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFILTRAR.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFILTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFILTRAR.Location = new System.Drawing.Point(491, 12);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(112, 41);
            this.btnFILTRAR.TabIndex = 50;
            this.btnFILTRAR.Text = "FILTRAR";
            this.btnFILTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // dgvLISTA
            // 
            this.dgvLISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA.Location = new System.Drawing.Point(12, 65);
            this.dgvLISTA.Name = "dgvLISTA";
            this.dgvLISTA.Size = new System.Drawing.Size(827, 318);
            this.dgvLISTA.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Usuario";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(62, 35);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(123, 20);
            this.txtEMAIL.TabIndex = 58;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(242, 9);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(123, 20);
            this.txtNOMBRE.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre";
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(609, 12);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(112, 41);
            this.btnACEPTAR.TabIndex = 65;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(727, 12);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 40);
            this.btnCANCELAR.TabIndex = 66;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // frmBUSCARUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 393);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.dgvLISTA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBUSCARUSUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.DataGridView dgvLISTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Button btnCANCELAR;
    }
}