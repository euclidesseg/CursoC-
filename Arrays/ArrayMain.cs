using Bibliotecas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArrayMain
    {
        
        public static void Main(string[] args)
        {

            int[] edades = new int[4];
            edades[0] = 1;
            edades[1] = 3;
            edades[2] = 3;
            edades[3] = 4;

            //array implicitos
            //array implicito indica que es un tipo de datos que no se sabe cual sera el tipo de datos ni cuantos elementos tendra el array
            //var datos = new[] { "uan", "diaz", "españa", 6 }; // error

            var valores = new[] {2,54, 34,23.5, 3.1 , 6 }; //todos a fouble

            //array de objetos
            ClaseEjemplo[] arrayEjemplos = new ClaseEjemplo[2];
            //se indico que es un array de tipo claseEjemplo y que almaceneara objetos

            arrayEjemplos[0] = new ClaseEjemplo("sara", 37);
            ClaseEjemplo Ana = new ClaseEjemplo("ana", 20);
            arrayEjemplos[1] = Ana;

            Console.WriteLine(arrayEjemplos[0]);

            for (int i = 0; i < arrayEjemplos.Length; i++)
            {
                Console.WriteLine("nombre = " + arrayEjemplos[i].name + " edad = " + arrayEjemplos[i].age);
            }
            Console.WriteLine(edades[3]);
        }
    }
}
