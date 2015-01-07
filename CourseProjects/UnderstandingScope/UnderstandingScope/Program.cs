using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Lesson 19 Understanding Scope and Utilizing Accessibility Modifiers
// Commenting out the entire Scope portion examples 

namespace UnderstandingScope
{
    /*class Program
    {
        static void Main(string[] args)
        {
            // 1st example
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);  'i' is defined in the above code block, can not be used outside of it
            Console.ReadLine();
            
         // 2nd example
            string j = "";      //since 'j' is defined outside of the following code block it is available inside and outside of the code block

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
               Console.WriteLine(i);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.ReadLine();
        } 
        


        // 3rd example
        // the private keyword static makes this not available outside of this class
        // a static member is available across all instances of the class and 
        // all the methods, properties and fields it utilizes have to be static as well

        private static string k = "";  

        static void Main(string[] args)
        {
            
             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);  'i' is defined in the above code block, can not be used outside of it
            Console.ReadLine();
            

            string j = "";      //since 'j' is defined outside of the following code block it is available inside and outside of the code block

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                // 4th example adds the following from here:
                //if (i == 9)
                //{
                //    string l = i.ToString();
                //}
               // Console.WriteLine("l: " + l); // to here - since 'l' is not defined outside the code block like 'j' then this causes error
                       
            }
            Console.WriteLine("Outside of the for: " + j);
           // commenting out for example 5: Console.WriteLine("k: " + k);
            // example 5 - add call to helperMethod

            helperMethod();  // example 5
            Console.ReadLine();
        }

        // example 5 
        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod: " + k);
        }
    }
     */


    // ===========================================================================================================
    //  Utilizing Accessibility Modifiers
    // ===========================================================================================================

    // naming convention
    // Uppercase first letter denotes public method 'DoSomething()'
    // Lowercase first letter denotes private method 'helperMethod()'
    // same thing for variables

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
           // car.DoSomething  - the car.menu shows the public 'DoSomething()' method but not the private 'helperMethod()'
           // can't access private methods outside of their class
           // illustrates the notion of encapsulation, hiding the implementation, exposing the interface
            car.DoSomething();
            Console.ReadLine();
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());  //breaking his own rules of not including this in the class, should be in the presentation layer
            }

            private string helperMethod() 
            {
                return "Hello World!";
            }
        }
    }
}
