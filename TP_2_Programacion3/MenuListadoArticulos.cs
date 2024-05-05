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
    public partial class MenuListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;  //creo una lista de articulos para mostrar
        public MenuListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloManager arti = new ArticuloManager();

            listaArticulos = arti.Listar();

            dataGridViewListadoArticulos.DataSource = listaArticulos;

            dataGridViewListadoArticulos.Columns["Id"].Visible = false;

            cargarImagen(listaArticulos[0].ImagenUrl);
        }

        private void cargarImagen(string URL)
        {
            try
            {
                pictureBoxImagenesArticulos.Load(URL);
            }
            catch(Exception ex)
            {
                pictureBoxImagenesArticulos.Load("https://lh3.googleusercontent.com/proxy/jqqWJjcMEOB_l4SJJt9CFmQ-TRwAluEyp0heuNsFc84MWiRVPZ6ShOI9N6IWXpT6kFmOcIVDusGorkSuNkKAZZDDqvpiyJ2WF6zsZFpTdPdVBH-2TfQ51Bo");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewListadoArticulos.CurrentRow != null) //  valida que haya una fila seleccionada
            {
                Articulo artSeleccionado =(Articulo) dataGridViewListadoArticulos.CurrentRow.DataBoundItem;
                try
                {
                    pictureBoxImagenesArticulos.Load(artSeleccionado.ImagenUrl);
                }
                catch(Exception ex)
                {
                    pictureBoxImagenesArticulos.Load("https://lh3.googleusercontent.com/proxy/jqqWJjcMEOB_l4SJJt9CFmQ-TRwAluEyp0heuNsFc84MWiRVPZ6ShOI9N6IWXpT6kFmOcIVDusGorkSuNkKAZZDDqvpiyJ2WF6zsZFpTdPdVBH-2TfQ51Bo");
                }

            }
        
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            MenuAgregarArticulo menuAgregarArticulo = new MenuAgregarArticulo();
            menuAgregarArticulo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dataGridViewListadoArticulos.CurrentRow != null)
            {
                Articulo artSeleccionado = (Articulo)dataGridViewListadoArticulos.CurrentRow.DataBoundItem;
                MenuAgregarArticulo menuModificarArticulo = new MenuAgregarArticulo(artSeleccionado);
                menuModificarArticulo.ShowDialog();
                cargar();
               
            }
            else
            {
                MessageBox.Show("Seleccione un articulo para modificar");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager articulo = new ArticuloManager();
            Articulo Seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(" Estas por eliminar un articulo. Esta accion no se puede deshacer.", "Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning );

                if(respuesta == DialogResult.Yes)
                {
                Seleccionado = (Articulo)dataGridViewListadoArticulos.CurrentRow.DataBoundItem;
                articulo.eliminar(Seleccionado.id);
                cargar();   
                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBoxImagenesArticulos_Click(object sender, EventArgs e)
        {

        }
    }
}
