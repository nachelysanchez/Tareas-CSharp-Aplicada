using System;

namespace MenuNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("En este menu, se encuentran los ejercicios solicitados de la Unidad 1\n");
            do
            {
                Console.Clear();
                Console.WriteLine("Menú\t\t\n\n1-Nombre\t\t\n2-Más informaciones\t\t\n3-Salir\t\t\nIngrese un numero correspondiente a un ejercicio");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        imprimirNombre();
                        break;
                    case 2:
                        //imprimirNombre();
                        imprimirInformacion();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("El numero de ejercicio ingresado, no fue asignado...");
                        Console.ReadKey();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcion != 3);
        }

        public static void imprimirNombre()
        {
            Console.WriteLine("Nombre: Nachely");
        }
        public static void imprimirInformacion()
        {
            imprimirNombre();
            Console.WriteLine("Edad: 18 años");
            Console.WriteLine("Ocupación: Estudiante");
            Console.WriteLine("Nacionalidad: Dominicana");
        }
    }
}
