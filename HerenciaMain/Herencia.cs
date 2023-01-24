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

            //cada clase hija me esta pideindo un parametro y se lo debo enviar como argumento desde la llamada al mismo
            Caballo caballo1 = new Caballo("babieca");
            Gorila copito = new Gorila("copito");
            Humano humano1 = new Humano("Euclides");

            //los dos primeros metodos son de la clase mamifereos pero lo usamos con el objeto caballo1 porque los esta heredando
            caballo1.CuidarCrias();
            caballo1.Respirar();
            caballo1.galopar();
            caballo1.getNombre();   
            
            Console.WriteLine();

            copito.CuidarCrias();
            copito.Respirar();
            copito.Trepar();
            copito.getNombre(); 

            Console.WriteLine();

            humano1.CuidarCrias();
            humano1.Respirar();
            humano1.pensar();
            humano1.getNombre();
        }
    }
}
//principio de sustitucion consiste en que un objeto de la clase padre puede instanciar o almacenar un a cualquiera de sus clases hijas
// ejemplo Mamifero animao = new Caballo();
// solo se podra acceder a los metodos de la clase Mamifero