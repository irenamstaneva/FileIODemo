using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] states =
            {"Alaska","Arizona","California","Deleware","Georgia","Hawaii"};
            string[] alaskaCities ={
            "Anchorage","Juno","Fairbanks"};
            string[] arizonaCities ={
            "Phoenix","Tucson","Flagstaff","Prescott","Gilbert","Glendale"};
            string[] californiaCities ={
            "Los Angeles","San Francisco","San Diego","Fresno"};
            string[] delewareCities ={
            "Wilimigton","Dover"};
            string[] georgiaCities ={
            "Atlanta","Valdosta","Macon"};
            string[] hawaiiCities ={
            "Honolulu","Kona","Pearl City","Hilo"};
            string[][] statesAndTheirCapitals = new string[states.Length][];
            statesAndTheirCapitals[0] = alaskaCities;
            statesAndTheirCapitals[1]=arizonaCities;
            statesAndTheirCapitals[2] = californiaCities;
            statesAndTheirCapitals[3] = delewareCities;
            statesAndTheirCapitals[4] = georgiaCities;
            statesAndTheirCapitals[5] = hawaiiCities;
            for(int i=0; i < states.Length; i++)
            {
                for(int j = 0; j < statesAndTheirCapitals[i].Length; j++)
                {
                    Console.WriteLine("The state " + states[i] +
                        " has the city number " + j + " as " + statesAndTheirCapitals[i][j]);
                }
            }

        }
    }
}
