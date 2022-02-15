using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipLoader
{
    internal class Ship
    {
        const int Cycle_Weight = 3;
        const int Car_Weight = 5;
        const int Truck_Weight = 11;
        const int Train_Weight = 17;
        const int Max_Weight = 10;
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }
        Random random=new Random();
        public int getShipLoad()
        {
            return CycleCount * Cycle_Weight + CarCount * Car_Weight + 
                TruckCount * Truck_Weight + TrainCarCount * Train_Weight;
        }
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;
            Capacity = random.Next(Max_Weight)*Cycle_Weight + random.Next(Max_Weight)*Car_Weight+
                random.Next(Max_Weight)*Truck_Weight + random.Next(Max_Weight)*Train_Weight;
        }
        public int overUnder()
        {
            return Capacity-getShipLoad();
        }
        public override string ToString()
        {
            return "Capacity = " + Capacity +
                ", CurrentLoad = " + getShipLoad();
        }

    }
}
