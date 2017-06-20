using System;

namespace ForIteration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                // For loop from 0 to 9.
                //Console.WriteLine(i);
                if(i == 7){
                    // if i == 7 then print out it is found.
                    Console.WriteLine("Found seven!");
                    break;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                
            }
            // Visual studio has code snippet for for loop (press tab tab)


            Console.ReadLine();

            // Debugger = F9
            // Step onto (next step) = F10
            // Can use it for conditional breaks (breaks when something is true)

        }
    }
}
