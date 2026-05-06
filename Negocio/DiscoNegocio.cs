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
                comando.CommandText = "Select Titulo, Artista, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Edicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.Artista = (string)lector["Artista"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)lector["Genero"];
                    aux.Tipo = new Edicion();
                    aux.Tipo.Descripcion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }

            
        }
    }
}
