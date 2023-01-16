using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMetodos
{
    public class Operacion
    {
        int numero1;
        int numero2;

        int suma;
        int resta;
        int multiplicacion;
        int division;

        /* cando se declara la variable en el metodo se conoce como pedida de parametros y cuando se le manda desde la clase
         * implementadora se conoce como argumento*/
        public void sumar(int numero1, int numero2)
        {
            suma = numero1 + numero2;
        }
        public void restar(int numero1, int numero2)
        {
            resta = numero1 - numero2;
        }
        public void multiplicar(int numero1, int numero2)
        {
            multiplicacion = numero1 * numero2;
        }
        public void dividir(int numero1, int numero2)
        {
            division = numero1 / numero2;
        }

        public void mostrar()
        {
            Console.WriteLine("la suma es  " + suma);
            Console.WriteLine("la resta es " + resta);
            Console.WriteLine("la multiplicacion es " + multiplicacion);
            Console.WriteLine("la division es " + division);
        }
    }


}
