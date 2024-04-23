﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_Programacion3
{
    class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre {  get; set; }
        public string descripcion {  get; set; }
        public decimal precio {  get; set; }

        public Marca marca {  get; set; }

        public Categoria categoria {  get; set; }
        public DateTime fechaAlta {  get; set; }

        public List<Imagen> imagenes {  get; set; }
    }
}
