using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class VariasExcepciones
    {
        public static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int miNumero;
            int intentos = 0;

            Console.WriteLine("Ingresa un numero para adivinar entre 1 y 100");


            do
            {
                intentos++;
                try
                {
                    miNumero = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException err)
                {

                    Console.WriteLine("No ha introducido un formato de numero valido");
                    miNumero = 0;
                    /* Acontinuacion se especifica otro tipo de excepcion y de esta manera se capturan dos dos exceptiones en una */
                    /* Los tipos de excepciones en modo decendente son:  Exception, SystemException, FormatException y OverflowException*/
                }
                catch (Exception ex) when (ex.GetType()!= typeof(FormatException))
                /*para resolver los conflictos entre las excepciones hacemoes esto */
                /*que capture todas las excepciones mientras el tipo de excepcion sea diferente a FormatException*/
                {

                    Console.WriteLine("El valor es demasiado alto");
                    miNumero = 0;
                }


                if (miNumero > aleatorio)
                {
                    Console.WriteLine("El numero ingresado es mayor");
                }
                if (miNumero < aleatorio)
                {
                    Console.WriteLine("El numero ingresado es menor");
                }
            } while (miNumero != aleatorio);
            Console.WriteLine("Correcto has necesitado " + intentos + " intentos");
            Console.WriteLine("A partir de esta linea de codigo continuara el programa");
        }
    }
}
