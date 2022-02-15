using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewFriendsList
{
    public partial class MyFriends : Form
    {
        List<String> myFriends = new List<String>();
        BindingSource bs = new BindingSource();
        public MyFriends()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
            listBox1.DataSource = bs;
        }

        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(txt_newFriends.Text);
            myFriends.Add(txt_newFriends.Text);
            
            bs.ResetBindings(false);
            lbl_AddFriends.Text = "There are " + myFriends.Count + " people in the list.";
        }

        private void btn_Add5Friends_Click(object sender, EventArgs e)
        {
            myFriends.Add("Steven");
            myFriends.Add("Vicki");
            myFriends.Add("Manuel");
            myFriends.Add("Hanna");
            myFriends.Add("Lorenzo");
            listBox1.DataSource=bs;
            bs.ResetBindings(false);
            lbl_AddFriends.Text = "There are " + myFriends.Count + " people in the list.";
        }

        private void btn_sortAscending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sortDescending_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            myFriends.Clear();
            txt_newFriends.Clear();
            lbl_AddFriends.Text = "";
            bs.ResetBindings(false);
        }
    }
}
