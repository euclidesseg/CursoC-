using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class GenericaAlmacenOgjetos<T> where T: IEmpleados
        /* De esta forma le indicamos a nuestra clase generica va a recibir de objetod de todo tipo de clases
         * pero esas clases deben estar implementando la clase IEmpleados*/
    {
        int i = 0;

        private T [] DatosEmpleados; 
        /* declaramos un arreglo de generico llamado datosempleados*/
        public GenericaAlmacenOgjetos(int n)
        {
            DatosEmpleados = new T[n];
            /* ubducamos que nuestro arreglo tendra n numeros de posiciones*/
        }

        public void LlenarArreglo(T objeto)
        {

            DatosEmpleados[i] = objeto;
            i++;
        }
        public T getDatosEmpleados(int posicion)
        {
            return DatosEmpleados[posicion];
        }
    }
 
}
