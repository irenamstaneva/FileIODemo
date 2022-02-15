using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] names={ "Abel", "Beatris", "Cheryl", "Dobby", 
                "Eckbert", "Fabio", "Giovani","Halga"};
            foreach(string name in names)
            {
                Console.WriteLine("One of the names is: "+name);
            }
        }
    }
}
