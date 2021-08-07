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
    public partial class frmREMITOS : Form
    {
        public static frmREMITOS instancia;
        public static frmREMITOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmREMITOS(miUSUARIO);
            }
            return instancia;
        }
        Modelo.Usuario oUsuario;
        Controladora.Remitos cRemitos;
        private frmREMITOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            oUsuario = miUSUARIO;         
            cRemitos = Controladora.Remitos.OBTENER_INSTANCIA();
            APAGAR_BOTONES();
            ARMA_MENU();
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    if (oPermiso.DESCRIPCION.Contains("Remito"))
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
        public void ARMAR_GRILLA()
        {
            dgvREMITOS.DataSource = null;
            dgvREMITOS.DataSource = cRemitos.LISTAR_REMITOS();
        }
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARREMITO abrir = new frmBUSCARREMITO();
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dgvREMITOS.DataSource = null;
                dgvREMITOS.DataSource = abrir.returndgv.DataSource;
                
            }
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmREMITO abrir = new frmREMITO(new Modelo.Remito(),"A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("No se encuentran remitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmREMITO abrir = new frmREMITO(cRemitos.BUSCAR_REMITO(Convert.ToInt32(dgvREMITOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Remito", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modelo.Remito oRemito = cRemitos.BUSCAR_REMITO(Convert.ToInt32(dgvREMITOS.CurrentRow.Cells[0].Value));
            DialogResult pregunta = MessageBox.Show("Desea dar de baja el remito con codigo: " + " " + oRemito.CODIGO_REMITO + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                cRemitos.ELMINAR_REMITO(oRemito);
                ARMAR_GRILLA();
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
