using System;
using System.Collections.Generic;
using System.IO;    //see the comments below
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Microsoft Virtual Academy Course: C# Fundamentals for Absolute Beginners, Lesson 2 and 21
// Lesson 21 changed the name of the file from Values.txt to Values1.txt which creates an error which lesson 21 will try/catch

namespace ReadTextFileWhileLesson
{
    /* Lesson 2
     
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

            while (line != null)  // null is not the same as an empty string, it means unknown or indeterminate
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
    */

    // Lesson 21 - examples 1 + 2, displaying a problem, then modifying to display the actual problem message
    /*class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }

                }

                myReader.Close();

            }
            // catch block, works but doesn't explain what is wrong, just that something isn't working correctly
           // catch

            catch (Exception e) //using 'e' to access the error message
            {
                //Console.WriteLine("the Catch block code worked: Something didn't quite work correctly");
                Console.WriteLine("Something didn't quite work correctly: {0}", e.Message);
            }

            Console.ReadLine();


        }
    }
    */


    // Lesson 21 - example 3 - looking for specific exceptions
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //StreamReader myReader = new StreamReader("Values.txt"); // testing wrong file name - name in the \release\bin\... directory is 'Values1.txt'
                
                StreamReader myReader = new StreamReader("\\bogus\\Values.txt"); //adding bogus directory to test catch

               // StreamReader myReader = new StreamReader("Values1.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }

                }

                myReader.Close();

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the DIRECTORY exists?");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure you're looking for the correct file?");
            }
            catch (Exception e) //using 'e' to access the error message
            {
                //Console.WriteLine("the Catch block code worked: Something didn't quite work correctly");
                Console.WriteLine("Not a directory or filename problem, must be something else: {0}", e.Message);
            }
            finally
            {
                // Perform any cleanup to roll back the data or close connections
                // to files, database, network etc.
            }
            Console.ReadLine();


        }
    }
}
