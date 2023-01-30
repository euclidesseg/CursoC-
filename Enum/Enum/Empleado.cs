using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Empleado
    {
        private double bonus;
        private double sueldo;
        public Empleado(Bonus bonusEmpleado, double sueldo) 
        {
            this. bonus = (double)bonusEmpleado;
            this.sueldo = sueldo;
        }
        public double getSueldo()
        {
            return bonus + sueldo;

        }
    }
}
