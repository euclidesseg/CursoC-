﻿using Microsoft.AspNetCore.Mvc;
using TiendaApi.DTOs;
using TiendaApi.Models;

namespace TiendaApi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    /* esto indicaria la ruta de nuestra api a la que va a apuntar*/
    public class ProductoController
    {
        /*indicando que voy a consumir la data y traere la informacion con httget*/
        [HttpGet]
      
        public async Task <ActionResult<List<Mproductos>>> Get() // si no retorno nada me dara herror para eso creamos la conexion en otra carpeta
        /* Acabo de indicar que el primer metodo de nuestro controlador sera una tarea azincrona y que sera una lista de Mproductos*/
        {
            var funcion = new ProductsDTO();
            var lista = await funcion.MostrarProductos();
            return lista;
        }
       


    }
}
