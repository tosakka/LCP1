using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_8
{
    internal class SegundoGrado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes de la ecuación de segundo grado (ax^2 + bx + c = 0):");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las soluciones son x1 = " + x1 + " y x2 = " + x2);
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("La solución única es x = " + x);
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }

            Console.ReadKey();
        }
    }
}
