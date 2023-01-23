using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    //la sintaxis para especificar ue una clase hereda es : y el nombre de la clase que va a heredar
    public class Caballo: Mamiferos
    {
        // si un caballo respira y cuida de las crias no necesito volverlo a programar porque ya lo hereda
        public void galopar()
        {
            Console.WriteLine("hola puedo galopar");
        }
    }
}
