using System.Data;
using System.Data.SqlClient;
using TiendaApi.Conexion;
using TiendaApi.Models;

namespace TiendaApi.DTOs
{

    /*devemos importar nuestro modelo de datos*/
    public class ProductsDTO
    {
        ConexionBD  cnx = new ConexionBD();

        public async Task <List<Mproductos>> MostrarProductos()
            /*indicamos que retornaremos una lista de productos cada vez que se llame a la funcion*/
        {
            var lista = new List<Mproductos>();
            /* antes de usar sqlConnection descargamos system.data.sqlClient*/
            using ( var sql = new SqlConnection(cnx.getConection())) // la funcion using me cierra la conexion automaticamente
            {

                /*a continuacion consumiremos el procedimiento almacenado*/
                using (var cmd = new SqlCommand("[dbo].[ReadProducts]", sql))
                {
                    await sql.OpenAsync(); //para habrir la conexion
                    /*indicamos que se trata de un procedimiento almacenadao*/
                    cmd.CommandType = CommandType.StoredProcedure;

                    /* A continuacion en el siguiente metodo recorreremos la data de lo que nos retorna el metodo anterior*/
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while(await item.ReadAsync())
                        {
                            var mproductos = new Mproductos();
                            mproductos.id = (int)item["ID"];
                            mproductos.descripcion = (string)item["DESCRIPCION"];
                            mproductos.precio = (decimal)item["PRECIO"];
                            lista.Add(mproductos);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task AddProducts(Mproductos parametros)// cada que el usuario consuma esta funcion tendra que enviar un objeto de parametros
        {
            using (var sql = new SqlConnection(cnx.getConection()))
            {
                /* a continuacion hacemos nuestro comando nuevamente*/
                using(var cmd = new SqlCommand("[dbo].[InsertProduct]" ,sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /* ahora indicamos que tambien tiene parametros*/
                    cmd.Parameters.AddWithValue("descripcion", parametros.descripcion); //indicamos que este procedimiento tendra paramtros para agrear
                    cmd.Parameters.AddWithValue("precio", parametros.precio);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }
    }
}
