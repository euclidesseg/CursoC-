using clasesObjetos;
using System;

namespace Metodos
{
    public class Methods
    {
        /*Los metodos en son un grupo de instrucciones que van a realizar un grupo de tareas
           en concreto*/
        public static void Main(string[] args)
        {
            /* creacion de un objeto de tipo de la clae Coche para poder usarla hay que agregar referencia al proyecto 
             * e importar el la biblioteca de clases*/
            /* Coche coche1 = new Coche();
             coche1.marca = "Audi";
             coche1.km = 0;
             coche1.color = "Blanco";

             Coche coche2 = new Coche();
             coche2.marca = "Mustan";
             coche2.km = 150;
             coche2.color = "Negro";

             Console.WriteLine("la marca del cohhe es:        " + coche1.marca);
             Console.WriteLine("El kilometraje del coche1 es: " +coche1.km);
             Console.WriteLine("el color del coche 1 es:      " + coche1.color);

             Console.WriteLine();

             Console.WriteLine("La marca del coche 2 es:        " + coche2.marca);
             Console.WriteLine("El kilometraje del coche 2 es;  " + coche2.km);
             Console.WriteLine("El color del coche 2 es         " + coche2.color);
            */


            Operacion op1 = new Operacion();
            op1.pedirNumeros();
            op1.restar();
            op1.sumar();
            op1.dividir ();
            op1.multiplicar();
            op1.mostarResultados();
        }
    }
}
