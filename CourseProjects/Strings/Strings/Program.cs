using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            //string myString = "Go to your c:\\ drive";  
            //the '\' character is an escape character- must use 2 backslashes to display the intended \

            //Example 2
            //string myString = "My "so called" life"; this example needs the escape character \ 
            //string myString = "My \"so called\" life";

            //Example 3
            //string myString = "What if I need \n a new line?";

            //Example 4
            //String myString = string.Format("{0}!", "Bonzai");  //simple substitution of Bonzai for the {0}

            //Example 5
            string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");  //first replacement code {0} will be matched up with the first argument "BMW" etc.




            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
