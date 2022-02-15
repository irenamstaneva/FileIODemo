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

namespace WordCounterApp
{
    public partial class Form1 : Form
    {
        private List<WordCounter> wordCounters = new List<WordCounter>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_createWordList_Click(object sender, EventArgs e)
        {
            String allWords = textBox1.Text;
            String[] WordsArray = allWords.Split(' ',',',',','!','-') ;
            
            foreach (String word in WordsArray)
            {
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }
        }

        private void btn_sortWordList_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btn_clearListBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_countWords_Click(object sender, EventArgs e)
        {
            String allWords = textBox1.Text;
            String[] WordsArray = allWords.Split(' ', ',', '.', '!', '-');
            

            foreach (String w in WordsArray)
            {
                WordCounter foundWord = wordCounters.Find(x => x.word == w);

                if(foundWord == null)
                {
                    wordCounters.Add(new WordCounter(w,1));
                }
                else
                {
                    foundWord.frequency++;
                }
            }
            
            listView1.Columns.Add("Word", 100);
            listView1.Columns.Add("Frequency", 70);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            foreach (WordCounter word in wordCounters)
            {
                String[] rowItem = new string[] {word.word, word.frequency.ToString("D5")};
                listView1.Items.Add(new ListViewItem(rowItem));
            }
        }

        private void btn_sortWordListView_Click(object sender, EventArgs e)
        { 
            listView1.Sorting = SortOrder.Descending;           
        }

        private void btn_clearListView_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            String filePath = @"C:\Users\35989\OneDrive\Desktop\BorisThird.txt";
            textBox1.Text = File.ReadAllText(filePath);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String filePath = @"C:\Users\35989\OneDrive\Desktop\WikiWords.txt";

            List<string> outText = new List<string>();
            
            foreach (string line in listBox1.Items)
            {
                outText.Add(line);
            }
            
            File.WriteAllLines(filePath, outText);
            MessageBox.Show("The ListBox is saved.");
        }

        private void btn_saveViewList_Click(object sender, EventArgs e)
        {
            String filePath = @"C:\Users\35989\OneDrive\Desktop\WikiWordsView.txt";

            List<string> outText = new List<string>();

            foreach(ListViewItem line in listView1.Items)
            {
                outText.Add(line.Text);
            }
            File.WriteAllLines(filePath, outText);
            MessageBox.Show("The ListView is saved");
        }
    }
}
