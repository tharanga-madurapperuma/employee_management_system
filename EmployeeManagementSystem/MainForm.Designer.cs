
namespace EmployeeManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dashboard_btn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.addEmployee_btn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.salary_btn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SalaryDetailsButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attendence1 = new EmployeeManagementSystem.Attendence();
            this.jobRole1 = new EmployeeManagementSystem.jobRole();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.OrangeRed;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(1072, 4);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(4);
            this.exit.Size = new System.Drawing.Size(26, 25);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.siticoneRoundedButton1);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.SalaryDetailsButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 565);
            this.panel2.TabIndex = 1;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.SpringGreen;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(20, 389);
            this.siticoneRoundedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(187, 40);
            this.siticoneRoundedButton1.TabIndex = 11;
            this.siticoneRoundedButton1.Text = "ATTENDENCE";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(16, 80);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 37);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Tharanga";
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.CheckedState.Parent = this.dashboard_btn;
            this.dashboard_btn.CustomImages.Parent = this.dashboard_btn;
            this.dashboard_btn.FillColor = System.Drawing.Color.SpringGreen;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.dashboard_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboard_btn.HoveredState.Parent = this.dashboard_btn;
            this.dashboard_btn.Location = new System.Drawing.Point(20, 200);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.ShadowDecoration.Parent = this.dashboard_btn;
            this.dashboard_btn.Size = new System.Drawing.Size(187, 40);
            this.dashboard_btn.TabIndex = 9;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.CheckedState.Parent = this.addEmployee_btn;
            this.addEmployee_btn.CustomImages.Parent = this.addEmployee_btn;
            this.addEmployee_btn.FillColor = System.Drawing.Color.SpringGreen;
            this.addEmployee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.addEmployee_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addEmployee_btn.HoveredState.Parent = this.addEmployee_btn;
            this.addEmployee_btn.Location = new System.Drawing.Point(20, 342);
            this.addEmployee_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.ShadowDecoration.Parent = this.addEmployee_btn;
            this.addEmployee_btn.Size = new System.Drawing.Size(187, 40);
            this.addEmployee_btn.TabIndex = 8;
            this.addEmployee_btn.Text = "ADD EMPLOYEE";
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.CheckedState.Parent = this.salary_btn;
            this.salary_btn.CustomImages.Parent = this.salary_btn;
            this.salary_btn.FillColor = System.Drawing.Color.SpringGreen;
            this.salary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salary_btn.HoveredState.Parent = this.salary_btn;
            this.salary_btn.Location = new System.Drawing.Point(20, 248);
            this.salary_btn.Margin = new System.Windows.Forms.Padding(2);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.ShadowDecoration.Parent = this.salary_btn;
            this.salary_btn.Size = new System.Drawing.Size(187, 40);
            this.salary_btn.TabIndex = 7;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click_1);
            // 
            // SalaryDetailsButton
            // 
            this.SalaryDetailsButton.CheckedState.Parent = this.SalaryDetailsButton;
            this.SalaryDetailsButton.CustomImages.Parent = this.SalaryDetailsButton;
            this.SalaryDetailsButton.FillColor = System.Drawing.Color.SpringGreen;
            this.SalaryDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryDetailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaryDetailsButton.HoveredState.Parent = this.SalaryDetailsButton;
            this.SalaryDetailsButton.Location = new System.Drawing.Point(20, 295);
            this.SalaryDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryDetailsButton.Name = "SalaryDetailsButton";
            this.SalaryDetailsButton.ShadowDecoration.Parent = this.SalaryDetailsButton;
            this.SalaryDetailsButton.Size = new System.Drawing.Size(187, 40);
            this.SalaryDetailsButton.TabIndex = 7;
            this.SalaryDetailsButton.Text = "SALARY DETAILS";
            this.SalaryDetailsButton.Click += new System.EventHandler(this.SalaryDetailsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(50, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign Out";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.Location = new System.Drawing.Point(11, 517);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.greet_user.Location = new System.Drawing.Point(16, 50);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(111, 26);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome";
            this.greet_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.attendence1);
            this.panel3.Controls.Add(this.jobRole1);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 565);
            this.panel3.TabIndex = 2;
            // 
            // attendence1
            // 
            this.attendence1.Location = new System.Drawing.Point(0, 0);
            this.attendence1.Margin = new System.Windows.Forms.Padding(2);
            this.attendence1.Name = "attendence1";
            this.attendence1.Size = new System.Drawing.Size(873, 558);
            this.attendence1.TabIndex = 4;
            this.attendence1.Load += new System.EventHandler(this.attendence1_Load);
            // 
            // jobRole1
            // 
            this.jobRole1.Location = new System.Drawing.Point(0, 0);
            this.jobRole1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobRole1.Name = "jobRole1";
            this.jobRole1.Size = new System.Drawing.Size(875, 565);
            this.jobRole1.TabIndex = 3;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(875, 565);
            this.dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(875, 565);
            this.addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Margin = new System.Windows.Forms.Padding(4);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(875, 565);
            this.salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private jobRole jobRole1;
        private Siticone.UI.WinForms.SiticoneRoundedButton SalaryDetailsButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton addEmployee_btn;
        private Siticone.UI.WinForms.SiticoneRoundedButton salary_btn;
        private Siticone.UI.WinForms.SiticoneRoundedButton dashboard_btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private EmployeeManagementSystem.Attendence attendence1;
    }
}