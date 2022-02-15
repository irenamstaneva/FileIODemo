using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Irena Staneva";
            int countS = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if(name.Substring(i, 1) == "S")
                {
                    countS++;
                }

            }
            Console.WriteLine("There are "+countS+" letters S");
        }
    }
}
