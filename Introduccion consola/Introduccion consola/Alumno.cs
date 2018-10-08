using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_consola
{
    class Alumno : Persona
    {
        public float nota;
        public Alumno() : base()
        {
            float.TryParse(Console.ReadLine(), out nota);
        }
        

    }
}
