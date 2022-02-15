namespace SquareCalculator
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
            this.btn_calculator = new System.Windows.Forms.Button();
            this.label_lowerLimit = new System.Windows.Forms.Label();
            this.label_upperLimit = new System.Windows.Forms.Label();
            this.txt_lowerLimit = new System.Windows.Forms.TextBox();
            this.txt_upperLimit = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_countBy = new System.Windows.Forms.Label();
            this.txt_countBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(45, 12);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(89, 49);
            this.btn_calculator.TabIndex = 0;
            this.btn_calculator.Text = "Calculator";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // label_lowerLimit
            // 
            this.label_lowerLimit.AutoSize = true;
            this.label_lowerLimit.Location = new System.Drawing.Point(158, 15);
            this.label_lowerLimit.Name = "label_lowerLimit";
            this.label_lowerLimit.Size = new System.Drawing.Size(72, 16);
            this.label_lowerLimit.TabIndex = 1;
            this.label_lowerLimit.Text = "Lower limit:";
            // 
            // label_upperLimit
            // 
            this.label_upperLimit.AutoSize = true;
            this.label_upperLimit.Location = new System.Drawing.Point(156, 45);
            this.label_upperLimit.Name = "label_upperLimit";
            this.label_upperLimit.Size = new System.Drawing.Size(74, 16);
            this.label_upperLimit.TabIndex = 2;
            this.label_upperLimit.Text = "Upper limit:";
            // 
            // txt_lowerLimit
            // 
            this.txt_lowerLimit.Location = new System.Drawing.Point(236, 9);
            this.txt_lowerLimit.Name = "txt_lowerLimit";
            this.txt_lowerLimit.Size = new System.Drawing.Size(111, 22);
            this.txt_lowerLimit.TabIndex = 3;
            this.txt_lowerLimit.Text = "3";
            // 
            // txt_upperLimit
            // 
            this.txt_upperLimit.Location = new System.Drawing.Point(236, 39);
            this.txt_upperLimit.Name = "txt_upperLimit";
            this.txt_upperLimit.Size = new System.Drawing.Size(111, 22);
            this.txt_upperLimit.TabIndex = 4;
            this.txt_upperLimit.Text = "12";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(45, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 468);
            this.listBox1.TabIndex = 5;
            // 
            // lbl_countBy
            // 
            this.lbl_countBy.AutoSize = true;
            this.lbl_countBy.Location = new System.Drawing.Point(388, 15);
            this.lbl_countBy.Name = "lbl_countBy";
            this.lbl_countBy.Size = new System.Drawing.Size(62, 16);
            this.lbl_countBy.TabIndex = 6;
            this.lbl_countBy.Text = "Count by:";
            // 
            // txt_countBy
            // 
            this.txt_countBy.Location = new System.Drawing.Point(468, 9);
            this.txt_countBy.Name = "txt_countBy";
            this.txt_countBy.Size = new System.Drawing.Size(100, 22);
            this.txt_countBy.TabIndex = 7;
            this.txt_countBy.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 555);
            this.Controls.Add(this.txt_countBy);
            this.Controls.Add(this.lbl_countBy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_upperLimit);
            this.Controls.Add(this.txt_lowerLimit);
            this.Controls.Add(this.label_upperLimit);
            this.Controls.Add(this.label_lowerLimit);
            this.Controls.Add(this.btn_calculator);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.Label label_lowerLimit;
        private System.Windows.Forms.Label label_upperLimit;
        private System.Windows.Forms.TextBox txt_lowerLimit;
        private System.Windows.Forms.TextBox txt_upperLimit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_countBy;
        private System.Windows.Forms.TextBox txt_countBy;
    }
}

