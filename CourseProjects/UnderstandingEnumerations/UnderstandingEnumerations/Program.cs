using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            //enumerations available inside the .net framework

            Console.ForegroundColor = ConsoleColor.DarkYellow;   
            // ForegroundColor is of type 'enum ConsoleColor' defined somewhere in the .net framework library

            Console.WriteLine("Type in a super hero's name to see his nickname: ");
            string userValue = Console.ReadLine();


            Superhero myValue;

            // have to perform a data conversion?  converting a string value from the use into a 'Superhero enum'
            // 3 parameters to the 'TryParse' ( 1-the string to evaluate, 2-then whether to ignore upper/lower case of string, 3-output parameter)
            // output parameter is sent from the method to the caller 

            // TryParse will return either true or false
            // if true, the parsed enum will be sent out via the output parameter 'myValue'
            // use the output parameter so that both can communicate the success or failure of an operation 
            // as well as the result of a successful operation
            // now that we know that 'TryParse' succeded we can expect the switch (myValue) parameter to contain a VALID enum
            // that we can then use in the switch statement
      
            if (Enum.TryParse<Superhero>(userValue, true, out myValue))   //<  > means generic method
            {
                // type "switch" then 'tab' 'tab'
                // it will display the following:

                //switch (switch_on)
                // {
                //    default:
                //}
                //replace 'switch_on' with 'myValue' and hit 'enter' 'enter' and it will display all the switch code for 
                //each value of the 'enum Superhero' defined below

                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case Superhero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");           
            }
            
            Console.ReadLine();
        }
    }

    enum Superhero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
