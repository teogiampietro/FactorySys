namespace FactorySys.Remitos
{
    partial class frmREMITO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmREMITO));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.btnOC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFECHAO = new System.Windows.Forms.DateTimePicker();
            this.txtCODIGOOC = new System.Windows.Forms.TextBox();
            this.txtESTADO = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbENTREGA = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.dgvLINEA_REMITO = new System.Windows.Forms.DataGridView();
            this.txtINSUMO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnINSUMO = new System.Windows.Forms.Button();
            this.dtpFECHAE = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnREFRESCAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_REMITO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPROVEEDOR);
            this.groupBox1.Controls.Add(this.btnOC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFECHAO);
            this.groupBox1.Controls.Add(this.txtCODIGOOC);
            this.groupBox1.Controls.Add(this.txtESTADO);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar respectiva Orden de Compra";
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.Enabled = false;
            this.txtPROVEEDOR.Location = new System.Drawing.Point(361, 57);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(115, 20);
            this.txtPROVEEDOR.TabIndex = 3;
            // 
            // btnOC
            // 
            this.btnOC.Image = ((System.Drawing.Image)(resources.GetObject("btnOC.Image")));
            this.btnOC.Location = new System.Drawing.Point(218, 26);
            this.btnOC.Name = "btnOC";
            this.btnOC.Size = new System.Drawing.Size(25, 25);
            this.btnOC.TabIndex = 2;
            this.btnOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOC.UseVisualStyleBackColor = true;
            this.btnOC.Click += new System.EventHandler(this.btnOC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo OC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha OC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado:";
            // 
            // dtpFECHAO
            // 
            this.dtpFECHAO.Enabled = false;
            this.dtpFECHAO.Location = new System.Drawing.Point(360, 31);
            this.dtpFECHAO.Name = "dtpFECHAO";
            this.dtpFECHAO.Size = new System.Drawing.Size(195, 20);
            this.dtpFECHAO.TabIndex = 7;
            // 
            // txtCODIGOOC
            // 
            this.txtCODIGOOC.Enabled = false;
            this.txtCODIGOOC.Location = new System.Drawing.Point(112, 31);
            this.txtCODIGOOC.Name = "txtCODIGOOC";
            this.txtCODIGOOC.Size = new System.Drawing.Size(100, 20);
            this.txtCODIGOOC.TabIndex = 5;
            // 
            // txtESTADO
            // 
            this.txtESTADO.Enabled = false;
            this.txtESTADO.Location = new System.Drawing.Point(112, 57);
            this.txtESTADO.Name = "txtESTADO";
            this.txtESTADO.Size = new System.Drawing.Size(100, 20);
            this.txtESTADO.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnREFRESCAR);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbENTREGA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTOTAL);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.dgvLINEA_REMITO);
            this.groupBox2.Controls.Add(this.txtINSUMO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCANTIDAD);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPRECIO);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.btnINSUMO);
            this.groupBox2.Controls.Add(this.dtpFECHAE);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Remito";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Entrega";
            // 
            // cmbENTREGA
            // 
            this.cmbENTREGA.FormattingEnabled = true;
            this.cmbENTREGA.Location = new System.Drawing.Point(484, 33);
            this.cmbENTREGA.Name = "cmbENTREGA";
            this.cmbENTREGA.Size = new System.Drawing.Size(93, 21);
            this.cmbENTREGA.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(487, 218);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(98, 20);
            this.txtTOTAL.TabIndex = 25;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(676, 30);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(25, 25);
            this.btnELIMINAR.TabIndex = 23;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // dgvLINEA_REMITO
            // 
            this.dgvLINEA_REMITO.AllowUserToAddRows = false;
            this.dgvLINEA_REMITO.AllowUserToDeleteRows = false;
            this.dgvLINEA_REMITO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_REMITO.Location = new System.Drawing.Point(26, 59);
            this.dgvLINEA_REMITO.Name = "dgvLINEA_REMITO";
            this.dgvLINEA_REMITO.ReadOnly = true;
            this.dgvLINEA_REMITO.Size = new System.Drawing.Size(677, 150);
            this.dgvLINEA_REMITO.TabIndex = 8;
            this.dgvLINEA_REMITO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLINEA_CellClick);
            // 
            // txtINSUMO
            // 
            this.txtINSUMO.Location = new System.Drawing.Point(384, 33);
            this.txtINSUMO.Name = "txtINSUMO";
            this.txtINSUMO.Size = new System.Drawing.Size(94, 20);
            this.txtINSUMO.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insumo";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(184, 33);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(94, 20);
            this.txtCANTIDAD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Precio";
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(284, 33);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(94, 20);
            this.txtPRECIO.TabIndex = 21;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(614, 30);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(25, 25);
            this.btnAGREGAR.TabIndex = 22;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnINSUMO
            // 
            this.btnINSUMO.Image = ((System.Drawing.Image)(resources.GetObject("btnINSUMO.Image")));
            this.btnINSUMO.Location = new System.Drawing.Point(583, 30);
            this.btnINSUMO.Name = "btnINSUMO";
            this.btnINSUMO.Size = new System.Drawing.Size(25, 25);
            this.btnINSUMO.TabIndex = 17;
            this.btnINSUMO.UseVisualStyleBackColor = true;
            this.btnINSUMO.Click += new System.EventHandler(this.btnINSUMO_Click);
            // 
            // dtpFECHAE
            // 
            this.dtpFECHAE.Location = new System.Drawing.Point(26, 33);
            this.dtpFECHAE.Name = "dtpFECHAE";
            this.dtpFECHAE.Size = new System.Drawing.Size(152, 20);
            this.dtpFECHAE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha entrega:";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(418, 360);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 42);
            this.btnGUARDAR.TabIndex = 3;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(524, 360);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(100, 42);
            this.btnCANCELAR.TabIndex = 2;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnREFRESCAR
            // 
            this.btnREFRESCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnREFRESCAR.Image")));
            this.btnREFRESCAR.Location = new System.Drawing.Point(645, 30);
            this.btnREFRESCAR.Name = "btnREFRESCAR";
            this.btnREFRESCAR.Size = new System.Drawing.Size(25, 25);
            this.btnREFRESCAR.TabIndex = 29;
            this.btnREFRESCAR.UseVisualStyleBackColor = true;
            this.btnREFRESCAR.Click += new System.EventHandler(this.btnREFRESCAR_Click);
            // 
            // frmREMITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 415);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmREMITO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::.. Remito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_REMITO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.Button btnOC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLINEA_REMITO;
        private System.Windows.Forms.DateTimePicker dtpFECHAO;
        private System.Windows.Forms.TextBox txtESTADO;
        private System.Windows.Forms.TextBox txtCODIGOOC;
        private System.Windows.Forms.DateTimePicker dtpFECHAE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.TextBox txtINSUMO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnINSUMO;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbENTREGA;
        private System.Windows.Forms.Button btnREFRESCAR;
    }
}