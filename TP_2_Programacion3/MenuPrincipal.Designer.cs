﻿namespace WinFormPantallas
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
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnListarArticulos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnDetallesArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatalogoArticulos
            // 
            this.labelCatalogoArticulos.AutoSize = true;
            this.labelCatalogoArticulos.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogoArticulos.Location = new System.Drawing.Point(110, 32);
            this.labelCatalogoArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatalogoArticulos.Name = "labelCatalogoArticulos";
            this.labelCatalogoArticulos.Size = new System.Drawing.Size(265, 22);
            this.labelCatalogoArticulos.TabIndex = 1;
            this.labelCatalogoArticulos.Text = "CATALOGO DE ARTICULOS";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(51, 106);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(86, 58);
            this.btnBuscarArticulo.TabIndex = 2;
            this.btnBuscarArticulo.Text = "Buscar Articulo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.buttonBuscarArticulo_Click);
            // 
            // btnListarArticulos
            // 
            this.btnListarArticulos.Location = new System.Drawing.Point(298, 106);
            this.btnListarArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarArticulos.Name = "btnListarArticulos";
            this.btnListarArticulos.Size = new System.Drawing.Size(83, 58);
            this.btnListarArticulos.TabIndex = 4;
            this.btnListarArticulos.Text = "Listar Articulos";
            this.btnListarArticulos.UseVisualStyleBackColor = true;
            this.btnListarArticulos.Click += new System.EventHandler(this.buttonListarArticulos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 340);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 24);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(160, 212);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(86, 48);
            this.btnEliminarArticulo.TabIndex = 7;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnDetallesArticulo
            // 
            this.btnDetallesArticulo.Location = new System.Drawing.Point(298, 212);
            this.btnDetallesArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(83, 48);
            this.btnDetallesArticulo.TabIndex = 8;
            this.btnDetallesArticulo.Text = "Detalles de Articulos";
            this.btnDetallesArticulo.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 440);
            this.Controls.Add(this.btnDetallesArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarArticulos);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.labelCatalogoArticulos);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(494, 479);
            this.MinimumSize = new System.Drawing.Size(494, 479);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Catalogo";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCatalogoArticulos;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnListarArticulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulo;
    }
}

