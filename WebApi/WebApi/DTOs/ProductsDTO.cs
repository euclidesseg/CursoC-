using Microsoft.AspNetCore.Mvc;
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

        /*Mostrar los registros*/
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

      
        /*agregar registros*/
        public async Task AddProducts(Mproductos parametros)// cada que el usuario consuma esta funcion tendra que enviar un objeto de Mproductos
        {
            using (var sql = new SqlConnection(cnx.getConection()))
            {
                /* a continuacion hacemos nuestro comando para agregar productos*/
                using(var cmd = new SqlCommand("[dbo].[InsertProduct]" ,sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /* ahora indicamos que tambien tiene parametros*/
                    cmd.Parameters.AddWithValue("@descripcion", parametros.descripcion); //indicamos que este procedimiento tendra paramtros para agrear
                    cmd.Parameters.AddWithValue("@precio", parametros.precio);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }


        /*Actualizamos los datos  */
        public async Task EditarProductos(Mproductos parametros)// cada que el usuario consuma esta funcion tendra que enviar un objeto de Mproductos
        {
            using (var sql = new SqlConnection(cnx.getConection()))
            {
                /* a continuacion hacemos nuestro comando para editar productos*/
                using (var cmd = new SqlCommand("[dbo].[UpdateProduct]", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /* ahora indicamos que tambien tiene parametros*/

                    cmd.Parameters.AddWithValue("@id", parametros.id); //indicamos que este procedimiento tendra paramtros para agrear
                    cmd.Parameters.AddWithValue("@precio", parametros.precio);// vamoa a actualizar solamanet el precio del producto seleccionado
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                } 
            }

        }



        /*Eliminar un registro*/
        public async Task EliminarProductos(Mproductos parameters)
        /*indicamos que retornaremos una lista de productos cada vez que se llame a la funcion*/
        {
            using (var sql = new SqlConnection(cnx.getConection())) // la funcion using me cierra la conexion automaticamente
            {

                /*a continuacion consumiremos el procedimiento almacenado*/
                using (var cmd = new SqlCommand("[dbo].[DeleteProduct]", sql))
                {
                    /*indicamos que se trata de un procedimiento almacenadao*/
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", parameters.id);
                    await sql.OpenAsync(); //para habrir la conexion
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
