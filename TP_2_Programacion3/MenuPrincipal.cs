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

namespace WinFormPantallas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        //Boton para agregar un nuevo articulo
        private void buttonBuscarArticulo_Click(object sender, EventArgs e)
        {
            MenuBuscarArticulo menuBuscarArticulo = new MenuBuscarArticulo();
            menuBuscarArticulo.ShowDialog();
        }


        // Boton para listar los articulos
        private void buttonListarArticulos_Click(object sender, EventArgs e)
        {

            MenuListadoArticulos listado = new MenuListadoArticulos();
            listado.ShowDialog();
        }


        // Boton para salir de la aplicacion
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            string textoSalida = "GRACIAS POR UTILIZAR LA APP";
            MessageBox.Show(textoSalida);
            Close();    
        }

       
         
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void btnDetallesArticulo_Click(object sender, EventArgs e)
        {

        }
    }
}
