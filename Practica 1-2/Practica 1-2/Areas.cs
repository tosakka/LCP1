using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_2
{
    internal class Areas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la forma que desee calcular (Cuadrado, Circulo, Triangulo, Pentagono, Hexagono):");
            string shape = Console.ReadLine();

            switch (shape)
            {
                case "Cuadrado":
                    Console.WriteLine("Ingrese la longitud del lado del Cuadrado:");
                    double CuadradoLado = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del Cuadrado es " + CalcCuadradoArea(CuadradoLado));
                    break;
                case "Circulo":
                    Console.WriteLine("Ingrese el radio del Circulo:");
                    double Circuloradio = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del Circulo es " + CalcCirculoArea(Circuloradio));
                    break;
                case "Triangulo":
                    Console.WriteLine("Ingrese la base y altura del Triangulo, separar por espacio:");
                    string[] TrianguloInput = Console.ReadLine().Split();
                    double TrianguloBase = double.Parse(TrianguloInput[0]);
                    double Trianguloaltura = double.Parse(TrianguloInput[1]);
                    Console.WriteLine("El area del Triangulo es " + CalcTrianguloArea(TrianguloBase, Trianguloaltura));
                    break;
                case "Pentagono":
                    Console.WriteLine("Ingrese la longitud del Lado of the Pentagono:");
                    double PentagonoLado = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del Pentagono es " + CalcPentagonoArea(PentagonoLado));
                    break;
                case "Hexagono":
                    Console.WriteLine("Ingrese la longitud del Lado of the Hexagono:");
                    double HexagonoLado = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del Hexagono es " + CalcHexagonoArea(HexagonoLado));
                    break;
                default:
                    Console.WriteLine("Invalido.");
                    break;
            }
        }

        static double CalcCuadradoArea(double Lado)
        {
            return Lado * Lado;
        }

        static double CalcCirculoArea(double radio)
        {
            return Math.PI * radio * radio;
        }

        static double CalcTrianguloArea(double baseLength, double altura)
        {
            return (baseLength * altura) / 2;
        }

        static double CalcPentagonoArea(double Lado)
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / 5));
            return (5 * Lado * apotema) / 2;
        }

        static double CalcHexagonoArea(double Lado)
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / 6));
            return (6 * Lado * apotema) / 2;
        }
    }
}
