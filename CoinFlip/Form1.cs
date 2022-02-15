using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        Coins[] coins = new Coins[5];
        int num = 0;
        int num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.Text = "";
            

            int num = 0;
            int num2 = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                coins[i].FlipCoin(r);
                label1.Text += i + ". "+coins[i].isHeads + ", ";
                
            }
            
            for(int i = 0; i < coins.Length ; i++)
            {
                if (coins[i].isHeads)
                {
                    num++;
                }
                else
                {
                    num2++;
                }
                
            }
            label2.Text =num+" Heads";
            label3.Text =num2+" Tails";

            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.QuarterHead : Properties.Resources.QuarterTail;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.QuarterHead : Properties.Resources.QuarterTail;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.QuarterHead : Properties.Resources.QuarterTail;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.QuarterHead : Properties.Resources.QuarterTail;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.QuarterHead : Properties.Resources.QuarterTail;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coins(false);
            }
        }


    }
}
