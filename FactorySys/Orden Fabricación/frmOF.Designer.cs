namespace FactorySys
{
    partial class frmOF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOF));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbORIGEN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.dgvLINEA_PEDIDO = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCOSTO_TOTAL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.txtPEDIDO = new System.Windows.Forms.TextBox();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLOCALIDAD = new System.Windows.Forms.TextBox();
            this.btnBUSCAR_PEDIDO = new System.Windows.Forms.Button();
            this.txtCLASE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLINEA_INSUMOS = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbTAREAS = new System.Windows.Forms.GroupBox();
            this.cmbTAREAS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnELIMINAR_PROCESO = new System.Windows.Forms.Button();
            this.btnAGREGAR_PROCESO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLINEA_FABRICACION = new System.Windows.Forms.DataGridView();
            this.txtDETALLE = new System.Windows.Forms.TextBox();
            this.gbOF = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.RichTextBox();
            this.dtpFECHA_OF = new System.Windows.Forms.DateTimePicker();
            this.txtCODIGO_OF = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbORIGEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_INSUMOS)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbTAREAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).BeginInit();
            this.gbOF.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 453);
            this.tabControl1.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbORIGEN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Origen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbORIGEN
            // 
            this.gbORIGEN.Controls.Add(this.label1);
            this.gbORIGEN.Controls.Add(this.txtTOTAL);
            this.gbORIGEN.Controls.Add(this.dgvLINEA_PEDIDO);
            this.gbORIGEN.Controls.Add(this.label15);
            this.gbORIGEN.Controls.Add(this.label9);
            this.gbORIGEN.Controls.Add(this.label13);
            this.gbORIGEN.Controls.Add(this.txtCOSTO_TOTAL);
            this.gbORIGEN.Controls.Add(this.label12);
            this.gbORIGEN.Controls.Add(this.label11);
            this.gbORIGEN.Controls.Add(this.label3);
            this.gbORIGEN.Controls.Add(this.txtNOMBRE);
            this.gbORIGEN.Controls.Add(this.txtDIRECCION);
            this.gbORIGEN.Controls.Add(this.txtPEDIDO);
            this.gbORIGEN.Controls.Add(this.txtCLIENTE);
            this.gbORIGEN.Controls.Add(this.label4);
            this.gbORIGEN.Controls.Add(this.txtLOCALIDAD);
            this.gbORIGEN.Controls.Add(this.btnBUSCAR_PEDIDO);
            this.gbORIGEN.Controls.Add(this.txtCLASE);
            this.gbORIGEN.Controls.Add(this.label10);
            this.gbORIGEN.Location = new System.Drawing.Point(6, 6);
            this.gbORIGEN.Name = "gbORIGEN";
            this.gbORIGEN.Size = new System.Drawing.Size(721, 415);
            this.gbORIGEN.TabIndex = 62;
            this.gbORIGEN.TabStop = false;
            this.gbORIGEN.Text = "Cliente/Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(587, 357);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(98, 20);
            this.txtTOTAL.TabIndex = 40;
            // 
            // dgvLINEA_PEDIDO
            // 
            this.dgvLINEA_PEDIDO.AllowUserToAddRows = false;
            this.dgvLINEA_PEDIDO.AllowUserToDeleteRows = false;
            this.dgvLINEA_PEDIDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_PEDIDO.Location = new System.Drawing.Point(40, 206);
            this.dgvLINEA_PEDIDO.Name = "dgvLINEA_PEDIDO";
            this.dgvLINEA_PEDIDO.ReadOnly = true;
            this.dgvLINEA_PEDIDO.Size = new System.Drawing.Size(645, 128);
            this.dgvLINEA_PEDIDO.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Nombre y Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Costo Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Direccion:";
            // 
            // txtCOSTO_TOTAL
            // 
            this.txtCOSTO_TOTAL.Enabled = false;
            this.txtCOSTO_TOTAL.Location = new System.Drawing.Point(483, 357);
            this.txtCOSTO_TOTAL.Name = "txtCOSTO_TOTAL";
            this.txtCOSTO_TOTAL.Size = new System.Drawing.Size(98, 20);
            this.txtCOSTO_TOTAL.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Numero Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lista de productos del pedido ";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Enabled = false;
            this.txtNOMBRE.Location = new System.Drawing.Point(195, 95);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(160, 20);
            this.txtNOMBRE.TabIndex = 24;
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Enabled = false;
            this.txtDIRECCION.Location = new System.Drawing.Point(434, 121);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(160, 20);
            this.txtDIRECCION.TabIndex = 26;
            // 
            // txtPEDIDO
            // 
            this.txtPEDIDO.Enabled = false;
            this.txtPEDIDO.Location = new System.Drawing.Point(195, 27);
            this.txtPEDIDO.Name = "txtPEDIDO";
            this.txtPEDIDO.Size = new System.Drawing.Size(160, 20);
            this.txtPEDIDO.TabIndex = 34;
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Enabled = false;
            this.txtCLIENTE.Location = new System.Drawing.Point(195, 54);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(160, 20);
            this.txtCLIENTE.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Numero Pedido:";
            // 
            // txtLOCALIDAD
            // 
            this.txtLOCALIDAD.Enabled = false;
            this.txtLOCALIDAD.Location = new System.Drawing.Point(195, 121);
            this.txtLOCALIDAD.Name = "txtLOCALIDAD";
            this.txtLOCALIDAD.Size = new System.Drawing.Size(160, 20);
            this.txtLOCALIDAD.TabIndex = 28;
            // 
            // btnBUSCAR_PEDIDO
            // 
            this.btnBUSCAR_PEDIDO.Image = global::FactorySys.Properties.Resources.find;
            this.btnBUSCAR_PEDIDO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR_PEDIDO.Location = new System.Drawing.Point(376, 27);
            this.btnBUSCAR_PEDIDO.Name = "btnBUSCAR_PEDIDO";
            this.btnBUSCAR_PEDIDO.Size = new System.Drawing.Size(218, 47);
            this.btnBUSCAR_PEDIDO.TabIndex = 32;
            this.btnBUSCAR_PEDIDO.Text = "Buscar Pedido";
            this.btnBUSCAR_PEDIDO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR_PEDIDO.UseVisualStyleBackColor = true;
            this.btnBUSCAR_PEDIDO.Click += new System.EventHandler(this.btnBUSCAR_PEDIDO_Click);
            // 
            // txtCLASE
            // 
            this.txtCLASE.Enabled = false;
            this.txtCLASE.Location = new System.Drawing.Point(195, 147);
            this.txtCLASE.Name = "txtCLASE";
            this.txtCLASE.Size = new System.Drawing.Size(160, 20);
            this.txtCLASE.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Clase:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insumos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLINEA_INSUMOS);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 415);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total insumos necesarios";
            // 
            // dgvLINEA_INSUMOS
            // 
            this.dgvLINEA_INSUMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_INSUMOS.Location = new System.Drawing.Point(19, 40);
            this.dgvLINEA_INSUMOS.Name = "dgvLINEA_INSUMOS";
            this.dgvLINEA_INSUMOS.Size = new System.Drawing.Size(671, 335);
            this.dgvLINEA_INSUMOS.TabIndex = 37;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbTAREAS);
            this.tabPage3.Controls.Add(this.gbOF);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(733, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Orden Fabricacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbTAREAS
            // 
            this.gbTAREAS.Controls.Add(this.cmbTAREAS);
            this.gbTAREAS.Controls.Add(this.label5);
            this.gbTAREAS.Controls.Add(this.btnELIMINAR_PROCESO);
            this.gbTAREAS.Controls.Add(this.btnAGREGAR_PROCESO);
            this.gbTAREAS.Controls.Add(this.label2);
            this.gbTAREAS.Controls.Add(this.dgvLINEA_FABRICACION);
            this.gbTAREAS.Controls.Add(this.txtDETALLE);
            this.gbTAREAS.Location = new System.Drawing.Point(6, 176);
            this.gbTAREAS.Name = "gbTAREAS";
            this.gbTAREAS.Size = new System.Drawing.Size(707, 245);
            this.gbTAREAS.TabIndex = 18;
            this.gbTAREAS.TabStop = false;
            this.gbTAREAS.Text = "Tareas de la Orden de Fabricacion";
            // 
            // cmbTAREAS
            // 
            this.cmbTAREAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTAREAS.FormattingEnabled = true;
            this.cmbTAREAS.Items.AddRange(new object[] {
            "Cortado",
            "Lijado",
            "Ensamblado",
            "Pintura"});
            this.cmbTAREAS.Location = new System.Drawing.Point(147, 28);
            this.cmbTAREAS.Name = "cmbTAREAS";
            this.cmbTAREAS.Size = new System.Drawing.Size(110, 21);
            this.cmbTAREAS.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tareas";
            // 
            // btnELIMINAR_PROCESO
            // 
            this.btnELIMINAR_PROCESO.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR_PROCESO.Image")));
            this.btnELIMINAR_PROCESO.Location = new System.Drawing.Point(570, 26);
            this.btnELIMINAR_PROCESO.Name = "btnELIMINAR_PROCESO";
            this.btnELIMINAR_PROCESO.Size = new System.Drawing.Size(25, 25);
            this.btnELIMINAR_PROCESO.TabIndex = 38;
            this.btnELIMINAR_PROCESO.UseVisualStyleBackColor = true;
            this.btnELIMINAR_PROCESO.Click += new System.EventHandler(this.btnELIMINAR_PROCESO_Click);
            // 
            // btnAGREGAR_PROCESO
            // 
            this.btnAGREGAR_PROCESO.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR_PROCESO.Image")));
            this.btnAGREGAR_PROCESO.Location = new System.Drawing.Point(539, 26);
            this.btnAGREGAR_PROCESO.Name = "btnAGREGAR_PROCESO";
            this.btnAGREGAR_PROCESO.Size = new System.Drawing.Size(25, 25);
            this.btnAGREGAR_PROCESO.TabIndex = 37;
            this.btnAGREGAR_PROCESO.UseVisualStyleBackColor = true;
            this.btnAGREGAR_PROCESO.Click += new System.EventHandler(this.btnAGREGAR_PROCESO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Detalle";
            // 
            // dgvLINEA_FABRICACION
            // 
            this.dgvLINEA_FABRICACION.AllowUserToAddRows = false;
            this.dgvLINEA_FABRICACION.AllowUserToDeleteRows = false;
            this.dgvLINEA_FABRICACION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_FABRICACION.Location = new System.Drawing.Point(46, 57);
            this.dgvLINEA_FABRICACION.Name = "dgvLINEA_FABRICACION";
            this.dgvLINEA_FABRICACION.ReadOnly = true;
            this.dgvLINEA_FABRICACION.Size = new System.Drawing.Size(595, 166);
            this.dgvLINEA_FABRICACION.TabIndex = 36;
            // 
            // txtDETALLE
            // 
            this.txtDETALLE.Location = new System.Drawing.Point(263, 29);
            this.txtDETALLE.Name = "txtDETALLE";
            this.txtDETALLE.Size = new System.Drawing.Size(265, 20);
            this.txtDETALLE.TabIndex = 17;
            // 
            // gbOF
            // 
            this.gbOF.Controls.Add(this.label6);
            this.gbOF.Controls.Add(this.txtDESCRIPCION);
            this.gbOF.Controls.Add(this.dtpFECHA_OF);
            this.gbOF.Controls.Add(this.txtCODIGO_OF);
            this.gbOF.Controls.Add(this.label19);
            this.gbOF.Controls.Add(this.label18);
            this.gbOF.Controls.Add(this.txtUSUARIO);
            this.gbOF.Controls.Add(this.cmbESTADO);
            this.gbOF.Controls.Add(this.label17);
            this.gbOF.Controls.Add(this.label16);
            this.gbOF.Location = new System.Drawing.Point(6, 17);
            this.gbOF.Name = "gbOF";
            this.gbOF.Size = new System.Drawing.Size(707, 153);
            this.gbOF.TabIndex = 17;
            this.gbOF.TabStop = false;
            this.gbOF.Text = "Orden de Fabricacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion:";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(96, 91);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(460, 44);
            this.txtDESCRIPCION.TabIndex = 17;
            this.txtDESCRIPCION.Text = "";
            // 
            // dtpFECHA_OF
            // 
            this.dtpFECHA_OF.Location = new System.Drawing.Point(342, 31);
            this.dtpFECHA_OF.Name = "dtpFECHA_OF";
            this.dtpFECHA_OF.Size = new System.Drawing.Size(214, 20);
            this.dtpFECHA_OF.TabIndex = 15;
            // 
            // txtCODIGO_OF
            // 
            this.txtCODIGO_OF.Enabled = false;
            this.txtCODIGO_OF.Location = new System.Drawing.Point(96, 31);
            this.txtCODIGO_OF.Name = "txtCODIGO_OF";
            this.txtCODIGO_OF.Size = new System.Drawing.Size(139, 20);
            this.txtCODIGO_OF.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Usuario:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Codigo OF:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Enabled = false;
            this.txtUSUARIO.Location = new System.Drawing.Point(96, 57);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(139, 20);
            this.txtUSUARIO.TabIndex = 14;
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Items.AddRange(new object[] {
            "Abierta",
            "Finalizada"});
            this.cmbESTADO.Location = new System.Drawing.Point(342, 57);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(132, 21);
            this.cmbESTADO.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Fecha:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(293, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Estado:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(655, 473);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(98, 42);
            this.btnCANCELAR.TabIndex = 60;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(551, 473);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(98, 42);
            this.btnGUARDAR.TabIndex = 59;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // frmOF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 520);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Fabricación";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbORIGEN.ResumeLayout(false);
            this.gbORIGEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_INSUMOS)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbTAREAS.ResumeLayout(false);
            this.gbTAREAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).EndInit();
            this.gbOF.ResumeLayout(false);
            this.gbOF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLINEA_PEDIDO;
        private System.Windows.Forms.TextBox txtPEDIDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBUSCAR_PEDIDO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCLASE;
        private System.Windows.Forms.TextBox txtLOCALIDAD;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCOSTO_TOTAL;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbOF;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.DateTimePicker dtpFECHA_OF;
        private System.Windows.Forms.TextBox txtCODIGO_OF;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbORIGEN;
        private System.Windows.Forms.GroupBox gbTAREAS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLINEA_FABRICACION;
        private System.Windows.Forms.TextBox txtDETALLE;
        private System.Windows.Forms.Button btnELIMINAR_PROCESO;
        private System.Windows.Forms.Button btnAGREGAR_PROCESO;
        private System.Windows.Forms.DataGridView dgvLINEA_INSUMOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTAREAS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTOTAL;
    }
}