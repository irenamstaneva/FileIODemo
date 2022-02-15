using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How tall do you want the triangle to be?");
                int triangleHeight = int.Parse(Console.ReadLine());


                int[][] triangleArray = new int[triangleHeight + 1][];

                for (int row = 0; row < triangleHeight + 1; row++)
                {
                    triangleArray[row] = new int[row + 1];
                }




                for (int row = 0; row < triangleHeight; row++)
                {

                    for (int col = 0; col < row; col += 1)
                    {

                        if (row == col || col == 0)
                        {
                            triangleArray[row][col] = 1;
                        }
                        else
                        {
                            triangleArray[row][col] = triangleArray[row - 1][col - 1] + triangleArray[row - 1][col];
                        }


                    }

                }


                for (int row = 0; row < triangleHeight; row++)
                {
                    Console.Write( new String(' ',(triangleHeight-row)*3) );

                    for (int col = 0; col < row; col++)
                    {
                        Console.Write("{0,6}", triangleArray[row][col]);
                    }
                    Console.WriteLine();

                }

            }

        }
    }
}
