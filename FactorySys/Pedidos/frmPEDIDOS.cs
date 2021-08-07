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
    public partial class frmPEDIDOS : Form
    {
        public static frmPEDIDOS instancia;
        public static frmPEDIDOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmPEDIDOS(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Pedidos cPedido;
        Modelo.Usuario oUsuario;
        public frmPEDIDOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cPedido = Controladora.Pedidos.OBTENER_INSTANCIA();
            oUsuario = miUSUARIO;
            APAGAR_BOTONES();
            ARMA_MENU();
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    if (oPermiso.DESCRIPCION.Contains("Insumos"))
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {
                            case 1:
                                btnAGREGAR.Enabled = true;
                                break;
                            case 2:
                                btnELIMINAR.Enabled = true;
                                break;
                            case 3:
                                btnMODIFICAR.Enabled = true;
                                break;
                            case 4:
                                break;
                            default:
                                MessageBox.Show("Error en permiso");
                                break;
                        }
                    }
                }
            }
        }
        public void APAGAR_BOTONES()
        {
            btnAGREGAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnMODIFICAR.Enabled = false;
        }
        private void ARMAR_GRILLA()
        {
            dgvPEDIDOS.DataSource = null;
            dgvPEDIDOS.DataSource = cPedido.LISTAR_PEDIDOS();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmPEDIDO abrir = new frmPEDIDO(new Modelo.Pedido(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvPEDIDOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Pedido", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPEDIDO abrir = new frmPEDIDO(cPedido.BUSCAR_PEDIDO(Convert.ToInt32(dgvPEDIDOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvPEDIDOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Pedido", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Confirma eliminar el pedido seleccionado?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cPedido.ELIMINAR_PEDIDO(cPedido.BUSCAR_PEDIDO(Convert.ToInt32(dgvPEDIDOS.CurrentRow.Cells[0].Value)));
                ARMAR_GRILLA();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARPEDIDOS abrir = new frmBUSCARPEDIDOS("TODO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dgvPEDIDOS.DataSource = null;
                dgvPEDIDOS.DataSource = abrir.returndgv.DataSource;
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
