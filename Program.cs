using System.Collections.Generic;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            string valorElemento;

            // Instanciando la clase
            GuardaObjetos objetos1 = new GuardaObjetos(3);

            // Agregar objetos
            objetos1.AgregarElementos("Luis");
            objetos1.AgregarElementos("José");
            objetos1.AgregarElementos("Juan");

            // Obtener elemento
            valorElemento = (string)objetos1.ObtenerElemento(2);
            Console.WriteLine(valorElemento);
        }
    }

    class GuardaObjetos
    {
        // Campos
        private int i = 0;
        private object[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementosPa)
        {
            matrizElementos = new object[elementosPa];
        }

        // Métodos
        public void AgregarElementos(object elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public object ObtenerElemento(int elementoPa)
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
