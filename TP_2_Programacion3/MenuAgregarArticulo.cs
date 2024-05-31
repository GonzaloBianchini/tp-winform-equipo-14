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

            textBoxNombreArticulo.Text = articuloSeleccionado.nombre;
            textBoxDescripcion.Text = articuloSeleccionado.descripcion;
            textBoxPrecio.Text = articuloSeleccionado.precio.ToString();
            textBoxCodigoArticulo.Text = articuloSeleccionado.codigo;
            comboBoxCategorias.SelectedItem = articuloSeleccionado.categoria;
            comboBoxMarcas.SelectedItem = articuloSeleccionado.marca;
            textBoxURL.Text = articuloSeleccionado.ImagenUrl;
            cargarImagen(articuloSeleccionado.ImagenUrl);
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
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

        private void btnAAceptar_Click(object sender, EventArgs e)
        {
            // Validar los campos del formulario
            if (!ValidarCampos())
            {
                return;
            }

            ArticuloManager artMana = new ArticuloManager();
            try
            {
                if (articuloSeleccionado != null)
                {
                    // Modificar el artículo existente
                    articuloSeleccionado.descripcion = textBoxDescripcion.Text;
                    articuloSeleccionado.precio = decimal.Parse(textBoxPrecio.Text);
                    articuloSeleccionado.codigo = textBoxCodigoArticulo.Text;
                    articuloSeleccionado.nombre = textBoxNombreArticulo.Text;
                    articuloSeleccionado.categoria = (Categoria)comboBoxCategorias.SelectedItem;
                    articuloSeleccionado.marca = (Marca)comboBoxMarcas.SelectedItem;
                    articuloSeleccionado.ImagenUrl = textBoxURL.Text;

                    // Llamar al método modificar
                    artMana.modificar(articuloSeleccionado);
                    MessageBox.Show("Artículo Modificado!");
                }
                else
                {
                    // Agregar un nuevo artículo
                    Articulo articuloNuevo = new Articulo();
                    articuloNuevo.descripcion = textBoxDescripcion.Text;
                    articuloNuevo.precio = decimal.Parse(textBoxPrecio.Text);
                    articuloNuevo.codigo = textBoxCodigoArticulo.Text;
                    articuloNuevo.nombre = textBoxNombreArticulo.Text;
                    articuloNuevo.categoria = (Categoria)comboBoxCategorias.SelectedItem;
                    articuloNuevo.marca = (Marca)comboBoxMarcas.SelectedItem;
                    articuloNuevo.ImagenUrl = textBoxURL.Text;

                    // Llamar al método agregar
                    artMana.Agregar(articuloNuevo);
                    MessageBox.Show("Artículo Agregado!");
                }

                this.Close(); // Cerrar la ventana actual después de agregar o modificar el artículo
            }
            catch (Exception ex)
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

        private bool ValidarCampos()
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(textBoxNombreArticulo.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescripcion.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxCodigoArticulo.Text) ||
                comboBoxCategorias.SelectedItem == null ||
                comboBoxMarcas.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxURL.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            // Verificar que el precio sea un número válido
            if (!decimal.TryParse(textBoxPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return false;
            }

            return true;
        }





    }
}
