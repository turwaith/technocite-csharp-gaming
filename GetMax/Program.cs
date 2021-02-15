using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate a array of size 200 with random numbers from 0 to 1857
            // then display the higher number with its index

            int[] numbers = InitializeArray(0, 1857),
                  max = GetMax(numbers);

            Console.WriteLine($"Numbers:\n[{string.Join(",", numbers)}]");
            Console.WriteLine($"\nThe higher number is {numbers.Max()}");
            Console.WriteLine($"The higher number is {max[0]} at index {max[1]}");
            Console.ReadKey(true);
        }

        static int[] InitializeArray(int from, int to)
        {
            int[] numbers = new int[200];
            Random rand = new Random();

            for(int i = 0, size = numbers.Length; i < size; i++)            
                numbers[i] = rand.Next(from, to);            

            return numbers;
        }

        static int[] GetMax(int[] numbers)
        {
            // max[0] = higher
            // max[1] = index
            int[] max = { 0, 0 };
            for(int i = 0, size = numbers.Length; i < size; i++)
            {
                if (numbers[i] > max[0])
                {
                    max[0] = numbers[i];
                    max[1] = i;
                }
            }
            return max;
        }
    }
}
