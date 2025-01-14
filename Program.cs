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
            int opcion;
            string nombre;
            long numero;

            // Instanciamos a la colección
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                // Menú
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contacto");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);

                        Console.WriteLine($"\n({nombre}) se ha agregado co éxito");

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encotrado!");
                            Console.WriteLine($"{nombre}: {contactos[nombre]}");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);
                            Console.WriteLine($"\n({nombre}) ha sido eliminado con éxito");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> contacto in contactos)
                        {
                            Console.WriteLine($"{contacto.Key}: {contacto.Value}");
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion >= 1 && opcion <= 4);
        }
    }
}
