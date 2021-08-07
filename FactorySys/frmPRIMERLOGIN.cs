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
    public partial class frmPRIMERLOGIN : Form
    {
        Controladora.Facade cUsuario;
        Modelo.Usuario oUsuario;
        public frmPRIMERLOGIN(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cUsuario = Controladora.Facade.OBTENER_INSTANCIA();
            oUsuario = miUSUARIO;
            
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            if (txtCONTRASEÑA.Text != txtCONTRASEÑA2.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oUsuario.PRIMERA = false;
            oUsuario.CONTRASEÑA = COMUN.MetodosComunes.Encriptar(txtCONTRASEÑA.Text);
            cUsuario.MODIFICAR_USUARIO(oUsuario);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
