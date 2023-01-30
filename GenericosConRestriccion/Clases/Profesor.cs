using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Profesor:IEmpleados
    {
        double salario;
        public Profesor(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }
}
