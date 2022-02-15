using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
        private void convertFromFahrenheit()
        {
            float f = 0;
            txt_fahrenheit.ForeColor = Color.Black;
            try
            {
                f = float.Parse(txt_fahrenheit.Text);
            }
            catch
            {
                txt_fahrenheit.ForeColor = Color.Red;
                MessageBox.Show("Try only numbers.");
            }
            float c = 5f / 9f * (f - 32);
            float k = c - 273;
            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }
        private void convertFromCelsius()
        {
            float c = 0;
            txt_celsius.ForeColor = Color.Black;
            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                txt_celsius.ForeColor = Color.Red;
                MessageBox.Show("Try only numbers.");
            }
            float k = c - 273;
            txt_kelvin.Text = k.ToString();
            float f = 9f / 5f * c + 32;
            txt_fahrenheit.Text = f.ToString();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }
        private void convertFromKelvin()
        {
            float k = 0;
            txt_kelvin.ForeColor = Color.Black;
            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                txt_kelvin.ForeColor = Color.Red;
                MessageBox.Show("Try only numbers");
            }
            float c = k + 273;
            txt_celsius.Text = c.ToString();
            float f = 9f / 5f * c + 32;
            txt_fahrenheit.Text = f.ToString();
        }
        private void onTextChangeFahrenheigh(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
        private void onTextChangeCelsius(object sender, EventArgs e)
        {
            convertFromCelsius();
        }
        private void onTextChangeKelvin(object sender, EventArgs e)
        {
            convertFromKelvin();
        }
    }
}
