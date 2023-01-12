using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            int tabla = 7;
            int limite = 10;
            int resultado = 0;
           
            for (int i = 0; i <= limite; i ++)
            {
                resultado = 7 * i;
                Console.WriteLine(tabla + "*" + i + " = " + resultado);
            }

            parserar();
        }
        public static void parserar()
        {
            int numero1 = 3;
            string numero = Convert.ToString(numero1);
            Console.WriteLine(numero + 6);
            Console.WriteLine(Convert.ToInt32 ( numero) + 6);

        }
    }
}
