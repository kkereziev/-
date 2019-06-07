using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); ;
            int[,] matrix = new int[n, n];
            int row = 0;
            int column = 0;
            string direction = "right";
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (direction == "right" && (column > n - 1 || matrix[row, column] != 0))
                {
                    direction = "down";
                    column--;
                    row++;
                }
                else if (direction == "down" && (row > n - 1 || matrix[row, column] != 0))
                {
                    direction = "left";
                    row--;
                    column--;
                }
                else if (direction == "left" && (column < 0 || matrix[row, column] != 0))
                {
                    direction = "up";
                    column++;
                    row--;
                }
                else if (direction == "up" && (row < 0 || matrix[row, column] != 0))
                {
                    direction = "right";
                    row++;
                    column++;
                }
                matrix[row, column] = i;
                if (direction == "right")
                {
                    column++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    column--;
                }
                else if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{matrix[r, c],4}");
                }
                Console.WriteLine();
            }
        }
    }
}