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
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion AS DescripcionArticulo, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo;");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["DescripcionArticulo"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    // Instanciación de objetos internos
                    aux.marca = new Marca { descripcion = (string)datos.Lector["Marca"] };
                    aux.categoria = new Categoria { descripcion = (string)datos.Lector["Categoria"] };

                    // Verificar si ImagenUrl es nulo antes de asignar
                    if (datos.Lector["ImagenUrl"] != DBNull.Value)
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente, por ejemplo:
                Console.WriteLine("Error al listar los artículos: " + ex.Message);
                throw;
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
                datos.SetearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, Precio,IdMarca,IdCategoria) VALUES('" + artNue.codigo + "','" + artNue.nombre + "','" + artNue.descripcion + "',"+ artNue.precio +",@IdMarca,@IdCategoria)");
                datos.setearParametro("@IdMarca",artNue.marca.id);
                datos.setearParametro("@IdCategoria",artNue.categoria.id);
                datos.ejecutarAccion();

                /*
                //meto la imagen vinculando id de articulo
                datos.SetearConsulta("DECLARE @IdArticulo INT SET @IdArticulo = SCOPE_IDENTITY()");
                datos.ejecutarAccion();

                
                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, '"+artNue.ImagenUrl+"')");
                datos.ejecutarAccion();
                */
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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = '" + artExistente.codigo + "', Nombre = '" + artExistente.nombre + "', Descripcion = '" + artExistente.descripcion + "', Precio = " + artExistente.precio + ", IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = " + artExistente.id);
                datos.setearParametro("@IdMarca", artExistente.marca.id);
                datos.setearParametro("@IdCategoria", artExistente.categoria.id);
                datos.ejecutarAccion();

                //modifico la imagen
                datos.SetearConsulta("UPDATE IMAGENES SET ImagenUrl = '" + artExistente.ImagenUrl + "' WHERE IdArticulo = " + artExistente.id);
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @id" );
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}
