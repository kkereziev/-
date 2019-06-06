using System;

namespace FindHowManyDigitsInNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            FindHowManyDigits(num);
        }

        static void FindHowManyDigits(int num)
        {
            int count = 0;
            while (num>0)
            {
                num /= 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
