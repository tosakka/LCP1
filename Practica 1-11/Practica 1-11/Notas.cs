using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_11
{
    internal class Notas
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;




            Console.WriteLine("Ingrese su nota de Primer Parcial");
            nota1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su nota Segundo Parcial");
            nota2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su nota Práctica");
            nota3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su nota de Exámen final");
            nota4 = Convert.ToInt16(Console.ReadLine());

            int PP = (nota1 + nota2) / 2;
            int PF = (PP + nota3 + nota4) / 3;

            Console.WriteLine("Su nota Final es " + PF);

            if (nota4 < 55)
            {
                Console.WriteLine("Su nota literal es F debido a haber fallado el examen final");
            }
            else if (PF >= 0 && PF <= 50)
            {
                Console.WriteLine("Su nota literal es F");
            }
            else if (PF >= 51 && PF <= 59)
            {
                Console.WriteLine("Su nota literal es E");
            }
            else if (PF >= 60 && PF <= 69)
            {
                Console.WriteLine("Su nota literal es D");
            }
            else if (PF >= 70 && PF <= 79)
            {
                Console.WriteLine("Su nota literal es C");
            }
            else if (PF >= 80 && PF <= 89)
            {
                Console.WriteLine("Su nota literal es B");
            }
            else if (PF >= 90 && PF <= 100)
            {
                Console.WriteLine("Su nota literal es A");
            }


            Console.ReadLine();

        }
    }
}
