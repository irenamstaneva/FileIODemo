using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i= 0; i < 8; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("["+i+", "+ j+"]");
                }
                Console.WriteLine();
            }
        }
    }
}
