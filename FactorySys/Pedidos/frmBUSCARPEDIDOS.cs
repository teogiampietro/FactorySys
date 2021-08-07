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
    public partial class frmBUSCARPEDIDOS : Form
    {
        public System.Collections.IEnumerable pedidosSeleccionados { get; set; }
        public Modelo.Pedido pedidoSeleccionado { get; set; }
        public DataGridView returndgv { get { return dgvLISTA; } }
        Controladora.Pedidos cPedidos;
        Modelo.Cliente oCliente;
        public frmBUSCARPEDIDOS(string ACCION)
        {
            InitializeComponent();
            cPedidos = Controladora.Pedidos.OBTENER_INSTANCIA();
            if (ACCION != "TODO")
            {
                btnACEPTAR.Enabled = false;
            }
            else
            {
                btnACEPTAR.Enabled = true;
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvLISTA.DataSource = null;
            if (string.IsNullOrWhiteSpace(txtCODIGO.Text))
            {
                pedidosSeleccionados = cPedidos.LISTAR_PEDIDOS(txtCLIENTE.Text);
            }
            else
            {
                pedidosSeleccionados = cPedidos.LISTAR_PEDIDOS(txtCLIENTE.Text, Convert.ToInt32(txtCODIGO.Text));
            }
            dgvLISTA.DataSource = pedidosSeleccionados;
        }
        private void btnCLIENTE_Click(object sender, EventArgs e)
        {
            frmBUSCARCLIENTE abrir = new frmBUSCARCLIENTE("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oCliente = abrir.clienteSeleccionado;
                txtCLIENTE.Text = oCliente.NOMBRE;
            }
        }

        private void btnFILTRAR_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }

        private void dgvLISTA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pedidoSeleccionado = cPedidos.BUSCAR_PEDIDO(Convert.ToInt32(dgvLISTA.CurrentRow.Cells[0].Value));
            DialogResult = DialogResult.OK;
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
