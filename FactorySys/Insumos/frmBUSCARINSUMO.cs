using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Insumos
{
    public partial class frmBUSCARINSUMO : Form
    {
        public System.Collections.IEnumerable insumosSeleccionados { get; set; }
        public Modelo.Insumo insumoSeleccionado { get; set; }
        Controladora.Insumos cInsumo;
        public DataGridView returndgv { get { return DGVBuscarInsumos; } }
        public frmBUSCARINSUMO(string ACCION)
        {
            InitializeComponent();
            cInsumo = Controladora.Insumos.OBTENER_INSTANCIA();
            if (ACCION == "UNO")
            {
                btnACEPTAR.Enabled = false;
            }
        }
        private void ARMAR_GRILLA()
        {
            DGVBuscarInsumos.DataSource = null;
            insumosSeleccionados = cInsumo.LISTAR_INSUMO(100, txtCodigoInsumo.Text, txtNombre.Text);
            DGVBuscarInsumos.DataSource = insumosSeleccionados;
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void DGVBuscarInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            insumoSeleccionado = cInsumo.BUSCAR_INSUMO(Convert.ToInt32(DGVBuscarInsumos.CurrentRow.Cells[0].Value));
            this.DialogResult = DialogResult.OK;
        }
    }
}
