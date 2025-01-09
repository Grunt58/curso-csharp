﻿using System.Collections.Generic;
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
        }
    }
}
