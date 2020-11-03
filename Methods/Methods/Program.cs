using System;
namespace Methods
{
    class Program
    {
        static void Mabtoor()
        {       
            float obt = 432;
            float total = 500;
            float per = obt / total * 100;
            Console.WriteLine($" Your Percentage is { per} . You are Pass");

        }

        static void Horair()
        {
            float obt = 480;
            float total = 500;
            float per = obt / total * 100;
            Console.WriteLine($" Your Percentage is { per} . You are Pass");
        }

        static void Waheed()
        {
            float obt = 420;
            float total = 500;
            float per = obt / total * 100;
            Console.WriteLine($" Your Percentage is { per} . You are Pass" );
        }

        static void Waqas()
        {
            float obt = 440;
            float total = 500;
            float per = obt / total * 100;
            Console.WriteLine($" Your Percentage is { per} . You are Pass");
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            if (name == "Mabtoor")
            {
                Mabtoor();
            }
            else if (name == "Waqas")
            {
                Waqas();
            }
            else if (name == "Waheed")
            {
                Waheed();
            }
            else if (name == "Horair")
            {
                Horair();
            }
            else
            {
                Console.WriteLine("Does not Exist");
            }
            Console.ReadLine();
        }
    }
}