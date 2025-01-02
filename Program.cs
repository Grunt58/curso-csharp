using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            int opcion, indice;
            string alumno;

            // Instancia de List
            List<string> Alumnos = new List<string>();

            do
            {
                Console.Clear();

                // Menú
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Buscar por nombres");

                // Escoger una opción
                Console.Write("\nEscoge una ocpión: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1. Agregar estudiante");
                        Console.Write("\nNombre de alumno: ");

                        alumno = Console.ReadLine();
                        Alumnos.Add(alumno);

                        Console.WriteLine($"{alumno} se ha agregado correctamente");
                        Console.WriteLine("\nPresione cualquier tecla para regresar al menú");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("2. Eliminar estudiante");
                        Console.Write("\nNúmero del estudiante: ");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--; // Reducimos en 1 a indice porque el usuario no sabe que el indice empieza en 0, por lo tanto, si se ingresa 1, en realidad será 0

                        if (indice >= Alumnos.Count || indice < 0)
                        {
                            Console.WriteLine("El alumno no existe.");
                        }
                        else
                        {
                            string alumnoElim = Alumnos[indice];
                            Alumnos.RemoveAt(indice); // Quitamos al alumno de la List
                            Console.WriteLine($"{alumnoElim} se ha eliminado correctamente");
                        }

                        Console.WriteLine("\nPresione cualquier tecla para regresar al menú");
                        Console.ReadKey();
                        break;

                    case 3:
                        int i = 1; // Nos sirve para mostrar el índice de los estudiantes
                        Console.WriteLine("3. Mostrar estudiantes\n");

                        foreach (string item in Alumnos)
                        {
                            Console.WriteLine($"[{i++}]: {item}");
                        }

                        Console.WriteLine("\nPresione cualquier tecla para regresar al menú");
                        Console.ReadKey();
                        break;

                    case 4:
                        string encontrarAlum;
                        int j; // Número de lista

                        Console.WriteLine("4. Buscar por nombres");
                        Console.Write("\nNombre del alumno: ");

                        alumno = Console.ReadLine();

                        // Verificar si el elemento(alumno) está o no en la List
                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)];
                            j = Alumnos.IndexOf(alumno) + 1;
                            Console.WriteLine($"El estudiante {encontrarAlum} se encuentra en el número {j} de lista");
                        }
                        else
                        {
                            Console.WriteLine($"El estudiante {alumno} no se encuentra en el sistema.");
                        }
                        
                        Console.WriteLine("\nPresione cualquier tecla para regresar al menú");
                        Console.ReadKey();
                        break;
                }

            } while (opcion >= 1 && opcion <= 4);
        }
    }
}
