using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    /* los enum o enumerables son un conjunto de constantes con nombres 
     * nos ayudan a reprecentar y manejar valores fijos o constantes en nuestros programas*/

     enum Bonus { Bajo = 500, Normal = 600, Buenmo = 700, Extra = 800};
    // a esas constantes les podemos dar un valor 
    /* la sintaxis para acceder a cada una de esta constantes es Estacion.Verano*/
    internal class EnumMain
    {
        public static void Main(string[] args)
        {

            /*  //se usan muy parecido a las declaraciones de un objeto solo que esta vez es con un tipo enumerado
              //intentemos darle a un empleado el bonues bueno

              Bonus Euclides = Bonus.Extra;
              Console.WriteLine(Euclides);

              //Si quiero imprimir el valor y no el nombre debo hacer un castind a double de Euclides
              double bonusEuclides = (double)Euclides;
              Console.WriteLine(bonusEuclides);

              //despues de hacer eso podemos operar con ese valor

              double salarioEuclides = 600 + bonusEuclides;
              Console.WriteLine(salarioEuclides);*/

            //ahora hagamos un ejemplo mandandolo por parametro a un constructor

            Empleado euclides = new Empleado(Bonus.Extra, 200);
            Console.WriteLine($"el bonus del empleado es {euclides.getSueldo()}");
            
        }
    }
}
