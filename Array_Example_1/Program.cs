using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long will the 2d array be? (row-s)");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How wide will the 2d array be? (col-s)");
            int cols = int.Parse(Console.ReadLine());
            int[,] grid = new int[rows, cols];
            Console.WriteLine("Time to fill the grid");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine("grid[{0},{1}]=", row, col);
                    grid[row, col] = int.Parse(Console.ReadLine());
                    PrintGrid(rows, cols, grid);
                }
                
            }
            Console.WriteLine("Finished");
            PrintGrid(rows, cols, grid);
        }

        private static void PrintGrid(int rows, int cols, int[,] grid)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(grid[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
