using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Example of original individual classes 'Car' and 'Truck' being reworked into a new abstract base class 'Vehicle'.
// Final verision - cleaned up and removing the Sealed class example

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

            printVehicleDetails(myCar);

            // instantiate a new instance of Truck 
           
            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            
            printVehicleDetails(myTruck);

            Console.ReadLine();

        }

        //helper method that belongs to the Program class
        private static void printVehicleDetails(Vehicle vehicle)  
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",    
            vehicle.FormatMe());
        }
    }

    //new abstract class
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

       public abstract string FormatMe();
    }

    
    class Car : Vehicle
    {
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
       
     }

    // create a new class 'Truck' from 'Car'
    // class Truck : Car  // the ':' means inherit everything from the 'Car' class and add the following property
    // modifying class Truck to derive from new abstract class Vehicle
  
    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        
        //creating an override method so FormatMe() works with trucks 
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
       
    }  

   /* example of a Sealed class - can't create another instance of some other kind of truck that would inherit from 'Truck'
    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        //creating an override method so FormatMe() works with trucks 
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }

    class Semi : Truck
    {
        // when trying to build it creates an error
        // ".... cannot derive from sealed type 'UnderstandingInheritance.Truck'
    }
    */ 
}
