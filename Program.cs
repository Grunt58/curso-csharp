using System.Collections.Generic;

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
            Personas.Add("Erick");

            do
            {
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingresa el elemento a agregar en la lista: ");
                    elem = Console.ReadLine();

                    Personas.Add(elem);
                }
            } while (opcion != 2);
        }
    }
}
