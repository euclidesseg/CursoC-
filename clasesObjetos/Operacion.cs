using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesObjetos
{
    public class Operacion
    {
        int numero1;
        int numero2;

        int suma;
        int resta;
        int division;
        int multiplicasion;

        public void pedirNumeros()
        {
            Console.WriteLine("Ingrese el numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

        }
        public void sumar()
        {
            suma = numero1 + numero2;
        }
        public void restar()
        {
            resta = numero1 - numero2;
        }

        public void dividir()
        {
            division = numero1 / numero2;
        }

        public void multiplicar()
        {
            multiplicasion = numero1 * numero2;
        }

        public void mostarResultados()
        { 
            Console.WriteLine("El resultado de la suma es           " + suma);
            Console.WriteLine("El resultado de la resta es          " + resta);
            Console.WriteLine("El resultado de la division es       " + division);
            Console.WriteLine("El resultado de la multiplicasion es " + multiplicasion);
        }
    }
}
