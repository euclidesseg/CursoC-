using HerenciasInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasInterfaces;

public class Ballena : Mamiferos
{
    //Llamado del constructor de la clase padre
    public Ballena(String nombreBallena) : base(nombreBallena)
    {

    }

    public string nadar()
    {
        return "Hola  puedo nadar";
    }
}
