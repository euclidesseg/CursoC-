﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Director:IEmpleados
    {
        double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
