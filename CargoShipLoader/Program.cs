using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to Cargo ship. The goal of this game " +
                "is to load the ship tp its maximum capacity by adding motor cycles, " +
                "car, trucks and train cars. A cycle takes 3 units of weight. " +
                "A car takes 5 units of weight. A truck takes 11 units. " +
                "A train car takes 17 units.";

            Console.WriteLine(WelcomeMessage);

            while(ship.Capacity != ship.getShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship capacity is "+ ship.Capacity + ".");
                Console.WriteLine("A number between 0 and 10 is required.");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("The ship has " + ship.CycleCount + " motor cycles on board.");
                Console.WriteLine("The ship has " + ship.CarCount + " cars cycle on board.");
                Console.WriteLine("The ship has " + ship.TruckCount + " trucks cycle on board.");
                Console.WriteLine("The ship has " + ship.TrainCarCount + " train cars cycle on board.");
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("The ship currently has "+ ship.getShipLoad() + " total units on board.");
                Console.ForegroundColor = ConsoleColor.White;
                int x = 0;
                Console.WriteLine("How many motor cycles would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.CycleCount = x;

                Console.WriteLine("How many motor cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.TruckCount = x;

                Console.WriteLine("How many train cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.TrainCarCount = x;

                Console.WriteLine("The ship now has "+ ship.getShipLoad() + 
                    " total units of weight on board.");
                if(ship.getShipLoad() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The skip still has room tp spare. Load more items.");
                }
                if (ship.getShipLoad() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship still is overloaded. Take some items off!");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("You loaded the successfully!");

            Console.ReadLine();
        }
    }
}
