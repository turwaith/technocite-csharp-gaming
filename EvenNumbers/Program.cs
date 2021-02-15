using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // display even numbers from an array with random numbers
            int[] numbers = FillArray(new int[200]);

            Console.WriteLine($"Numbers:\n[{String.Join(",", numbers)}]\n----------");
            Console.WriteLine($"The even numbers are:\n[{String.Join(",", DisplayEvenNumbers(numbers))}]");            

            Console.ReadKey(true);
        }

        static int[] FillArray(int[] numbers)
        {
            Random rand = new Random();

            for(int i = 0, size = numbers.Length; i < size; i++)            
                numbers[i] = rand.Next(0, 100);            

            return numbers;
        }

        static int[] DisplayEvenNumbers(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0, size = numbers.Length; i < size; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenNumbers.Add(numbers[i]);
                    //Console.Write($"{numbers[i]} - ");
            }
            return evenNumbers.ToArray();
        }
    }
}
