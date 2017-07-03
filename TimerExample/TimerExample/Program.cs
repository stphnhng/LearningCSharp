using System;
using System.Timers;
namespace TimerExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            // 2 seconds (milliseconds)

            myTimer.Elapsed += MyTimer_Elapsed;
            // runs MyTimer_Elapsed everytime the timer's 2000 seconds are covered.
            // (red text)

            myTimer.Elapsed += MyTimer_Elapsed1;
            // adds another event. (white text)

            myTimer.Start();
            // starts timer

            Console.WriteLine("Press enter to remove the red event");
            Console.ReadLine();
            // detach the second event handler.
            myTimer.Elapsed -= MyTimer_Elapsed;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
