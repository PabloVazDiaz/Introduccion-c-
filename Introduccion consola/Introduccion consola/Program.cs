using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            char opc=' ';
            ArrayList lista = new ArrayList();

            
            for (int i = 0; i < 5; i++)
            {
                lista.Add(new Persona());
            }
            while (opc != '5')
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.DAR DE ALTA ");
                Console.WriteLine("2.DAR DE BAJA");
                Console.WriteLine("3.MODIFICAR DATOS");
                Console.WriteLine("4.VER DATOS");
                Console.WriteLine("5.SALIR");
                opc = Console.ReadKey().KeyChar;
                switch (opc)
                {
                    case '1':
                        {
                            lista.Add(new Persona());
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("¿Qué coche quieres borrar?");
                            int index;
                            int.TryParse(Console.ReadLine(), out index);
                            lista.RemoveAt(index);
                            break;
                        }
                    case '3':
                        {
                            
                            Console.WriteLine("¿Que persona quieres modificar?");
                            int index;
                            int.TryParse(Console.ReadLine(), out index);
                            ((Persona)lista[index]).VerDatosPersona();

                            ((Persona)lista[index]).Nombre=Console.ReadLine();

                            break;
                        }
                    case '4':
                        {
                            for(int i=0; i < lista.Count; i++)
                            {
                                ((Persona)lista[i]).VerDatosPersona();
                            }
                            Console.ReadKey();
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine("Ta luego");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Introduce un valor váido para el menu");
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}

