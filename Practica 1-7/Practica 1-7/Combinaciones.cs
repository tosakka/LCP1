using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_7
{
    internal class Combinaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de elementos a combinar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de elementos a elegir: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Combinación con repetición (y/n)? ");
            string repetitionInput = Console.ReadLine();

            if (repetitionInput.ToLower() == "y")
            {
                Console.WriteLine("El número de combinaciones con repetición es: " + ConRepeticion(n, r));
            }
            else
            {
                Console.WriteLine("El número de combinaciones sin repetición es: " + SinRepeticion(n, r));
            }

            Console.ReadLine();
        }

        static int ConRepeticion(int n, int r)
        {
            return (int)(Factorial(n + r - 1) / (Factorial(r) * Factorial(n - 1)));
        }

        static int SinRepeticion(int n, int r)
        {
            return (int)(Factorial(n) / (Factorial(r) * Factorial(n - r)));
        }

        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
