namespace WordCounterApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_createWordList = new System.Windows.Forms.Button();
            this.btn_sortWordList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_countWords = new System.Windows.Forms.Button();
            this.btn_sortWordListView = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_clearListBox1 = new System.Windows.Forms.Button();
            this.btn_clearListView = new System.Windows.Forms.Button();
            this.btn_readFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveViewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Load a Text File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Split the File Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.Count the Frequency of Each Word ";
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(13, 29);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(75, 48);
            this.btn_chooseFile.TabIndex = 3;
            this.btn_chooseFile.Text = "Choose a File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(258, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 48);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 452);
            this.textBox1.TabIndex = 5;
            // 
            // btn_createWordList
            // 
            this.btn_createWordList.Location = new System.Drawing.Point(405, 29);
            this.btn_createWordList.Name = "btn_createWordList";
            this.btn_createWordList.Size = new System.Drawing.Size(75, 48);
            this.btn_createWordList.TabIndex = 6;
            this.btn_createWordList.Text = "Create Word List";
            this.btn_createWordList.UseVisualStyleBackColor = true;
            this.btn_createWordList.Click += new System.EventHandler(this.btn_createWordList_Click);
            // 
            // btn_sortWordList
            // 
            this.btn_sortWordList.Location = new System.Drawing.Point(487, 29);
            this.btn_sortWordList.Name = "btn_sortWordList";
            this.btn_sortWordList.Size = new System.Drawing.Size(75, 48);
            this.btn_sortWordList.TabIndex = 7;
            this.btn_sortWordList.Text = "Sort Words";
            this.btn_sortWordList.UseVisualStyleBackColor = true;
            this.btn_sortWordList.Click += new System.EventHandler(this.btn_sortWordList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(405, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 452);
            this.listBox1.TabIndex = 8;
            // 
            // btn_countWords
            // 
            this.btn_countWords.Location = new System.Drawing.Point(766, 29);
            this.btn_countWords.Name = "btn_countWords";
            this.btn_countWords.Size = new System.Drawing.Size(75, 48);
            this.btn_countWords.TabIndex = 9;
            this.btn_countWords.Text = "Count";
            this.btn_countWords.UseVisualStyleBackColor = true;
            this.btn_countWords.Click += new System.EventHandler(this.btn_countWords_Click);
            // 
            // btn_sortWordListView
            // 
            this.btn_sortWordListView.Location = new System.Drawing.Point(848, 29);
            this.btn_sortWordListView.Name = "btn_sortWordListView";
            this.btn_sortWordListView.Size = new System.Drawing.Size(75, 48);
            this.btn_sortWordListView.TabIndex = 10;
            this.btn_sortWordListView.Text = "Sort Words";
            this.btn_sortWordListView.UseVisualStyleBackColor = true;
            this.btn_sortWordListView.Click += new System.EventHandler(this.btn_sortWordListView_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(766, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 452);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_clearListBox1
            // 
            this.btn_clearListBox1.Location = new System.Drawing.Point(650, 29);
            this.btn_clearListBox1.Name = "btn_clearListBox1";
            this.btn_clearListBox1.Size = new System.Drawing.Size(75, 48);
            this.btn_clearListBox1.TabIndex = 16;
            this.btn_clearListBox1.Text = "Clear";
            this.btn_clearListBox1.UseVisualStyleBackColor = true;
            this.btn_clearListBox1.Click += new System.EventHandler(this.btn_clearListBox1_Click);
            // 
            // btn_clearListView
            // 
            this.btn_clearListView.Location = new System.Drawing.Point(1011, 30);
            this.btn_clearListView.Name = "btn_clearListView";
            this.btn_clearListView.Size = new System.Drawing.Size(75, 48);
            this.btn_clearListView.TabIndex = 17;
            this.btn_clearListView.Text = "Clear";
            this.btn_clearListView.UseVisualStyleBackColor = true;
            this.btn_clearListView.Click += new System.EventHandler(this.btn_clearListView_Click);
            // 
            // btn_readFile
            // 
            this.btn_readFile.Location = new System.Drawing.Point(177, 29);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(75, 48);
            this.btn_readFile.TabIndex = 18;
            this.btn_readFile.Text = "Read a File";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(569, 29);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 48);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveViewList
            // 
            this.btn_saveViewList.Location = new System.Drawing.Point(930, 30);
            this.btn_saveViewList.Name = "btn_saveViewList";
            this.btn_saveViewList.Size = new System.Drawing.Size(75, 47);
            this.btn_saveViewList.TabIndex = 20;
            this.btn_saveViewList.Text = "Save";
            this.btn_saveViewList.UseVisualStyleBackColor = true;
            this.btn_saveViewList.Click += new System.EventHandler(this.btn_saveViewList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 630);
            this.Controls.Add(this.btn_saveViewList);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_readFile);
            this.Controls.Add(this.btn_clearListView);
            this.Controls.Add(this.btn_clearListBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_sortWordListView);
            this.Controls.Add(this.btn_countWords);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_sortWordList);
            this.Controls.Add(this.btn_createWordList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_createWordList;
        private System.Windows.Forms.Button btn_sortWordList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_countWords;
        private System.Windows.Forms.Button btn_sortWordListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_clearListBox1;
        private System.Windows.Forms.Button btn_clearListView;
        private System.Windows.Forms.Button btn_readFile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveViewList;
    }
}

