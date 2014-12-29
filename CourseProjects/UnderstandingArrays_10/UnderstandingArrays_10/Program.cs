using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXAMPLE 1 
             int[] numbers = new int[5];  //describring an array of integers to declare an array of type int called numbers
                                         // and contains 5 values or elements - must remember that the array always starts at 0.  So the 5th element is [4]

           //setting the elements of the array to an integer value the long way
             numbers[0] = 4;
             numbers[1] = 8;
             numbers[2] = 15;
             numbers[3] = 16;
             numbers[4] = 23;
             numbers[5] = 42;   
            
             Console.WriteLine(numbers.Length);
            */

            /* EXAMPLE 2
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };  // defined without specifying how many elements like the example above using [5]
            
            Console.WriteLine(numbers[1].ToString()); // the ToString is not necessary 
            Console.ReadLine();
            */


           /* EXAMPLE 3  
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            
            foreach (string name in names) // goes thru this code block once for each element in the array
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */


           //EXAMPLE 4
            string zig = "You can get what you want out of life " + 
                "if you help enough other people get what they want.";

            char[] chararray = zig.ToCharArray(); //copies each letter of the string into an element of the new chararray
            Array.Reverse(chararray); // takes each element of the array and reverses its ordinal position

            foreach (char zigchar in chararray)
            {
                //Console.WriteLine(zigchar);  results in a vertical list of each element in reverse with a space in between
                
                Console.Write(zigchar);
                    // RESULTS in: .tnaw yeht tahw teg elpoep rehto hguone pleh uoy fi efil fo tuo tnaw uoy tahw teg nac uoY
            }

            Console.ReadLine();
        }
    }
}
