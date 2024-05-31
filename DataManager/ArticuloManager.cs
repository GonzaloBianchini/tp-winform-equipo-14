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


        public void Agregar(Articulo artNue)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Establecer consulta de inserción
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria); " +
                                     "SELECT SCOPE_IDENTITY();"); // Recupera el ID insertado
                datos.setearParametro("@Codigo", artNue.codigo);
                datos.setearParametro("@Nombre", artNue.nombre);
                datos.setearParametro("@Descripcion", artNue.descripcion);
                datos.setearParametro("@Precio", artNue.precio);
                datos.setearParametro("@IdMarca", artNue.marca.id);
                datos.setearParametro("@IdCategoria", artNue.categoria.id);

                // Ejecutar la consulta y obtener el ID del artículo recién insertado
                object result = datos.ejecutarEscalar();

                if (result != DBNull.Value)
                {
                    int idArticulo = Convert.ToInt32(result);

                    // Insertar la imagen vinculando el ID del artículo
                    if (!string.IsNullOrEmpty(artNue.ImagenUrl))
                    {
                        datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                        datos.setearParametro("@IdArticulo", idArticulo);
                        datos.setearParametro("@ImagenUrl", artNue.ImagenUrl);
                        datos.ejecutarAccion();
                    }
                }
                else
                {
                    throw new Exception("No se pudo obtener el ID del artículo recién insertado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el artículo: " + ex.Message);
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
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id");
                datos.setearParametro("@Codigo", artExistente.codigo);
                datos.setearParametro("@Nombre", artExistente.nombre);
                datos.setearParametro("@Descripcion", artExistente.descripcion);
                datos.setearParametro("@Precio", artExistente.precio);
                datos.setearParametro("@IdMarca", artExistente.marca.id);
                datos.setearParametro("@IdCategoria", artExistente.categoria.id);
                datos.setearParametro("@Id", artExistente.id);
                datos.ejecutarAccion();

                // Modificar la imagen
                datos.SetearConsulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@ImagenUrl", artExistente.ImagenUrl);
                datos.setearParametro("@IdArticulo", artExistente.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el artículo: " + ex.Message);
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
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
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
