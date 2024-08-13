namespace EmployeeManagementSystem
{
    partial class Attendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.dailyPanel = new System.Windows.Forms.Panel();
            this.leavePanel = new System.Windows.Forms.Panel();
            this.fullDayRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDayRadioButton = new System.Windows.Forms.RadioButton();
            this.leaveReasonTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.leaveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LeaveInsert = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.leaveempID = new System.Windows.Forms.TextBox();
            this.button3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.picktimeOut = new System.Windows.Forms.DateTimePicker();
            this.pickTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.monthPanel = new System.Windows.Forms.Panel();
            this.leaveDaysTextBox = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.siticoneDataGridView1 = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.attendanceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataSet1 = new EmployeeManagementSystem.employeeDataSet();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dailyPanel.SuspendLayout();
            this.leavePanel.SuspendLayout();
            this.monthPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyPanel
            // 
            this.dailyPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dailyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyPanel.Controls.Add(this.button3);
            this.dailyPanel.Controls.Add(this.label7);
            this.dailyPanel.Controls.Add(this.picktimeOut);
            this.dailyPanel.Controls.Add(this.pickTimeIn);
            this.dailyPanel.Controls.Add(this.label13);
            this.dailyPanel.Controls.Add(this.pickDate);
            this.dailyPanel.Controls.Add(this.label12);
            this.dailyPanel.Controls.Add(this.label11);
            this.dailyPanel.Controls.Add(this.label10);
            this.dailyPanel.Controls.Add(this.label9);
            this.dailyPanel.Controls.Add(this.empID);
            this.dailyPanel.Location = new System.Drawing.Point(23, 154);
            this.dailyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dailyPanel.Name = "dailyPanel";
            this.dailyPanel.Size = new System.Drawing.Size(401, 522);
            this.dailyPanel.TabIndex = 17;
            // 
            // leavePanel
            // 
            this.leavePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leavePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leavePanel.Controls.Add(this.fullDayRadioButton);
            this.leavePanel.Controls.Add(this.halfDayRadioButton);
            this.leavePanel.Controls.Add(this.leaveReasonTextBox);
            this.leavePanel.Controls.Add(this.label20);
            this.leavePanel.Controls.Add(this.label21);
            this.leavePanel.Controls.Add(this.label22);
            this.leavePanel.Controls.Add(this.leaveDatePicker);
            this.leavePanel.Controls.Add(this.LeaveInsert);
            this.leavePanel.Controls.Add(this.label23);
            this.leavePanel.Controls.Add(this.label24);
            this.leavePanel.Controls.Add(this.leaveempID);
            this.leavePanel.Location = new System.Drawing.Point(453, 243);
            this.leavePanel.Margin = new System.Windows.Forms.Padding(4);
            this.leavePanel.Name = "leavePanel";
            this.leavePanel.Size = new System.Drawing.Size(401, 525);
            this.leavePanel.TabIndex = 18;
            // 
            // fullDayRadioButton
            // 
            this.fullDayRadioButton.AutoSize = true;
            this.fullDayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullDayRadioButton.Location = new System.Drawing.Point(208, 370);
            this.fullDayRadioButton.Name = "fullDayRadioButton";
            this.fullDayRadioButton.Size = new System.Drawing.Size(82, 22);
            this.fullDayRadioButton.TabIndex = 17;
            this.fullDayRadioButton.TabStop = true;
            this.fullDayRadioButton.Text = "Full Day";
            this.fullDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // halfDayRadioButton
            // 
            this.halfDayRadioButton.AutoSize = true;
            this.halfDayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfDayRadioButton.Location = new System.Drawing.Point(76, 370);
            this.halfDayRadioButton.Name = "halfDayRadioButton";
            this.halfDayRadioButton.Size = new System.Drawing.Size(85, 22);
            this.halfDayRadioButton.TabIndex = 16;
            this.halfDayRadioButton.TabStop = true;
            this.halfDayRadioButton.Text = "Half Day";
            this.halfDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // leaveReasonTextBox
            // 
            this.leaveReasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveReasonTextBox.Location = new System.Drawing.Point(221, 257);
            this.leaveReasonTextBox.Multiline = true;
            this.leaveReasonTextBox.Name = "leaveReasonTextBox";
            this.leaveReasonTextBox.Size = new System.Drawing.Size(132, 69);
            this.leaveReasonTextBox.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 258);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 18);
            this.label20.TabIndex = 14;
            this.label20.Text = "Reason";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(44, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 24);
            this.label21.TabIndex = 13;
            this.label21.Text = "Leave";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(35, 158);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 18);
            this.label22.TabIndex = 9;
            this.label22.Text = "Enter Employ Detail";
            // 
            // leaveDatePicker
            // 
            this.leaveDatePicker.CustomFormat = "yyyy:mm:dd";
            this.leaveDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.leaveDatePicker.Location = new System.Drawing.Point(221, 90);
            this.leaveDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.leaveDatePicker.Name = "leaveDatePicker";
            this.leaveDatePicker.Size = new System.Drawing.Size(129, 22);
            this.leaveDatePicker.TabIndex = 10;
            // 
            // LeaveInsert
            // 
            this.LeaveInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.LeaveInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeaveInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveInsert.ForeColor = System.Drawing.Color.White;
            this.LeaveInsert.Location = new System.Drawing.Point(245, 437);
            this.LeaveInsert.Margin = new System.Windows.Forms.Padding(4);
            this.LeaveInsert.Name = "LeaveInsert";
            this.LeaveInsert.Size = new System.Drawing.Size(100, 28);
            this.LeaveInsert.TabIndex = 7;
            this.LeaveInsert.Text = "Insert";
            this.LeaveInsert.UseVisualStyleBackColor = false;
            this.LeaveInsert.Click += new System.EventHandler(this.LeaveInsert_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(53, 90);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 18);
            this.label23.TabIndex = 6;
            this.label23.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(44, 207);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 18);
            this.label24.TabIndex = 5;
            this.label24.Text = "Employee ID";
            // 
            // leaveempID
            // 
            this.leaveempID.Location = new System.Drawing.Point(221, 206);
            this.leaveempID.Margin = new System.Windows.Forms.Padding(4);
            this.leaveempID.Name = "leaveempID";
            this.leaveempID.Size = new System.Drawing.Size(132, 22);
            this.leaveempID.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.CheckedState.Parent = this.button3;
            this.button3.CustomImages.Parent = this.button3;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.HoveredState.Parent = this.button3;
            this.button3.Location = new System.Drawing.Point(245, 434);
            this.button3.Name = "button3";
            this.button3.ShadowDecoration.Parent = this.button3;
            this.button3.Size = new System.Drawing.Size(119, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "Insert";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Daily Attendence";
            // 
            // picktimeOut
            // 
            this.picktimeOut.CustomFormat = "yyyy:mm:dd";
            this.picktimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.picktimeOut.Location = new System.Drawing.Point(208, 328);
            this.picktimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.picktimeOut.Name = "picktimeOut";
            this.picktimeOut.Size = new System.Drawing.Size(156, 22);
            this.picktimeOut.TabIndex = 12;
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.CustomFormat = "yyyy:mm:dd";
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(208, 272);
            this.pickTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(156, 22);
            this.pickTimeIn.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Enter Employ Detail";
            // 
            // pickDate
            // 
            this.pickDate.CustomFormat = "yyyy:mm:dd";
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate.Location = new System.Drawing.Point(205, 102);
            this.pickDate.Margin = new System.Windows.Forms.Padding(4);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(159, 22);
            this.pickDate.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Employee ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Time Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Time In";
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(205, 224);
            this.empID.Margin = new System.Windows.Forms.Padding(4);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(159, 22);
            this.empID.TabIndex = 0;
            // 
            // monthPanel
            // 
            this.monthPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthPanel.Controls.Add(this.leaveDaysTextBox);
            this.monthPanel.Controls.Add(this.label19);
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
            this.monthPanel.Location = new System.Drawing.Point(741, 219);
            this.monthPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monthPanel.Name = "monthPanel";
            this.monthPanel.Size = new System.Drawing.Size(401, 522);
            this.monthPanel.TabIndex = 14;
            // 
            // leaveDaysTextBox
            // 
            this.leaveDaysTextBox.AutoSize = true;
            this.leaveDaysTextBox.Location = new System.Drawing.Point(315, 268);
            this.leaveDaysTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leaveDaysTextBox.Name = "leaveDaysTextBox";
            this.leaveDaysTextBox.Size = new System.Drawing.Size(21, 16);
            this.leaveDaysTextBox.TabIndex = 18;
            this.leaveDaysTextBox.Text = "00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(55, 267);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = "Total Leave Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Monthly Detail";
            // 
            // monthYearPick
            // 
            this.monthYearPick.CustomFormat = "MM/yyyy";
            this.monthYearPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthYearPick.Location = new System.Drawing.Point(255, 86);
            this.monthYearPick.Margin = new System.Windows.Forms.Padding(4);
            this.monthYearPick.Name = "monthYearPick";
            this.monthYearPick.Size = new System.Drawing.Size(99, 22);
            this.monthYearPick.TabIndex = 14;
            // 
            // OT
            // 
            this.OT.AutoSize = true;
            this.OT.Location = new System.Drawing.Point(315, 233);
            this.OT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(21, 16);
            this.OT.TabIndex = 12;
            this.OT.Text = "00";
            // 
            // workHours
            // 
            this.workHours.AutoSize = true;
            this.workHours.Location = new System.Drawing.Point(315, 199);
            this.workHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workHours.Name = "workHours";
            this.workHours.Size = new System.Drawing.Size(21, 16);
            this.workHours.TabIndex = 11;
            this.workHours.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Overtime Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Work Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Work Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year and Month";
            // 
            // empSearchId
            // 
            this.empSearchId.Location = new System.Drawing.Point(187, 315);
            this.empSearchId.Margin = new System.Windows.Forms.Padding(4);
            this.empSearchId.Name = "empSearchId";
            this.empSearchId.Size = new System.Drawing.Size(164, 22);
            this.empSearchId.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(255, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.monthBtn);
            this.panel2.Controls.Add(this.dailyBtn);
            this.panel2.Location = new System.Drawing.Point(23, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 123);
            this.panel2.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(429, 19);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "Leave";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // monthBtn
            // 
            this.monthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.monthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBtn.ForeColor = System.Drawing.Color.White;
            this.monthBtn.Location = new System.Drawing.Point(829, 19);
            this.monthBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(237, 81);
            this.monthBtn.TabIndex = 3;
            this.monthBtn.Text = "Monthy Attendence";
            this.monthBtn.UseVisualStyleBackColor = false;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dailyBtn
            // 
            this.dailyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dailyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyBtn.ForeColor = System.Drawing.Color.White;
            this.dailyBtn.Location = new System.Drawing.Point(39, 19);
            this.dailyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(204, 81);
            this.dailyBtn.TabIndex = 2;
            this.dailyBtn.Text = "Daily Attendence";
            this.dailyBtn.UseVisualStyleBackColor = false;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView1.AutoGenerateColumns = false;
            this.siticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siticoneDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.siticoneDataGridView1.ColumnHeadersHeight = 27;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.attendancedateDataGridViewTextBoxColumn,
            this.timeinDataGridViewTextBoxColumn,
            this.timeoutDataGridViewTextBoxColumn});
            this.siticoneDataGridView1.DataMember = "attendance";
            this.siticoneDataGridView1.DataSource = this.employeeDataSet1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.siticoneDataGridView1.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(434, 154);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 24;
            this.siticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(708, 522);
            this.siticoneDataGridView1.TabIndex = 18;
            this.siticoneDataGridView1.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // attendanceidDataGridViewTextBoxColumn
            // 
            this.attendanceidDataGridViewTextBoxColumn.DataPropertyName = "attendance_id";
            this.attendanceidDataGridViewTextBoxColumn.HeaderText = "attendance_id";
            this.attendanceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceidDataGridViewTextBoxColumn.Name = "attendanceidDataGridViewTextBoxColumn";
            this.attendanceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            // 
            // attendancedateDataGridViewTextBoxColumn
            // 
            this.attendancedateDataGridViewTextBoxColumn.DataPropertyName = "attendance_date";
            this.attendancedateDataGridViewTextBoxColumn.HeaderText = "attendance_date";
            this.attendancedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendancedateDataGridViewTextBoxColumn.Name = "attendancedateDataGridViewTextBoxColumn";
            // 
            // timeinDataGridViewTextBoxColumn
            // 
            this.timeinDataGridViewTextBoxColumn.DataPropertyName = "time_in";
            this.timeinDataGridViewTextBoxColumn.HeaderText = "time_in";
            this.timeinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeinDataGridViewTextBoxColumn.Name = "timeinDataGridViewTextBoxColumn";
            // 
            // timeoutDataGridViewTextBoxColumn
            // 
            this.timeoutDataGridViewTextBoxColumn.DataPropertyName = "time_out";
            this.timeoutDataGridViewTextBoxColumn.HeaderText = "time_out";
            this.timeoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeoutDataGridViewTextBoxColumn.Name = "timeoutDataGridViewTextBoxColumn";
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "employeeDataSet";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT attendance.*\r\nFROM     attendance";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = resources.GetString("sqlConnection1.ConnectionString");
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@employee_id", System.Data.SqlDbType.VarChar, 0, "employee_id"),
            new System.Data.SqlClient.SqlParameter("@attendance_date", System.Data.SqlDbType.DateTime, 0, "attendance_date"),
            new System.Data.SqlClient.SqlParameter("@time_in", System.Data.SqlDbType.DateTime, 0, "time_in"),
            new System.Data.SqlClient.SqlParameter("@time_out", System.Data.SqlDbType.DateTime, 0, "time_out")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@employee_id", System.Data.SqlDbType.VarChar, 0, "employee_id"),
            new System.Data.SqlClient.SqlParameter("@attendance_date", System.Data.SqlDbType.DateTime, 0, "attendance_date"),
            new System.Data.SqlClient.SqlParameter("@time_in", System.Data.SqlDbType.DateTime, 0, "time_in"),
            new System.Data.SqlClient.SqlParameter("@time_out", System.Data.SqlDbType.DateTime, 0, "time_out"),
            new System.Data.SqlClient.SqlParameter("@Original_attendance_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "attendance_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_attendance_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "attendance_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_time_in", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time_in", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_time_out", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time_out", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@attendance_id", System.Data.SqlDbType.Int, 4, "attendance_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_attendance_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "attendance_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_attendance_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "attendance_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_time_in", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time_in", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_time_out", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time_out", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "attendance", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("attendance_id", "attendance_id"),
                        new System.Data.Common.DataColumnMapping("employee_id", "employee_id"),
                        new System.Data.Common.DataColumnMapping("attendance_date", "attendance_date"),
                        new System.Data.Common.DataColumnMapping("time_in", "time_in"),
                        new System.Data.Common.DataColumnMapping("time_out", "time_out")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leavePanel);
            this.Controls.Add(this.monthPanel);
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.dailyPanel);
            this.Controls.Add(this.panel2);
            this.Name = "Attendence";
            this.Size = new System.Drawing.Size(1167, 695);
            this.dailyPanel.ResumeLayout(false);
            this.dailyPanel.PerformLayout();
            this.leavePanel.ResumeLayout(false);
            this.leavePanel.PerformLayout();
            this.monthPanel.ResumeLayout(false);
            this.monthPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dailyPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker picktimeOut;
        private System.Windows.Forms.DateTimePicker pickTimeIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Panel monthPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker monthYearPick;
        private System.Windows.Forms.Label OT;
        private System.Windows.Forms.Label workHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empSearchId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dailyBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton button3;
        private System.Windows.Forms.Panel leavePanel;
        private System.Windows.Forms.RadioButton fullDayRadioButton;
        private System.Windows.Forms.RadioButton halfDayRadioButton;
        private System.Windows.Forms.TextBox leaveReasonTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker leaveDatePicker;
        private System.Windows.Forms.Button LeaveInsert;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox leaveempID;
        private System.Windows.Forms.Label leaveDaysTextBox;
        private System.Windows.Forms.Label label19;
        private Siticone.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private employeeDataSet employeeDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutDataGridViewTextBoxColumn;
    }
}
