using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Again:
            Console.WriteLine("Enter Employee Details:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Employee Gender (M/F): ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Date of Joining (DOJ): ");
            string doj = Console.ReadLine();

            Console.WriteLine("\nID \t Employee Name \t Employee Gender \t Employee Salary \t DOJ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t\t{salary:C}\t\t{doj}");

            double taxRate;

            if (salary > 90000)
            {
                taxRate = 0.30;
            }
            else
            {
                taxRate = 0.15;
            }

            double tax = salary * taxRate;

            goto Again;
            Console.ReadKey();
        }
    }
}
