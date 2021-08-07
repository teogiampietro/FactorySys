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
    public partial class frmMAIN : Form
    {
        Modelo.LogInOut oLog;
        Controladora.LogInOuts cLog;
        Modelo.Usuario oUsuario;
        Controladora.Facade cGrupo;
        public frmMAIN(Modelo.Usuario miUSUARIO)
        {          
            InitializeComponent();
            cLog = Controladora.LogInOuts.OBTENER_INSTANCIA();
            cGrupo = Controladora.Facade.OBTENER_INSTANCIA();           
            oUsuario = miUSUARIO;
            APAGAR_MENU();
            ARMA_MENU();            
        }
        public void APAGAR_MENU()
        {
            foreach (ToolStripMenuItem Modulos in menuStrip.Items)
            {
                foreach (ToolStripMenuItem dropFormularios in Modulos.DropDownItems)
                {
                    Modulos.Enabled = false;
                    dropFormularios.Enabled = false;
                }
            }
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    foreach (ToolStripMenuItem Modulos in menuStrip.Items)
                    {
                        foreach (ToolStripMenuItem dropFormularios in Modulos.DropDownItems)
                        {
                            if (oPermiso.DESCRIPCION.Contains(dropFormularios.Name))
                            {
                                Modulos.Enabled = true;;
                                dropFormularios.Enabled = true;
                            }
                        }
                    }
                }
            }
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            LogOut();
            frmLOGIN abrir = frmLOGIN.OBTENER_INSTANCIA("NUEVA");
            abrir.Show();
            this.Hide();
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmMAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogOut();
            Application.Exit();
        }
        public void LogOut()
        {
            oLog = new Modelo.LogInOut();
            oLog.ACCION = "LOG OUT";
            oLog.USUARIO = oUsuario;
            oLog.FECHA = DateTime.Now;
            cLog.AGREGAR_LOGINOUT(oLog);
        }
        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmORDENES abrir = frmORDENES.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void remitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remitos.frmREMITOS abrir = Remitos.frmREMITOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.frmPROVEEDORES abrir = FactorySys.Proveedores.frmPROVEEDORES.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insumos.frmINSUMOS abrir = FactorySys.Insumos.frmINSUMOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.frmUSUARIOS abrir = FactorySys.Usuarios.frmUSUARIOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos.frmGRUPOS abrir = FactorySys.Grupos.frmGRUPOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCLIENTES abrir = frmCLIENTES.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPRODUCTOS abrir = frmPRODUCTOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPEDIDOS abrir = frmPEDIDOS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void ordenDeFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOFS abrir = frmOFS.OBTENER_INSTANCIA(oUsuario);
            abrir.Show();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSTOCK abrir = frmSTOCK.OBTENER_INSTANCIA();
            abrir.Show();
        }
    }
}
