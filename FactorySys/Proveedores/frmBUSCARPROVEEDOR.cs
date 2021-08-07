using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Proveedores
{
    public partial class frmBUSCARPROVEEDOR : Form
    {
        public System.Collections.IEnumerable Lista_Proveedores { get; set; }
        public Proveedor oProveedor { get; set; }
        Controladora.Proveedores cProveedores;
        public frmBUSCARPROVEEDOR(string ACCION)
        {
            InitializeComponent();
            cProveedores = Controladora.Proveedores.OBTENER_INSTANCIA();
            if (ACCION == "UNO")
            {
                btnACEPTAR.Enabled = false;
            }
        }
        public void ARMAR_GRILLA()
        {
            DGVBuscarProveedor.DataSource = null;
            Lista_Proveedores = cProveedores.LISTAR_PROVEEDORES(100, txtNombre.Text, txtCuit.Text);
            DGVBuscarProveedor.DataSource = Lista_Proveedores;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DGVBuscarProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oProveedor = cProveedores.BUSCAR_PROVEEDOR(Convert.ToInt32(DGVBuscarProveedor.CurrentRow.Cells[0].Value));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
