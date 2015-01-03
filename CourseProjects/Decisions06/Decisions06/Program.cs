using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the following is from lesson 7 even though I typed lesson 6 in the previous commits

namespace Decisions06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();

          // making decisions using if, else if
          // repeating code - next session refactors this code 
          // for reusability
          /* 
            Console.WriteLine("Would you prefer what is behind door number 1 or door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a new car!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a new boat!");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a new cat!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry we didn't understand You lose!");
                Console.ReadLine();
            }  */

            // code from above refactored by adding variable "message"
            /*
            Console.WriteLine("Would you prefer what is behind door number 1 or door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                message = ("Sorry we didn't understand. You lose!");
            } 
  

            Console.WriteLine(message);
            Console.ReadLine();
        */

            // all the above using a much more condensed version
            // using string replacement syntax and an optional version of Console.WriteLine
           
            Console.WriteLine("Would you prefer what is behind door number 1 or door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();
        }
    }
}
