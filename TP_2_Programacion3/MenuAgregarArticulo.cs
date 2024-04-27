using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dominio;
using DataManager;

namespace WinFormPantallas
{
    public partial class MenuAgregarArticulo : Form
    {
        public MenuAgregarArticulo()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCodigoArticulo_Click(object sender, EventArgs e)
        {

        }

        private void labelMarca_Click(object sender, EventArgs e)
        {

        }

        private void MenuAgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void labelNombreArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            ArticuloManager artMana = new ArticuloManager();   
            try
            {
                articuloNuevo.descripcion=textBoxDescripcion.Text;
                articuloNuevo.precio = decimal.Parse(textBoxPrecio.Text);   //HAY QUE VALIDAR ESTO POR SI NO SE INTRODUCE UN VALOR DECIMAL
                articuloNuevo.codigo=textBoxCodigoArticulo.Text;
                articuloNuevo.nombre=textBoxNombreArticulo.Text;
                //validarDatos();       // HACER ESTA FUNCION?
                //falta marca
                //falta categoria
                //falta imagenes
                artMana.agregar(articuloNuevo);
                MessageBox.Show("Articulo Agregado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
