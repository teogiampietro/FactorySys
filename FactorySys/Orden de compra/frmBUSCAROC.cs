using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Orden_de_compra
{
    public partial class frmBUSCAROC : Form
    {
        public System.Collections.IEnumerable Lista_Ordenes { get; set; }
        public Modelo.OrdenCompra oOrden { get; set; }
        
        Controladora.OrdenesCompra cOrden;

        string nombreProveedor;
        public frmBUSCAROC(string ACCION)
        {
            InitializeComponent();
            cOrden = Controladora.OrdenesCompra.OBTENER_INSTANCIA();
            rbNO.Checked = true;
            nombreProveedor = "";
            if (ACCION == "UNO")
            {
                btnACEPTAR.Enabled = false;
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvOC.DataSource = null;
            bool verificado = false;     
            if (rbSI.Checked)
            {
                verificado = true;
            }
            else
            {
                verificado = false;
            }
            if (txtCODIGOOC.Text == "")
            {
                Lista_Ordenes = cOrden.LISTAR_ORDENCOMPRA(dtpHASTA.Value, dtpDESDE.Value, verificado, nombreProveedor);
            }
            else
            {
                Lista_Ordenes = cOrden.LISTAR_ORDENCOMPRA(dtpHASTA.Value, dtpDESDE.Value, verificado, nombreProveedor,Convert.ToInt32(txtCODIGOOC.Text));
            }           
            dgvOC.DataSource = Lista_Ordenes;
        }
        private void btnFILTRAR_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnPROVEEDOR_Click(object sender, EventArgs e)
        {
            Proveedores.frmBUSCARPROVEEDOR abrir = new Proveedores.frmBUSCARPROVEEDOR("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Modelo.Proveedor proveedorselect = abrir.oProveedor;
                nombreProveedor = proveedorselect.NOMBRE;
                btnPROVEEDOR.Text = nombreProveedor;
            }
        }

        private void dgvOC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oOrden = cOrden.BUSCAR_OC(Convert.ToInt32(dgvOC.CurrentRow.Cells[0].Value));
            this.DialogResult = DialogResult.OK;
        }
    }
}
