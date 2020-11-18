namespace CalorieCounter
{
    partial class CalorieCounter
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.restartWeek = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.foodName = new System.Windows.Forms.TextBox();
            this.foodServings = new System.Windows.Forms.TextBox();
            this.carbs = new System.Windows.Forms.TextBox();
            this.protein = new System.Windows.Forms.TextBox();
            this.fat = new System.Windows.Forms.TextBox();
            this.totalCalories = new System.Windows.Forms.TextBox();
            this.sunday = new System.Windows.Forms.TextBox();
            this.monday = new System.Windows.Forms.TextBox();
            this.tuesday = new System.Windows.Forms.TextBox();
            this.wednesday = new System.Windows.Forms.TextBox();
            this.thursday = new System.Windows.Forms.TextBox();
            this.friday = new System.Windows.Forms.TextBox();
            this.saturday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CalorieCheck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(201, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "by TrailBlazers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(99, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(41, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(103, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Protein";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(24, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carbs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(165, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Servings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(104, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(133, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Monday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(32, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sunday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(335, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wednesday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(250, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tuesday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(95, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Thursday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label14.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(211, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Friday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(309, 535);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Saturday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Highlight;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(131, 438);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "Weekly Rundown";
            // 
            // restartWeek
            // 
            this.restartWeek.AutoSize = true;
            this.restartWeek.BackColor = System.Drawing.SystemColors.Highlight;
            this.restartWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restartWeek.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartWeek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restartWeek.Location = new System.Drawing.Point(169, 589);
            this.restartWeek.Name = "restartWeek";
            this.restartWeek.Size = new System.Drawing.Size(113, 18);
            this.restartWeek.TabIndex = 16;
            this.restartWeek.Text = "Start a New Week";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(197, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 18);
            this.label18.TabIndex = 17;
            this.label18.Text = "Fat";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Highlight;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(77, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "Nutrition";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(214, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 8);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Highlight;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(66, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 23);
            this.label20.TabIndex = 21;
            this.label20.Text = "Total Calories";
            // 
            // foodName
            // 
            this.foodName.Location = new System.Drawing.Point(12, 213);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(100, 20);
            this.foodName.TabIndex = 22;
            // 
            // foodServings
            // 
            this.foodServings.Location = new System.Drawing.Point(141, 213);
            this.foodServings.Name = "foodServings";
            this.foodServings.Size = new System.Drawing.Size(100, 20);
            this.foodServings.TabIndex = 23;
            // 
            // carbs
            // 
            this.carbs.Location = new System.Drawing.Point(24, 317);
            this.carbs.Name = "carbs";
            this.carbs.Size = new System.Drawing.Size(44, 20);
            this.carbs.TabIndex = 24;
            // 
            // protein
            // 
            this.protein.Location = new System.Drawing.Point(103, 317);
            this.protein.Name = "protein";
            this.protein.Size = new System.Drawing.Size(52, 20);
            this.protein.TabIndex = 25;
            // 
            // fat
            // 
            this.fat.Location = new System.Drawing.Point(196, 317);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(45, 20);
            this.fat.TabIndex = 26;
            // 
            // totalCalories
            // 
            this.totalCalories.Location = new System.Drawing.Point(86, 397);
            this.totalCalories.Name = "totalCalories";
            this.totalCalories.Size = new System.Drawing.Size(100, 20);
            this.totalCalories.TabIndex = 27;
            // 
            // sunday
            // 
            this.sunday.Location = new System.Drawing.Point(8, 500);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(100, 20);
            this.sunday.TabIndex = 28;
            // 
            // monday
            // 
            this.monday.Location = new System.Drawing.Point(114, 500);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(100, 20);
            this.monday.TabIndex = 29;
            // 
            // tuesday
            // 
            this.tuesday.Location = new System.Drawing.Point(220, 500);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(100, 20);
            this.tuesday.TabIndex = 30;
            // 
            // wednesday
            // 
            this.wednesday.Location = new System.Drawing.Point(326, 500);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(100, 20);
            this.wednesday.TabIndex = 31;
            // 
            // thursday
            // 
            this.thursday.Location = new System.Drawing.Point(77, 554);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(100, 20);
            this.thursday.TabIndex = 32;
            // 
            // friday
            // 
            this.friday.Location = new System.Drawing.Point(182, 554);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(100, 20);
            this.friday.TabIndex = 33;
            // 
            // saturday
            // 
            this.saturday.Location = new System.Drawing.Point(288, 554);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(100, 20);
            this.saturday.TabIndex = 34;
            // 
            // CalorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalorieCounter.Properties.Resources.caloriecounterbackground2;
            this.ClientSize = new System.Drawing.Size(436, 614);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.totalCalories);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.protein);
            this.Controls.Add(this.carbs);
            this.Controls.Add(this.foodServings);
            this.Controls.Add(this.foodName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.restartWeek);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CalorieCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label restartWeek;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox foodName;
        private System.Windows.Forms.TextBox foodServings;
        private System.Windows.Forms.TextBox carbs;
        private System.Windows.Forms.TextBox protein;
        private System.Windows.Forms.TextBox fat;
        private System.Windows.Forms.TextBox totalCalories;
        private System.Windows.Forms.TextBox sunday;
        private System.Windows.Forms.TextBox monday;
        private System.Windows.Forms.TextBox tuesday;
        private System.Windows.Forms.TextBox wednesday;
        private System.Windows.Forms.TextBox thursday;
        private System.Windows.Forms.TextBox friday;
        private System.Windows.Forms.TextBox saturday;
    }
}

