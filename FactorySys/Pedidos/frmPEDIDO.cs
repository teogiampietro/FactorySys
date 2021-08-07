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
    public partial class frmPEDIDO : Form
    {
        Controladora.Pedidos cPedido;
        Controladora.Strategy myStrategy;
        Modelo.Pedido oPedido;
        Modelo.LineaPedido oLinea_Pedido;
        Modelo.Cliente oCliente;
        Modelo.Producto oProducto;
 
        string ACCION;
        decimal TOTAL;
        decimal COSTO_TOTAL;
        List<Modelo.LineaPedido> Lista_Linea_Pedido;
        public frmPEDIDO(Modelo.Pedido miPEDIDO, string miACCION)
        {
            InitializeComponent();
            cPedido = Controladora.Pedidos.OBTENER_INSTANCIA();
            oPedido = miPEDIDO;
            ACCION = miACCION;
            Lista_Linea_Pedido = oPedido.LINEA_PEDIDO.ToList();
            gbDETALLE.Enabled = false;
            if (ACCION != "A")
            {
                TOTAL = oPedido.TOTAL;
                COSTO_TOTAL = oPedido.COSTO_TOTAL;
                oCliente = oPedido.CLIENTE;
                CARGAR_CLIENTE();
                dtpFECHA.Value = oPedido.FECHA_ENTREGA;
                txtCOSTO_TOTAL.Text = oPedido.COSTO_TOTAL.ToString();
                txtTOTAL.Text = oPedido.TOTAL.ToString();             
                STRATEGY();  //PATRON STRATEGY
                ARMAR_GRILLA();
            }
        }
        public void ARMAR_GRILLA()
        {
            dgvLINEA_PEDIDO.DataSource = null;
            dgvLINEA_PEDIDO.DataSource = oPedido.LINEA_PEDIDO.ToList();
            dgvLINEA_PEDIDO.Columns[0].Visible = false;
        }
        private void btnCLIENTE_Click(object sender, EventArgs e)
        {
            frmBUSCARCLIENTE abrir = new frmBUSCARCLIENTE("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oCliente = abrir.clienteSeleccionado;
                CARGAR_CLIENTE();
            }
        }
        private void CARGAR_CLIENTE()
        {
            txtTELEFONO.Text = oCliente.TELEFONO;
            txtCLIENTE.Text = oCliente.NOMBRE;
            txtCATEOGIRA.Text = oCliente.CATEGORIA;
            switch (oCliente.CATEGORIA)
            {
                case "A":
                    txtPORCENTAJE.Text = "%15";
                    break;
                case "B":
                    txtPORCENTAJE.Text = "%10";
                    break;
                case "C":
                    txtPORCENTAJE.Text = "%0";
                    break;
                default:
                    txtPORCENTAJE.Text = "error";  //sino me toma la variable como no asignada
                    break;
            }
        }
        private void btnPRODUCTO_Click(object sender, EventArgs e)
        {
            frmBUSCARPRODUCTO abrir = new frmBUSCARPRODUCTO("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oProducto = abrir.productoSeleccionado;
                txtCOSTO.Text = oProducto.COSTO_PRODUCTO.ToString();
                txtPRODUCTO.Text = oProducto.DESCRIPCION;
                txtDETALLE.Text = oProducto.DETALLE;
                txtGANANCIA.Text = oProducto.TIPO.GANANCIA.ToString();

            }
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (oProducto == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCANTIDAD.Text)|| string.IsNullOrEmpty(txtGANANCIA.Text) || string.IsNullOrEmpty(txtCOSTO.Text))
            {
                return;
            }
            if (oPedido.LINEA_PEDIDO.Count == 0)
            {
                TOTAL = 0;
                COSTO_TOTAL = 0;
            }
            oLinea_Pedido = new Modelo.LineaPedido();

            oLinea_Pedido.PRODUCTO = oProducto;
            oLinea_Pedido.CANTIDAD = Convert.ToInt32(txtCANTIDAD.Text);
            oLinea_Pedido.COSTO = Math.Round(Convert.ToDecimal(txtCOSTO.Text));            
            oLinea_Pedido.PRECIO = Math.Round(oLinea_Pedido.COSTO + (oLinea_Pedido.COSTO * Convert.ToDecimal(txtGANANCIA.Text) / 100));
                      
            oPedido.LINEA_PEDIDO.Add(oLinea_Pedido);

            TOTAL += oLinea_Pedido.SUB_TOTAL;
            COSTO_TOTAL += oLinea_Pedido.SUB_TOTAL_COSTO;
            
            STRATEGY(); //PATRON STRATEGY
            txtCOSTO_TOTAL.Text = COSTO_TOTAL.ToString();
            txtTOTAL.Text = TOTAL.ToString();

            ARMAR_GRILLA();
        }       
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_PEDIDO.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oLinea_Pedido = (Modelo.LineaPedido)dgvLINEA_PEDIDO.CurrentRow.DataBoundItem;
            oPedido.LINEA_PEDIDO.Remove(oLinea_Pedido);
            

            TOTAL = 0;
            COSTO_TOTAL = 0;
            foreach (var item in oPedido.LINEA_PEDIDO.ToList())
            {
                TOTAL += item.SUB_TOTAL;
                COSTO_TOTAL += item.SUB_TOTAL_COSTO;
            }
            txtCOSTO_TOTAL.Text = COSTO_TOTAL.ToString();
            txtTOTAL.Text = TOTAL.ToString();
            STRATEGY();
            ARMAR_GRILLA();
        }
        private void STRATEGY()
        {
            switch (oCliente.CATEGORIA)
            {
                case "A":
                    myStrategy = new Controladora.EstrategiaA();
                    break;
                case "B":
                    myStrategy = new Controladora.EstrategiaB();
                    break;
                case "C":
                    myStrategy = new Controladora.EstrategiaC();
                    break;
                default:                   
                    break;
            }
            txtTOTAL_TOTAL.Text = myStrategy.Calculo(TOTAL).ToString();
            txtDESCUENTO.Text = Convert.ToString(TOTAL - myStrategy.Calculo(TOTAL));
        }
        string detalle = "";
        private void chkDETALLE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDETALLE.Checked)
            {
                txtDETALLE.Enabled = true;
                detalle = txtDETALLE.Text;
                txtDETALLE.Clear();
            }
            else
            {
                txtDETALLE.Enabled = false;
                txtDETALLE.Text = detalle;
            }
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oPedido.LINEA_PEDIDO = Lista_Linea_Pedido;
            DialogResult = DialogResult.Cancel;
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_PEDIDO.Rows.Count == 0)
            {
                MessageBox.Show("No es posible agregar un pedido sin productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDETALLE.Enabled == true)
            {
                oPedido.DETALLE = txtDETALLE.Text;
            }
            oPedido.CLIENTE = oCliente;
            oPedido.FECHA_ENTREGA = dtpFECHA.Value;
            
            if (ACCION == "A")
            {
                cPedido.AGREGAR_PEDIDO(oPedido);
            }
            if (ACCION == "M")
            {
                cPedido.MODIFICAR_PEDIDO(oPedido);
            }
            DialogResult = DialogResult.OK;
        }
        private void txtCLIENTE_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCLIENTE.Text))
            {
                gbDETALLE.Enabled = false;
            }
            else
            {
                gbDETALLE.Enabled = true;
            }
        }
    }
}
