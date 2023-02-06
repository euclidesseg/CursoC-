using Microsoft.AspNetCore.Mvc;
using TiendaApi.DTOs;
using TiendaApi.Models;

namespace TiendaApi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    /* esto indicaria la ruta de nuestra api a la que va a apuntar*/
    public class ProductoController : ControllerBase
    {
        /*indicando que voy a consumir la data y traere la informacion con httget*/
        [HttpGet]

        public async Task <ActionResult<List<Mproductos>>> Get() // si no retorno nada me dara herror para eso creamos la conexion en otra carpeta
        /* Acabo de indicar que el primer metodo de nuestro controlador sera una tarea azincrona y que devolvera una lista de Mproductos*/
        {
            var funcion = new ProductsDTO();
            var lista = await funcion.MostrarProductos();
            return lista;
        }



        // otro metodo para enviar los datos
        /* el frombody indica que es el cuerpo del metodo es decir se enviara la informacion atravez de un cuerpo json que representa
         * al modelado de productos*/
        [HttpPost]
        public async Task Post([FromBody] Mproductos parametros)/*indicamos que enviaremos los datos atravez de fromBody*/
        {
            var funcion = new ProductsDTO();
            await funcion.AddProducts(parametros);
        }


        //Actualizando un registro con HttPut
        [HttpPut("{Id}")] // para poder actualizar un registro siempre necesitamos enviarle un parametro a travez de la url para poder editar el registro
        public async Task<ActionResult> Put(int Id, [FromBody] Mproductos parameters) //indicamos que el id del parametro va a llgar atravez del fronBody
            /* este metodo va a pedir un id de parametro que llega atravez de la url y va a pedir un objeto de tipo Mproductos*/
        {
            var funcion = new ProductsDTO();
            parameters.id = Id;
            await funcion.EditarProductos(parameters);
            return NoContent(); //para poder usar este metodo debemos heredar de basecontrollers
        }

        [HttpDelete("{Id}")] /*Para hacer un delete tambien necesitamos pasar un parametro por la ruta*/
        public async Task<ActionResult> Delete(int Id)
        {
            var funcion = new ProductsDTO();
            var parameters = new Mproductos();
            parameters.id = Id;
            await funcion.EliminarProductos(parameters);
            return NoContent();

        }
    }
}
