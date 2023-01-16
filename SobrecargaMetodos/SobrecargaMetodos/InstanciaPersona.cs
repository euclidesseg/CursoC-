using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesMetodos;

namespace SobrecargaMetodos
{
    public class InstanciaPersona
    {
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona("Euclides", 26);
            persona1.correr();

            Persona persona2 = new Persona("sdfg646");     

            persona2.correr(25);
        }
      
    }
}
