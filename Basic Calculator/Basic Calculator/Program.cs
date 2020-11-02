using System;
namespace Basic_Calculator
{
    class Program
    {
        static void Main(String[] args)
            // Basic Calculator Designed By Mabtoor Mabx
        {
            Console.WriteLine("Enter First Value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("The Answer is :" + " " + (a + b));
                
            }
            else if (c == "-")
            {
                Console.WriteLine("The Answer is :" + " " + (a - b));
            }
            else if (c == "*")
            {
                Console.WriteLine("The Answer is :" + " " + (a * b));
                
            }
            else if (c == "/")
            {
                Console.WriteLine("The Answer is :" + " " + (a / b));
                Console.ReadLine();
            }
            else if (c == "%")
            {
                Console.WriteLine("The Answer is :" + " " + (a % b));
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}