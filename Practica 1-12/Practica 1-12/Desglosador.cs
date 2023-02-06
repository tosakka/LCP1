using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_12
{
    internal class Desglosador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de pesos a desglosar:");
            int pesos = int.Parse(Console.ReadLine());

            int[] Billetes = { 2000, 1000, 500, 200, 100 };
            int[] Monedas = { 50, 25, 10, 5, 1 };

            Console.WriteLine("Desglose de billetes:");
            for (int i = 0; i < Billetes.Length; i++)
            {
                int numberOfBilletes = pesos / Billetes[i];
                if (numberOfBilletes > 0)
                {
                    Console.WriteLine(numberOfBilletes + " billetes de " + Billetes[i]);
                    pesos = pesos - (numberOfBilletes * Billetes[i]);
                }
            }

            Console.WriteLine("Desglose de monedas:");
            for (int i = 0; i < Monedas.Length; i++)
            {
                int numberOfMonedas = pesos / Monedas[i];
                if (numberOfMonedas > 0)
                {
                    Console.WriteLine(numberOfMonedas + " monedas de " + Monedas[i]);
                    pesos = pesos - (numberOfMonedas * Monedas[i]);
                }
            }
            Console.ReadLine();

        }



    }
}
