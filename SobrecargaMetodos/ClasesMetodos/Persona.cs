namespace ClasesMetodos
{

    /* se conoce como sobrecarcga de metodos declarar dos metodos de una clase exactamente iguales pero diferenciarlos poniendole parametros diferentes 
     * se diferencian por la cantidad de parametros y */
    public class Persona
    {
        //atrubutos
        string nombre;
        int edad;
        string dni;


        //metodos
        public Persona(string nombre, int edad)  
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona(string dni)
        {
            this.dni = dni; 
        }
        
        public void correr()
        {
            Console.WriteLine("Hola soy " + nombre + "Tengo " + edad);
        }

        public void correr(int km)
        {
            Console.WriteLine(" estoy correiendo una maraton y he recorrido " + km );
        }
    }
}