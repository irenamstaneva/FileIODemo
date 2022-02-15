using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensional_Array_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    grid[i, j] = i + j;
                    Console.Write(grid[i, j]+", ");
                }
                Console.WriteLine();
            }
            foreach(int i in grid)
            {
                Console.Write("One item in the grid {0} ",i);
            }
        }
    }
}
