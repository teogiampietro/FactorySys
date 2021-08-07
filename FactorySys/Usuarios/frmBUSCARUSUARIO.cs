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
    public partial class frmBUSCARUSUARIO : Form
    {
        public DataGridView returndgv
        {
            get { return dgvLISTA; }
        }
        Controladora.Facade cUsuarios;
        public frmBUSCARUSUARIO()
        {
            InitializeComponent();
            cUsuarios = Controladora.Facade.OBTENER_INSTANCIA();
        }
        private void ARMAR_GRILLA()
        {
            dgvLISTA.DataSource = null;
            dgvLISTA.DataSource = cUsuarios.LISTAR_USUARIOS(100,txtUSUARIO.Text, txtEMAIL.Text,txtNOMBRE.Text);
        }
        private void btnFILTRAR_Click(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

            
    }
}
