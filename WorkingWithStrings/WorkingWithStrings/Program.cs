using System;
using System.Text;

namespace WorkingWithStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Learning about escape sequences and new lines.

            string myString = "My \"so-called\" life";
            string myString2 = "What if I need a \nnew line";
            string myString3 = "Go to your c:\\ drive";

            Console.WriteLine("1: " + myString);
            Console.WriteLine("2: " + myString2);
            Console.WriteLine("3: " + myString3);

            // Learning to use String Format.

            string myString4 = String.Format("{0} = {1}", "First", "Second");
            string myString5 = String.Format("{0:C}", 123.45); // currency
            string myString6 = String.Format("{0:N}", 1234567890); // number format (comma + decimals)
            string myString7 = String.Format("{0:P}", .123); // percentage
            string myString8 = String.Format("Phone Number: {0:(###) ###-####}", 123456789099);
            // custom pound symbol to create custom format
            // format is right to left, so additional numbers will be put on the right.

            Console.WriteLine("4: " + myString4);
            Console.WriteLine("5: " + myString5);
            Console.WriteLine("6: " + myString6);
            Console.WriteLine("7: " + myString7);
            Console.WriteLine("8: " + myString8);

            // Learning to use string methods.

            string myString9 = " That summer we took threes across the board  ";
            myString9 = myString9.Substring(6); // use of substring
            string myString10 = myString9.ToUpper(); // everything becomes upper case
            string myString11 = myString9.Replace(" ", "--"); // replace all {0} with {1}
            string myString12 = myString9.Remove(6,14); // removes all characters from {0} to {1}
            string myString13 = String.Format("Length before: {0} -- Length after: {1}",
                                              myString9.Length,
                                              myString9.Trim().Length); 
            // trims all preceding and succeeding spaces.

            Console.WriteLine("9: " + myString9);
            Console.WriteLine("10: " + myString10);
            Console.WriteLine("11: " + myString11);
            Console.WriteLine("12: " + myString12);
            Console.WriteLine("13: " + myString13);

            string myString14 = " That summer we took threes across the board  ";

            for (int i = 0; i < 100; i++)
            {
                myString14 += "--" + i.ToString();
                // string is immutable, cannot add values to it.
                // thus, new string is made everytime you '+' a string.
            }
            Console.WriteLine("14: " + myString14);

            // StringBuilder is better way to add strings together.

            StringBuilder myString15 = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString15.Append("--");
                myString15.Append(i);
            }

            Console.WriteLine("15: " + myString15);

            Console.ReadLine();
        }
    }
}
