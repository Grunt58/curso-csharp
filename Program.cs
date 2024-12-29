using System.Collections.Generic;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            Alumno valorElemento;

            // Instanciando la clase
            GuardaObjetos objetos1 = new GuardaObjetos(3);

            // Instanciamos a la clase "Alumno"
            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            // Agregar objetos a la clase "GuardarObjetos"
            objetos1.AgregarElementos(alumno1);
            objetos1.AgregarElementos(alumno2);
            objetos1.AgregarElementos(alumno3);

            //// Agregar objetos
            //objetos1.AgregarElementos("Luis");
            //objetos1.AgregarElementos("José");
            //objetos1.AgregarElementos("Juan");

            // Obtener elemento
            valorElemento = (Alumno)objetos1.ObtenerElemento(2);
            Console.WriteLine(valorElemento.Calificacion);
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
