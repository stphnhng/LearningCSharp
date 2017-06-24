using System;

namespace ObjectLifetime
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Car.MyMethod();
            Car myCar = new Car(); // calls the constructor when instantiated

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar; // both point to myCar.
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                              myOtherCar.Make, 
                              myOtherCar.Model, 
                              myOtherCar.Year,
                              myOtherCar.Color);
            // proof that it points to myCar's info. 

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                              myCar.Make,
                              myCar.Model,
                              myCar.Year,
                              myCar.Color);
            // Model is now 98, since myOtherCar is a reference to myCar.

            myOtherCar = null; // sets both myOtherCar and myCar references to null

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            // Use of overloaded constructor.

        }
    }

    class Car{
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(){
            this.Make = "Nissan"; // 'this' clarifies that it is a part of the class.

        }

        // Overloaded constructor.
        public Car(string make, string model, int year, string color){
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        // static just means properties don't require a class to be instantiated to use it.
        // Math x = new Math() -> x.calcuate() vs. Math.calculate()
        public static void MyMethod(){
            Console.WriteLine("My method is run");
        }
    }
}
