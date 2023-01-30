
using HerenciasInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class ClaseMain
    {
        public static void Main(string[] args)
        {

            Caballo caballo1 = new Caballo("babieca");
            Gorila copito = new Gorila("copito");
            Humano humano1 = new Humano("Euclides");
            Ballena ballena1 = new Ballena("Willi");

            caballo1.CuidarCrias();
            caballo1.Respirar();
            caballo1.galopar();
            caballo1.getNombre();
            caballo1.numeroPatas();
            caballo1.deporte();
            caballo1.esHolimpico();
            Console.WriteLine(caballo1.numeroPatas());

            Console.WriteLine();

            copito.CuidarCrias();
            copito.Respirar();
            copito.Trepar();
            copito.getNombre();
            Console.WriteLine(copito.numeroPatas());

            Console.WriteLine();

            humano1.CuidarCrias();
            humano1.Respirar();
            humano1.pensar();
            humano1.getNombre();

            Console.WriteLine();

            ballena1.CuidarCrias();
            ballena1.Respirar();
            ballena1.pensar();
            Console.WriteLine("soy la ballena " + ballena1.getNombre() + "y " + ballena1.nadar());
        }
    }
}
