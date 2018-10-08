using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_consola
{
    class Persona
    {
        private String DNI, apellidos, nombre, Fecha_N;
        private char sexo;
        private int peso, altura;

        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha_N1 { get => Fecha_N; set => Fecha_N = value; }

        public Persona()
        {
            LeeDatosPersona();
        }

        public void LeeDatosPersona()
        {
            Console.WriteLine("Introduce DNI");
            DNI = Console.ReadLine();
            Console.WriteLine("Introduce apellido");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduce nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce Fecha_N");
            Fecha_N = Console.ReadLine();
            Console.WriteLine("Introduce sexo");
            sexo = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine("Introduce peso");
            int.TryParse(Console.ReadLine(),out peso);
            Console.WriteLine("Introduce altura");
            int.TryParse(Console.ReadLine(), out altura);
            
        }

        public void VerDatosPersona()
        {
            Console.WriteLine(ToString());
            
        }

        public override string ToString()
        {
            return "[DNI= " + DNI + " apellidos= " + apellidos + " nombre= " + nombre + " Fecha_N= " + Fecha_N + " Sexo= " + sexo + " Peso= " + peso + " Altura= " + altura+ "]";
        }
    }
}
