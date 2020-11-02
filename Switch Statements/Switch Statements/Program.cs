using System;
namespace Switch_Statements
{
    class Program
    {


        static void Main(String[] args)
        {
            Console.WriteLine("Choose No (1 For Age 0 to 17) (2 for Age 18-40) ( 3 For Age 40 To Onward)");
            int age = Convert.ToInt32(Console.ReadLine());
           
            switch (age)
            {
                case 1:
                    Console.WriteLine("You Are UnderAge For Driving License");
                    break;
                case 2:
                    Console.WriteLine("You Are Eligible For Driving License");
                    break;
                case 3:
                    Console.WriteLine("You Are Overage For Driving License");
                    break;
                default:
                    Console.WriteLine("Runtime Error");
                    
                    break;
                    
            }
            Console.ReadLine();
        }
       
    }
    
}