using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolución de ecuaciones de primer grado de la forma ax + b = 0");
            Console.WriteLine("Ingrese el valor de a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b:");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("La ecuación no es de primer grado.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("La solución de la ecuación es x = " + x);
                Console.ReadLine();
            }
        }
    }
}
