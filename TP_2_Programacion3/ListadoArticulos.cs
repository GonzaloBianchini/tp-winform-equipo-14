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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }



        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            dataGridViewListadoArticulos.DataSource = dataManager.listarArticulos();
        }
 

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
