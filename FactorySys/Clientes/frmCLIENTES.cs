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
    public partial class frmCLIENTES : Form
    {
        public static frmCLIENTES instancia;
        public static frmCLIENTES OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmCLIENTES(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Clientes cCliente;
        Modelo.Cliente oCliente;
        Modelo.Usuario oUsuario;
        public frmCLIENTES(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cCliente = Controladora.Clientes.OBTENER_INSTANCIA();
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
                                btnCONSULTAR.Enabled = true;
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
            btnCONSULTAR.Enabled = false;
        }
        private void ARMAR_GRILLA()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = cCliente.LISTAR_CLIENTES();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmCLIENTE abrir = new frmCLIENTE(new Modelo.Cliente(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCLIENTE abrir = new frmCLIENTE(cCliente.BUSCAR_CLIENTE(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oCliente = cCliente.BUSCAR_CLIENTE(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
            DialogResult resultado = MessageBox.Show("Desea dar de baja el cliente " + oCliente.NOMBRE + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cCliente.ELIMINAR_CLIENTE(oCliente);
                ARMAR_GRILLA();
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARCLIENTE abrir = new frmBUSCARCLIENTE("TODO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dgvCLIENTES.DataSource = abrir.clientesSeleccionados;
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCLIENTE abrir = new frmCLIENTE(cCliente.BUSCAR_CLIENTE(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value)), "C");
            abrir.ShowDialog();
        }
    }
}
