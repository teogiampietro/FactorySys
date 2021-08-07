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
    public partial class frmBUSCARPRODUCTO : Form
    {
        public System.Collections.IEnumerable productosSeleccionados { get; set; }
        public Modelo.Producto productoSeleccionado { get; set; }
        Controladora.Productos cProducto;
        public frmBUSCARPRODUCTO(string ACCION)
        {
            InitializeComponent();
            cProducto = Controladora.Productos.OBTENER_INSTANCIA();
            if (ACCION == "UNO")
            {
                btnACEPTAR.Enabled = false;
            }
        }
        public void ARMAR_GRILLA()
        {
            dgvLISTA.DataSource = null;
            productosSeleccionados = cProducto.LISTAR_PRODUCTOS(100,txtCODIGO.Text,txtDESCRIPCION.Text);
            dgvLISTA.DataSource = productosSeleccionados;
        }
        private void btnFILTRAR_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
        public DataGridView returndgv
        {
            get { return dgvLISTA; }
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvLISTA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productoSeleccionado = cProducto.BUSCAR_PRODUCTO(Convert.ToInt32(dgvLISTA.CurrentRow.Cells[0].Value));
            DialogResult = DialogResult.OK;
        }
    }
}
