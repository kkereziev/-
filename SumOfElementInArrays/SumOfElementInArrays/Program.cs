using System;
using System.Linq;

namespace SumOfElementInArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum=SumOfArrayElements(arrayOne,arrayTwo);
            Console.WriteLine(sum);
        }

        static int SumOfArrayElements(int[] arrayOne, int[] arrayTwo)
        {
            int sum = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i] + arrayTwo[i];
            }
            return sum;
        }
    }
}
