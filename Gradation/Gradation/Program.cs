using System;

namespace Gradation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine()); // Math.Pow(num,power);
            int result=Gradation(num, power);
            Console.WriteLine(result);      
        }

        static int Gradation(int num, int power)
        {
            int firstNum = num;
            for (int i = 1; i < power; i++)
            {
                firstNum *= num;
            }
            return firstNum;
        }
    }
}
