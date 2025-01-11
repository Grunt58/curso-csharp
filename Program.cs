using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue o cola
            // El primero en entrar, el primero en salir
            Queue<char> miFila = new Queue<char>();

            // Agregando objetos al Queue
            miFila.Enqueue('a');
            miFila.Enqueue('b');
            miFila.Enqueue('c');
            miFila.Enqueue('d');

            int i = 0;

            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            // Agregando otro elemento
            Console.WriteLine("\nDespués de agregar a (e)\n");
            miFila.Enqueue('e');

            i = 0;
            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }

            // Después de quitar un elemento
            Console.WriteLine("Después de quitar el elemento\n");
            var objElim = miFila.Dequeue();

            i = 0;
            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"[{i++}]: {elemento}");
            }
            Console.WriteLine($"\n({objElim}) fue eliminado correctamente");
        }
    }
}
