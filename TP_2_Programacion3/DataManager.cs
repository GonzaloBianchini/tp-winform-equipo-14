using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_2_Programacion3
{
    class DataManager   //Clase para el manejo de registros
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista= new List<Articulo>();
            SqlConnection conn = new SqlConnection();   //Creo conexion
            SqlCommand cmd = new SqlCommand();          //Creo un comando
            SqlDataReader reader;

            try
            {
                //(local)\\SQLEXPRESS
                //.\\SQLEXPRESS
                string server = "server=LAPTOP-P08IR0AA\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                conn.ConnectionString = server;

                cmd.CommandType = System.Data.CommandType.Text;
                //ahora va la sentencia SQL
                string sentenciaTablaArticulos = "SELECT Id, Codigo,Nombre,Descripcion,Precio FROM ARTICULOS";
                //faltan IdMarca,IdCategoria,Marca,FechaAlta,Categoria

                cmd.CommandText = sentenciaTablaArticulos;

                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Articulo aux = new Articulo();

                    aux.id = (int)reader["Id"];
                    aux.codigo = (string)reader["Codigo"];
                    aux.nombre = (string)reader["Nombre"];
                    aux.descripcion = (string)reader["Descripcion"];
                    aux.precio = (decimal)reader["Precio"];

                    lista.Add(aux);
                }
                //conn.Close();

                return lista;
            }
            catch (Exception ex)
            {

                //pregunto si la conexion sigue abierta, la cierro
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                return lista;
            }
  
        }
    }
}
