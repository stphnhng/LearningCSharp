using System;

namespace DatesAndTimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            // printing current time + date.
            Console.WriteLine(myValue.ToString()); // date & time to string
            Console.WriteLine(myValue.ToShortDateString()); // only short date to string
            Console.WriteLine(myValue.ToShortTimeString()); // only short time to string
            Console.WriteLine(myValue.ToLongDateString()); // long date as string
            Console.WriteLine(myValue.ToLongTimeString()); // long time as string

            // empty break line.
            Console.WriteLine();
            // altering time + date.
            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // 3 days from now
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // 3 hours from now
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); // 3 days previously

            Console.WriteLine(myValue.Month);


            // empty break line.
            Console.WriteLine();


            // making my own date time.

            DateTime myBirthday = new DateTime(1997, 11, 24);
            Console.WriteLine(myBirthday.ToShortDateString());

            myBirthday = DateTime.Parse("11/24/1997"); // parses a string to create a date time object
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            // TimeSpan is an object for a span of time.
            // Subtract subtracts two date time objects from each other.

            Console.WriteLine(myAge.TotalDays); // gets the total days in a datetime object (not always an integer)

        }
    }
}
