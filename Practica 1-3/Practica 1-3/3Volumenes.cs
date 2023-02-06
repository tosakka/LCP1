using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_3
{
    internal class Volumennes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la forma que desee calcular (cubo, Esfera, Cono, piramide):");
            string shape = Console.ReadLine();

            switch (shape)
            {
                case "cubo":
                    Console.WriteLine("Ingrese la longitud de los lados del cubo:");
                    double cubolado = double.Parse(Console.ReadLine());
                    Console.WriteLine("El volumen es " + CalculatecuboVolumen(cubolado));
                    break;
                case "Esfera":
                    Console.WriteLine("Ingrese el radio de la Esfera:");
                    double radioEsfera = double.Parse(Console.ReadLine());
                    Console.WriteLine("El volumen es " + CalculateEsferaVolumen(radioEsfera));
                    break;
                case "Cono":
                    Console.WriteLine("Ingrese el radio y altura del Cono, separada por espacios: ");
                    string[] ConoInput = Console.ReadLine().Split();
                    double radioCono = double.Parse(ConoInput[0]);
                    double Conoaltura = double.Parse(ConoInput[1]);
                    Console.WriteLine("El volumen es " + CalculateConoVolumen(radioCono, Conoaltura));
                    break;
                case "piramide":
                    Console.WriteLine("Ingrese la longitud, ancho, y altura de la piramide, separada por espacios: ");
                    string[] piramideInput = Console.ReadLine().Split();
                    double piramideBaselongitud = double.Parse(piramideInput[0]);
                    double piramideBaseancho = double.Parse(piramideInput[1]);
                    double piramidealtura = double.Parse(piramideInput[2]);
                    Console.WriteLine("El volumen es " + CalculatepiramideVolumen(piramideBaselongitud, piramideBaseancho, piramidealtura));
                    break;
                default:
                    Console.WriteLine("Invalido.");
                    break;
            }
        }

        static double CalculatecuboVolumen(double lado)
        {
            return lado * lado * lado;
        }

        static double CalculateEsferaVolumen(double radio)
        {
            return (4.0 / 3.0) * Math.PI * radio * radio * radio;
        }

        static double CalculateConoVolumen(double radio, double altura)
        {
            return (Math.PI * radio * radio * altura) / 3;
        }

        static double CalculatepiramideVolumen(double baselongitud, double baseancho, double altura)
        {
            return (baselongitud * baseancho * altura) / 3;
        }

    }

}
