﻿using System;
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
    public partial class MenuListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;  //creo una lista de articulos para mostrar
        public MenuListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            listaArticulos = dataManager.listarArticulos();

            dataGridViewListadoArticulos.DataSource = listaArticulos;
            //prueba imagen
            pictureBoxImagenesArticulos.Load("https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542");
        }
 

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}