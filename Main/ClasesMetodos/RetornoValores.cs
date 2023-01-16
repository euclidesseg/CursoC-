using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMetodos
{
    public class RetornoValores
    {
        /* No todas las clases deven tener atributos y metodos por ejempo esta no tiene atributos solo tiene metodos
         * esos metodos tienen atributos que se van a rellenar con argumentos que se envian desde otra clase*/
        public int  sumar(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }
        public int  restar(int numero1, int numero2)
        {
            int resta = numero1 - numero2;
            return resta;
        }
        public int multiplicar(int numero1, int numero2)
        {
            int multiplicacion = numero1 * numero2;
            return multiplicacion;
        }
        public int  dividir(int numero1, int numero2)
        {
            int division = numero1 / numero2;
            return division;
        }

        public void mostrar(int suma, int resta, int multiplicacion, int division)
        {
            Console.Write(suma + "\n");
            Console.Write(resta);
            Console.WriteLine();
            Console.Write(multiplicacion);
            Console.WriteLine();
            Console.Write(division);

        }
    }
}
