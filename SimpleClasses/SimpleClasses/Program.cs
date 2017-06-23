using System;

namespace SimpleClasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create new instance of class
            Car myCar = new Car();

            // set properties of class
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            // get properties of class
            Console.WriteLine("{0} {1} {2} {3}", 
                              myCar.Make, 
                              myCar.Model, 
                              myCar.Year,
                              myCar.Color);
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value); // {0:C} for first variable in currency form.

            // using car class instead of seperate method.
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
        }

        private static decimal DetermineMarketValue(Car car){
            decimal carValue = 100.0M;

            // no calculation here, but there can be.

            return carValue;
        }
    }

    class Car{
        // get; and set; make myCar.Make = "" set the value and myCar.Make get the value.
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue(){
            // can access properties inside class.
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }
    }



}
