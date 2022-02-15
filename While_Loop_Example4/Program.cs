using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while (y < -10)
            {
                y--;
                Console.WriteLine("Your number"+y+" is less than -10.");
            }
            Console.WriteLine("The number is greater than -10. All done here.");
        }
    }
}
