using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un programa que simule una app bancaria sencilla, y que nos permita tres cosas:

            - Ingresar un gasto
            - Mostrarnos todos los gastos que hemos hecho, empezando por el último
            - Sumar todos los gastos hechos y mostrarnos el monto que debemos pagar(pago para no generar intereses)
            */

            // Variables necesarias
            float gasto, totalGasto;
            int opcion, i;

            Stack<float> gastos = new Stack<float>();

            do
            {
                Console.Clear();
                Console.WriteLine("Banca Online");

                // Menú
                Console.WriteLine("1. Ingresar gasto");
                Console.WriteLine("2. Mostrar gastos");
                Console.WriteLine("3. Mostrar monto a pagar");

                Console.Write("\nElige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el monto: ");
                        gasto = Convert.ToSingle(Console.ReadLine());

                        gastos.Push(gasto);

                        Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                        Console.ReadKey();

                        break;
                    case 2:
                        i = 0;

                        if (gastos.Count != 0)
                        {
                            Console.WriteLine("Mostrando gastos:\n");
                            foreach (float item in gastos)
                            {
                                Console.WriteLine($"[{i++}]: ${item}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay gastos registrados.");
                        }
                        

                        Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                        Console.ReadKey();

                        break;
                    case 3:
                        totalGasto = 0;

                        if(gastos.Count != 0)
                        {
                            foreach (float item in gastos)
                            {
                                totalGasto += item;
                            }

                            Console.WriteLine($"El monto total a pagar es: ${totalGasto} ({gastos.Count} gasto(s))");
                        }
                        else
                        {
                            Console.WriteLine("No hay gastos registrados.");
                        }

                        Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                        Console.ReadKey();

                        break;
                }
            } while (opcion >= 1 && opcion <= 3);
        }
    }
}
