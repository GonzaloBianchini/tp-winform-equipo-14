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
            this.comboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombreArticulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.textBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNroSerie = new System.Windows.Forms.Label();
            this.txtBoxNroSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(297, 332);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 30);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Items.AddRange(new object[] {
            "Apple",
            "Sony",
            "Samsung",
            "Huawei",
            "Motorola"});
            this.comboBoxMarcas.Location = new System.Drawing.Point(145, 145);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(187, 24);
            this.comboBoxMarcas.TabIndex = 2;
            this.comboBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarcas_SelectedIndexChanged);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(34, 153);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 16);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Items.AddRange(new object[] {
            "Celulares",
            "Televisores",
            "Media",
            "Audio"});
            this.comboBoxCategorias.Location = new System.Drawing.Point(534, 81);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(187, 24);
            this.comboBoxCategorias.TabIndex = 1;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(411, 84);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(66, 16);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria";
            this.labelCategoria.Click += new System.EventHandler(this.labelCategoria_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(34, 206);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 7;
            this.labelPrecio.Text = "Precio";
            this.labelPrecio.Click += new System.EventHandler(this.labelPrecio_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(34, 90);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.Click += new System.EventHandler(this.labelDescripcion_Click);
            // 
            // textBoxNombreArticulo
            // 
            this.textBoxNombreArticulo.Location = new System.Drawing.Point(143, 84);
            this.textBoxNombreArticulo.Name = "textBoxNombreArticulo";
            this.textBoxNombreArticulo.Size = new System.Drawing.Size(189, 22);
            this.textBoxNombreArticulo.TabIndex = 0;
            this.textBoxNombreArticulo.TextChanged += new System.EventHandler(this.textBoxNombreArticulo_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(145, 200);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(187, 22);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Location = new System.Drawing.Point(411, 153);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(98, 16);
            this.labelCodigoArticulo.TabIndex = 12;
            this.labelCodigoArticulo.Text = "Codigo Articulo";
            this.labelCodigoArticulo.Click += new System.EventHandler(this.labelCodigoArticulo_Click);
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(534, 147);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(187, 22);
            this.textBoxCodigoArticulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "CARGA DE ARTICULOS";
            // 
            // btnNroSerie
            // 
            this.btnNroSerie.AutoSize = true;
            this.btnNroSerie.Location = new System.Drawing.Point(411, 206);
            this.btnNroSerie.Name = "btnNroSerie";
            this.btnNroSerie.Size = new System.Drawing.Size(64, 16);
            this.btnNroSerie.TabIndex = 15;
            this.btnNroSerie.Text = "Nro Serie";
            // 
            // txtBoxNroSerie
            // 
            this.txtBoxNroSerie.Location = new System.Drawing.Point(534, 206);
            this.txtBoxNroSerie.Name = "txtBoxNroSerie";
            this.txtBoxNroSerie.Size = new System.Drawing.Size(187, 22);
            this.txtBoxNroSerie.TabIndex = 5;
            // 
            // MenuAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 391);
            this.Controls.Add(this.txtBoxNroSerie);
            this.Controls.Add(this.btnNroSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoArticulo);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombreArticulo);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.comboBoxMarcas);
            this.Controls.Add(this.btnVolver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.MenuAgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox comboBoxMarcas;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombreArticulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.TextBox textBoxCodigoArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnNroSerie;
        private System.Windows.Forms.TextBox txtBoxNroSerie;
    }
}