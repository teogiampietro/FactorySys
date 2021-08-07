namespace FactorySys
{
    partial class frmPRODUCTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRODUCTO));
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCODIGO_INSUMO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.txtINSUMO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnINSUMO = new System.Windows.Forms.Button();
            this.dgvLINEA_PRODUCTO = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTIPO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDETALLE = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCODIGO_PRODUCTO = new System.Windows.Forms.TextBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PRODUCTO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(418, 428);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 42);
            this.btnGUARDAR.TabIndex = 7;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(524, 428);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(100, 42);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCODIGO_INSUMO);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTOTAL);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.txtINSUMO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCANTIDAD);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.btnINSUMO);
            this.groupBox2.Controls.Add(this.dgvLINEA_PRODUCTO);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 246);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insumos del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Codigo Insumo";
            // 
            // txtCODIGO_INSUMO
            // 
            this.txtCODIGO_INSUMO.Enabled = false;
            this.txtCODIGO_INSUMO.Location = new System.Drawing.Point(82, 31);
            this.txtCODIGO_INSUMO.Name = "txtCODIGO_INSUMO";
            this.txtCODIGO_INSUMO.Size = new System.Drawing.Size(94, 20);
            this.txtCODIGO_INSUMO.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Costo total:";
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
            this.btnELIMINAR.Location = new System.Drawing.Point(481, 31);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(25, 25);
            this.btnELIMINAR.TabIndex = 23;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // txtINSUMO
            // 
            this.txtINSUMO.Enabled = false;
            this.txtINSUMO.Location = new System.Drawing.Point(182, 31);
            this.txtINSUMO.Name = "txtINSUMO";
            this.txtINSUMO.Size = new System.Drawing.Size(132, 20);
            this.txtINSUMO.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insumo";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(320, 31);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(94, 20);
            this.txtCANTIDAD.TabIndex = 19;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(450, 31);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(25, 25);
            this.btnAGREGAR.TabIndex = 22;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnINSUMO
            // 
            this.btnINSUMO.Image = ((System.Drawing.Image)(resources.GetObject("btnINSUMO.Image")));
            this.btnINSUMO.Location = new System.Drawing.Point(419, 31);
            this.btnINSUMO.Name = "btnINSUMO";
            this.btnINSUMO.Size = new System.Drawing.Size(25, 25);
            this.btnINSUMO.TabIndex = 17;
            this.btnINSUMO.UseVisualStyleBackColor = true;
            this.btnINSUMO.Click += new System.EventHandler(this.btnINSUMO_Click);
            // 
            // dgvLINEA_PRODUCTO
            // 
            this.dgvLINEA_PRODUCTO.AllowUserToAddRows = false;
            this.dgvLINEA_PRODUCTO.AllowUserToDeleteRows = false;
            this.dgvLINEA_PRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_PRODUCTO.Location = new System.Drawing.Point(41, 62);
            this.dgvLINEA_PRODUCTO.Name = "dgvLINEA_PRODUCTO";
            this.dgvLINEA_PRODUCTO.ReadOnly = true;
            this.dgvLINEA_PRODUCTO.Size = new System.Drawing.Size(544, 150);
            this.dgvLINEA_PRODUCTO.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbTIPO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCODIGO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDETALLE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCODIGO_PRODUCTO);
            this.groupBox1.Controls.Add(this.txtDESCRIPCION);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo";
            // 
            // cmbTIPO
            // 
            this.cmbTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPO.FormattingEnabled = true;
            this.cmbTIPO.Location = new System.Drawing.Point(125, 109);
            this.cmbTIPO.Name = "cmbTIPO";
            this.cmbTIPO.Size = new System.Drawing.Size(134, 21);
            this.cmbTIPO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(125, 57);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(134, 20);
            this.txtCODIGO.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Detalle";
            // 
            // txtDETALLE
            // 
            this.txtDETALLE.Location = new System.Drawing.Point(332, 31);
            this.txtDETALLE.Name = "txtDETALLE";
            this.txtDETALLE.Size = new System.Drawing.Size(222, 87);
            this.txtDETALLE.TabIndex = 7;
            this.txtDETALLE.Text = "Alto:\nAncho:\nVolumen:\nColor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descripcion";
            // 
            // txtCODIGO_PRODUCTO
            // 
            this.txtCODIGO_PRODUCTO.Enabled = false;
            this.txtCODIGO_PRODUCTO.Location = new System.Drawing.Point(125, 31);
            this.txtCODIGO_PRODUCTO.Name = "txtCODIGO_PRODUCTO";
            this.txtCODIGO_PRODUCTO.Size = new System.Drawing.Size(134, 20);
            this.txtCODIGO_PRODUCTO.TabIndex = 5;
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(125, 83);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(134, 20);
            this.txtDESCRIPCION.TabIndex = 6;
            // 
            // frmPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 484);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PRODUCTO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.TextBox txtINSUMO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnINSUMO;
        private System.Windows.Forms.DataGridView dgvLINEA_PRODUCTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCODIGO_PRODUCTO;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDETALLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCODIGO_INSUMO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTIPO;
    }
}