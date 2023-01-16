using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoExcepciones
{
    public class Exception
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Ingresa el numero de mes");

            try
            {
                int  mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(nombreMes(mes));
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine("el numero que ingreso no es permitido en el metodo");
            }
            
        }

        public static string nombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "febrero";
                    break;
                case 3:
                    return "marzo";
                    break;
                case 4:
                    return "abril";
                    break;
                case 5:
                    return "mayo";
                    break;
                case 6:
                    return "junio";
                    break;
                case 7:
                    return "julio";
                    break;
                case 8:
                    return "agosto";
                    break;
                case 9:
                    return "sepriembre";
                    break;
                case 10:
                    return "octubre";
                    break;
                case 11:
                    return "nobiembre";
                case 12:
                    return "diciembre";

                    /*ahoa veremos como lanzar excepciones de esta menera se obliga a que cada vez que un programador trabaje en nuesto proyecto tambien 
                     * deba usar un try catch para llamar a este metodo*/
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
