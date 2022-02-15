using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 0;
            while (secretNumber < 100)
            {
                secretNumber=Int32.Parse(Console.ReadLine());
                Console.WriteLine("You enter the number : " + secretNumber +
                    ". I will ask you to enter a number greater than 100.");
            }
            Console.WriteLine("All done here. Your number is greater than 100.");
        }
    }
}
