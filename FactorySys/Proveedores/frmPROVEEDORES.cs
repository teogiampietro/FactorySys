using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Proveedores
{
    public partial class frmPROVEEDORES : Form
    {
        public static frmPROVEEDORES instancia;
        public static frmPROVEEDORES OBTENER_INSTANCIA(Modelo.Usuario miUSUARIO)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmPROVEEDORES(miUSUARIO);
            }
            return instancia;
        }
        Controladora.Proveedores cProveedor;
        Modelo.Usuario oUsuario;
        private frmPROVEEDORES(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cProveedor = Controladora.Proveedores.OBTENER_INSTANCIA();           
            oUsuario = miUSUARIO;
            APAGAR_BOTONES();
            ARMA_MENU();
        }
        public void ARMA_MENU()
        {
            foreach (var oGrupo in oUsuario.GRUPO)
            {
                foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                {
                    if (oPermiso.DESCRIPCION.Contains("Proveedores"))
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
        }
        public void ARMAR_GRILLA()
        {
            DGVProveedores.DataSource = null;
            DGVProveedores.DataSource = cProveedor.LISTAR_PROVEEDORES();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmPROVEEDOR abrir = new frmPROVEEDOR(new Modelo.Proveedor(), "A");
            DialogResult res = abrir.ShowDialog();
            if (res == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            frmBUSCARPROVEEDOR abrir = new frmBUSCARPROVEEDOR("TODOS");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                DGVProveedores.DataSource = abrir.Lista_Proveedores;
            }      
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (DGVProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPROVEEDOR abrir = new frmPROVEEDOR(cProveedor.BUSCAR_PROVEEDOR(Convert.ToInt32(DGVProveedores.CurrentRow.Cells[0].Value)), "C");
            abrir.ShowDialog();
        }
        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGVProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPROVEEDOR abrir = new frmPROVEEDOR(cProveedor.BUSCAR_PROVEEDOR(Convert.ToInt32(DGVProveedores.CurrentRow.Cells[0].Value)), "M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modelo.Proveedor oProveedor = cProveedor.BUSCAR_PROVEEDOR(Convert.ToInt32(DGVProveedores.CurrentRow.Cells[0].Value));
            DialogResult resultado = MessageBox.Show("Desea dar de baja el proveedor  " + " " + oProveedor.NOMBRE + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cProveedor.ELIMINAR_PROVEEDOR(oProveedor);
                ARMAR_GRILLA();
            }
        }
    }
}
