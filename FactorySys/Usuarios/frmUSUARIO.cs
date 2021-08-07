using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Usuarios
{
    public partial class frmUSUARIO : Form
    {
        Controladora.Facade cFacada;
        Controladora.Facade cGrupo;
        Modelo.Usuario oUsuario;
        
        string ACCION;
        public frmUSUARIO(Modelo.Usuario miUSUARIO, string miACCION)
        {
            InitializeComponent();
            cFacada = Controladora.Facade.OBTENER_INSTANCIA();
            oUsuario = miUSUARIO;
            ACCION = miACCION;
            chklGRUPO.DataSource = cFacada.OBTENER_GRUPOS();
            chklGRUPO.DisplayMember = "NOMBRE";
            btnCLAVE.Enabled = false;
            List<Int32> listaIndex = new List<Int32>();
            if (ACCION != "A")
            {
                txtCODIGO.Text = oUsuario.CODIGO_USUARIO.ToString();
                txtUSUARIO.Text = oUsuario.USUARIO;
                txtNOMBRE.Text = oUsuario.NOMBRE;
                txtEMAIL.Text = oUsuario.EMAIL;
                chklGRUPO.ClearSelected();
                CheckedListBox.ObjectCollection lista = chklGRUPO.Items;
                btnCLAVE.Enabled = true;
                foreach (var grupos in oUsuario.GRUPO.ToList())
                {                   
                    foreach (Modelo.Grupo item in lista)
                    {
                        if (grupos.NOMBRE == item.NOMBRE)
                        {
                           Int32 index =chklGRUPO.Items.IndexOf(item);
                            listaIndex.Add(index);                           
                        }
                    }
                }
                foreach (var item in listaIndex.ToList())
                {
                    chklGRUPO.SetItemChecked(item, true);
                }
                if (ACCION == "C")
                {
                    btnGUARDAR.Enabled = false;
                    btnCLAVE.Enabled = false;
                }
            }
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Complete el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (COMUN.MetodosComunes.ValidacionEMAIL(e, txtEMAIL.Text) == false)
            {
                MessageBox.Show("Mail invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oUsuario.NOMBRE = txtNOMBRE.Text;
            oUsuario.USUARIO = txtUSUARIO.Text;
            oUsuario.CONTRASEÑA = COMUN.MetodosComunes.Encriptar(txtUSUARIO.Text);  
            oUsuario.EMAIL = txtEMAIL.Text;
            
            foreach (var item in chklGRUPO.CheckedItems)
            {
                oUsuario.GRUPO.Add((Modelo.Grupo)item);
            }
            if (ACCION == "A")
            {
                oUsuario.PRIMERA = true;
                cFacada.AGREGAR_USUARIO(oUsuario);                
            }
            if (ACCION == "M")
                cFacada.MODIFICAR_USUARIO(oUsuario);

            this.DialogResult = DialogResult.OK;          
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnCLAVE_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Resetear clave del usuario " + oUsuario.NOMBRE + " ?","Pregunto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                oUsuario.CONTRASEÑA = COMUN.MetodosComunes.Encriptar(oUsuario.USUARIO); 
                oUsuario.PRIMERA = true;
                cFacada.MODIFICAR_USUARIO(oUsuario);
                MessageBox.Show("Clave restablecida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
    }
}
