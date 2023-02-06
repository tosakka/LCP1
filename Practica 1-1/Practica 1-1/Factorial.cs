using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_1
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero al que desee hallar el factorial:");
            int num = int.Parse(Console.ReadLine());

            int result = calcuFactorial(num);

            Console.WriteLine("El factorial de " + num + " es  " + result);
        }

        static int calcuFactorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;


        }



    }

}
