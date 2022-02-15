using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] states = { "Alaska", "Arisona", "California", "Delaware","Georgia","Hawaii" };
            foreach(string s in states)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
