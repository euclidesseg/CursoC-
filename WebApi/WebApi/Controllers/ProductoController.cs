using Microsoft.AspNetCore.Mvc;
using TiendaApi.Models;

namespace TiendaApi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    /* esto indicaria la ruta de nuestra api a la que va a apuntar*/
    public class ProductoController
    {
        /*indicando que voy a consumir la data y traere la informacion*/
        [HttpGet]
      
        public async Task <ActionResult <List<Mproductos>>> Get()
        /* Acabo de indicar que el primer metodo de nuestro controlador sera una tarea azincrona y que sera una lista de Mproductos*/
        {

        }
       


    }
}
