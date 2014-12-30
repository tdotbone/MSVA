using System;
using System.Collections.Generic;
using System.IO;    //see the comments below
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // the C# compile can't resolve the words StreamReader to it's full name which is system.io.StreamReader, VS doesn't know where this class lives
            //StreamReader myReader = new StreamReader("Values.txt"); 
            // this is resolved by hovering over the text StreamReader to display the contextual menu that pops up and selecting "useing System.IO" which is then added to the using list above
            // this still produces an error because the text file does not exist in the \\project\bin\debug directory 
            // select the 'Values.txt' file in the solution window which will display property options for this file
            // in Properties window, select 'Copy if newer' option from the Copy to output directory item.

            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null)  // null is not the same as an empty string, it means unknown or indeterminent
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }

            }

            myReader.Close();  //failing to close the file will lead to other methods or apps not being able to access the file
            Console.ReadLine();
        }
    }
}
