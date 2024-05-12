namespace WinFormPantallas
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnListarArticulos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDetallesArticulo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRTICULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscadorArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iMAGENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminarArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarArticulos
            // 
            this.btnListarArticulos.Location = new System.Drawing.Point(345, 137);
            this.btnListarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarArticulos.Name = "btnListarArticulos";
            this.btnListarArticulos.Size = new System.Drawing.Size(148, 119);
            this.btnListarArticulos.TabIndex = 4;
            this.btnListarArticulos.Text = "Listar Articulos";
            this.btnListarArticulos.UseVisualStyleBackColor = true;
            this.btnListarArticulos.Click += new System.EventHandler(this.buttonListarArticulos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(195, 349);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 60);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // btnDetallesArticulo
            // 
            this.btnDetallesArticulo.Location = new System.Drawing.Point(94, 137);
            this.btnDetallesArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(144, 119);
            this.btnDetallesArticulo.TabIndex = 8;
            this.btnDetallesArticulo.Text = "Detalles de Articulos";
            this.btnDetallesArticulo.UseVisualStyleBackColor = true;
            this.btnDetallesArticulo.Click += new System.EventHandler(this.btnDetallesArticulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem,
            this.cATEGORIASToolStripMenuItem,
            this.iMAGENESToolStripMenuItem,
            this.mARCASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRTICULOSToolStripMenuItem
            // 
            this.aRTICULOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarArticuloMenu,
            this.ListadoArticuloMenu,
            this.BuscadorArticuloMenu,
            this.ModificarArticuloMenu,
            this.eliminarArticuloMenu});
            this.aRTICULOSToolStripMenuItem.Name = "aRTICULOSToolStripMenuItem";
            this.aRTICULOSToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.aRTICULOSToolStripMenuItem.Text = "ARTICULOS";
            this.aRTICULOSToolStripMenuItem.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem_Click);
            // 
            // AgregarArticuloMenu
            // 
            this.AgregarArticuloMenu.Name = "AgregarArticuloMenu";
            this.AgregarArticuloMenu.Size = new System.Drawing.Size(224, 26);
            this.AgregarArticuloMenu.Text = "Agregar articulo";
            // 
            // ListadoArticuloMenu
            // 
            this.ListadoArticuloMenu.Name = "ListadoArticuloMenu";
            this.ListadoArticuloMenu.Size = new System.Drawing.Size(224, 26);
            this.ListadoArticuloMenu.Text = "Listado Articulos";
            this.ListadoArticuloMenu.Click += new System.EventHandler(this.buscadorDeArticulosToolStripMenuItem_Click);
            // 
            // BuscadorArticuloMenu
            // 
            this.BuscadorArticuloMenu.Name = "BuscadorArticuloMenu";
            this.BuscadorArticuloMenu.Size = new System.Drawing.Size(224, 26);
            this.BuscadorArticuloMenu.Text = "Buscador ";
            // 
            // ModificarArticuloMenu
            // 
            this.ModificarArticuloMenu.Name = "ModificarArticuloMenu";
            this.ModificarArticuloMenu.Size = new System.Drawing.Size(224, 26);
            this.ModificarArticuloMenu.Text = "Modificar";
            // 
            // cATEGORIASToolStripMenuItem
            // 
            this.cATEGORIASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.cATEGORIASToolStripMenuItem.Name = "cATEGORIASToolStripMenuItem";
            this.cATEGORIASToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.cATEGORIASToolStripMenuItem.Text = "CATEGORIAS";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // iMAGENESToolStripMenuItem
            // 
            this.iMAGENESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeImagenesToolStripMenuItem});
            this.iMAGENESToolStripMenuItem.Name = "iMAGENESToolStripMenuItem";
            this.iMAGENESToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.iMAGENESToolStripMenuItem.Text = "IMAGENES";
            // 
            // listadoDeImagenesToolStripMenuItem
            // 
            this.listadoDeImagenesToolStripMenuItem.Name = "listadoDeImagenesToolStripMenuItem";
            this.listadoDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listadoDeImagenesToolStripMenuItem.Text = "Listado de imagenes";
            // 
            // mARCASToolStripMenuItem
            // 
            this.mARCASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.listarToolStripMenuItem,
            this.modificarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2});
            this.mARCASToolStripMenuItem.Name = "mARCASToolStripMenuItem";
            this.mARCASToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.mARCASToolStripMenuItem.Text = "MARCAS";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusHora
            // 
            this.StripStatusHora.Name = "StripStatusHora";
            this.StripStatusHora.Size = new System.Drawing.Size(151, 20);
            this.StripStatusHora.Text = "toolStripStatusLabel1";
            // 
            // eliminarArticuloMenu
            // 
            this.eliminarArticuloMenu.Name = "eliminarArticuloMenu";
            this.eliminarArticuloMenu.Size = new System.Drawing.Size(224, 26);
            this.eliminarArticuloMenu.Text = "Eliminar";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDetallesArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarArticulos);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(653, 579);
            this.MinimumSize = new System.Drawing.Size(653, 579);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Grupo 14";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListarArticulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDetallesArticulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarArticuloMenu;
        
        private System.Windows.Forms.ToolStripMenuItem ListadoArticuloMenu;
        private System.Windows.Forms.ToolStripMenuItem BuscadorArticuloMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarArticuloMenu;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iMAGENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeImagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusHora;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloMenu;
    }
}

