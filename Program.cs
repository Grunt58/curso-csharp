using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey,TValue> (Diccionario)
            Dictionary<string, int> empleados = new Dictionary<string, int>();

            // Añadiando key-value pairs a la colección
            empleados.Add("Hugo", 36);
            empleados.Add("Erica", 20);

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }

            // colección[key] = value;
            empleados["Miguel"] = 45; // Con Add: empleados.Add("Miguel", 45);

            // Después de agregar un elemento con Item[]
            Console.WriteLine("\nDespués de agregar un elemento con Item[]\n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }

            // Comprobando que Item[] reemplaza la "key"
            Console.WriteLine("\nComprobando que Item[] reemplaza la (key)\n");

            empleados["Hugo"] = 19;

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }

            // Usando el get de la propiedad Item[]
            Console.WriteLine($"\nLa edad de Erica es: {empleados["Erica"]}\n");

            // Si no se encuetra la clave
            Console.WriteLine($"\nLa edad de Erica es: {empleados["Maria"]}\n");
        }
    }
}
