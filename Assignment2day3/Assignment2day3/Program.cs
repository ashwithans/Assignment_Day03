using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = "24";
            int result;
            if (int.TryParse(Input, out result))
            {
                Console.WriteLine($"Successfully converted to integer:" +result);
            }
            else
            {
                Console.WriteLine("Conversion to integer failed.");
            }
            Console.ReadKey();

            //string input = "12.35";           
            //try
            //{
            //    double result = Convert.ToDouble(input);
            //    Console.WriteLine($"successfully converted to double:" + result);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("conversion to double failed due to format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("conversion to double failed due to overflow.");
            //}
            //Console.ReadKey();



            //string input = "123.456";
            //try
            //{
            //    decimal result = decimal.Parse(input);
            //    Console.WriteLine($"Successfully parsed to decimal:"+result);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Parsing to decimal failed due to format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Parsing to decimal failed due to overflow.");
            //}
            //Console.ReadKey();  

        }
    }
}
