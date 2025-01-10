using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack
            Stack<double> miPila = new Stack<double>();

            // Insertar objetos al principio del Stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);

            int i = 0; // Mostrar índice

            // Mostrar la información del Stack
            foreach(double elemento in miPila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            // Después de insertar un elemento
            Console.WriteLine("\nDespués de insertar un elemento\n");
            miPila.Push(1.5);
            i = 0;

            // Mostrar la información del Stack
            foreach(double elemento in miPila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            // Después de quitar un elemento
            Console.WriteLine("\nDespués de quitar un elemento\n");
            var eliminado = miPila.Pop();
            i = 0; // Reiniciamos el valor del índice

            // Mostrar la información del Stack
            foreach(double elemento in miPila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            Console.WriteLine($"El elemento ({eliminado}) se ha eliminado con éxito.");

            //Después de usar Peek()
            Console.WriteLine("\nDespués de usar Peek()\n");
            var primerObj = miPila.Peek();
            i = 0; // Reiniciamos el valor del índice

            // Mostrar la información del Stack
            foreach (double elemento in miPila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            Console.WriteLine($"El primer elemento del Stack es: ({primerObj})");

            // Saber si el Stack contiene el elemento
            bool contiene;
            double buscarElem;

            Console.Write("\nIngresa el elemento a buscar: ");
            buscarElem = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(buscarElem);

            if (contiene)
            {
                Console.WriteLine($"El objeto ({buscarElem}) se encuentra en el Stack");
            }
            else
            {
                Console.WriteLine($"No se encontró el objeto ({buscarElem}) en el Stack");
            }

            Console.WriteLine($"\nEl Stack contiene {miPila.Count} elementos.");
        }
    }
}
