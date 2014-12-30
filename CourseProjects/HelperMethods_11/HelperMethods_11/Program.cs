using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods_11   //course Creating and Calling Simple Overloaded Helper Methods
{
    class Program
    {
        static void Main(string[] args)
        //Keyword 'void' means this method doesn't return any values
            //Main doesn't need to return anything because it is the entry point of the entire application
            //Can be used to delegate 
        
        {
            //passing value "world" to the private method below as "name"
            //string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("sunshine");
                //changing value here but do not have to change anything in the method being called below

            Console.WriteLine(myValue);
            Console.ReadLine();
        }

       // multiple versions of the same method name used for different reasons
        private static string superSecretFormula()  // uses line 14 above
        {
            // some cool stuff here
            return "Hello World!";
        }  
        
        private static string superSecretFormula(string name)  // uses line 15 above
        {
            return String.Format("Hello, {0}", name);
        }


        //Keyword 'void' means this method doesn't return any values

    }
}
