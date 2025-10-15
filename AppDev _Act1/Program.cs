using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.Write("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            string operation;

            Console.Write("Enter operation (+, -, *, /): ");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine($"Result: {x + y}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"Result: {x - y}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"Result: {x * y}");
            }
            else if (operation == "/")
            {
                if (y != 0)
                {
                    Console.WriteLine($"Result: {x / y}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid operation.");
            }   
        }
    }
}