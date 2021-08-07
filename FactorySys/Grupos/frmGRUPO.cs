using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Grupos
{
    public partial class frmGRUPO : Form
    {
        Controladora.Facade cFacade;
        Modelo.Grupo oGrupo;
        Modelo.Permiso oPermiso;
        string ACCION;        
        public frmGRUPO(Modelo.Grupo miGRUPO, string miACCION)
        {
            InitializeComponent();
            cFacade = Controladora.Facade.OBTENER_INSTANCIA();
            oGrupo = miGRUPO;      
            ACCION = miACCION;
            CARGAR_CHK();
            if (ACCION != "A")
            {
                txtNOMBRE.Text = oGrupo.NOMBRE;
                int num = 0;
                LIMPIAR_CHK_SELEC();
                for (int i = 4; i < oGrupo.PERMISOS.Count; i++)
                {
                    foreach (var oPermiso in oGrupo.PERMISOS.ToList())
                    {
                        switch (oPermiso.CODIGO_ACCION)
                        {
                            case 1:
                                //alta
                                num = oPermiso.CODIGO_FORMULARIO;
                                num--;
                                    chklALTA.SetItemChecked(num, true); 
                                break;
                            case 2:
                                //baja
                                num = oPermiso.CODIGO_FORMULARIO;
                                num--;
                                chklBAJA.SetItemChecked(num, true);
                                break;
                            case 3:
                                //modif
                                num = oPermiso.CODIGO_FORMULARIO;
                                num--;
                                chklMODIFICACION.SetItemChecked(num, true);
                                break;
                            case 4:
                                //consul
                                num = oPermiso.CODIGO_FORMULARIO;
                                num--; 
                                chklCONSULTA.SetItemChecked(num, true);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        public void CARGAR_CHK()
        {
            chklALTA.DataSource = cFacade.Obtener_Formularios("ALTA");
            chklALTA.DisplayMember = "NOMBRE";

            chklBAJA.DataSource = cFacade.Obtener_Formularios("BAJA");
            chklBAJA.DisplayMember = "NOMBRE";

            chklMODIFICACION.DataSource = cFacade.Obtener_Formularios("MODIFICACION");
            chklMODIFICACION.DisplayMember = "NOMBRE";

            chklCONSULTA.DataSource = cFacade.Obtener_Formularios("CONSULTA");
            chklCONSULTA.DisplayMember = "NOMBRE";
        }
        public void LIMPIAR_CHK_SELEC()
        {
            chklALTA.ClearSelected();
            chklBAJA.ClearSelected();
            chklCONSULTA.ClearSelected();
            chklMODIFICACION.ClearSelected();
        }     
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oGrupo.NOMBRE = txtNOMBRE.Text;
            if (ACCION == "A")
            {
                cFacade.AGREGAR_GRUPO(oGrupo); //SI ESTOY EN ALTA, CREA UN GRUPO, SIN PERMISOS
            }
            else
            {
                foreach (Modelo.Permiso oPermiso in oGrupo.PERMISOS.ToList()) //ELIMINO TODOS LOS PERMISOS DE UN GRUPO, PARA VOLVER A CARGARLOS YA MODIFICADOS
                {
                    cFacade.ELIMINAR_PERMISO(oPermiso);  
                }
                
            }
            //CARGAR PERMISOS AL GRUPO
            for (int i = 1; i <= 4; i++)
            {
                string descripcionACCION;
                CheckedListBox chk = null;
                switch (i) //Cada interacion "i", esta referenciada con una accion.
                {
                    case 1:
                        chk = chklALTA;
                        descripcionACCION = "Alta";
                        break;
                    case 2:
                        chk = chklBAJA;
                        descripcionACCION = "Baja";
                        break;
                    case 3:
                        chk = chklMODIFICACION;
                        descripcionACCION = "Modificacion";
                        break;
                    case 4:
                        chk = chklCONSULTA;
                        descripcionACCION = "Consulta";
                        break;
                    default:
                        MessageBox.Show("No funciono.");
                        return;
                }                
                foreach (Modelo.Formulario oFormulario in chk.CheckedItems)
                {
                    oPermiso = new Modelo.Permiso();      
                    oPermiso.CODIGO_FORMULARIO = oFormulario.CODIGO_FORMULARIO;
                    oPermiso.CODIGO_ACCION = i;
                    oPermiso.GRUPO = oGrupo;
                    oPermiso.DESCRIPCION = (oFormulario.NOMBRE + " " + descripcionACCION);
                    cFacade.AGREGAR_PERMISO(oPermiso);
                    oGrupo.PERMISOS.Add(oPermiso);
                    oPermiso = null;                   
                }            
            }
            cFacade.MODIFICAR_GRUPO(oGrupo);
            MessageBox.Show("¡Datos guardados!","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
