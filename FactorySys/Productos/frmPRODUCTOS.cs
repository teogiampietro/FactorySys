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
    public partial class frmPRODUCTOS : Form
    {
        public static frmPRODUCTOS instancia;
        public static frmPRODUCTOS OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmPRODUCTOS(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Productos cProductos;
        Modelo.Usuario oUsuario;
        public frmPRODUCTOS(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cProductos = Controladora.Productos.OBTENER_INSTANCIA();
            oUsuario = miUSUARIO;
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    if (oPermiso.DESCRIPCION.Contains("Insumos"))
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {
                            case 1:
                                btnAGREGAR.Enabled = true;
                                break;
                            case 2:
                                btnELIMINAR.Enabled = true;
                                break;
                            case 3:
                                btnMODIFICAR.Enabled = true;
                                break;
                            case 4:
                                btnCONSULTAR.Enabled = true;
                                break;
                            default:
                                MessageBox.Show("Error en permiso");
                                break;
                        }
                    }
                }
            }
        }
        public void APAGAR_BOTONES()
        {
            btnAGREGAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnMODIFICAR.Enabled = false;
            btnCONSULTAR.Enabled = false;
        }
        public void ARMAR_GRILLA()
        {
            DGVproductos.DataSource = null;
            DGVproductos.DataSource = cProductos.LISTAR_PRODUCTOS();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmPRODUCTO abrir = new frmPRODUCTO(new Modelo.Producto(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGVproductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPRODUCTO abrir = new frmPRODUCTO(cProductos.BUSCAR_PRODUCTO(Convert.ToInt32(DGVproductos.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVproductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Confirma eliminar el producto seleccionado?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cProductos.ELIMINAR_PRODUCTO(cProductos.BUSCAR_PRODUCTO(Convert.ToInt32(DGVproductos.CurrentRow.Cells[0].Value)));
                ARMAR_GRILLA();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVproductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPRODUCTO abrir = new frmPRODUCTO(cProductos.BUSCAR_PRODUCTO(Convert.ToInt32(DGVproductos.CurrentRow.Cells[0].Value)), "C");
            abrir.ShowDialog();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARPRODUCTO abrir = new frmBUSCARPRODUCTO("TODOS");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                DGVproductos.DataSource = abrir.productosSeleccionados;
            }
        }
    }
}
