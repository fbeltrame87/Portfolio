using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Nuevo uso
using Dominio;

namespace Negocio
{ 
    public class DiscoNegocio
    {
        //Clase acceso a datos de los discos
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Desarrollo
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo, Artista, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND D.IdTipoEdicion = T.Id AND D.EnStock = 1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.Artista = new Artista();
                    aux.Artista.Nombre = (string)lector["Artista"];
                    aux.cantidadCanciones = (int)lector["CantidadCanciones"];
                    //Validación de columna NULL, más que nada si es Not NULL en DB
                    //Op. a)
                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    //Op. b)
                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    aux.Genero = new Estilo();
                    aux.Genero.Id = (int)lector["IdEstilo"];
                    aux.Genero.Descripcion = (string)lector["Genero"];
                    aux.Tipo = new Edicion();
                    aux.Tipo.Id = (int)lector["IdTipoEdicion"];
                    aux.Tipo.Descripcion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarDisco(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Dos maneras de agregar values, una concatenando y otra agregando parametros
                datos.setearConsulta("insert into DISCOS(Titulo, Artista, CantidadCanciones, EnStock, IdTipoEdicion, IdEstilo, UrlImagenTapa) values ('" + nuevo.Titulo +"', '" + nuevo.Artista.Nombre +"', " + nuevo.cantidadCanciones +", 1, @idTipoEdicion, @idEstilo, @urlImagenTapa)");
                datos.setearParametro("@idTipoEdicion", nuevo.Tipo.Id);
                datos.setearParametro("@idEstilo", nuevo.Genero.Id);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
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

        public void modificarDisco(Disco modifica) 
        {
            AccesoDatos datos = new AccesoDatos(); //Puede ser atributo privado de clase DiscoNegocio o agregado en constructor 

            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo, CantidadCanciones = @cantidadCanciones, UrlImagenTapa = @img, IdEstilo = @idGenero, IdTipoEdicion = @idTipo, Artista = @artista where Id = @id");
                datos.setearParametro("@titulo", modifica.Titulo);
                datos.setearParametro("@cantidadCanciones", modifica.cantidadCanciones);
                datos.setearParametro("@img", modifica.UrlImagenTapa);
                datos.setearParametro("@idGenero", modifica.Genero.Id);
                datos.setearParametro("@idTipo", modifica.Tipo.Id);
                datos.setearParametro("@artista", modifica.Artista.Nombre);
                datos.setearParametro("@id", modifica.Id);

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

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select Titulo, Artista, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND D.IdTipoEdicion = T.Id AND D.EnStock = 1 AND ";
                switch (campo)
                {
                    default: //ACA
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void quitarDisco(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where Id = @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void quitarDisco_Logico(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update DISCOS set EnStock = 0 where id = @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
