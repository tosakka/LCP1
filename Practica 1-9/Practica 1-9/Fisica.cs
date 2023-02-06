using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_9
{
    internal class Fisica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca dos de los siguientes valores: velocidad, tiempo y distancia.");
            Console.WriteLine("Por favor, introduzca el nombre del primer valor y su valor.");
            Console.Write("Nombre: ");
            string input1Name = Console.ReadLine();
            Console.Write("Valor: ");
            double input1Value = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, introduzca el nombre del segundo valor y su valor.");
            Console.Write("Nombre: ");
            string input2Name = Console.ReadLine();
            Console.Write("Valor: ");
            double input2Value = double.Parse(Console.ReadLine());

            if (input1Name.ToLower() == "velocidad" && input2Name.ToLower() == "tiempo")
            {
                double distance = input1Value * input2Value;
                Console.WriteLine("Distancia: " + distance);
            }
            else if (input1Name.ToLower() == "tiempo" && input2Name.ToLower() == "velocidad")
            {
                double distance = input2Value * input1Value;
                Console.WriteLine("Distancia: " + distance);
            }
            else if (input1Name.ToLower() == "velocidad" && input2Name.ToLower() == "distancia")
            {
                double time = input2Value / input1Value;
                Console.WriteLine("Tiempo: " + time);
            }
            else if (input1Name.ToLower() == "distancia" && input2Name.ToLower() == "velocidad")
            {
                double time = input1Value / input2Value;
                Console.WriteLine("Tiempo: " + time);
            }
            else if (input1Name.ToLower() == "tiempo" && input2Name.ToLower() == "distancia")
            {
                double velocity = input2Value / input1Value;
                Console.WriteLine("Velocidad: " + velocity);
            }
            else if (input1Name.ToLower() == "distancia" && input2Name.ToLower() == "tiempo")
            {
                double velocity = input1Value / input2Value;
                Console.WriteLine("Velocidad: " + velocity);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor introduzca dos de los siguientes valores: velocidad, tiempo y distancia.");
            }
            Console.ReadLine();

        }
    }
}
