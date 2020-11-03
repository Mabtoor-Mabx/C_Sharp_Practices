using System;
namespace Calculator_in_Methods
{
    class Program
    {
        static void Add(int a, int b)
        {
           int  c = a + b;
            Console.WriteLine($"The Sum Of Two Values is {c }");
            
        }
        static void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"The Difference Of Two Values is {c }");

        }
        static void Mult(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"The Multiplication Of Two Values is {c }");

        }

        static void Div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine($"The Division Of Two Values is {c }");

        }
        static void Main()
        {
            Console.WriteLine("Enter First Value");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator Symbol");
            string f =Console.ReadLine();

            if(f == "+")
            {
                Add(d, e);

            }
            else  if (f == "-")
            {
                Sub(d, e);

            }
            else if (f == "*")
            {
                Mult(d, e);

            }
            else if (f == "/")
            {
                Div(d, e);

            }
            else
            {
                Console.WriteLine("Runtime Error");
            }
            Console.ReadLine();
        }
    }
}