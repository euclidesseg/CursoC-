using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Resolver
    {
        public static void Main(string[] args)
        {
            resolverEjercicio();
        }
        public static void resolverEjercicio()

        {
            int numero = 0;
            Console.WriteLine("Ingresa un numero Cualquiera");
            numero = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Es un numero par " + i);
                }
                else
                {
                    Console.WriteLine("Es un numero impar " + i);
                }

            }

        }



    }
}
