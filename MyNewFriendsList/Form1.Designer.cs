namespace MyNewFriendsList
{
    partial class MyFriends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_newFriends = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_AddFriends = new System.Windows.Forms.Label();
            this.btn_addFriend = new System.Windows.Forms.Button();
            this.btn_Add5Friends = new System.Windows.Forms.Button();
            this.btn_sortAscending = new System.Windows.Forms.Button();
            this.btn_sortDescending = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_newFriends
            // 
            this.txt_newFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_newFriends.Location = new System.Drawing.Point(225, 37);
            this.txt_newFriends.Name = "txt_newFriends";
            this.txt_newFriends.Size = new System.Drawing.Size(336, 22);
            this.txt_newFriends.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 292);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_AddFriends
            // 
            this.lbl_AddFriends.AutoSize = true;
            this.lbl_AddFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AddFriends.Location = new System.Drawing.Point(378, 90);
            this.lbl_AddFriends.Name = "lbl_AddFriends";
            this.lbl_AddFriends.Size = new System.Drawing.Size(0, 16);
            this.lbl_AddFriends.TabIndex = 2;
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addFriend.Location = new System.Drawing.Point(225, 83);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Size = new System.Drawing.Size(95, 37);
            this.btn_addFriend.TabIndex = 3;
            this.btn_addFriend.Text = "Add Friend";
            this.btn_addFriend.UseVisualStyleBackColor = true;
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // btn_Add5Friends
            // 
            this.btn_Add5Friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add5Friends.Location = new System.Drawing.Point(225, 152);
            this.btn_Add5Friends.Name = "btn_Add5Friends";
            this.btn_Add5Friends.Size = new System.Drawing.Size(95, 55);
            this.btn_Add5Friends.TabIndex = 4;
            this.btn_Add5Friends.Text = "Add 5 Firends";
            this.btn_Add5Friends.UseVisualStyleBackColor = true;
            this.btn_Add5Friends.Click += new System.EventHandler(this.btn_Add5Friends_Click);
            // 
            // btn_sortAscending
            // 
            this.btn_sortAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sortAscending.Location = new System.Drawing.Point(225, 297);
            this.btn_sortAscending.Name = "btn_sortAscending";
            this.btn_sortAscending.Size = new System.Drawing.Size(95, 32);
            this.btn_sortAscending.TabIndex = 5;
            this.btn_sortAscending.Text = "A -> Z";
            this.btn_sortAscending.UseVisualStyleBackColor = true;
            this.btn_sortAscending.Click += new System.EventHandler(this.btn_sortAscending_Click);
            // 
            // btn_sortDescending
            // 
            this.btn_sortDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sortDescending.Location = new System.Drawing.Point(352, 297);
            this.btn_sortDescending.Name = "btn_sortDescending";
            this.btn_sortDescending.Size = new System.Drawing.Size(95, 32);
            this.btn_sortDescending.TabIndex = 6;
            this.btn_sortDescending.Text = "Z -> A";
            this.btn_sortDescending.UseVisualStyleBackColor = true;
            this.btn_sortDescending.Click += new System.EventHandler(this.btn_sortDescending_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.Location = new System.Drawing.Point(479, 297);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(95, 32);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // MyFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 367);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sortDescending);
            this.Controls.Add(this.btn_sortAscending);
            this.Controls.Add(this.btn_Add5Friends);
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.lbl_AddFriends);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_newFriends);
            this.Name = "MyFriends";
            this.Text = "MyFirends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newFriends;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_AddFriends;
        private System.Windows.Forms.Button btn_addFriend;
        private System.Windows.Forms.Button btn_Add5Friends;
        private System.Windows.Forms.Button btn_sortAscending;
        private System.Windows.Forms.Button btn_sortDescending;
        private System.Windows.Forms.Button btn_Clear;
    }
}

