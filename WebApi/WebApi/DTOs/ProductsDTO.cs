using System.Data.SqlClient;
using TiendaApi.Conexion;
using TiendaApi.Models;
namespace TiendaApi.DTOs
{

    /*devemos importar nuestro modelo de datos*/
    public class ProductsDTO
    {
        ConexionBD  cn = new ConexionBD();
        public async Task <List<Mproductos>> MostrarProductos()
            /*indicamos que retornaremos una lista de productos*/
        {
            var lista = new List<Mproductos>();
            using (var sql = new SqlConnection(cn.getConection()));
        }
    }
}
