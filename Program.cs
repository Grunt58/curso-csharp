using System.Collections.Generic;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            string valorElemento;

            //// Instanciando la clase
            //GuardaObjetos<Alumno> objetos1 = new GuardaObjetos<Alumno>(3);

            // Instanciamos a la clase "Alumno"
            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            //// Agregar objetos a la clase "GuardarObjetos"
            //objetos1.AgregarElementos(alumno1);
            //objetos1.AgregarElementos(alumno2);
            //objetos1.AgregarElementos(alumno3);

            GuardaObjetos<string> objetos1 = new GuardaObjetos<string>(3);

            // Agregar objetos
            objetos1.AgregarElementos("Luis");
            objetos1.AgregarElementos("José");
            objetos1.AgregarElementos("Juan");

            // Obtener elemento
            valorElemento = objetos1.ObtenerElemento(2);
            Console.WriteLine(valorElemento);
        }
    }

    class GuardaObjetos<T>
    {
        // Campos
        private int i = 0;
        private T[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementosPa)
        {
            matrizElementos = new T[elementosPa];
        }

        // Métodos
        public void AgregarElementos(T elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }

    class Alumno
    {
        // Campos
        double calificacion;

        // Constructor
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }

        // Propiedades
        public double Calificacion
        {
            get => calificacion;
        }
    }
}
