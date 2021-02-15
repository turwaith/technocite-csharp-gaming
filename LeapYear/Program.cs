using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2021; i < 2042; i++)
            {
                if(i%4 == 0 && (i%100 != 0 || i%400 ==0))
                {                   
                    Console.WriteLine($"{i} is a leap year");                    
                }
                else
                {
                    Console.WriteLine($"{i} is not a leap year");
                }
            }

            Console.WriteLine();

            // use of IsLeapYear
            for (int i = 2021; i < 2042; i++)
            {
                if(DateTime.IsLeapYear(i))
                    Console.WriteLine($"{i} is a leap year");
            }

            Console.ReadKey(true);
        }
    }
}
