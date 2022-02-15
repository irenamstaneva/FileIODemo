using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip2
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 45;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }
        private void updateUI()
        {
            track_cycle.Value = 0;
            track_car.Value = 0;
            track_truck.Value = 0;
            track_trainCars.Value = 0;

            progressBar1.Maximum = ship.Capacity;

            if(ship.getShipLoad()<=ship.Capacity)
            progressBar1.Value = ship.getShipLoad();

            label_shipLabel.Text = ship.ToString(); 
            label_cycleCount.Text = ship.CycleCount.ToString();
            label_carCount.Text = ship.CarCount.ToString();
            label_truckCount.Text = ship.TruckCount.ToString();
            label_trainCarCount.Text = ship.TrainCarCount.ToString();

            track_cycle.Value = ship.CycleCount;
            track_car.Value = ship.CarCount;
            track_truck.Value = ship.TruckCount;
            track_trainCars.Value =ship.TrainCarCount;


            if (ship.overUnder() == 0)
                progressBar1.ForeColor = Color.Green;
            if (ship.overUnder() > 0)
                progressBar1.ForeColor = Color.Yellow;
            if(ship.overUnder() < 0)
                progressBar1.ForeColor= Color.Red;

        }

        private void track_motorCycle_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount=track_cycle.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount=track_car.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_truck.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            updateUI();
        }
    }
}
