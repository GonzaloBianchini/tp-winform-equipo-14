namespace WinFormPantallas
{
    partial class MenuListadoArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuListadoArticulos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridViewListadoArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagenesArticulos = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADOS DE ARTICULOS";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(321, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(202, 31);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridViewListadoArticulos
            // 
            this.dataGridViewListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListadoArticulos.Location = new System.Drawing.Point(12, 95);
            this.dataGridViewListadoArticulos.MultiSelect = false;
            this.dataGridViewListadoArticulos.Name = "dataGridViewListadoArticulos";
            this.dataGridViewListadoArticulos.RowHeadersWidth = 51;
            this.dataGridViewListadoArticulos.RowTemplate.Height = 24;
            this.dataGridViewListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListadoArticulos.Size = new System.Drawing.Size(875, 283);
            this.dataGridViewListadoArticulos.TabIndex = 4;
            this.dataGridViewListadoArticulos.SelectionChanged += new System.EventHandler(this.dataGridViewListadoArticulos_SelectionChanged);
            // 
            // pictureBoxImagenesArticulos
            // 
            this.pictureBoxImagenesArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagenesArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxImagenesArticulos.Location = new System.Drawing.Point(960, 95);
            this.pictureBoxImagenesArticulos.Name = "pictureBoxImagenesArticulos";
            this.pictureBoxImagenesArticulos.Size = new System.Drawing.Size(231, 283);
            this.pictureBoxImagenesArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenesArticulos.TabIndex = 5;
            this.pictureBoxImagenesArticulos.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(928, 206);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(26, 46);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonFront
            // 
            this.buttonFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFront.Location = new System.Drawing.Point(1197, 206);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(26, 46);
            this.buttonFront.TabIndex = 7;
            this.buttonFront.Text = ">";
            this.buttonFront.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 384);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(115, 31);
            this.btnAgregarArticulo.TabIndex = 8;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // MenuListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1247, 544);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.buttonFront);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxImagenesArticulos);
            this.Controls.Add(this.dataGridViewListadoArticulos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoArticulos";
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridViewListadoArticulos;
        private System.Windows.Forms.PictureBox pictureBoxImagenesArticulos;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFront;
        private System.Windows.Forms.Button btnAgregarArticulo;
    }
}