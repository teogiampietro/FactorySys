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
    public partial class frmOF : Form
    {
        List<Modelo.LineaOrdenFabricación> Lista_Fabricacion;
        List<Modelo.Insumo> Lista_Insumos;
        Modelo.OrdenFabricacion oOF;
        Modelo.Pedido oPedido;
        Modelo.Usuario oUsuario;
        Modelo.LineaOrdenFabricación oLinea_Fabricacion;               
        Controladora.OrdenesFabricacion cOF;
        string ACCION;
        public frmOF(Modelo.OrdenFabricacion miORDEN, string miACCION, Modelo.Usuario Usuario)
        {
            InitializeComponent();
            cOF = Controladora.OrdenesFabricacion.OBTENER_INSTANCIA();
            oOF = miORDEN;
            oUsuario = Usuario;
            ACCION = miACCION;
            txtUSUARIO.Text = oUsuario.NOMBRE;
            cmbTAREAS.DataSource = cOF.LISTAR_TAREA();
            cmbTAREAS.DisplayMember = "NOMBRE";
            cmbESTADO.DataSource = cOF.LISTAR_ESTADOS();
            cmbESTADO.DisplayMember = "NOMBRE";
            if (ACCION != "A")
            {
                oPedido = oOF.PEDIDO;

                Lista_Insumos = cOF.LISTAR_INSUMOS(oPedido);
                Lista_Fabricacion = oOF.LINEA_OF.ToList();

                ARMAR_LINEA_INSUMOS();
                ARMAR_LINEA_PEDIDO();
                ARMAR_LINEA_FABRICACION();                      
                COMPLETAR_CAMPOS(oPedido);
                gbORIGEN.Enabled = false;
                txtCODIGO_OF.Text = oOF.CODIGO_OF.ToString(); ;
                txtUSUARIO.Text = oOF.USUARIO.NOMBRE;
                cmbESTADO.SelectedItem = oOF.ESTADO;
                txtDESCRIPCION.Text = oOF.DESCRIPCION;
                if (oOF.ESTADO.NOMBRE == "FINALIZADA")
                {
                    gbOF.Enabled = false;
                    gbTAREAS.Enabled = false;
                }
            }          
        }
        private void ARMAR_LINEA_PEDIDO()
        {
            dgvLINEA_PEDIDO.DataSource = null;
            dgvLINEA_PEDIDO.DataSource = oPedido.LINEA_PEDIDO.ToList();
            dgvLINEA_PEDIDO.Columns[3].Visible = false;
            dgvLINEA_PEDIDO.Columns[5].Visible = false;
        }
        private void ARMAR_LINEA_INSUMOS()
        {
            dgvLINEA_INSUMOS.DataSource = null;
            dgvLINEA_INSUMOS.DataSource = cOF.ARMAR_INSUMOS(Lista_Insumos);
        }
        public void ARMAR_LINEA_FABRICACION()
        {
            dgvLINEA_FABRICACION.DataSource = null;
            dgvLINEA_FABRICACION.DataSource = oOF.LINEA_OF.ToList();
            dgvLINEA_FABRICACION.Columns[3].Width = 350;
            dgvLINEA_FABRICACION.Columns[1].Visible = false;
        }
        private void btnBUSCAR_PEDIDO_Click(object sender, EventArgs e)
        {
            frmBUSCARPEDIDOS abrir = new frmBUSCARPEDIDOS("NADA");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oPedido = abrir.pedidoSeleccionado;
                COMPLETAR_CAMPOS(oPedido);

                Lista_Insumos = new List<Modelo.Insumo>();
                Lista_Insumos = cOF.LISTAR_INSUMOS(oPedido);

                ARMAR_LINEA_INSUMOS();
                ARMAR_LINEA_PEDIDO();             
            }
        }

        private void COMPLETAR_CAMPOS(Modelo.Pedido oPedido)
        {
            txtPEDIDO.Text = oPedido.CODIGO_PEDIDO.ToString();
            txtCLIENTE.Text = oPedido.CODIGO_CLIENTE.ToString();
            txtNOMBRE.Text = oPedido.CLIENTE.NOMBRE;
            txtLOCALIDAD.Text = oPedido.CLIENTE.LOCALIDAD.ToString();
            txtDIRECCION.Text = oPedido.CLIENTE.DIRECCION;
            txtCLASE.Text = oPedido.CLIENTE.CATEGORIA;
            txtCOSTO_TOTAL.Text = oPedido.COSTO_TOTAL.ToString();
            txtTOTAL.Text = oPedido.TOTAL.ToString();
        }
       
        private void btnAGREGAR_PROCESO_Click(object sender, EventArgs e)
        {
            oLinea_Fabricacion = new Modelo.LineaOrdenFabricación();
            oLinea_Fabricacion.TAREA = (Modelo.Tarea)cmbTAREAS.SelectedItem;
            oLinea_Fabricacion.DETALLE = txtDETALLE.Text;
            oOF.LINEA_OF.Add(oLinea_Fabricacion);
            ARMAR_LINEA_FABRICACION();
            cmbTAREAS.SelectedIndex = 0;
            txtDETALLE.Clear();
        }
        private void btnELIMINAR_PROCESO_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_FABRICACION.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Linea", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oLinea_Fabricacion = (Modelo.LineaOrdenFabricación)dgvLINEA_FABRICACION.CurrentRow.DataBoundItem;
            oOF.LINEA_OF.Remove(oLinea_Fabricacion);
            ARMAR_LINEA_FABRICACION();
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oOF.LINEA_OF = Lista_Fabricacion;
            DialogResult = DialogResult.Cancel;
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {            
            oOF.DESCRIPCION = txtDESCRIPCION.Text;
            oOF.ESTADO = (Modelo.Estado)cmbESTADO.SelectedItem;
            oOF.USUARIO = oUsuario;

            if (ACCION == "A")
            {
                oOF.PEDIDO = oPedido;
                cOF.AGREGAR_OF(oOF);
            }
            else
            {
                cOF.MODIFICAR_OF(oOF);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
