using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_10
{
    internal class Temperatura
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la temperatura a convertir, en numeros:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la unidad de medida de la temperatura (Celsius, Kelvin o Fahrenheit):");
            string temperatureUnit = Console.ReadLine();

            if (temperatureUnit.ToLower() == "celsius")
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                double kelvin = temperature + 273.15;
                Console.WriteLine(temperature + " grados Celsius = " + fahrenheit + " grados Fahrenheit");
                Console.WriteLine(temperature + " grados Celsius = " + kelvin + " grados Kelvin");
            }
            else if (temperatureUnit.ToLower() == "fahrenheit")
            {
                double celsius = (temperature - 32) * 5 / 9;
                double kelvin = (temperature + 459.67) * 5 / 9;
                Console.WriteLine(temperature + " grados Fahrenheit = " + celsius + " grados Celsius");
                Console.WriteLine(temperature + " grados Fahrenheit = " + kelvin + " grados Kelvin");
            }
            else if (temperatureUnit.ToLower() == "kelvin")
            {
                double celsius = temperature - 273.15;
                double fahrenheit = (temperature * 9 / 5) - 459.67;
                Console.WriteLine(temperature + " grados Kelvin = " + celsius + " grados Celsius");
                Console.WriteLine(temperature + " grados Kelvin = " + fahrenheit + " grados Fahrenheit");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor introduzca una unidad de medida válida (Celsius, Kelvin o Fahrenheit).");
            }
            Console.ReadLine();
        }
    }
}
