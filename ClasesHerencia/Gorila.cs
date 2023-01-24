using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    public class Gorila:Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("soy capaz de trepar");
        }
    }
}
