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
    public partial class frmPROVEEDOR : Form
    {
        Controladora.Proveedores cProveedor;
        Modelo.Proveedor oProveedor;
        string accion;
        public frmPROVEEDOR(Modelo.Proveedor MiProveedor, string MiAccion)
        {
            InitializeComponent();
            cProveedor = Controladora.Proveedores.OBTENER_INSTANCIA();
            accion = MiAccion;
            oProveedor = MiProveedor;
            cmbPAIS.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_PAIS();
            cmbPAIS.DisplayMember = "NOMBRE_PAIS";
            cmbPROVINCIA.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_PROVINCIAS(cmbPAIS.SelectedIndex+1);
            cmbPROVINCIA.DisplayMember = "NOMBRE_PROVINCIA";
            cmbLOCALIDAD.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_LOCALIDAD(cmbPROVINCIA.SelectedIndex + 1);
            cmbLOCALIDAD.DisplayMember = "NOMBRE_LOCALIDAD";
            if (accion != "A")
            {
                txtNombre.Text = oProveedor.NOMBRE;
                txtCelular.Text = oProveedor.CELULAR;
                txtCodigo.Text = oProveedor.CODIGO_PROVEEDOR.ToString();
                txtCuit.Text = oProveedor.CUIT;            
                txtEmail.Text = oProveedor.EMAIL;
                cmbPROVINCIA.SelectedIndex = oProveedor.LOCALIDAD.PROVINCIA.CODIGO_PROVINCIA - 1;
                cmbLOCALIDAD.SelectedItem = oProveedor.LOCALIDAD;
                txtDireccion.Text = oProveedor.DIRECCION;
                txtRubro.Text = oProveedor.RUBRO;
                txtTelefono.Text = oProveedor.TELEFONO;             
                rtxbObservaciones.Text = oProveedor.OBSERVACIONES;
                if (accion == "C")
                {
                    btnGuardar.Enabled = false;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Ingrese un numero de celular", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Ingrese numero de CUIT", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese la dirreccion donde radica", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (cmbPROVINCIA.SelectedItem == null)
            {
                MessageBox.Show("Ingrese la provincia del proveedor", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (cmbLOCALIDAD.SelectedItem == null)
            {
                MessageBox.Show("Ingrese la localidad del proveedor", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRubro.Text))
            {
                MessageBox.Show("Ingrese el rubro", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un telefono fijo", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ingrese una casilla de correo", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            oProveedor.NOMBRE = txtNombre.Text;
            oProveedor.LOCALIDAD = (Modelo.Localidad)cmbLOCALIDAD.SelectedItem;
            oProveedor.CELULAR = txtCelular.Text;
            oProveedor.CUIT = txtCuit.Text;
            oProveedor.DIRECCION = txtDireccion.Text;
            oProveedor.EMAIL = txtEmail.Text;
            oProveedor.OBSERVACIONES = rtxbObservaciones.Text;
            oProveedor.RUBRO = txtRubro.Text;
            oProveedor.TELEFONO = txtTelefono.Text.ToString();
            if (accion == "A")
            {
                cProveedor.AGREGAR_PROVEEDOR(oProveedor);
            }
            else
            {
                cProveedor.MODIFICAR_PROVEEDOR(oProveedor);
            }
            DialogResult = DialogResult.OK;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbPROVINCIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLOCALIDAD.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_LOCALIDAD(cmbPROVINCIA.SelectedIndex + 1);
            cmbLOCALIDAD.DisplayMember = "NOMBRE_LOCALIDAD";
        }
    }
}
