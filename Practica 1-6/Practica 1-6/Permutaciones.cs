using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_6
{
    internal class Permutaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de elementos a permutar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de elementos a elegir: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Permutación con repetición (y/n)? ");
            string repetitionInput = Console.ReadLine();

            if (repetitionInput.ToLower() == "y")
            {
                Console.WriteLine("El número de permutaciones con repetición es: " + ConRepeticion(n, r));
            }
            else
            {
                Console.WriteLine("El número de permutaciones sin repetición es: " + SinRepeticion(n, r));
            }

            Console.ReadLine();
        }

        static int ConRepeticion(int n, int r)
        {
            return (int)Math.Pow(n, r);
        }

        static int SinRepeticion(int n, int r)
        {
            int result = 1;
            for (int i = n; i > n - r; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
