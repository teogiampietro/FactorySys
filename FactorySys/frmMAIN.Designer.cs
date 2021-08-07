namespace FactorySys
{
    partial class frmMAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMAIN));
            this.btnSALIR = new System.Windows.Forms.Button();
            this.lblUSUARIO = new System.Windows.Forms.LinkLabel();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Insumos = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Almacen = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.Remito = new System.Windows.Forms.ToolStripMenuItem();
            this.Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Grupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedido = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenFabricacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSALIR
            // 
            this.btnSALIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSALIR.AutoSize = true;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.Location = new System.Drawing.Point(1167, 602);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(135, 73);
            this.btnSALIR.TabIndex = 0;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIO.LinkColor = System.Drawing.Color.Black;
            this.lblUSUARIO.Location = new System.Drawing.Point(342, 668);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(0, 17);
            this.lblUSUARIO.TabIndex = 7;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.Image = global::FactorySys.Properties.Resources.back;
            this.btnCERRAR.Location = new System.Drawing.Point(42, 602);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(135, 73);
            this.btnCERRAR.TabIndex = 8;
            this.btnCERRAR.Text = "Cerrar Sesion";
            this.btnCERRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // Gestion
            // 
            this.Gestion.BackColor = System.Drawing.Color.Transparent;
            this.Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proveedores,
            this.Clientes,
            this.Insumos,
            this.Productos});
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(59, 20);
            this.Gestion.Text = "Gestion";
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.SystemColors.Control;
            this.Proveedores.Image = global::FactorySys.Properties.Resources.app_chart;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(152, 22);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // Clientes
            // 
            this.Clientes.Image = global::FactorySys.Properties.Resources.app_preferences;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(152, 22);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Insumos
            // 
            this.Insumos.BackColor = System.Drawing.SystemColors.Control;
            this.Insumos.Image = global::FactorySys.Properties.Resources.app_large_icons;
            this.Insumos.Name = "Insumos";
            this.Insumos.Size = new System.Drawing.Size(152, 22);
            this.Insumos.Text = "Insumos";
            this.Insumos.Click += new System.EventHandler(this.insumosToolStripMenuItem_Click);
            // 
            // Productos
            // 
            this.Productos.Image = global::FactorySys.Properties.Resources.app_options;
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(152, 22);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // Almacen
            // 
            this.Almacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenCompra,
            this.Remito,
            this.Stock});
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(66, 20);
            this.Almacen.Text = "Almacen";
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.Image = global::FactorySys.Properties.Resources.file_edit;
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.Size = new System.Drawing.Size(169, 22);
            this.OrdenCompra.Text = "Orden de Compra";
            this.OrdenCompra.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // Remito
            // 
            this.Remito.Image = global::FactorySys.Properties.Resources.file_edit;
            this.Remito.Name = "Remito";
            this.Remito.Size = new System.Drawing.Size(169, 22);
            this.Remito.Text = "Remito";
            this.Remito.Click += new System.EventHandler(this.remitoToolStripMenuItem_Click);
            // 
            // Stock
            // 
            this.Stock.Image = global::FactorySys.Properties.Resources.objects;
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(169, 22);
            this.Stock.Text = "Stock";
            this.Stock.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Grupos});
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(72, 20);
            this.Seguridad.Text = "Seguridad";
            // 
            // Usuarios
            // 
            this.Usuarios.Image = global::FactorySys.Properties.Resources.user;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(152, 22);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // Grupos
            // 
            this.Grupos.Image = global::FactorySys.Properties.Resources.users;
            this.Grupos.Name = "Grupos";
            this.Grupos.Size = new System.Drawing.Size(152, 22);
            this.Grupos.Text = "Grupos";
            this.Grupos.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gestion,
            this.Almacen,
            this.produccionToolStripMenuItem,
            this.Seguridad});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1325, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pedido,
            this.OrdenFabricacion});
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // Pedido
            // 
            this.Pedido.Image = global::FactorySys.Properties.Resources.apps;
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(187, 22);
            this.Pedido.Text = "Pedidos";
            this.Pedido.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // OrdenFabricacion
            // 
            this.OrdenFabricacion.Image = global::FactorySys.Properties.Resources.banner;
            this.OrdenFabricacion.Name = "OrdenFabricacion";
            this.OrdenFabricacion.Size = new System.Drawing.Size(187, 22);
            this.OrdenFabricacion.Text = "Orden de Fabricacion";
            this.OrdenFabricacion.Click += new System.EventHandler(this.ordenDeFabricacionToolStripMenuItem_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1325, 697);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion Fabrica de Muebles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMAIN_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblUSUARIO;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.ToolStripMenuItem Gestion;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Insumos;
        private System.Windows.Forms.ToolStripMenuItem Almacen;
        private System.Windows.Forms.ToolStripMenuItem OrdenCompra;
        private System.Windows.Forms.ToolStripMenuItem Remito;
        private System.Windows.Forms.ToolStripMenuItem Stock;
        private System.Windows.Forms.ToolStripMenuItem Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Grupos;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenFabricacion;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Pedido;
    }
}