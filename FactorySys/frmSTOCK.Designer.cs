namespace FactorySys
{
    partial class frmSTOCK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSTOCK));
            this.dgvSTOCK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTOCK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSTOCK
            // 
            this.dgvSTOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTOCK.Location = new System.Drawing.Point(12, 12);
            this.dgvSTOCK.Name = "dgvSTOCK";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSTOCK.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSTOCK.Size = new System.Drawing.Size(846, 342);
            this.dgvSTOCK.TabIndex = 0;
            // 
            // frmSTOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 366);
            this.Controls.Add(this.dgvSTOCK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSTOCK";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmSTOCK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTOCK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSTOCK;
    }
}