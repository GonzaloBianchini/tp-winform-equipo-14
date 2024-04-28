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

        private void textBoxNombreArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaManager catNue = new CategoriaManager();
            MarcaManager marcaNue = new MarcaManager();
            try
            {
                comboBoxCategorias.DataSource = catNue.Listar();
                comboBoxCategorias.DisplayMember = "Descripcion";

                comboBoxMarcas.DataSource = marcaNue.Listar();
                comboBoxMarcas.DisplayMember = "Descripcion";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
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
                articuloNuevo.categoria = (Categoria)comboBoxCategorias.SelectedItem;
                articuloNuevo.marca=(Marca)comboBoxMarcas.SelectedItem;
                //validarDatos();       // HACER ESTA FUNCION?
                
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
