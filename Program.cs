using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************\nCALCULADORA SIMPLE\n*******************");
            Console.WriteLine("Menú:");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Salir");
            Console.WriteLine();

            bool fin = false;
            int opcion = 0;

            while(!fin)
            {
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        int sumando1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int sumando2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es = {(sumando1 + sumando2)}");
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        int minuendo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int sustraendo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es = {(minuendo - sustraendo)}");
                        break;
                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        int multiplicando = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int multiplicador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es = {(multiplicando * multiplicador)}");
                        break;
                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        int dividendo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int divisor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es = {(dividendo / divisor)}");
                        break;
                    case 5:
                        fin = true;
                        break;
                }
            }

            Console.WriteLine("Fin del programa...");


            Console.ReadKey();
        }
    }
}
