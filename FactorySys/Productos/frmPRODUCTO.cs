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
    public partial class frmPRODUCTO : Form
    {
        Modelo.Producto oProducto;
        Controladora.Productos cProducto;
        Modelo.Insumo InsumoSelecionado;
        Modelo.LineaProducto oLinea_Producto;
        Modelo.Insumo oInsumo;
        string ACCION;
        public frmPRODUCTO(Modelo.Producto miPRODUCTO, string miACCION)
        {
            InitializeComponent();
            cProducto = Controladora.Productos.OBTENER_INSTANCIA();
            oProducto = miPRODUCTO;
            ACCION = miACCION;
            cmbTIPO.DataSource = cProducto.LISTAR_TIPOS();
            cmbTIPO.DisplayMember = "NOMBRE";
            if (ACCION != "A")
            {
                txtDESCRIPCION.Text = oProducto.DESCRIPCION;
                txtCODIGO.Text = oProducto.CODIGO;
                txtDETALLE.Text = oProducto.DETALLE;
                txtCODIGO_PRODUCTO.Text = oProducto.CODIGO_PRODUCTO.ToString();
                txtTOTAL.Text = oProducto.COSTO_PRODUCTO.ToString();
                cmbTIPO.SelectedItem = oProducto.TIPO;
                ARMAR_GRILLA();
                if (ACCION == "C")
                {
                    btnGUARDAR.Enabled = false;

                }
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvLINEA_PRODUCTO.DataSource = null;
            dgvLINEA_PRODUCTO.DataSource = oProducto.LINEA_PRODUCTO.ToList();
            //Oculto lineas que no interesan
            dgvLINEA_PRODUCTO.Columns[0].Visible = false;
            dgvLINEA_PRODUCTO.Columns[3].Visible = false;
            dgvLINEA_PRODUCTO.Columns[4].Visible = false;
            dgvLINEA_PRODUCTO.Columns[2].Width = 159;
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_PRODUCTO.Rows.Count == 0)
            {
                MessageBox.Show("No puede generar un Producto sin Insumos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            oProducto.CODIGO = txtCODIGO.Text;
            oProducto.DESCRIPCION = txtDESCRIPCION.Text;
            oProducto.DETALLE = txtDETALLE.Text;
            oProducto.CANTIDAD = 1;
            oProducto.TIPO = (Modelo.Tipo)cmbTIPO.SelectedItem;
            oProducto.COSTO_PRODUCTO = Convert.ToDecimal(txtTOTAL.Text);
            if (ACCION == "A")
            {
                cProducto.AGREGAR_PRODUCTO(oProducto);
            }
            if (ACCION == "M")
            {
                cProducto.MODIFICAR_PRODUCTO(oProducto);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnINSUMO_Click(object sender, EventArgs e)
        {
            Insumos.frmBUSCARINSUMO abrir = new Insumos.frmBUSCARINSUMO("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                InsumoSelecionado = abrir.insumoSeleccionado;
                txtINSUMO.Text = InsumoSelecionado.NOMBRE_INSUMO;
                txtCODIGO_INSUMO.Text = InsumoSelecionado.CODIGO.ToString();
                txtCANTIDAD.Text = InsumoSelecionado.CANTIDAD.ToString();
            }
        }

        decimal aux;
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (InsumoSelecionado == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCANTIDAD.Text))
            {
                return;
            }
            oLinea_Producto = new Modelo.LineaProducto();
            oLinea_Producto.INSUMO = InsumoSelecionado;
            oLinea_Producto.COSTO = InsumoSelecionado.PRECIO;
            oLinea_Producto.CANTIDAD = Convert.ToInt32(txtCANTIDAD.Text);

            oProducto.LINEA_PRODUCTO.Add(oLinea_Producto);
            aux += (oLinea_Producto.CANTIDAD * oLinea_Producto.COSTO);
            txtTOTAL.Text = aux.ToString();
            ARMAR_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_PRODUCTO.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un insumo a remover.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oLinea_Producto = (Modelo.LineaProducto)dgvLINEA_PRODUCTO.CurrentRow.DataBoundItem;
            oProducto.LINEA_PRODUCTO.Remove(oLinea_Producto);
            aux -= (oLinea_Producto.CANTIDAD * oLinea_Producto.COSTO);
            txtTOTAL.Text = aux.ToString();
            ARMAR_GRILLA();
        }
    }
}
