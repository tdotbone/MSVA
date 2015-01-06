using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Example of original individual classes 'Car' and 'Truck' being reworked into a new abstract base class 'Vehicle'.


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

           // printCarDetails(myCar);
            printVehicleDetails(myCar);

            // instantiate a new instance of Truck (this was done after creating the Truck class in line 54
           
            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
      //printCarDetails(myTruck);     
            
            //anywhere 'Car' would work, 'Truck' would work as well since 'Truck' is a "type" of 'Car' but has an extra property
            //parent/child class or Superclass etc.

            // 'Truck' is no longer a type of 'Car' it is a type of new class 'Vehicle' so the above line creates an error
            // has changed from parent/child to sibling of 'Car'
            // has changed from 'Car' to 'Vehicle' also

            printVehicleDetails(myTruck);

            Console.ReadLine();

        }

        //helper method that belongs to the Program class
       
        //private static void printCarDetails(Car car)  // not true anymore since adding 'Vehicle' class, not car details but vehicle details now
        
        private static void printVehicleDetails(Vehicle vehicle)  

        {
            //Console.WriteLine("Here are the Car's details: {0}",
                // car.FormatMe());
            
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

       public abstract string FormatMe(); //can't create an instance of abstract FormatMe(), so you have to have an instance of FormatMe() whenever you derive from 'Vehicle'
    }

    //class Car
    class Car : Vehicle
    {
//        public string Make { get; set; }
//        public string Model { get; set; }
//        public int Year { get; set; }
//        public string Color { get; set; }
       
      //  public abstract string FormatMe()  //create an abstract class above to work with both cars and trucks at a higher level
        //now that we have the abstract class Vehicle, this needs to use 'overide'
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

  /*
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
       
    }  */

    // example of a Sealed class - can't create another instance of some other kind of truck that would inherit from 'Truck'
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
}
