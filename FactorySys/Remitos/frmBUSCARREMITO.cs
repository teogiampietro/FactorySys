using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Remitos
{
    public partial class frmBUSCARREMITO : Form
    {
        public System.Collections.IEnumerable Lista_Remitos { get; set; }
        public DataGridView returndgv { get { return dgvLISTA; } }
        public Modelo.Remito oRemito { get; set; }
        Controladora.Remitos cRemito;
        Modelo.Proveedor oProveedor;
        string nombreProveedor;
        public frmBUSCARREMITO()
        {
            InitializeComponent();
            cRemito = Controladora.Remitos.OBTENER_INSTANCIA();
            nombreProveedor = "";
        }
        private void ARMAR_GRILLA()
        {
            dgvLISTA.DataSource = null;          
            if (string.IsNullOrWhiteSpace(txtCODIGO_REMITO.Text))
            {
                Lista_Remitos = cRemito.LISTAR_REMITOS(dtpDESDE.Value, dtpHASTA.Value, nombreProveedor);
            }
            else
            {
                Lista_Remitos = cRemito.LISTAR_REMITOS(dtpDESDE.Value, dtpHASTA.Value, nombreProveedor, Convert.ToInt32(txtCODIGO_REMITO.Text));
            }       
            dgvLISTA.DataSource = Lista_Remitos;
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
        private void btnBUSCAR_PROV_Click(object sender, EventArgs e)
        {
            Proveedores.frmBUSCARPROVEEDOR abrir = new Proveedores.frmBUSCARPROVEEDOR("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oProveedor = abrir.oProveedor;
                nombreProveedor = oProveedor.NOMBRE;
                txtPROVEEDOR.Text = oProveedor.NOMBRE;
            }
        }

        private void dgvLISTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oRemito = cRemito.BUSCAR_REMITO(Convert.ToInt32(dgvLISTA.CurrentRow.Cells[0].Value));
            this.DialogResult = DialogResult.OK;
        }
    }
}
