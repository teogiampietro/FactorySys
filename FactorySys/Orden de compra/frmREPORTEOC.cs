using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys
{
    public partial class frmREPORTEOC : Form
    {
        Controladora.OrdenesCompra cOrden;
        public frmREPORTEOC()
        {
            InitializeComponent();
            cOrden = Controladora.OrdenesCompra.OBTENER_INSTANCIA();

        }

        private void frmREPORTEOC_Load(object sender, EventArgs e)
        {
        }

        private void cargarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompraBindingSource.DataSource = cOrden.OBTENER_ORDENES();
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Teo\Desktop\Proyecto TDC\FactorySys\FactorySys\Orden de compra\OCreport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
