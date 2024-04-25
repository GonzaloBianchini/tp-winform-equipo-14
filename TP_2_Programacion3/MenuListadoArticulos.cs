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
            //Datos dataManager = new Datos();
            //listaArticulos = dataManager.listarArticulos();

            //dataGridViewListadoArticulos.DataSource = listaArticulos;
            ArticuloManager arti = new ArticuloManager();
            dataGridViewListadoArticulos.DataSource=arti.Listar();


            //prueba imagen
            pictureBoxImagenesArticulos.Load("https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542");
        }
 

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
