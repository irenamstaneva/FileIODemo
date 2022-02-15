using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            try
            {
                PrintName(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        private static void PrintName(string std)
        {
            if (std == null)
            {
                throw new NullReferenceException("Name is null.");
            }
            Console.WriteLine(std);
        }
    }
}
