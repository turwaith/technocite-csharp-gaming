using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            int a = 10;

            a++;
            Console.WriteLine($"Valeur de a: {a}");
            Console.WriteLine($"Valeur de a négatif: {-a}");

            Console.ReadKey(true);
        }
    }
}
