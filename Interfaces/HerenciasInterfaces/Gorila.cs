using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasInterfaces
{
    public class Gorila:Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public int numeroPatas()
        {
            return 2;
        }

        public void Trepar()
        {
            Console.WriteLine("soy capaz de trepar");
        }
    }
}
