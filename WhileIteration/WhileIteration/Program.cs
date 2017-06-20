using System;

namespace WhileIteration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                // Simple while loop.
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu(){
            // clears the entire console.
            Console.Clear();

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1"){
                PrintNumbers();
                return true;
            }else if(result == "2"){
                GuessingGame();
                return true;
            }else if(result == "3"){
                return false;
            }else{
                return false;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result+1){
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            // Uses C#'s random class
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            // min value of 1 and out of bounds at 11.

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString()){
                    incorrect = false;
                }else{
                    Console.WriteLine("Wrong!");
                }
            } while(incorrect);

            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
