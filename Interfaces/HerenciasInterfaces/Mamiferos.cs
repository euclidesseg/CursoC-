
namespace HerenciasInterfaces
{
    // para crear la herencia vamos a crear una clase mamiferos de la cual van a heredar las clases Caballo Humano Y Gorila
    public class Mamiferos
    {
        // debo llamar al constrstructor de esta clase desde el constructor de la clase Hija para que este le de un estado inicial a todos los 
        // objetos

        private string nombreSerVivo;
        public Mamiferos(string nombreSerVivo)
        { 
            this.nombreSerVivo = nombreSerVivo;
        }
        


        public void Respirar()
        {
            Console.WriteLine("Hola estoy respirando");
        }

        public void CuidarCrias ()
        {
            Console.WriteLine("Cuido de mis crias hata que se valgan solas");
        }

        // para hacer una sobreescritura de metodos en c# al metodo principal le debo agrear la palabra recervada virtual
        // para que se pueda agregarr en la en el metodo de la clase hija la palabra override
        public virtual void pensar() 
        {
            Console.WriteLine("razonamiento basico instintivo");
        }
        public string getNombre()
        {
            return this.nombreSerVivo;
        }
    }
}