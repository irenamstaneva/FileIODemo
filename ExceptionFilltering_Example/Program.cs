using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilltering_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to divide 100: ");
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"The {num}/100={num / 100}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divied by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again. ");
            }
        }
    }
}
