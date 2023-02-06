using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_4
{
    internal class Trigonometria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ángulo en grados:");
            double angle = double.Parse(Console.ReadLine());
            double angleInRadians = angle * Math.PI / 180;

            Console.WriteLine("El seno del ángulo es: " + Math.Sin(angleInRadians));
            Console.WriteLine("El coseno del ángulo es: " + Math.Cos(angleInRadians));
            Console.WriteLine("La tangente del ángulo es: " + Math.Tan(angleInRadians));
            Console.WriteLine("La secante del ángulo es: " + (1 / Math.Cos(angleInRadians)));
            Console.WriteLine("La cosecante del ángulo es: " + (1 / Math.Sin(angleInRadians)));
            Console.WriteLine("La cotangente del ángulo es: " + (1 / Math.Tan(angleInRadians)));
            Console.ReadLine();

        }
    }
}
