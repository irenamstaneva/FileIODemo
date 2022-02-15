using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOGUI
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();
        private List<string> lines = new List<string>();
        private List<string> outContent = new List<string>();

        BindingSource bs = new BindingSource();

        string filePath = @"C:\Users\35989\OneDrive\Документи\C# кодовете на Ирена\Demo\People.txt";
        
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = people;
            listBox1.DataSource = bs;
        }

        private void btn_addToList_Click(object sender, EventArgs e)
        {
            Person p = new Person(txt_firstName.Text, txt_lastName.Text, txt_uRL.Text);
            people.Add(p);

            bs.ResetBindings(false);
            lbl_addToListBox.Text = "There are " + people.Count + " people in the list.";
        }

        private void btn_saveToFile_Click(object sender, EventArgs e)
        {
            Person p = new Person(txt_firstName.Text, txt_lastName.Text, txt_uRL.Text);
            outContent.Add(p.ToString());

            File.WriteAllLines(filePath, outContent);
            MessageBox.Show("The person is saved in the file People.txt");

        }

        private void btn_readFromFile_Click(object sender, EventArgs e)
        {
            people.Clear();
            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                string[] items = line.Split(':',',');

                Person p = new Person(items[1], items[3], items[5]);
                people.Add(p);
                
                bs.ResetBindings(false);
                lbl_addToListBox.Text = "There are " + people.Count + " people in the list.";

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            people.Clear();
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_uRL.Clear();
            bs.ResetBindings(false);
            lbl_addToListBox.Text = "";
            
        }
    }
}