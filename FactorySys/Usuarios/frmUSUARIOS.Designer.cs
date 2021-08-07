namespace FactorySys.Usuarios
{
    partial class frmUSUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIOS));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnBAJA = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnMODIFICACION = new System.Windows.Forms.Button();
            this.btnALTA = new System.Windows.Forms.Button();
            this.dgvUSUARIOS = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnBUSCAR);
            this.groupBox2.Controls.Add(this.btnBAJA);
            this.groupBox2.Controls.Add(this.btnSALIR);
            this.groupBox2.Controls.Add(this.btnMODIFICACION);
            this.groupBox2.Controls.Add(this.btnALTA);
            this.groupBox2.Controls.Add(this.dgvUSUARIOS);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 439);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::FactorySys.Properties.Resources.find;
            this.btnBUSCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBUSCAR.Location = new System.Drawing.Point(6, 384);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(110, 50);
            this.btnBUSCAR.TabIndex = 4;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnBAJA
            // 
            this.btnBAJA.Image = global::FactorySys.Properties.Resources.delete;
            this.btnBAJA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBAJA.Location = new System.Drawing.Point(351, 384);
            this.btnBAJA.Name = "btnBAJA";
            this.btnBAJA.Size = new System.Drawing.Size(110, 50);
            this.btnBAJA.TabIndex = 6;
            this.btnBAJA.Text = "Eliminar";
            this.btnBAJA.UseVisualStyleBackColor = true;
            this.btnBAJA.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSALIR.Location = new System.Drawing.Point(738, 388);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(107, 45);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnMODIFICACION
            // 
            this.btnMODIFICACION.Image = global::FactorySys.Properties.Resources.file_edit;
            this.btnMODIFICACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMODIFICACION.Location = new System.Drawing.Point(236, 384);
            this.btnMODIFICACION.Name = "btnMODIFICACION";
            this.btnMODIFICACION.Size = new System.Drawing.Size(110, 50);
            this.btnMODIFICACION.TabIndex = 4;
            this.btnMODIFICACION.Text = "Modificar";
            this.btnMODIFICACION.UseVisualStyleBackColor = true;
            this.btnMODIFICACION.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnALTA
            // 
            this.btnALTA.Image = global::FactorySys.Properties.Resources.add;
            this.btnALTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnALTA.Location = new System.Drawing.Point(121, 384);
            this.btnALTA.Name = "btnALTA";
            this.btnALTA.Size = new System.Drawing.Size(110, 50);
            this.btnALTA.TabIndex = 3;
            this.btnALTA.Text = "Nuevo";
            this.btnALTA.UseVisualStyleBackColor = true;
            this.btnALTA.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvUSUARIOS
            // 
            this.dgvUSUARIOS.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIOS.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvUSUARIOS.Location = new System.Drawing.Point(6, 19);
            this.dgvUSUARIOS.Name = "dgvUSUARIOS";
            this.dgvUSUARIOS.Size = new System.Drawing.Size(839, 359);
            this.dgvUSUARIOS.TabIndex = 2;
            // 
            // frmUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 455);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUSUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Usuarios";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnBAJA;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnMODIFICACION;
        private System.Windows.Forms.Button btnALTA;
        private System.Windows.Forms.DataGridView dgvUSUARIOS;
    }
}