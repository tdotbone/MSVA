using System;
using System.Collections.Generic;
using System.IO;    //added by option menu for 'StreamReader below
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacessAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
           // System.IO.StreamReader myStreamReader = new System.IO.StreamReader();

           // StreamReader myStreamReader = new myStreamReader();  // not using full name so causes error

           // use the Control key and the period to open up the option menu instead of trying to hover over the little box underneath StreamReader
            
           // StreamReader myStreamReader = new StreamReader();

  // added the Lesson 18 sample 'Tabor.dll' file to References which contains "Bob" class
            //added 'using Tabor' to the using list above

            Bob bob = new Bob();

            string html = bob.Lookup("http://www.learnvisualstudio.net");

            Console.WriteLine(html);
            Console.ReadLine();
            // opened the console with a lot of html from Tabor's website



        }
    }
}
