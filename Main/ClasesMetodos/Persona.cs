using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMetodos
{
    /*Provando el metro constructor */
    public class Persona
    {
        //atribuos 
        string nombre;
        int edad;

        //metodos 
        /* el primer metodo que se suele crear en toda clase es el metodo contructor no devuelve ningun valor y el metodo constructor es el unico 
         * que nose le debe poner el tipo de retorno*/


        //este metodo nos facilita la inicializacion de los atributos de esta clase
        public Persona(string nombre, int edad ) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void mostrarDatos()
        {
            Console.WriteLine("el nombre es " + nombre);
            Console.WriteLine("la edad es " + edad);
        }

    }
}
