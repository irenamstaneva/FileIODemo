using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<100; i = i + 15)
            {
                Console.WriteLine("i = " + i);
            }
            for(int j = 100; j > 0; j = j - 15)
            {
                Console.WriteLine("j = "+ j);
            }
            for(int k=1; k<100;k = k * 3)
            {
                Console.WriteLine("k = "+k);
            }
        }
    }
}
