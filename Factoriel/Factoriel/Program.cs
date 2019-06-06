using System;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result=Factoriel(num);
            Console.WriteLine(result);
        }

        static int Factoriel(int num)
        {
            int r = 1;
            for (int i = 2; i <=num; i++)
            {
                r *= i;
            }
            return r;
        }
    }
}
