using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Exception_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            try
            {
                Console.WriteLine("Enter a positive number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"The division 100/{num} is {100 / num}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Divided by {num} is not posible");
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered string must be a interger value.");
            }
        }
    }
}
