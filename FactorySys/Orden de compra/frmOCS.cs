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
    public partial class frmORDENES : Form
    {
        public static frmORDENES instancia;
        public static frmORDENES OBTENER_INSTANCIA(Modelo.Usuario miUsuario)
        {
            if (instancia == null || instancia.IsDisposed)
            {
               instancia = new frmORDENES(miUsuario);
            }
            return instancia;
        }
        Controladora.OrdenesCompra cOrden;
        Modelo.Usuario oUsuario;
        private frmORDENES(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cOrden = Controladora.OrdenesCompra.OBTENER_INSTANCIA();
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
                    if (oPermiso.DESCRIPCION.Contains("OrdenCompra"))
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
            dgvORDENES.DataSource = null;
            dgvORDENES.DataSource = cOrden.OBTENER_ORDENES();
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmORDEN abrir = new frmORDEN(new Modelo.OrdenCompra(), "A");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
               ARMAR_GRILLA();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Orden_de_compra.frmBUSCAROC abrir = new Orden_de_compra.frmBUSCAROC("TODO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dgvORDENES.DataSource = abrir.Lista_Ordenes;
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmORDEN abrir = new frmORDEN(cOrden.BUSCAR_OC(Convert.ToInt32(dgvORDENES.CurrentRow.Cells[0].Value)),"M");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Orden de Compra", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modelo.OrdenCompra oOrden = cOrden.BUSCAR_OC(Convert.ToInt32(dgvORDENES.CurrentRow.Cells[0].Value));
            DialogResult pregunta = MessageBox.Show("Desea dar de baja la Orden de compra con codigo: " + " " + oOrden.CODIGO_ORDEN + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                cOrden.ELIMINAR_ORDENCOMPRA(oOrden);
                ARMAR_GRILLA();
            }
        }
    }
}
