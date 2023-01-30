using System.Reflection;

namespace ClasesGenericas
{
    public class GenericasConHerencia
    {
        /* para probar la diferencia entre la creaion de clases que sirvan para todo con la POO y la programacion generica veamos 
         * la POO primero */
        private Object [] elementos;
        int indice = 0;

        public  GenericasConHerencia(int z)
        {
            /*estamos indicando que este objeto tendra z numeros de posiciones */
            elementos = new Object[z];
        }

        /* el metodo para llenar el objeto me va a recibir un objeto de tipo object y por ende podra recibir de todo*/
        public void LlenarArreglo(Object obj)
        {
            /* cada vez que se instancie este metodo dentro de una clase recibira el objeto por parametro y lo almacenara en la posision
             * indice seguido incrementara el indice y si se intancia orta vez repitiraj el siclo*/
            elementos[indice] = obj;
            indice ++;
        }
        public Object GetOBjeto(int posision)
        {
            return elementos[posision];
        }
    }
}