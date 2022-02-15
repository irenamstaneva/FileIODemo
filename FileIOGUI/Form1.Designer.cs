namespace FileIOGUI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_uRL = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_uRL = new System.Windows.Forms.TextBox();
            this.btn_addToList = new System.Windows.Forms.Button();
            this.btn_saveToFile = new System.Windows.Forms.Button();
            this.btn_readFromFile = new System.Windows.Forms.Button();
            this.lbl_addToListBox = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(406, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 532);
            this.listBox1.TabIndex = 0;
            this.listBox1.Tag = "0";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(13, 13);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(72, 16);
            this.lbl_firstName.TabIndex = 1;
            this.lbl_firstName.Text = "FirstName:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(13, 35);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(72, 16);
            this.lbl_lastName.TabIndex = 2;
            this.lbl_lastName.Text = "LastName:";
            // 
            // lbl_uRL
            // 
            this.lbl_uRL.AutoSize = true;
            this.lbl_uRL.Location = new System.Drawing.Point(13, 64);
            this.lbl_uRL.Name = "lbl_uRL";
            this.lbl_uRL.Size = new System.Drawing.Size(37, 16);
            this.lbl_uRL.TabIndex = 3;
            this.lbl_uRL.Text = "URL:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(92, 6);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(158, 22);
            this.txt_firstName.TabIndex = 1;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(92, 35);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(158, 22);
            this.txt_lastName.TabIndex = 2;
            // 
            // txt_uRL
            // 
            this.txt_uRL.Location = new System.Drawing.Point(92, 64);
            this.txt_uRL.Name = "txt_uRL";
            this.txt_uRL.Size = new System.Drawing.Size(158, 22);
            this.txt_uRL.TabIndex = 3;
            // 
            // btn_addToList
            // 
            this.btn_addToList.Location = new System.Drawing.Point(147, 108);
            this.btn_addToList.Name = "btn_addToList";
            this.btn_addToList.Size = new System.Drawing.Size(103, 23);
            this.btn_addToList.TabIndex = 4;
            this.btn_addToList.Text = "Add to list";
            this.btn_addToList.UseVisualStyleBackColor = true;
            this.btn_addToList.Click += new System.EventHandler(this.btn_addToList_Click);
            // 
            // btn_saveToFile
            // 
            this.btn_saveToFile.Location = new System.Drawing.Point(92, 211);
            this.btn_saveToFile.Name = "btn_saveToFile";
            this.btn_saveToFile.Size = new System.Drawing.Size(125, 23);
            this.btn_saveToFile.TabIndex = 5;
            this.btn_saveToFile.Text = "Save to File";
            this.btn_saveToFile.UseVisualStyleBackColor = true;
            this.btn_saveToFile.Click += new System.EventHandler(this.btn_saveToFile_Click);
            // 
            // btn_readFromFile
            // 
            this.btn_readFromFile.Location = new System.Drawing.Point(92, 240);
            this.btn_readFromFile.Name = "btn_readFromFile";
            this.btn_readFromFile.Size = new System.Drawing.Size(125, 23);
            this.btn_readFromFile.TabIndex = 6;
            this.btn_readFromFile.Text = "Read from File";
            this.btn_readFromFile.UseVisualStyleBackColor = true;
            this.btn_readFromFile.Click += new System.EventHandler(this.btn_readFromFile_Click);
            // 
            // lbl_addToListBox
            // 
            this.lbl_addToListBox.AutoSize = true;
            this.lbl_addToListBox.Location = new System.Drawing.Point(44, 149);
            this.lbl_addToListBox.Name = "lbl_addToListBox";
            this.lbl_addToListBox.Size = new System.Drawing.Size(0, 16);
            this.lbl_addToListBox.TabIndex = 10;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(92, 270);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(125, 23);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 556);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_addToListBox);
            this.Controls.Add(this.btn_readFromFile);
            this.Controls.Add(this.btn_saveToFile);
            this.Controls.Add(this.btn_addToList);
            this.Controls.Add(this.txt_uRL);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.lbl_uRL);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_uRL;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_uRL;
        private System.Windows.Forms.Button btn_addToList;
        private System.Windows.Forms.Button btn_saveToFile;
        private System.Windows.Forms.Button btn_readFromFile;
        private System.Windows.Forms.Label lbl_addToListBox;
        private System.Windows.Forms.Button btn_Clear;
    }
}

