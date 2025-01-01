using System.Collections.Generic;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            string elem;
            int opcion;

            // Instancia de List
            List<string> Personas = new List<string>();

            // Agregamos objetos a la lista
            Personas.Add("Hugo");
            Personas.Add("Miguel");
            Personas.Add("Diana");
            Personas.Add("Héctor");

            //do
            //{
            //    Console.WriteLine("1. Agregar elemento");
            //    Console.WriteLine("2. Salir");

            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Write("Ingresa el elemento a agregar en la lista: ");
            //        elem = Console.ReadLine();

            //        Personas.Add(elem);
            //    }

            //} while (opcion != 2);

            Console.WriteLine("Información en la List: \n");
            // Instrucción "foreach" para recorrer una colección
            foreach (string elemento in Personas)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Ejecutando el método 'Clear()'");
            Personas.Clear();

            Console.WriteLine($"\nElementos en la List: {Personas.Count}");
        }
    }
}
