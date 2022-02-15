using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Abel","Beatris", "Cheryl","Dobby",
                "Eckbert","Fabio","Giovani","Helga"};

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name number "+i+" is "+names[i]);
            }
            for(int i = names.Length-1;i >= 0; i--)
            {
                Console.WriteLine("Name number "+i+" is "+names[i]);
            }
        }
    }
}
