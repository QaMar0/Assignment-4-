using System;

namespace TalhasApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstName, myLastName;
            Console.WriteLine("What is your name ?");
            Console.Write("Enter your first name = ");
            myFirstName = Console.ReadLine();

            Console.Write("Enter your last name = ");
            myLastName = Console.ReadLine();
            Console.WriteLine("Your name is = " + myFirstName + " " + myLastName);
            Console.WriteLine("Thank you!" + " " + myFirstName + " " + myLastName);

        }
    }
}
