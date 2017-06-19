using System;

namespace Decisions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Regular If/Else statements
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message;

            if(userValue == "1")
                // First decision block
                message = "You won a new car!";
            else if(userValue == "2")
                // checks if the first decision block is false
                message = "You won a new boat!";
            else if(userValue == "3")
                message = "You won a new cat!";
            else
                // Checks if all decisions blocks are false
                message = "Sorry, we didn't understand that";
            Console.WriteLine(message);
            Console.ReadLine();
            */

            // Shortened If/Else statements
            // Doesn't work for multiple conditions.
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of hair";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            // ^^ can be written as such....

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            // Similar to String.format.

            Console.ReadLine();


        }
    }
}
