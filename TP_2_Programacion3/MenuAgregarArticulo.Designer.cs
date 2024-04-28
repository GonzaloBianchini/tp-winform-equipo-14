namespace WinFormPantallas
{
    partial class MenuAgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAgregarArticulo));
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombreArticulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.textBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.pictureBoxPreviewImagen = new System.Windows.Forms.PictureBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(202, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 30);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(14, 154);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 16);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(14, 184);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(66, 16);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(14, 240);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 7;
            this.labelPrecio.Text = "Precio";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(14, 96);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxNombreArticulo
            // 
            this.textBoxNombreArticulo.Location = new System.Drawing.Point(125, 62);
            this.textBoxNombreArticulo.Name = "textBoxNombreArticulo";
            this.textBoxNombreArticulo.Size = new System.Drawing.Size(189, 22);
            this.textBoxNombreArticulo.TabIndex = 0;
            this.textBoxNombreArticulo.TextChanged += new System.EventHandler(this.textBoxNombreArticulo_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(123, 90);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(189, 22);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Location = new System.Drawing.Point(14, 124);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(98, 16);
            this.labelCodigoArticulo.TabIndex = 12;
            this.labelCodigoArticulo.Text = "Codigo Articulo";
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(125, 118);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(189, 22);
            this.textBoxCodigoArticulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "CARGA DE ARTICULOS";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(123, 234);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(189, 22);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 30);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Location = new System.Drawing.Point(125, 146);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(189, 24);
            this.comboBoxMarcas.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(125, 176);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(189, 24);
            this.comboBoxCategorias.TabIndex = 4;
            // 
            // pictureBoxPreviewImagen
            // 
            this.pictureBoxPreviewImagen.Location = new System.Drawing.Point(355, 62);
            this.pictureBoxPreviewImagen.Name = "pictureBoxPreviewImagen";
            this.pictureBoxPreviewImagen.Size = new System.Drawing.Size(254, 194);
            this.pictureBoxPreviewImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreviewImagen.TabIndex = 19;
            this.pictureBoxPreviewImagen.TabStop = false;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(14, 212);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(82, 16);
            this.labelURL.TabIndex = 20;
            this.labelURL.Text = "URL Imagen";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(125, 206);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(189, 22);
            this.textBoxURL.TabIndex = 5;
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // MenuAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 349);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.pictureBoxPreviewImagen);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.comboBoxMarcas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoArticulo);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombreArticulo);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.btnVolver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.MenuAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombreArticulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.TextBox textBoxCodigoArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxMarcas;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.PictureBox pictureBoxPreviewImagen;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
    }
}