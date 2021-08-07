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
    public partial class frmBUSCARCLIENTE : Form
    {
        public System.Collections.IEnumerable clientesSeleccionados { get; set; }
        public Modelo.Cliente clienteSeleccionado { get; set; }
        Controladora.Clientes cCliente;
        public frmBUSCARCLIENTE(string ACCION)
        {
            InitializeComponent();
            cCliente = Controladora.Clientes.OBTENER_INSTANCIA();
            if (ACCION == "UNO")
            {
                btnACEPTAR.Enabled = false;
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvLISTA.DataSource = null;
            clientesSeleccionados = cCliente.LISTAR_CLIENTES(100, txtDNI.Text, txtNOMBRE.Text,txtEMAIL.Text);
            dgvLISTA.DataSource = clientesSeleccionados;
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
            DialogResult = DialogResult.Cancel;
        }

        private void dgvLISTA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteSeleccionado = cCliente.BUSCAR_CLIENTE(Convert.ToInt32(dgvLISTA.CurrentRow.Cells[0].Value));
            DialogResult = DialogResult.OK;
        }
    }
}
