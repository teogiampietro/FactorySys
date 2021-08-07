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
    public partial class frmCLIENTE : Form
    {
        Controladora.Clientes cCliente;
        Modelo.Cliente oCliente;
        string ACCION;
        public frmCLIENTE(Modelo.Cliente miCLIENTE, string miACCION)
        {
            InitializeComponent();
            cCliente = Controladora.Clientes.OBTENER_INSTANCIA();
            oCliente = miCLIENTE;
            ACCION = miACCION;
            cmbPAIS.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_PAIS();
            cmbPAIS.DisplayMember = "NOMBRE_PAIS";
            cmbPROVINCIA.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_PROVINCIAS(cmbPAIS.SelectedIndex + 1);
            cmbPROVINCIA.DisplayMember = "NOMBRE_PROVINCIA";
            cmbLOCALIDAD.DataSource = Controladora.Proveedores.OBTENER_INSTANCIA().LISTAR_LOCALIDAD(cmbPROVINCIA.SelectedIndex + 1);
            cmbLOCALIDAD.DisplayMember = "NOMBRE_LOCALIDAD";
            cmbCATEGORIA.SelectedItem = "C";
            if (ACCION != "A")
            {
                txtNombre.Text = oCliente.NOMBRE;          
                txtCodigo.Text = oCliente.CODIGO_CLIENTE.ToString();
                cmbPROVINCIA.SelectedIndex = oCliente.LOCALIDAD.PROVINCIA.CODIGO_PROVINCIA - 1;
                cmbLOCALIDAD.SelectedItem = oCliente.LOCALIDAD;             
                cmbCATEGORIA.SelectedItem = oCliente.CATEGORIA;
                txtDNI.Text = oCliente.DNI.ToString();
                txtDireccion.Text = oCliente.DIRECCION;
                txtTelefono.Text = oCliente.TELEFONO;
                txtEmail.Text = oCliente.EMAIL;
                txtCelular.Text = oCliente.CELULAR;
                rtxbObservaciones.Text = oCliente.OBSERVACIONES;
                if (ACCION == "C")
                {
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Ingrese un numero de celular", "Atencion", 0, MessageBoxIcon.Hand);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Ingrese numero de DNI", "Atencion", 0, MessageBoxIcon.Hand);
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
            oCliente.NOMBRE = txtNombre.Text;
            oCliente.LOCALIDAD = (Modelo.Localidad)cmbLOCALIDAD.SelectedItem;
            //oCliente.PROVINCIA = cmbPROVINCIA.SelectedItem;
            oCliente.DIRECCION = txtDireccion.Text;
            oCliente.DNI = txtDNI.Text;
            oCliente.CATEGORIA = cmbCATEGORIA.SelectedItem.ToString();
            oCliente.TELEFONO = txtTelefono.Text;
            oCliente.CELULAR = txtCelular.Text;
            oCliente.EMAIL = txtEmail.Text;
            if (ACCION == "A")
            {
                cCliente.AGREGAR_CLIENTE(oCliente);
            }
            else
            {
                cCliente.MODIFICAR_CLIENTE(oCliente);
            }
            this.DialogResult = DialogResult.OK;
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
