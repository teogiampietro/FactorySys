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
    public partial class frmSTOCK : Form
    {
        public static frmSTOCK instancia;
        public static frmSTOCK OBTENER_INSTANCIA()
        {
            if (instancia == null  || instancia.IsDisposed)
            {
                instancia = new frmSTOCK();
            }
            return instancia;
        }
        Controladora.Insumos cInsumos;
        public frmSTOCK()
        {
            InitializeComponent();
            cInsumos = Controladora.Insumos.OBTENER_INSTANCIA();
        }
        //REVISAR TEMA COLORES
        public void ARMAR_GRILLA()
        {
            dgvSTOCK.DataSource = null;
            dgvSTOCK.DataSource = cInsumos.LISTAR_INSUMO();
            if (dgvSTOCK.RowCount == 0)
            {
                return;
            }
            dgvSTOCK.Rows[1].DefaultCellStyle.BackColor = Color.Blue;
            foreach (DataGridViewRow Row in dgvSTOCK.Rows)
            {
                if(Convert.ToInt32(Row.Cells[4].Value)<=Convert.ToInt32(Row.Cells[5].Value))
                {
                    Row.DefaultCellStyle.BackColor = Color.IndianRed;
                }
                if (Convert.ToInt32(Row.Cells[4].Value) > Convert.ToInt32(Row.Cells[6].Value))
                {
                    Row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(Row.Cells[4].Value) < Convert.ToInt32(Row.Cells[6].Value) && Convert.ToInt32(Row.Cells[4].Value) > Convert.ToInt32(Row.Cells[5].Value))
                {
                    Row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }        
        }
        private void frmSTOCK_Load(object sender, EventArgs e)
        {
            ARMAR_GRILLA();
        }
    }
}
