using System;

namespace UnderstandingArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            // Integer array of size 5.
            int[] numbers = new int[5];

            // Initializes all the indices in the array.
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            // Prints out the second element in the array.
            Console.WriteLine(numbers[1]);

            // Prints out the length of the array.
            Console.WriteLine(numbers.Length);
            */

            // Declare and initialize an array.
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            /*
            for (int i = 0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }
            */

            foreach (string name in names)
            {
                // foreach loop loops through the elements in an array.
                Console.WriteLine(name);
            }

            string zig = "You can get what you want out of life" + 
                "if you hep enough other people get what you want";
            char[] charArray = zig.ToCharArray();
            // usage of string helper method to turn a string into a character array.
            Array.Reverse(charArray);
            // Uses array method to reverse char array.
            foreach (char zigChar in charArray)
            {
                // Prints out the characters in the string zig backwards.
                Console.Write(zigChar);
            }


        }
    }
}
