using System.Data.SqlTypes;

namespace TiendaApi.Models
{
    public class Mproductos
    {
        /* aqui iria los campos exsacamente como en la base de datos 
         * el signo de ? es para que me deje darle valores nulos*/
        public int id { get; set; }
        public string? descripcion { get; set; }
        public decimal precio { get; set; }
    }
}
