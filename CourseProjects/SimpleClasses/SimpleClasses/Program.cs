using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();  // Car is the new instance of the class defined below
           
            myNewCar.Make =  "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
           // myNewCar.Year = 1991;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();

        }

        // helper method
        private static double determineMarketValue(Car _car) // data type 'Car' and input parameter name '_car'
        {
            double carValue = 100.0;

            // Some day I am going to write code to go online and look up the car's value
            // and return it's value into the carValue variable
            return carValue;

        }
    }

    // a class is not an object and an object is not a class
    // a  class is a blueprint to instantiate a new object of that class
    // the word 'new' creates the new instance of the class
    

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.Year > 1990) // the keyword 'this' allows you to access all the private and public classes
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }

    }

}
