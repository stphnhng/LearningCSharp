using System;

namespace Decisions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            if(userValue == "1"){
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
