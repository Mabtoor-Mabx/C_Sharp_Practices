using System;
namespace BookSelections
{
    class Program
    {
        static void Matriccomp()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Computer Science", "8.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for ( int i = 0; i < sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void Matricbio()
        {

            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Biology", "8.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }


        static void FSCPreMedical()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Biology",  "7.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void FScPreEngineering()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void ICSStat ()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Statistics", "5.Pak Studies", "6.Mathematics", "7.Computer" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }

        static void ICSphy()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Computer" };
             Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void Icom()
        {
            string[] sub = { "1.English ", "2.Urdu", "3.Islamiat", "4.Principle of Accounting", "5.Pak Studies", "6.Principle of Commerce & Banking.", "7.Principle of Eco. & Commercial Geo" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }

        static void FA()
        {
            string[] sub = { "1.Civics ", "2Ecnomics", "3.FineArts", "4.Phy. Education.", "5.English Literature", "6.Home Economics.", "7.Islamiyat Elective." };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i<sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }

        static void Matricelec()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Electrical ", "8.Chemistry" };
           Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void Matricwood()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Wood Studies", "8.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }
        static void Matricmettalic()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Mettalic Arts", "8.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }

        static void Matricarabic()
        {
            string[] sub = { "1.English", "2.Urdu", "3.Islamiat", "4.Physics", "5.Pak Studies", "6.Mathematics", "7.Arabic Study", "8.Chemistry" };
            Console.WriteLine("Your Subjects Are");
            for (int i = 0; i <sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }
        }


        static void Main(String[] args)
        {
            // Books List Of Matric & Inter Level Education

            Console.WriteLine("Books List Of Matric & Inter Level Education.");
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Education");
            string edu = Console.ReadLine();

            if(edu == "Matric")
            {
                Console.WriteLine("Enter Your Main Subject");
                string sub = Console.ReadLine();
                if(sub == "Computer")
                {
                    Matriccomp();
                }
                else if(sub == "Biology")
                {
                    Matricbio();
                }
                else if(sub == "Electic")
                {
                    Matricelec();
                }
                else if(sub == "Wood")
                {
                    Matricwood();
                }
                else if (sub == "Mettalic")
                {
                    Matricmettalic();
                }
                else if (sub == "Arabic")
                {
                    Matricarabic();
                }
                else
                {
                    Console.WriteLine("Wrong Subject Selection");
                }

            }
            else if (edu == "Inter")
            {
                Console.WriteLine("Enter Your Main Degree");
                string pro = Console.ReadLine();
                if(pro ==" Fsc Pre-Engineering")
                {
                    FScPreEngineering();
                }
                else if(pro == "FSc Pre-Medical")
                {
                    FSCPreMedical();
                }
                else if(pro == "ICS")
                {
                    Console.WriteLine("Enter Main Subject");
                    string subb = Console.ReadLine();
                    if(subb == "Physics")
                    {
                        ICSphy();
                    }
                   else  if (subb == "Statistics")
                    {
                        ICSStat();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Subject Selection");
                    }
                }
                else if(pro == "I.com")
                {
                    Icom();
                }
                else if(pro == "FA")
                {
                    FA();
                }
                else
                {
                    Console.WriteLine("Wrong Degree Selection");
                }
            }
            else
            {
                Console.WriteLine("There Must Be An Error");
            }
            Console.ReadLine();
        }
    }
}
// @2020 All CopyRights Reserved By Mabtoor Mabx