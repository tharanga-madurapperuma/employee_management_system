using EmployeeManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            attendence_Control1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
<<<<<<< HEAD

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            attendence_Control1.Visible = false;



            Dashboard dashForm = dashboard1 as Dashboard;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
            attendence_Control1.Visible = false;

            AddEmployee addEmForm = addEmployee1 as AddEmployee;

            if(addEmForm != null)
            {
                addEmForm.RefreshData();
            }

        }
=======
        
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4

        private void salary_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
<<<<<<< HEAD
           attendence_Control1.Visible = false;
=======
            jobRole1.Visible = false;
            attendence1.Visible = false;
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4

            Salary salaryForm = salary1 as Salary;

            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            jobRole1.Visible = false;
            attendence1.Visible = false;
        }

        private void salary_btn_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
            jobRole1.Visible = false;
            attendence1.Visible = false;
        }

        private void SalaryDetailsButton_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            jobRole1.Visible = true;
        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
            jobRole1.Visible = false;
            attendence1.Visible = false;

            AddEmployee addEmForm = addEmployee1 as AddEmployee;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }

        }

<<<<<<< HEAD
        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
=======
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            jobRole1.Visible = false;
            attendence1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
<<<<<<< HEAD
            attendence_Control1.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendence_Control1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
             
=======

>>>>>>> origin/attendance
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< HEAD

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        
=======
>>>>>>> origin/attendance
=======
            jobRole1.Visible = false;
            attendence1.Visible = true;
        }
>>>>>>> e7738b0b522bfa8911c17f6638a93c37176ce6e4
    }
}
