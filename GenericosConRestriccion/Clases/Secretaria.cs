namespace Clases
{
    public class Secretaria: IEmpleados
    {
        double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }
}