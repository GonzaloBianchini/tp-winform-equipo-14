using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_Programacion3
{
    class Articulo
    {
        int id;
        string codigo;
        //string nombre;
        string descripcion;
        Marca marca;
        Categoria categoria;
        float precio;

        List<Imagen> imagenes;
    }
}
