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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string textoAMostrar = "La fecha y hora actual es: " + DateTime.Now.ToString();
            MessageBox.Show(textoAMostrar);
        }

        private void buttonBuscarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonListarArticulos_Click(object sender, EventArgs e)
        {

        }
    }
}
