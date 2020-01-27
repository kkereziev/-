using System;

namespace RazlaganeNaChisloDoProstiDeliteli
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()); //520=2x2x2x5x13
            FindSimpleDividers(number);                 // 64=2x2x2x2x2x2
            
        }

        public static int FindSimpleDividers(int number)
        {
            Console.WriteLine(number);
            var i = 1;
            while (number != 1)
            {
                i++;
                var how = 0;
                while (0 == number % i)
                {
                    how++;
                    number = number / i;
                }

                for (int j = 0; j < how; j++)
                {
                    Console.WriteLine(i);
                }
            }

            return 0;
        }
    }
}
