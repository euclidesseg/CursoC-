
using System;
using Clases;

namespace GenericosConRestriccion
{
    public class ClaseMain
    {
        public static void Main(string[] args)
        {
            GenericaAlmacenOgjetos<Secretaria> empleados = new GenericaAlmacenOgjetos<Secretaria>(2);
            empleados.LlenarArreglo(new Secretaria(1200000));
            empleados.LlenarArreglo(new Secretaria(1299999));

            Secretaria sueldo = empleados.getDatosEmpleados(1);
            Console.WriteLine((double)sueldo.getSalario());
        }
    }
}