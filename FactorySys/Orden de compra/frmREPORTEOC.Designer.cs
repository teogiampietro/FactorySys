namespace FactorySys
{
    partial class frmREPORTEOC
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LineaOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaOrdenCompraBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdenCompraBindingSource
            // 
            this.OrdenCompraBindingSource.DataSource = typeof(Modelo.OrdenCompra);
            // 
            // LineaOrdenCompraBindingSource
            // 
            this.LineaOrdenCompraBindingSource.DataSource = typeof(Modelo.LineaOrdenCompra);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "OC";
            reportDataSource1.Value = this.OrdenCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FactorySys.Orden de compra.OCreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarReporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarReporteToolStripMenuItem
            // 
            this.cargarReporteToolStripMenuItem.Name = "cargarReporteToolStripMenuItem";
            this.cargarReporteToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.cargarReporteToolStripMenuItem.Text = "Cargar Reporte";
            this.cargarReporteToolStripMenuItem.Click += new System.EventHandler(this.cargarReporteToolStripMenuItem_Click);
            // 
            // frmREPORTEOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 493);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmREPORTEOC";
            this.Text = "frmREPORTEOC";
            this.Load += new System.EventHandler(this.frmREPORTEOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaOrdenCompraBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarReporteToolStripMenuItem;
        private System.Windows.Forms.BindingSource OrdenCompraBindingSource;
        private System.Windows.Forms.BindingSource LineaOrdenCompraBindingSource;
    }
}