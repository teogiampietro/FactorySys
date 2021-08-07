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
    public partial class frmORDEN : Form
    {
        string ACCION;
        decimal TOTAL;
        Modelo.OrdenCompra oOrden;
        Modelo.LineaOrdenCompra oLinea;        
        Modelo.Insumo oInsumo;
        Modelo.Proveedor oProveedor;

        ICollection<Modelo.LineaOrdenCompra> Lineas_Eliminar;
        ICollection<Modelo.LineaOrdenCompra> Lineas_Cancelar;
        Controladora.OrdenesCompra cOrden;
        public frmORDEN(Modelo.OrdenCompra miORDEN, string miACCION)
        {
            InitializeComponent();            
            oOrden = miORDEN;
            ACCION = miACCION;
            txtTOTAL.Enabled = false;
            txtPROVEEDOR.Enabled = false;
            txtINSUMO.Enabled = false;
            cOrden = Controladora.OrdenesCompra.OBTENER_INSTANCIA();
            Lineas_Eliminar = new HashSet<Modelo.LineaOrdenCompra>();
            Lineas_Cancelar = oOrden.LINEAOC.ToList();
            cmbENTREGA.DataSource = cOrden.LISTAR_ENTREGA();
            cmbENTREGA.DisplayMember = "NOMBRE";
            cmbENTREGA.SelectedIndex = 0;
            cmbENTREGA.Enabled = false;
            if (ACCION != "A")
            {
                if (oOrden.ESTADO == "Entregado")
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    btnVERIFICAR.Enabled = false;
                    btnGUARDAR.Enabled = false;
                }
                TOTAL = oOrden.TOTAL;
                btnPROVEEDOR.Enabled = false;
                txtPROVEEDOR.Text = oOrden.PROVEEDOR.NOMBRE;
                dtpFECHA.Value = oOrden.FECHA_EMISION;
                txtTOTAL.Text = oOrden.TOTAL.ToString();
                oProveedor = oOrden.PROVEEDOR;
                ARMAR_GRILLA();                           
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvLINEAOC.DataSource = oOrden.LINEAOC.ToList();
            dgvLINEAOC.Columns[3].Visible = false;
            dgvLINEAOC.Columns[5].Visible = false;
            dgvLINEAOC.Columns[6].Visible = false;
            dgvLINEAOC.Columns[7].Visible = false;
        }

        private void btnPROVEEDOR_Click(object sender, EventArgs e)
        {
            Proveedores.frmBUSCARPROVEEDOR abrir = new Proveedores.frmBUSCARPROVEEDOR("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oProveedor = abrir.oProveedor;
                txtPROVEEDOR.Text = oProveedor.NOMBRE;            
            }
        }
        private void btnINSUMO_Click(object sender, EventArgs e)
        {
            Insumos.frmBUSCARINSUMO abrir = new Insumos.frmBUSCARINSUMO("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oInsumo = abrir.insumoSeleccionado;
                txtINSUMO.Text = oInsumo.NOMBRE_INSUMO;
                txtPRECIO.Text = oInsumo.PRECIO.ToString();
            }
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            //Cargo los datos a la lineaOC
            if (oInsumo == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCANTIDAD.Text)|| string.IsNullOrEmpty(txtPRECIO.Text))
            {
                return;
            }
            if (oOrden.LINEAOC.Count == 0)
            {
                TOTAL = 0;
            }
            
            oLinea = new Modelo.LineaOrdenCompra();

            oLinea.INSUMO = oInsumo;
            oLinea.CANTIDAD = Convert.ToInt32(txtCANTIDAD.Text);
            oLinea.PRECIO = Convert.ToDecimal(txtPRECIO.Text);
            oLinea.ENTREGA = (Modelo.Entrega)cmbENTREGA.SelectedItem;
            
            //Agrego la lineaOC
            oOrden.LINEAOC.Add(oLinea);
            //Cargo el total al txt toal;
            TOTAL += oLinea.SUB_TOTAL;
            txtTOTAL.Text = TOTAL.ToString();
       
            ARMAR_GRILLA();
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEAOC.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Linea de OC", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oLinea = (Modelo.LineaOrdenCompra)dgvLINEAOC.CurrentRow.DataBoundItem;
            oOrden.LINEAOC.Remove(oLinea);
            Lineas_Eliminar.Add(oLinea);
            TOTAL = 0;
            foreach (var item in oOrden.LINEAOC.ToList())
            {
                TOTAL += item.SUB_TOTAL;
            }
            txtTOTAL.Text = TOTAL.ToString();
            ARMAR_GRILLA();
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEAOC.Rows.Count == 0)
            {
                MessageBox.Show("No puede generar una Orden de Compra sin ninguna linea en el Detalle. Intente agregando lineas.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (oProveedor == null)
            {
                MessageBox.Show("No puede generar una Orden de Compra sin un proveedor asignado. Intente asignando uno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            oOrden.PROVEEDOR = oProveedor;
            oOrden.FECHA_EMISION = dtpFECHA.Value;
            oOrden.VERIFICADO = false;
            if (ACCION == "A")
            {
                oOrden.ESTADO = "Abierta";
                
                cOrden.AGREGAR_ORDENDECOMPRA(oOrden);               
            }
            else
            {
                cOrden.MODIFICAR_ORDENCOMPRA(oOrden,Lineas_Eliminar);
            }        
            this.DialogResult = DialogResult.OK;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oOrden.LINEAOC = Lineas_Cancelar;
            this.DialogResult = DialogResult.Cancel;
        }
        private void frmORDEN_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.RefreshReport();
        }

        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {
            if (ACCION == "M")
            {
                if (oOrden.VERIFICADO == false)
                {                   
                    oOrden.VERIFICADO = true;
                    cOrden.MODIFICAR_ORDENCOMPRA(oOrden, new HashSet<Modelo.LineaOrdenCompra>());
                    MessageBox.Show("Orden de compra verificada con éxito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                if (oOrden.VERIFICADO == true)
                {
                    
                    oOrden.VERIFICADO = false;
                    cOrden.MODIFICAR_ORDENCOMPRA(oOrden, new HashSet<Modelo.LineaOrdenCompra>());
                    MessageBox.Show("Se ha cancelado la verificacion.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }
            else
            {
                btnVERIFICAR.Enabled = false;
            }
            
        }
    }
}
