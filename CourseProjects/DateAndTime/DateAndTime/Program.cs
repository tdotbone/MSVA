using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
           // Console.WriteLine(myValue.ToString());
           // Console.WriteLine(myValue.ToShortDateString());
           // Console.WriteLine(myValue.ToShortTimeString()); 
           // Console.WriteLine(myValue.ToLongDateString());
           // Console.WriteLine(myValue.ToLongTimeString()); 
           
           // Console.WriteLine(myValue.AddDays(3).ToLongDateString()); 
           // Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); 

           // Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
           // Console.WriteLine(myValue.Month.ToString());

         //via overloaded constructor
            //DateTime myBirthday = new DateTime(1956, 10, 30);
            //Console.WriteLine(myBirthday.ToShortDateString());


        //subtract method to determine the amount of time between when I was born to now
            DateTime myBirthday = DateTime.Parse("10/30/1956");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();

        }
    }
}
