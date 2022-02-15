using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();

        }
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
               new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
               new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
               new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
               new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
               new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
               new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
               Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }
        }
    }  

    
}
