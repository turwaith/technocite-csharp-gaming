using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[200];

            for(int i = 0, size = numbers.Length; i < size; i++)
            {
                numbers[i] = rand.Next(-10, 1789);
            }

            Console.WriteLine($"[{string.Join(",", numbers)}]");
            Console.WriteLine("---------");
            Console.WriteLine($"[{string.Join(",", SortArray(numbers))}]");

            Console.ReadKey(true);            
        }
        static int[] SortArray(int[] numbers)
        {
            bool isSorted;

            do
            {
                isSorted = false;
                for (int i = 1, size = numbers.Length; i < size; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        isSorted = true;
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            } while (!isSorted);

            return numbers;
        }
    }
}
