namespace FactorySys.Grupos
{
    partial class frmGRUPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRUPO));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblALTA = new System.Windows.Forms.Label();
            this.chklCONSULTA = new System.Windows.Forms.CheckedListBox();
            this.chklMODIFICACION = new System.Windows.Forms.CheckedListBox();
            this.chklBAJA = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chklALTA = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(68, 24);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(132, 20);
            this.txtNOMBRE.TabIndex = 29;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGUARDAR.Location = new System.Drawing.Point(553, 12);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(98, 42);
            this.btnGUARDAR.TabIndex = 36;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(657, 12);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(98, 42);
            this.btnCANCELAR.TabIndex = 37;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblALTA);
            this.groupBox1.Controls.Add(this.chklCONSULTA);
            this.groupBox1.Controls.Add(this.chklMODIFICACION);
            this.groupBox1.Controls.Add(this.chklBAJA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chklALTA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 389);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONSULTA";
            // 
            // lblALTA
            // 
            this.lblALTA.AutoSize = true;
            this.lblALTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALTA.Location = new System.Drawing.Point(67, 33);
            this.lblALTA.Name = "lblALTA";
            this.lblALTA.Size = new System.Drawing.Size(47, 18);
            this.lblALTA.TabIndex = 1;
            this.lblALTA.Text = "ALTA";
            // 
            // chklCONSULTA
            // 
            this.chklCONSULTA.FormattingEnabled = true;
            this.chklCONSULTA.Location = new System.Drawing.Point(568, 55);
            this.chklCONSULTA.Name = "chklCONSULTA";
            this.chklCONSULTA.Size = new System.Drawing.Size(161, 319);
            this.chklCONSULTA.TabIndex = 6;
            // 
            // chklMODIFICACION
            // 
            this.chklMODIFICACION.FormattingEnabled = true;
            this.chklMODIFICACION.Location = new System.Drawing.Point(387, 55);
            this.chklMODIFICACION.Name = "chklMODIFICACION";
            this.chklMODIFICACION.Size = new System.Drawing.Size(161, 319);
            this.chklMODIFICACION.TabIndex = 4;
            // 
            // chklBAJA
            // 
            this.chklBAJA.FormattingEnabled = true;
            this.chklBAJA.Location = new System.Drawing.Point(204, 55);
            this.chklBAJA.Name = "chklBAJA";
            this.chklBAJA.Size = new System.Drawing.Size(161, 319);
            this.chklBAJA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAJA";
            // 
            // chklALTA
            // 
            this.chklALTA.FormattingEnabled = true;
            this.chklALTA.Location = new System.Drawing.Point(27, 55);
            this.chklALTA.Name = "chklALTA";
            this.chklALTA.Size = new System.Drawing.Size(161, 319);
            this.chklALTA.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "MODIFICACION";
            // 
            // frmGRUPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtNOMBRE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGRUPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox chklCONSULTA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chklMODIFICACION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chklBAJA;
        private System.Windows.Forms.Label lblALTA;
        private System.Windows.Forms.CheckedListBox chklALTA;
    }
}