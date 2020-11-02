using System;
namespace Test_Application
{
    class Program
    {
        static void Main(String[] args)
        {
            // Result Of Mines Community Using Conditon 
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your AG No");
            string AG = Console.ReadLine();
            Console.WriteLine("Enter Your Obtained Marks Out Of 500");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (name == "Mabtoor" && AG == "2018-ag-8208")
            {
                Console.WriteLine($"Dear {name} Ag No {AG} !!! Your Marks is {marks}");
                Console.WriteLine(" Congrats! You Get A Grade");
            }

            else if (name == "Horair" && AG == "2018-ag-8207")
            {
                Console.WriteLine($"Dear {name} Ag No {AG} !!! Your Marks is {marks}");
                Console.WriteLine(" Congrats! You Get A+ Grade");
            }
            else if (name == "Waqas" && AG == "2018-ag-8224")
            {
                Console.WriteLine($"Dear {name} Ag No {AG} !!! Your Marks is {marks}");
                Console.WriteLine(" Congrats! You Get B+ Grade");
            }
            else if (name == "Waheed" && AG == "2018-ag-8232")
            {
                Console.WriteLine($"Dear {name} Ag No {AG} !!! Your Marks is {marks}");
                Console.WriteLine(" Congrats! You Get A++ Grade");
            }
            else
            {
                Console.WriteLine("AG No Does Not Exist");
            }
            Console.ReadLine();
        }
    }
}
