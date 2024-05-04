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
        private Articulo articuloSeleccionado = null;  
        public MenuAgregarArticulo()
        {
            InitializeComponent();
        }

        public MenuAgregarArticulo( Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloSeleccionado = articuloSeleccionado;
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
            AccesoDatos datos = new AccesoDatos(); // creo un objeto de acceso a datos

            CategoriaManager catNue = new CategoriaManager();
            MarcaManager marcaNue = new MarcaManager();
            try
            {
                comboBoxCategorias.DataSource = catNue.Listar();
                comboBoxCategorias.DisplayMember = "Descripcion";

                comboBoxMarcas.DataSource = marcaNue.Listar();
                comboBoxMarcas.DisplayMember = "Descripcion";

                if(articuloSeleccionado != null)
                {
                    textBoxNombreArticulo.Text = articuloSeleccionado.nombre;
                    textBoxDescripcion.Text = articuloSeleccionado.descripcion;
                    textBoxPrecio.Text = articuloSeleccionado.precio.ToString();
                    textBoxCodigoArticulo.Text = articuloSeleccionado.codigo;
                    comboBoxCategorias.SelectedItem = articuloSeleccionado.categoria;
                    comboBoxMarcas.SelectedItem = articuloSeleccionado.marca;
                    textBoxURL.Text = articuloSeleccionado.ImagenUrl;
                    cargarImagen(articuloSeleccionado.ImagenUrl);
                }
               

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
               
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
                articuloNuevo.ImagenUrl = textBoxURL.Text;
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

        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxURL.Text);
        }


        private void cargarImagen(string URL)
        {
            try
            {
                pictureBoxPreviewImagen.Load(URL);
            }
            catch (Exception ex)
            {
                pictureBoxPreviewImagen.Load("https://media.istockphoto.com/id/1396814518/vector/image-coming-soon-no-photo-no-thumbnail-image-available-vector-illustration.jpg?s=612x612&w=0&k=20&c=hnh2OZgQGhf0b46-J2z7aHbIWwq8HNlSDaNp2wn_iko=");
            }
        }
    }
}
