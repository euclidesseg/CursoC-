using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    /*Ahora para ver una ejemplo de programacion generica veamos como transformar la clase Genericas ConHerencia en una clase generica normal*/
    /*para especificar que una clase sera generica lo hacemos entre parentesis angulares y por convencion de C# se agrega la letra T*/
    public class AlmacenObjetos<T>
    {
        /*lo primero que hay que haceragregar todos sus metodos como genericos*/
        private T [] elementos;
        int indice = 0;

        public AlmacenObjetos(int z)
        {
            /*estamos indicando que este objeto tendra z numeros de posiciones */
            elementos = new T [z];
        }

        /* el metodo para llenar el objeto me va a recibir un objeto de tipo object y por ende podra recibir de todo*/
        public void LlenarArreglo(T obj)
        {
            /* cada vez que se instancie este metodo dentro de una clase recibira el objeto por parametro y lo almacenara en la posision
             * indice seguido incrementara el indice y si se intancia orta vez repitiraj el siclo*/
            elementos[indice] = obj;
            indice++;
        }
        public T GetObjeto(int posision)
        {
            return elementos[posision];
        }
    }
}
