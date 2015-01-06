using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printCarDetails(myCar);

            // instantiate a new instance of Truck (this was done after creating the Truck class in line 54
            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            printCarDetails(myTruck);     //anywhere 'Car' would work, 'Truck' would work as well since 'Truck' is a "type" of 'Car' but has an extra property
            //parent/child class or Superclass etc.

            Console.ReadLine();

        }

        //helper method that belongs to the Program class
        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the Car's details: {0}",
                car.FormatMe());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
       
        public virtual string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
       
     }

    // create a new class 'Truck'
    class Truck : Car  // the ':' means inherite everything from the 'Car' class and add the following property
    {
        public int TowingCapacity { get; set; }
        
        //creating an override method so FormatMe() works with trucks, added 'virtual' to the original FormatMe() method above 
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
       
    }
}
