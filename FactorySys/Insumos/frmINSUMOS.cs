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
    public partial class frmINSUMOS : Form
    {
        public static frmINSUMOS instancia;
        public static frmINSUMOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmINSUMOS(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Insumos cInsumo;
        Modelo.Usuario oUsuario;
        private frmINSUMOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cInsumo = Controladora.Insumos.OBTENER_INSTANCIA();
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
            DGVInsumos.DataSource = null;
            DGVInsumos.DataSource = cInsumo.LISTAR_INSUMO(10);
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmINSUMO abrir = new frmINSUMO(new Modelo.Insumo(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {

            frmBUSCARINSUMO abrir = new frmBUSCARINSUMO("TODO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                DGVInsumos.DataSource = abrir.returndgv.DataSource;
            }
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGVInsumos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Insumo", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmINSUMO abrir = new frmINSUMO(cInsumo.BUSCAR_INSUMO(Convert.ToInt32(DGVInsumos.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (DGVInsumos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Insumo", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Confirma eliminar el insumo seleccionado?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cInsumo.ELIMINAR_INSUMO(cInsumo.BUSCAR_INSUMO(Convert.ToInt32(DGVInsumos.CurrentRow.Cells[0].Value)));
                ARMAR_GRILLA();
            }
        }
        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVInsumos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Insumo", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmINSUMO abrir = new frmINSUMO(cInsumo.BUSCAR_INSUMO(Convert.ToInt32(DGVInsumos.CurrentRow.Cells[0].Value)), "C");
            abrir.ShowDialog();
        }
    }
}
