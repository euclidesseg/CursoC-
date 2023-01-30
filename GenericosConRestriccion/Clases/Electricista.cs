using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Electricista : IEmpleados
    {
        double salario;
        public Electricista(double salario) 
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }
}
