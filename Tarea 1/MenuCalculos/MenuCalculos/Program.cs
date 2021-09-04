using System;

namespace MenuCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("El menu de este programa contiene los ejercicios asignados del capitulo 2");
            do
            {
                Console.Clear();
                Console.WriteLine("Menu\n\n1- Perimetro de cualquier poligono regular\n\n2- Grados a Radianes\n\n3- Centigrados a Fahrenheit\n\n4- Dolares y Euros\n\n5- Salir\n\n\nDigite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        perimetroPoligono();
                        break;
                    case 2:
                        radianYgrado();
                        break;
                    case 3:
                        conversionTemperatura();
                        break;
                    case 4:
                        dolarYeuro();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("La opcion digitada no existe en el menu");
                        Console.ReadKey();
                        break;
                }
            } while (opcion !=5 );
        }

        public static void perimetroPoligono()
        {
            Console.Clear();
            int numeroLados = 0;
            float longitudLado = 0.0f, perimetro = 0.0f;
            Console.WriteLine("Digite el numero de lados del poligono regular: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());
            longitudLado = float.Parse(Console.ReadLine());
            perimetro = numeroLados * longitudLado;
            Console.WriteLine($"El perimetro del poligono regular de {numeroLados} lados es {perimetro}");
            Console.ReadKey();
            Console.Clear();
        }

        public static void radianYgrado()
        {
            Console.Clear();
            double grados = 0, conversion = 0;
            double PI = 3.1416;
            Console.WriteLine("Digita la cantidad en grado a convertir a radian");
            grados = double.Parse(Console.ReadLine());
            conversion = (grados * PI) / 180;
            Console.WriteLine($"La conversion de {grados} grados a radian es {conversion} radian");
            Console.ReadKey();
            Console.Clear();
        }

        public static void conversionTemperatura()
        {
            Console.Clear();
            float temperaturaCelsius = 0.0f, temperaturaFahreheit = 0.0f;
            Console.WriteLine("Digite la temperatura a convertir en Celsius: ");
            temperaturaCelsius = float.Parse(Console.ReadLine());

            temperaturaFahreheit = (temperaturaCelsius * (9 / 5)) + 32;
            Console.WriteLine($"La conversion de {temperaturaCelsius} Celsius a Fahrenheit es {temperaturaFahreheit} Fahrenheit");
            Console.ReadKey();
            Console.Clear();
        }

        public static void dolarYeuro()
        {
            Console.Clear();
            int opcion = 0;
            float cambio = 0.0f;
            float cantidad = 0.0f, conversion = 0.0f;
            do
            {
                Console.WriteLine("Menu\n\n1-Dolar a Euro\n\n2-Euro a Dolar\n\n3-Volver\nDigite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el tipo de cambio del dia para convertir a Dolares:");
                        cambio = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad de Euros a convertir: ");
                        cantidad = float.Parse(Console.ReadLine());

                        conversion = cantidad * cambio;

                        Console.WriteLine($"La conversion de {cantidad} euros con el tipo de cambio a {cambio} dolares es {conversion} dolares");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite el tipo de cambio del dia para convertir a Euros:");
                        cambio = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad de Dolares a convertir: ");
                        cantidad = float.Parse(Console.ReadLine());

                        conversion = cantidad * cambio;

                        Console.WriteLine($"La conversion de {cantidad} dolares con el tipo de cambio a {cambio} euros es {conversion} euros");
                        break;
                    case 3:
                        break;
                }
            } while (opcion != 3);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
