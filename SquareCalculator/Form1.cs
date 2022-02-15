using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            int lowerLimit = 0;
            int upperLimit = 10;
            int countBy = 1;
            listBox1.Items.Clear();
            if (int.TryParse(txt_lowerLimit.Text, out lowerLimit))
            {
                if (int.TryParse(txt_upperLimit.Text, out upperLimit))
                {
                    if (int.TryParse(txt_countBy.Text, out countBy))
                    {
                        if (countBy < 0)
                        {
                            if(lowerLimit > upperLimit)
                            {
                                int temp = lowerLimit;
                                lowerLimit = upperLimit;
                                upperLimit = temp;
                            }
                            for (int x = upperLimit; x > lowerLimit; x = x + countBy)
                            {
                                listBox1.Items.Add(" x = " + x + " squared = " + x * x);
                            }
                        }
                        else
                        {
                            if (lowerLimit > upperLimit)
                            {
                                int temp = lowerLimit;
                                lowerLimit = upperLimit;
                                upperLimit = temp;
                            }
                            for (int x = lowerLimit; x < upperLimit; x = x + countBy)
                            {
                                listBox1.Items.Add(" x = " + x + " squared = " + x * x);
                            }
                        }
                        
                    }
                }
            }

        }
    }
}
