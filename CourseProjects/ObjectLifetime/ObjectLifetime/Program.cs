using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            // set properties

            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");


            myOtherCar = null;
            myCar = null;


           // Car.MyMethod // the 'MyMethod' now shows up in the .menue
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            // You could get this from a configuration file, a database etc.
            // I'll just hardcode in this instance
            this.Make = "Nissan";
        }

        //overloaded version of the constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    
        /*
        // the following will cause an error because the the Object.Lifetime.Car already defines a member called 'Car' with the same parameter types
        // one of the parameters changed but the data type 'Car' remains the same
        public Car(string someOtherInputParameter, string model, int year, string color)
        {
            Make = someOtherInputParameter;
            Model = model;
            Year = year;
        }  
        */

        // use of static to make 'MyMehod' available when creating a new instance of the car class
        //  used in line 24 above
        public static void MyMethod()
        {

        }
   }

}
