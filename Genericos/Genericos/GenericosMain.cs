using ClasesGenericas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class GenericosMain
    {
        public static void Main(string[] args)
        {
            /* GenericasConHerencia files = new GenericasConHerencia(8);

              files.LlenarArreglo(2);
              files.LlenarArreglo("euclides de megara");
              files.LlenarArreglo(4);
              files.LlenarArreglo("anacsimandro");
              files.LlenarArreglo("socrates");
              files.LlenarArreglo("platon");
              files.LlenarArreglo("diogenes");
              files.LlenarArreglo("pitagoras");

             Console.WriteLine(files.GetOBjeto(0));
             //hasta aqui todo bien peor si intento crear una variable string para almacenear lo que me retorna el 
             //metodo GetObjetos me c# me obliga a usar un casting

             string resultado = (string)files.GetOBjeto(3);
             Console.WriteLine(resultado);*/


            /*a continuacion instanciamos la clase generica*/

           AlmacenObjetos<string> files = new AlmacenObjetos<string>(8);
           /* si yo quisiera almacenar objetos de cualquier otro tipo por ejemplo de una clase empleado solo cambio el valor entre los corchetes*/
           files.LlenarArreglo("aristotles");
           files.LlenarArreglo("euclides de megara");
           files.LlenarArreglo("tesla");
           files.LlenarArreglo("anacsimandro");
           files.LlenarArreglo("socrates");
           files.LlenarArreglo("platon");
           files.LlenarArreglo("diogenes");
           files.LlenarArreglo("pitagoras");

          Console.WriteLine(files.GetObjeto(0));
         

          string resultado = files.GetObjeto(3);
          /* ahora podemos precindir de este casting */
          Console.WriteLine(resultado);
        }

    }
}
