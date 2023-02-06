using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_5

{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }

    internal class Fracciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera fracción en el formato 'numerador/denominador':");
            string[] fraction1Input = Console.ReadLine().Split('/');
            int numerator1 = int.Parse(fraction1Input[0]);
            int denominator1 = int.Parse(fraction1Input[1]);
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            Console.WriteLine("Ingrese la segunda fracción en el formato 'numerador/denominador':");
            string[] fraction2Input = Console.ReadLine().Split('/');
            int numerator2 = int.Parse(fraction2Input[0]);
            int denominator2 = int.Parse(fraction2Input[1]);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            Console.WriteLine("El resultado de la suma es: " + (fraction1 + fraction2));
            Console.WriteLine("El resultado de la resta es: " + (fraction1 - fraction2));
            Console.WriteLine("El resultado de la multiplicación es: " + (fraction1 * fraction2));
            Console.WriteLine("El resultado de la división es: " + (fraction1 / fraction2));
            Console.ReadLine();

        }
    }
}
