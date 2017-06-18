using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare Variables.
            int x;
            int y;

            // Initialize Variables.
            x = 7;
            y = x + 3;

            // Print it out to console and use a readline to stop console from crashing.
            Console.WriteLine(y);
            Console.ReadLine();

            /*
             * Declares block comments
             * 
             */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();
            // Gets input from console and assigns it to String Variable myFirstName

            Console.Write("Type your last name: ");
            string myLastname = Console.ReadLine();
            // Gets input from console and assigns it to String Variable myLastName

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
        }
    }
}
