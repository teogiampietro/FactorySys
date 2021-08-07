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
    public partial class frmLOGIN : Form
    {
        Controladora.Facade cUsuarios;
        Modelo.Usuario oUsuario;
        Controladora.LogInOuts cLog;
        Modelo.LogInOut oLog;
        public static frmLOGIN instancia;
        public static frmLOGIN OBTENER_INSTANCIA(string ACCION)
        {
            if (instancia == null)
            {
                instancia = new frmLOGIN(ACCION);
            }
            return instancia;
        }
        public frmLOGIN(string miACCION)
        {
            InitializeComponent();
            cLog = Controladora.LogInOuts.OBTENER_INSTANCIA();
            string ACCION = miACCION;
            if (ACCION == "NUEVA")
            {
                txtUSER.Clear();
                txtPWD.Clear();
            }           
        }      
        public void LOGUEAR()
        {
            
            cUsuarios = Controladora.Facade.OBTENER_INSTANCIA();
            oUsuario = cUsuarios.BUSCAR(txtUSER.Text, txtPWD.Text);
            if (oUsuario != null)
            {
                if (oUsuario.PRIMERA == true)
                {
                    frmPRIMERLOGIN abrirprimera = new frmPRIMERLOGIN(oUsuario);
                    DialogResult resultado = abrirprimera.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        LOGUINOK(oUsuario);
                        LogIn();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    LOGUINOK(oUsuario);
                    LogIn();
                }               
            }
            else
            {
                MessageBox.Show("Datos incorectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogIn()
        {
            oLog = new Modelo.LogInOut();
            oLog.USUARIO = oUsuario;
            oLog.ACCION = "LOG IN";
            oLog.FECHA = DateTime.Now;
            cLog.AGREGAR_LOGINOUT(oLog);
        }

        public void LOGUINOK (Modelo.Usuario oUsuario)
        {
            MessageBox.Show("¡Bienvenido " + oUsuario.NOMBRE + "!", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMAIN abrir = new frmMAIN(oUsuario);
            abrir.Show();
            this.Hide();
        }
        public void btnACEPTAR_Click(object sender, EventArgs e)
        {
            Controladora.A_Insumos A_insumos;
            A_insumos = Controladora.A_Insumos.OBTENER_INSTANCIA();
            A_insumos.LISTAR_A_INSUMOS();

            if ((string.IsNullOrEmpty(txtUSER.Text)) || (string.IsNullOrEmpty(txtPWD.Text)))
            {
                MessageBox.Show("Campos vacios. Por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            LOGUEAR();

        }
        private void txtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if ((string.IsNullOrEmpty(txtUSER.Text)) || (string.IsNullOrEmpty(txtPWD.Text)))
                {
                    MessageBox.Show("Campos vacios. Por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LOGUEAR();
            }
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
