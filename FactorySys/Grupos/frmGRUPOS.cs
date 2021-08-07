using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Grupos
{
    public partial class frmGRUPOS : Form
    {
        public static frmGRUPOS instancia;
        public static frmGRUPOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmGRUPOS(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Facade cGrupos;
        Modelo.Usuario oUsuario;
        private frmGRUPOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cGrupos = Controladora.Facade.OBTENER_INSTANCIA();
            ARMAR_GRILLA();
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
                    if (oPermiso.DESCRIPCION.Contains("Grupos"))
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
            dgvGRUPOS.DataSource = null;
            dgvGRUPOS.DataSource = cGrupos.LISTAR_GRUPOS();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmGRUPO abrir = new frmGRUPO(new Modelo.Grupo(),"A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("No se encuentran grupos");
                return;
            }
            frmGRUPO abrir = new frmGRUPO(cGrupos.BUSCAR_GRUPO(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("No se encuentran grupos");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Confirma eliminar por completo el grupo seleccionado?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cGrupos.ELIMINAR_GRUPO(cGrupos.BUSCAR_GRUPO(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)));
                ARMAR_GRILLA();
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
