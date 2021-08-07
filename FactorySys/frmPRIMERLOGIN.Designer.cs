namespace FactorySys
{
    partial class frmPRIMERLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRIMERLOGIN));
            this.txtCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.txtCONTRASEÑA2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCONTRASEÑA
            // 
            this.txtCONTRASEÑA.Location = new System.Drawing.Point(132, 34);
            this.txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            this.txtCONTRASEÑA.PasswordChar = '*';
            this.txtCONTRASEÑA.Size = new System.Drawing.Size(127, 20);
            this.txtCONTRASEÑA.TabIndex = 0;
            // 
            // txtCONTRASEÑA2
            // 
            this.txtCONTRASEÑA2.Location = new System.Drawing.Point(132, 72);
            this.txtCONTRASEÑA2.Name = "txtCONTRASEÑA2";
            this.txtCONTRASEÑA2.PasswordChar = '*';
            this.txtCONTRASEÑA2.Size = new System.Drawing.Size(127, 20);
            this.txtCONTRASEÑA2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repetir contraseña:";
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Image = global::FactorySys.Properties.Resources.apply;
            this.btnACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACEPTAR.Location = new System.Drawing.Point(47, 107);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(102, 42);
            this.btnACEPTAR.TabIndex = 4;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(206, 107);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(107, 42);
            this.btnCANCELAR.TabIndex = 5;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Es su primer login en el sistema, debe establecer una contraseña";
            // 
            // frmPRIMERLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTRASEÑA2);
            this.Controls.Add(this.txtCONTRASEÑA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRIMERLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Establecer contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCONTRASEÑA;
        private System.Windows.Forms.TextBox txtCONTRASEÑA2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label label3;
    }
}