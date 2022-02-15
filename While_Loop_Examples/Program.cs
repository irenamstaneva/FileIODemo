using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 30)
            {
                counter = counter+5;
                Console.WriteLine("Counter = "+counter);
            }
            Console.WriteLine("All done with counting example.");
        }
    }
}
