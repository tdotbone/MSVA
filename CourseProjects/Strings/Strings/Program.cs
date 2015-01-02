using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//review the methods of the string class to find out what they do, which will save you from reinventing the wheel when using strings

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
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");  //first replacement code {0} will be matched up with the first argument "BMW" etc.

            //more string format examples  http://msdn.microsoft.com/en-us/library/fht0f5be(v=vs.110).aspx
            //string myString = string.Format("{0:C}", 123.45);     //format using 'C'  expect $123.45
            //string myString = string.Format("{0:N}", 123456789);  //format using 'N'  expect 123,456,789.00
            //string myString = string.Format("{0:P}", .123);       //format using 'P'  expect 12.30%
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);       //format using a template for phone number - expect "Phone number: (123) 456-7890"

            
            //the following method causes a lot of resource use because space has to be found for each iteration declared in the while 
            
           /* string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }   
           */

           /*   using StringBuilder should improve performance if using a lot of string concatenation
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i); 
            }
           */

    /*
            string myString = " That summer we took threes across the board  ";
            
              //myString = myString.Substring(5, 14); //start at this position (5) and take the next (14) characters - expecting " summer we took"

              //myString = myString.ToUpper();   //converts all characters to upper case

              //myString = myString.Replace(" ", "--");  //replaces all spaces with --, "That--summer--we" ... etc.

            myString = String.Format("Length before: {0} -- After: {1}", //give the length of the string before and after trimming beginning and ending spaces
            myString.Length, myString.Trim().Length);
                    //expected output: Length before: 46 -- After: 43
            
            Console.WriteLine(myString);
            Console.ReadLine();
     */
     
        }
    }
}
