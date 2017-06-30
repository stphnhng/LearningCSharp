using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query syntax

            /*
            var bmws = from Car in myCars
                       where Car.Make == "BMW"
                        && Car.Year == 2010
                       select Car;
            */

            /*
            // ordered cars
            var orderedCars = from Car in myCars
                              orderby Car.Year descending
                              select Car;
            */

            // LINQ method syntax

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            // lambda expression = mini methods
            // p is like the input parameter (inputs Cars and checks when p.make == bmw
            // and p.year == 2010

            // var lets the compiler figure out what the data type of bmws is.
            // you only know that myCars.Where returns a collection of cars but not what
            // the exact data type of bmws is.


            // orders all cars by their descending order
            var orderedCars = myCars.OrderByDescending(p => p.Year);

            var firstBMWCar = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            // gets the first bmw car when ordering by year descending.

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));
            // checks if it is true that all cars in myCars has a year > 2007.

            // Output

            // bmws
            /*
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}",car.Model,car.VIN);
            }
            */

            /*
            // ordered cars
            foreach(var car in orderedCars){
                Console.WriteLine("{0} {1}", car.Year, car.Model);
            }
            */

            // first bmw car
            Console.WriteLine(firstBMWCar.VIN);


            // sums up all the sticker prices.
            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));

            // easy for-each action in LINQ
            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            // checks if the condition exists for at least one item in the collection.

            Console.WriteLine(myCars.GetType());
            // getType is in all classes (system.object) that returns the type of an object.
            // List of the Car data type.

            Console.WriteLine(orderedCars.GetType());
            // returns OrderedEnumerable of Car data type and integers.

            Console.WriteLine(bmws.GetType());
            // returns Enumerable+WhereListIterator of the Car data type.

            // ^^ this is why you use var so you don't have to know what data type
            // every method returns.

            var testingVar = from Car in myCars
                       where Car.Make == "BMW"
                        && Car.Year == 2010
                       select new { Car.Make, Car.Model };
            // select new gets the values in Make and Model (anonymous data type)

            Console.WriteLine(testingVar.GetType());
            // Enumerable+WhereSelectListIterator of data type Car and AnonymousType
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
