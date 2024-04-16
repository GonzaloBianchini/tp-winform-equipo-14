namespace TP_2_Programacion3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCatalogoArticulos = new System.Windows.Forms.Label();
            this.buttonBuscarArticulo = new System.Windows.Forms.Button();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.buttonListarArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatalogoArticulos
            // 
            this.labelCatalogoArticulos.AutoSize = true;
            this.labelCatalogoArticulos.Location = new System.Drawing.Point(238, 30);
            this.labelCatalogoArticulos.Name = "labelCatalogoArticulos";
            this.labelCatalogoArticulos.Size = new System.Drawing.Size(134, 16);
            this.labelCatalogoArticulos.TabIndex = 1;
            this.labelCatalogoArticulos.Text = "Catalogo de articulos";
            // 
            // buttonBuscarArticulo
            // 
            this.buttonBuscarArticulo.Location = new System.Drawing.Point(68, 130);
            this.buttonBuscarArticulo.Name = "buttonBuscarArticulo";
            this.buttonBuscarArticulo.Size = new System.Drawing.Size(75, 46);
            this.buttonBuscarArticulo.TabIndex = 2;
            this.buttonBuscarArticulo.Text = "Buscar Articulo";
            this.buttonBuscarArticulo.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulo.Click += new System.EventHandler(this.buttonBuscarArticulo_Click);
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(256, 130);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(75, 46);
            this.buttonAgregarArticulo.TabIndex = 3;
            this.buttonAgregarArticulo.Text = "Agregar Articulo";
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // buttonListarArticulos
            // 
            this.buttonListarArticulos.Location = new System.Drawing.Point(447, 130);
            this.buttonListarArticulos.Name = "buttonListarArticulos";
            this.buttonListarArticulos.Size = new System.Drawing.Size(75, 46);
            this.buttonListarArticulos.TabIndex = 4;
            this.buttonListarArticulos.Text = "Listar Articulos";
            this.buttonListarArticulos.UseVisualStyleBackColor = true;
            this.buttonListarArticulos.Click += new System.EventHandler(this.buttonListarArticulos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 534);
            this.Controls.Add(this.buttonListarArticulos);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.buttonBuscarArticulo);
            this.Controls.Add(this.labelCatalogoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(653, 581);
            this.MinimumSize = new System.Drawing.Size(653, 581);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCatalogoArticulos;
        private System.Windows.Forms.Button buttonBuscarArticulo;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.Button buttonListarArticulos;
    }
}

