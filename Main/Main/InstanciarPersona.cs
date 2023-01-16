using ClasesMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class InstanciarPersona
    {
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona("Euclides", 21);
            persona1.mostrarDatos();
        }
    }
}
