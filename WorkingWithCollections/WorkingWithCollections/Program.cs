using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // linq : language integrated query

            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            // ArrayLists are dynamically sized, 
            // cool features sorting, remove items, etc.

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);

            // no easy way to limit the type of data that would be stored in the array

            myArrayList.Add(b1);
            // ^ this will work just fine - any type can be added.
            // but if you want to print out all the models?

            myArrayList.Remove(b1); // removes item from arraylist.
             fixes the following invalid cast exception

            foreach(Car car in myArrayList){
                Console.WriteLine(car.Make);
            }
            // causes an invalid cast exception (cannot convert book into a car)
            */

            // Collection!!

            // List<T> (generic type) - allows to work with a specific type
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(b1); - will not work since it is strongly typed.

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            // Dictionary!
            // two components (key and then the value)
            // Dictionary<TKey, TValue>
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car> ();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            Car test1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            // can create a new variable and instantiate the variables inside like the array.

            Car test2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };
            // object initalizer syntax ^^
            // no need for a constructor.

            // Collection Initializer 
            List<Car> myListTest = new List<Car>(){
                new Car{Make="Oldsmovile",Model="Cutlas Supreme", VIN="E5"},
                new Car{Make="Nissan", Model="Altima",VIN="F6"}
            };

        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
