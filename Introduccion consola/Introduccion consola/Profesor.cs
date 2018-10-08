using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_consola
{
    class Profesor : Persona
    {
        int año_exp;
        public Profesor():base()
        {
            Console.WriteLine("¿Cuantos años de experiencia tiene?");
            int.TryParse(Console.ReadLine(), out año_exp);
        }
    }
}
