using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i.ToString());

                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;  // break out of the code, don't evaluate past 7
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }
            Console.ReadLine();
        }
    }
}
