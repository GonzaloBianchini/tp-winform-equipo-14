using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class ArticuloManager
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista= new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT Id,Codigo,Nombre,Descripcion,Precio FROM Articulos");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux= new Articulo();
                    aux.id = (int)datos.Lector["id"];
                    aux.codigo = (string)datos.Lector["codigo"];
                    aux.nombre = (string)datos.Lector["nombre"];
                    aux.descripcion = (string)datos.Lector["descripcion"];
                    aux.precio = (decimal)datos.Lector["precio"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo artNue)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, Precio)VALUES('" + artNue.codigo + "','" + artNue.nombre + "','" + artNue.descripcion + "',"+ artNue.precio +")");
                datos.ejecutarAccion();
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo artExistente)
        {

        }
    }
}
