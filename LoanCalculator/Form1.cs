using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        private decimal loan_amount;
        private int number_of_months;
        private decimal interest_rate;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txt_loanAmount.Text, out loan_amount)) { 
                    if (int.TryParse(txt_numberOfMonths.Text, out number_of_months)) { 
                        if (decimal.TryParse(txt_interestRate.Text, out interest_rate)) {
                            int counter = 0;
                            while (counter < number_of_months)
                            {
                                loan_amount = loan_amount * (interest_rate + 1);
                                listBox1.Items.Add("At month " + counter + " the loan is " + loan_amount.ToString("c"));
                                counter++;
                            }
                            txt_finalValue.Text = loan_amount.ToString("c");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number here");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_finalValue.Text = "";
            txt_interestRate.Text = "";
            txt_loanAmount.Text = "";
            txt_numberOfMonths.Text = "";
            listBox1.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
