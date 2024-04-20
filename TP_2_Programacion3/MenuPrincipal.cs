using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2_Programacion3
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string textoAMostrar = "BIENVENIDOS AL CATALOGO DE PRODUCTOS\n\nUltimo ingreso: " + DateTime.Now.ToString();
            MessageBox.Show(textoAMostrar);
        }

        private void buttonBuscarArticulo_Click(object sender, EventArgs e)
        {
            MenuBuscarArticulo menuBuscarArticulo = new MenuBuscarArticulo();
            menuBuscarArticulo.ShowDialog();
        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            MenuAgregarArticulo menuAgregarArticulo = new MenuAgregarArticulo();
            menuAgregarArticulo.ShowDialog();
        }

        private void buttonListarArticulos_Click(object sender, EventArgs e)
        {
            ListadoArticulos listado = new ListadoArticulos();
            listado.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            string textoSalida = "Gracias por utilizar el super catalogo!";
            MessageBox.Show(textoSalida);
            Close();    
        }
    }
}
