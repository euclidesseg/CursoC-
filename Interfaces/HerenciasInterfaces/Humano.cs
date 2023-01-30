using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasInterfaces
{

    // el estado inicial consiste en agregarle un nombre a los mamiferos que hereden de la clase principal
    public class Humano:Mamiferos
    {
        // el siguiente constructor debe llamar al constructor de la clase padre y ya que el constructor de la clase padre esta pidiendo un parametro
        // se lo mandamos desde la llamada al mismo
        public Humano(string nombreHumano):base(nombreHumano)
        {

        }
        //sobreescribiendo el metodo pensar
        public override   void pensar()
        {
            Console.WriteLine("Soy capaz de pensar razonablemente");
        }
    }
}
