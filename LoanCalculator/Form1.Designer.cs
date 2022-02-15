namespace LoanCalculator
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
            this.txt_finalValue = new System.Windows.Forms.TextBox();
            this.lbl_finalValue = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_loanAmount = new System.Windows.Forms.Label();
            this.lbl_numberOfMonths = new System.Windows.Forms.Label();
            this.lbl_interestRate = new System.Windows.Forms.Label();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_numberOfMonths = new System.Windows.Forms.TextBox();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(101, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 244);
            this.listBox1.TabIndex = 0;
            // 
            // txt_finalValue
            // 
            this.txt_finalValue.Location = new System.Drawing.Point(189, 473);
            this.txt_finalValue.Name = "txt_finalValue";
            this.txt_finalValue.ReadOnly = true;
            this.txt_finalValue.Size = new System.Drawing.Size(118, 22);
            this.txt_finalValue.TabIndex = 1;
            // 
            // lbl_finalValue
            // 
            this.lbl_finalValue.AutoSize = true;
            this.lbl_finalValue.Location = new System.Drawing.Point(101, 479);
            this.lbl_finalValue.Name = "lbl_finalValue";
            this.lbl_finalValue.Size = new System.Drawing.Size(77, 16);
            this.lbl_finalValue.TabIndex = 2;
            this.lbl_finalValue.Text = "Final Value:";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(92, 514);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(86, 36);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(241, 514);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 36);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(393, 514);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 36);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_loanAmount
            // 
            this.lbl_loanAmount.AutoSize = true;
            this.lbl_loanAmount.Location = new System.Drawing.Point(101, 57);
            this.lbl_loanAmount.Name = "lbl_loanAmount";
            this.lbl_loanAmount.Size = new System.Drawing.Size(88, 16);
            this.lbl_loanAmount.TabIndex = 6;
            this.lbl_loanAmount.Text = "Loan Amount:";
            // 
            // lbl_numberOfMonths
            // 
            this.lbl_numberOfMonths.AutoSize = true;
            this.lbl_numberOfMonths.Location = new System.Drawing.Point(101, 109);
            this.lbl_numberOfMonths.Name = "lbl_numberOfMonths";
            this.lbl_numberOfMonths.Size = new System.Drawing.Size(118, 16);
            this.lbl_numberOfMonths.TabIndex = 7;
            this.lbl_numberOfMonths.Text = "Number of Months:";
            // 
            // lbl_interestRate
            // 
            this.lbl_interestRate.AutoSize = true;
            this.lbl_interestRate.Location = new System.Drawing.Point(104, 161);
            this.lbl_interestRate.Name = "lbl_interestRate";
            this.lbl_interestRate.Size = new System.Drawing.Size(85, 16);
            this.lbl_interestRate.TabIndex = 8;
            this.lbl_interestRate.Text = "Interest Rate:";
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Location = new System.Drawing.Point(241, 57);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(118, 22);
            this.txt_loanAmount.TabIndex = 9;
            // 
            // txt_numberOfMonths
            // 
            this.txt_numberOfMonths.Location = new System.Drawing.Point(241, 103);
            this.txt_numberOfMonths.Name = "txt_numberOfMonths";
            this.txt_numberOfMonths.Size = new System.Drawing.Size(118, 22);
            this.txt_numberOfMonths.TabIndex = 10;
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Location = new System.Drawing.Point(241, 155);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(118, 22);
            this.txt_interestRate.TabIndex = 11;
            this.txt_interestRate.Text = "0,005";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 562);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.txt_numberOfMonths);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.lbl_interestRate);
            this.Controls.Add(this.lbl_numberOfMonths);
            this.Controls.Add(this.lbl_loanAmount);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_finalValue);
            this.Controls.Add(this.txt_finalValue);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_finalValue;
        private System.Windows.Forms.Label lbl_finalValue;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_loanAmount;
        private System.Windows.Forms.Label lbl_numberOfMonths;
        private System.Windows.Forms.Label lbl_interestRate;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_numberOfMonths;
        private System.Windows.Forms.TextBox txt_interestRate;
    }
}

