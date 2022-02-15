namespace CargoShip2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_cycle = new System.Windows.Forms.TrackBar();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_cycleLabel = new System.Windows.Forms.Label();
            this.label_truckLabel = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.track_truck = new System.Windows.Forms.TrackBar();
            this.label_trainLabel = new System.Windows.Forms.Label();
            this.label_trainCarCount = new System.Windows.Forms.Label();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.label_carLabel = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.track_car = new System.Windows.Forms.TrackBar();
            this.btn_newShip = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_car)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(67, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(177, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 96);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 45;
            // 
            // track_cycle
            // 
            this.track_cycle.Location = new System.Drawing.Point(13, 248);
            this.track_cycle.Name = "track_cycle";
            this.track_cycle.Size = new System.Drawing.Size(271, 56);
            this.track_cycle.TabIndex = 2;
            this.track_cycle.Scroll += new System.EventHandler(this.track_motorCycle_Scroll);
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(140, 216);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(14, 16);
            this.label_cycleCount.TabIndex = 3;
            this.label_cycleCount.Text = "0";
            // 
            // label_cycleLabel
            // 
            this.label_cycleLabel.AutoSize = true;
            this.label_cycleLabel.Location = new System.Drawing.Point(81, 307);
            this.label_cycleLabel.Name = "label_cycleLabel";
            this.label_cycleLabel.Size = new System.Drawing.Size(133, 16);
            this.label_cycleLabel.TabIndex = 4;
            this.label_cycleLabel.Text = "Motor Cycles (3 units)";
            // 
            // label_truckLabel
            // 
            this.label_truckLabel.AutoSize = true;
            this.label_truckLabel.Location = new System.Drawing.Point(434, 307);
            this.label_truckLabel.Name = "label_truckLabel";
            this.label_truckLabel.Size = new System.Drawing.Size(103, 16);
            this.label_truckLabel.TabIndex = 7;
            this.label_truckLabel.Text = "Trucks (11 units)";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(478, 216);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(14, 16);
            this.label_truckCount.TabIndex = 6;
            this.label_truckCount.Text = "0";
            // 
            // track_truck
            // 
            this.track_truck.Location = new System.Drawing.Point(351, 248);
            this.track_truck.Name = "track_truck";
            this.track_truck.Size = new System.Drawing.Size(271, 56);
            this.track_truck.TabIndex = 5;
            this.track_truck.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // label_trainLabel
            // 
            this.label_trainLabel.AutoSize = true;
            this.label_trainLabel.Location = new System.Drawing.Point(423, 436);
            this.label_trainLabel.Name = "label_trainLabel";
            this.label_trainLabel.Size = new System.Drawing.Size(124, 16);
            this.label_trainLabel.TabIndex = 13;
            this.label_trainLabel.Text = "Train Cars (17 units)";
            // 
            // label_trainCarCount
            // 
            this.label_trainCarCount.AutoSize = true;
            this.label_trainCarCount.Location = new System.Drawing.Point(478, 347);
            this.label_trainCarCount.Name = "label_trainCarCount";
            this.label_trainCarCount.Size = new System.Drawing.Size(14, 16);
            this.label_trainCarCount.TabIndex = 12;
            this.label_trainCarCount.Text = "0";
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(351, 377);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(271, 56);
            this.track_trainCars.TabIndex = 11;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // label_carLabel
            // 
            this.label_carLabel.AutoSize = true;
            this.label_carLabel.Location = new System.Drawing.Point(106, 436);
            this.label_carLabel.Name = "label_carLabel";
            this.label_carLabel.Size = new System.Drawing.Size(83, 16);
            this.label_carLabel.TabIndex = 10;
            this.label_carLabel.Text = "Cars (5 units)";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(140, 347);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(14, 16);
            this.label_carCount.TabIndex = 9;
            this.label_carCount.Text = "0";
            // 
            // track_car
            // 
            this.track_car.Location = new System.Drawing.Point(13, 377);
            this.track_car.Name = "track_car";
            this.track_car.Size = new System.Drawing.Size(271, 56);
            this.track_car.TabIndex = 8;
            this.track_car.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // btn_newShip
            // 
            this.btn_newShip.Location = new System.Drawing.Point(26, 483);
            this.btn_newShip.Name = "btn_newShip";
            this.btn_newShip.Size = new System.Drawing.Size(158, 57);
            this.btn_newShip.TabIndex = 14;
            this.btn_newShip.Text = "New Ship";
            this.btn_newShip.UseVisualStyleBackColor = true;
            this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(140, 135);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(179, 16);
            this.label_shipLabel.TabIndex = 15;
            this.label_shipLabel.Text = "Capacity = 0, CurrentLoad = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 566);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.btn_newShip);
            this.Controls.Add(this.label_trainLabel);
            this.Controls.Add(this.label_trainCarCount);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.label_carLabel);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.track_car);
            this.Controls.Add(this.label_truckLabel);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.track_truck);
            this.Controls.Add(this.label_cycleLabel);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.track_cycle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Load the Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_cycle;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_cycleLabel;
        private System.Windows.Forms.Label label_truckLabel;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.TrackBar track_truck;
        private System.Windows.Forms.Label label_trainLabel;
        private System.Windows.Forms.Label label_trainCarCount;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Label label_carLabel;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.TrackBar track_car;
        private System.Windows.Forms.Button btn_newShip;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

