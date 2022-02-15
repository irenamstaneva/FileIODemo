using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            do
            {
                y--;
                Console.WriteLine("The number is: " + y);
            } while (y > 0);
            Console.WriteLine("All done here.");
        }
    }
}
