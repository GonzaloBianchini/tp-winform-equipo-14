namespace TP_2_Programacion3
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
            this.labelCatalogoArticulos = new System.Windows.Forms.Label();
            this.buttonBuscarArticulo = new System.Windows.Forms.Button();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.buttonListarArticulos = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatalogoArticulos
            // 
            this.labelCatalogoArticulos.AutoSize = true;
            this.labelCatalogoArticulos.Location = new System.Drawing.Point(208, 40);
            this.labelCatalogoArticulos.Name = "labelCatalogoArticulos";
            this.labelCatalogoArticulos.Size = new System.Drawing.Size(134, 16);
            this.labelCatalogoArticulos.TabIndex = 1;
            this.labelCatalogoArticulos.Text = "Catalogo de articulos";
            // 
            // buttonBuscarArticulo
            // 
            this.buttonBuscarArticulo.Location = new System.Drawing.Point(68, 130);
            this.buttonBuscarArticulo.Name = "buttonBuscarArticulo";
            this.buttonBuscarArticulo.Size = new System.Drawing.Size(115, 71);
            this.buttonBuscarArticulo.TabIndex = 2;
            this.buttonBuscarArticulo.Text = "Buscar Articulo";
            this.buttonBuscarArticulo.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulo.Click += new System.EventHandler(this.buttonBuscarArticulo_Click);
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(239, 130);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(115, 71);
            this.buttonAgregarArticulo.TabIndex = 3;
            this.buttonAgregarArticulo.Text = "Agregar Articulo";
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // buttonListarArticulos
            // 
            this.buttonListarArticulos.Location = new System.Drawing.Point(398, 130);
            this.buttonListarArticulos.Name = "buttonListarArticulos";
            this.buttonListarArticulos.Size = new System.Drawing.Size(111, 71);
            this.buttonListarArticulos.TabIndex = 4;
            this.buttonListarArticulos.Text = "Listar Articulos";
            this.buttonListarArticulos.UseVisualStyleBackColor = true;
            this.buttonListarArticulos.Click += new System.EventHandler(this.buttonListarArticulos_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(230, 419);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(112, 30);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar Articulo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar Articulo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "Detalles de Articulos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonListarArticulos);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.buttonBuscarArticulo);
            this.Controls.Add(this.labelCatalogoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(653, 581);
            this.MinimumSize = new System.Drawing.Size(653, 581);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Super Productos!";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCatalogoArticulos;
        private System.Windows.Forms.Button buttonBuscarArticulo;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.Button buttonListarArticulos;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

