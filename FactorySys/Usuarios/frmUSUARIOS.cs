using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Usuarios
{
    public partial class frmUSUARIOS : Form
    {
        public static frmUSUARIOS instancia;
        public static frmUSUARIOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmUSUARIOS(miUSUARIO);
            }   
            return instancia;
        }
        Controladora.Facade cUsuario;
        Modelo.Usuario oUsuario;
        private frmUSUARIOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cUsuario = Controladora.Facade.OBTENER_INSTANCIA();            
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
                    if (oPermiso.DESCRIPCION.Contains("Usuarios"))
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {
                            case 1:
                                btnALTA.Enabled = true;
                                break;
                            case 2:
                                btnBAJA.Enabled = true;
                                break;
                            case 3:
                                btnMODIFICACION.Enabled = true;
                                break;
                            default:
                                MessageBox.Show("Error en permiso");
                                break;
                        }
                    }                    
                }
            }
            if (btnALTA.Enabled == true || btnBAJA.Enabled == true ||  btnMODIFICACION.Enabled == true)
            {
                btnBUSCAR.Enabled = true;
            }
        }
        public void APAGAR_BOTONES()
        {
            btnALTA.Enabled = false;
            btnBAJA.Enabled = false;
            btnMODIFICACION.Enabled = false;
            btnBUSCAR.Enabled = false;
        }
        public void ARMAR_GRILLA()
        {
            dgvUSUARIOS.DataSource = null;
            dgvUSUARIOS.DataSource = cUsuario.LISTAR_USUARIOS(10);                  
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmUSUARIO abrir = new frmUSUARIO(new Modelo.Usuario(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("No se encuentran Usuarios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmUSUARIO abrir = new frmUSUARIO(cUsuario.BUSCAR_USUARIO(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
               ARMAR_GRILLA();
            }

        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("No se encuentran Usuarios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Confirma eliminar el objeto seleccionado?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cUsuario.ELMINIAR_USUARIO(cUsuario.BUSCAR_USUARIO(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)));
               ARMAR_GRILLA();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARUSUARIO abrir = new frmBUSCARUSUARIO();
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dgvUSUARIOS.DataSource = abrir.returndgv.DataSource;
            }
        }
    }
}
