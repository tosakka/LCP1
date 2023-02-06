using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_13
{
    internal class AFP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el número de horas trabajadas:");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el salario por hora:");
            double hourlyWage = double.Parse(Console.ReadLine());

            double grossSalary = hourlyWage * horas;

            double afp = grossSalary * 0.0725;
            double seguro = grossSalary * 0.03;

            if (horas > 44)
            {
                double extraHours = horas - 44;
                double horasExtra = hourlyWage * 1.3;
                grossSalary += horasExtra * extraHours;
            }

            double netSalary = grossSalary - afp - seguro;

            Console.WriteLine("Salario bruto: " + grossSalary);
            Console.WriteLine("AFP: " + afp);
            Console.WriteLine("Seguro de salud: " + seguro);
            Console.WriteLine("Salario neto: " + netSalary);
            Console.ReadLine();
        }
    }
}
