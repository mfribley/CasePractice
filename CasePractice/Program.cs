/*
   Author: Mikessa Fribley
   Date: 1/31/2019
   Comments: This C# Console application code demonstrates the 
   use of 
*/



using System;

namespace CasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");

            try
            {
                string UserInput = Console.ReadLine();

                string UserName = UserInput;

                Console.WriteLine("");
                Console.WriteLine("Hello " + UserName + "!");
                Console.ReadKey(true);

            } // End of try.

            catch
            {
                Console.WriteLine("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of catch.
        } // End of main.
    } // End of class.
} // End of namespace.
