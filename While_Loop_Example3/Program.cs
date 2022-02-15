using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "";
            Console.WriteLine("Enter the secret message, which is the password.");
            while (secretMessage != "asdf")
            {
                secretMessage = Console.ReadLine();
                
                if(secretMessage == "asdf")
                {
                    break;
                }
                Console.WriteLine("The secret message you have entered is not the password." +
                    " Please try again");
            }
            Console.WriteLine("All have done here. " +
                "The secret message, that you have typed is the password.");
        }
    }
}
