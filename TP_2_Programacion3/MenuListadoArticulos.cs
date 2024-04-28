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
            ArticuloManager arti = new ArticuloManager();

            listaArticulos = arti.Listar();

            dataGridViewListadoArticulos.DataSource = listaArticulos;

            dataGridViewListadoArticulos.Columns["Id"].Visible = false;

            try
            {
                pictureBoxImagenesArticulos.Load(listaArticulos[0].ImagenURL);
            }
            catch(Exception ex)
            {
                pictureBoxImagenesArticulos.Load("https://media.istockphoto.com/id/1396814518/vector/image-coming-soon-no-photo-no-thumbnail-image-available-vector-illustration.jpg?s=612x612&w=0&k=20&c=hnh2OZgQGhf0b46-J2z7aHbIWwq8HNlSDaNp2wn_iko=");
            }


            //prueba imagen
            pictureBoxImagenesArticulos.Load("https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542");
        }
 

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado =(Articulo) dataGridViewListadoArticulos.CurrentRow.DataBoundItem;
            try
            {
                pictureBoxImagenesArticulos.Load(artSeleccionado.ImagenURL);
            }
            catch(Exception ex)
            {
                pictureBoxImagenesArticulos.Load("https://media.istockphoto.com/id/1396814518/vector/image-coming-soon-no-photo-no-thumbnail-image-available-vector-illustration.jpg?s=612x612&w=0&k=20&c=hnh2OZgQGhf0b46-J2z7aHbIWwq8HNlSDaNp2wn_iko=");
            }
        }
    }
}
