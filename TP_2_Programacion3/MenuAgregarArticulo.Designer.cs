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
            this.btncCancelar = new System.Windows.Forms.Button();
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
            // btncCancelar
            // 
            this.btncCancelar.Location = new System.Drawing.Point(152, 237);
            this.btncCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncCancelar.Name = "btncCancelar";
            this.btncCancelar.Size = new System.Drawing.Size(84, 24);
            this.btncCancelar.TabIndex = 8;
            this.btncCancelar.Text = "CANCELAR";
            this.btncCancelar.UseVisualStyleBackColor = true;
            this.btncCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(10, 125);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(10, 150);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(10, 195);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 7;
            this.labelPrecio.Text = "Precio";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(10, 78);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxNombreArticulo
            // 
            this.textBoxNombreArticulo.Location = new System.Drawing.Point(94, 50);
            this.textBoxNombreArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreArticulo.Name = "textBoxNombreArticulo";
            this.textBoxNombreArticulo.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombreArticulo.TabIndex = 0;
            this.textBoxNombreArticulo.TextChanged += new System.EventHandler(this.textBoxNombreArticulo_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(92, 73);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(143, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Location = new System.Drawing.Point(10, 101);
            this.labelCodigoArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(78, 13);
            this.labelCodigoArticulo.TabIndex = 12;
            this.labelCodigoArticulo.Text = "Codigo Articulo";
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(94, 96);
            this.textBoxCodigoArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(143, 20);
            this.textBoxCodigoArticulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "CARGA DE ARTICULOS";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(10, 55);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(92, 190);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(143, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 237);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 24);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAAceptar_Click);
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Location = new System.Drawing.Point(94, 119);
            this.comboBoxMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMarcas.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(94, 143);
            this.comboBoxCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCategorias.TabIndex = 4;
            // 
            // pictureBoxPreviewImagen
            // 
            this.pictureBoxPreviewImagen.Location = new System.Drawing.Point(266, 50);
            this.pictureBoxPreviewImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPreviewImagen.Name = "pictureBoxPreviewImagen";
            this.pictureBoxPreviewImagen.Size = new System.Drawing.Size(190, 158);
            this.pictureBoxPreviewImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreviewImagen.TabIndex = 19;
            this.pictureBoxPreviewImagen.TabStop = false;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(10, 172);
            this.labelURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(67, 13);
            this.labelURL.TabIndex = 20;
            this.labelURL.Text = "URL Imagen";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(94, 167);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(143, 20);
            this.textBoxURL.TabIndex = 5;
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // MenuAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 284);
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
            this.Controls.Add(this.btncCancelar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.MenuAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncCancelar;
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