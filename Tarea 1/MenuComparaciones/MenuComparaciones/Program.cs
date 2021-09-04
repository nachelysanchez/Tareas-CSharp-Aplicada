using System;

namespace MenuComparaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Menu\n\n1- Par o Impar \n\n 2- Dias de la semana\n\n3-Salir\n\nDigite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        parOimpar();
                        break;
                    case 2:
                        diasSemana();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("La opcion digitada no pertenece al menu. Enter para volver");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }

        public static void parOimpar()
        {
            Console.Clear();
            int numero = 0;
            Console.Write("Digite el numero que quiere comprobar: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void diasSemana()
        {
            Console.Clear();
            int numero = 0;
            Console.WriteLine("Digite un numero del 1 al 7: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("El numero digitado no pertenece a la cantidad de dias de la semana");
                    break;
            }
            Console.ReadKey();
        }
    }
}
