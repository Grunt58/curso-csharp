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

        }
    }
}
