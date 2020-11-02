using System;
    class FirstConsoleApp
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter Your Name");
        String Name = Console.ReadLine();
        Console.WriteLine("Enter Your AG No");
        Console.WriteLine("AG No Should Be 8190 - 8195");
         String Ag = Console.ReadLine();
        if (Name == "Adnan" && Ag == "2018-ag-8190")
        {
            Console.WriteLine("You Are Pass");
        }
        else if (Name == "Zubair" && Ag == "2018-ag-8191")
        {
            Console.WriteLine("You Are Pass");
        }

        else if (Name == "Akram" && Ag == "2018-ag-8192")
        {
            Console.WriteLine("You Are Fail");
        }

        else if (Name == "Atif" && Ag == "2018-ag-8193")
        {
            Console.WriteLine("You Are Pass");
        }
        else if (Name == "Faris" && Ag == "2018-ag-8194")
        {
            Console.WriteLine("You Are Fail");
        }

        else if (Name == "Adnan" && Ag == "2018-ag-8195")
        {
            Console.WriteLine("You Are Fail");
        }
        else
        {
            Console.WriteLine("Invalid No");
        }

        Console.ReadLine();
    }
}
