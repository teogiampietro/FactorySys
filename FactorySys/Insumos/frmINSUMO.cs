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
    public partial class frmINSUMO : Form
    {
        Controladora.Insumos cInsumo;
        Modelo.Insumo oInsumo;
        string accion;
        public frmINSUMO(Modelo.Insumo MiInsumo, string MiAccion)
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            cInsumo = Controladora.Insumos.OBTENER_INSTANCIA();
            oInsumo = MiInsumo;
            accion = MiAccion;
            txtCodigo.Enabled = false;
            if (accion != "A")
            {
                txtCodigoInsumo.Text = oInsumo.CODIGO_INSUMO.ToString();
                txtDetalle.Text = oInsumo.DETALLE;
                txtNombre.Text = oInsumo.NOMBRE_INSUMO;
                mtxtMin.Text = oInsumo.STOCK_MIN.ToString();
                mtxtMax.Text = oInsumo.STOCK_MAX.ToString();
                txtPRECIO.Text = oInsumo.PRECIO.ToString();
                if (accion == "C")
                {
                    btnGuardar.Enabled = false;
                }
            }           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCodigoInsumo.Text))
            {
                MessageBox.Show("Ingrese el codigo del insumo", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDetalle.Text))
            {
                MessageBox.Show("Ingrese un detalle acotado del insumo", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del insumo", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            oInsumo.NOMBRE_INSUMO = txtNombre.Text;
            oInsumo.DETALLE = txtDetalle.Text;
            oInsumo.CODIGO_INSUMO = txtCodigoInsumo.Text;
            oInsumo.STOCK_MIN = Convert.ToInt32(mtxtMin.Text);
            oInsumo.STOCK_MAX = Convert.ToInt32(mtxtMax.Text);
            oInsumo.PRECIO = Convert.ToDecimal(txtPRECIO.Text);
            oInsumo.CANTIDAD = 0;
            if (accion == "A")
            {
                cInsumo.AGREGAR_INSUMO(oInsumo);
            }
            else
            {
                cInsumo.MODIFICAR_INSUMO(oInsumo);
            }
            DialogResult = DialogResult.OK;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
