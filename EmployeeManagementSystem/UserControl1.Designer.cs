namespace EmployeeManagementSystem
{
    partial class attendence_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.monthYearPick = new System.Windows.Forms.DateTimePicker();
            this.OT = new System.Windows.Forms.Label();
            this.workHours = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empSearchId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dailyPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.picktimeOut = new System.Windows.Forms.DateTimePicker();
            this.pickTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.monthPanel.SuspendLayout();
            this.dailyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthPanel
            // 
            this.monthPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthPanel.Controls.Add(this.label8);
            this.monthPanel.Controls.Add(this.monthYearPick);
            this.monthPanel.Controls.Add(this.OT);
            this.monthPanel.Controls.Add(this.workHours);
            this.monthPanel.Controls.Add(this.label6);
            this.monthPanel.Controls.Add(this.label5);
            this.monthPanel.Controls.Add(this.label4);
            this.monthPanel.Controls.Add(this.label3);
            this.monthPanel.Controls.Add(this.label2);
            this.monthPanel.Controls.Add(this.label1);
            this.monthPanel.Controls.Add(this.empSearchId);
            this.monthPanel.Controls.Add(this.button2);
            this.monthPanel.Location = new System.Drawing.Point(16, 126);
            this.monthPanel.Name = "monthPanel";
            this.monthPanel.Size = new System.Drawing.Size(306, 427);
            this.monthPanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Monthly Detail";
            // 
            // monthYearPick
            // 
            this.monthYearPick.CustomFormat = "MM/yyyy";
            this.monthYearPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthYearPick.Location = new System.Drawing.Point(191, 70);
            this.monthYearPick.Name = "monthYearPick";
            this.monthYearPick.Size = new System.Drawing.Size(75, 20);
            this.monthYearPick.TabIndex = 14;
            // 
            // OT
            // 
            this.OT.AutoSize = true;
            this.OT.Location = new System.Drawing.Point(236, 189);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(19, 13);
            this.OT.TabIndex = 12;
            this.OT.Text = "00";
            // 
            // workHours
            // 
            this.workHours.AutoSize = true;
            this.workHours.Location = new System.Drawing.Point(236, 162);
            this.workHours.Name = "workHours";
            this.workHours.Size = new System.Drawing.Size(19, 13);
            this.workHours.TabIndex = 11;
            this.workHours.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Overtime Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Work Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Work Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year and Month";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empSearchId
            // 
            this.empSearchId.Location = new System.Drawing.Point(140, 256);
            this.empSearchId.Name = "empSearchId";
            this.empSearchId.Size = new System.Drawing.Size(124, 20);
            this.empSearchId.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dailyPanel
            // 
            this.dailyPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dailyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyPanel.Controls.Add(this.label7);
            this.dailyPanel.Controls.Add(this.picktimeOut);
            this.dailyPanel.Controls.Add(this.pickTimeIn);
            this.dailyPanel.Controls.Add(this.label13);
            this.dailyPanel.Controls.Add(this.pickDate);
            this.dailyPanel.Controls.Add(this.button3);
            this.dailyPanel.Controls.Add(this.label12);
            this.dailyPanel.Controls.Add(this.label11);
            this.dailyPanel.Controls.Add(this.label10);
            this.dailyPanel.Controls.Add(this.label9);
            this.dailyPanel.Controls.Add(this.empID);
            this.dailyPanel.Location = new System.Drawing.Point(16, 124);
            this.dailyPanel.Name = "dailyPanel";
            this.dailyPanel.Size = new System.Drawing.Size(306, 427);
            this.dailyPanel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Daily Attendence";
            // 
            // picktimeOut
            // 
            this.picktimeOut.CustomFormat = "yyyy:mm:dd";
            this.picktimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.picktimeOut.Location = new System.Drawing.Point(156, 246);
            this.picktimeOut.Name = "picktimeOut";
            this.picktimeOut.Size = new System.Drawing.Size(98, 20);
            this.picktimeOut.TabIndex = 12;
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.CustomFormat = "yyyy:mm:dd";
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(156, 201);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(98, 20);
            this.pickTimeIn.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 14);
            this.label13.TabIndex = 9;
            this.label13.Text = "Enter Employ Detail";
            // 
            // pickDate
            // 
            this.pickDate.CustomFormat = "yyyy:mm:dd";
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate.Location = new System.Drawing.Point(166, 73);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(98, 20);
            this.pickDate.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(184, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 14);
            this.label12.TabIndex = 6;
            this.label12.Text = "Date";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "Employee ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "Time Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Time In";
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(154, 162);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(100, 20);
            this.empID.TabIndex = 0;
            this.empID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.monthBtn);
            this.panel2.Controls.Add(this.dailyBtn);
            this.panel2.Location = new System.Drawing.Point(16, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 106);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(322, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Absence";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // monthBtn
            // 
            this.monthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.monthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBtn.ForeColor = System.Drawing.Color.White;
            this.monthBtn.Location = new System.Drawing.Point(622, 21);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(178, 66);
            this.monthBtn.TabIndex = 3;
            this.monthBtn.Text = "Monthy Attendence";
            this.monthBtn.UseVisualStyleBackColor = false;
            this.monthBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // dailyBtn
            // 
            this.dailyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dailyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyBtn.ForeColor = System.Drawing.Color.White;
            this.dailyBtn.Location = new System.Drawing.Point(29, 21);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(153, 66);
            this.dailyBtn.TabIndex = 2;
            this.dailyBtn.Text = "Daily Attendence";
            this.dailyBtn.UseVisualStyleBackColor = false;
            this.dailyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // attendence_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dailyPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthPanel);
            this.Controls.Add(this.panel2);
            this.Name = "attendence_Control";
            this.Size = new System.Drawing.Size(875, 565);
            this.Load += new System.EventHandler(this.attendence_Control_Load);
            this.monthPanel.ResumeLayout(false);
            this.monthPanel.PerformLayout();
            this.dailyPanel.ResumeLayout(false);
            this.dailyPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel monthPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox empSearchId;
        private System.Windows.Forms.Label OT;
        private System.Windows.Forms.Label workHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel dailyPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.DateTimePicker pickTimeIn;
        private System.Windows.Forms.DateTimePicker picktimeOut;
        private System.Windows.Forms.DateTimePicker monthYearPick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
