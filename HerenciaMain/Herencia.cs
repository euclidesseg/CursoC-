using ClasesHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaMain
{
    internal class Herencia
    {
        //ahora en la clase principal vamos a instanciar cada una de las clases que heredan de la clase mamiferos
        public static void Main(string[] args)
        {
            Caballo caballo1 = new Caballo();
            Gorila copito = new Gorila();
            Humano humano1 = new Humano();

            //los dos primeros metodos son de la clase mamifereos pero lo usamos con el objeto caballo1 porque los esta heredando
            caballo1.CuidarCrias();
            caballo1.Respirar();
            caballo1.galopar();
            
            Console.WriteLine();

            copito.CuidarCrias();
            copito.Respirar();
            copito.Trepar();

            Console.WriteLine();

            humano1.CuidarCrias();
            humano1.Respirar();
            humano1.pensar();
        }
    }
}
