using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class jobRole : UserControl
    {
        SqlConnection connect
            = new SqlConnection(dataSource.dataString);

        public jobRole()
        {
            InitializeComponent();
            selectJobRole.SelectedIndex = 0;
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJobRoleData(selectJobRole.SelectedItem.ToString());
            LoadDataToFront(selectJobRole.SelectedItem.ToString());
        }

        private void LoadDataToFront(string selectedJobRole)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectQuery = "SELECT basic_salary, EPF, ETF, overtime_per_hour FROM job_roles WHERE role_des = @selectedJobRole";
                    SqlCommand command = new SqlCommand(selectQuery, connect);
                    command.Parameters.AddWithValue("@selectedJobRole", selectedJobRole);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal basicSalaryVar = decimal.Parse(reader["basic_salary"].ToString());
                        decimal EPFVar = decimal.Parse(reader["EPF"].ToString());
                        decimal netSalary = basicSalaryVar - EPFVar;

                        basicSalary.Text = reader["basic_salary"].ToString();
                        EPF.Text = reader["EPF"].ToString();
                        ETF.Text = reader["ETF"].ToString();
                        OT.Text = reader["overtime_per_hour"].ToString();
                        NET.Text = netSalary.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected job role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void LoadJobRoleData(string selectedJobRole)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectQuery = "SELECT basic_salary, EPF, ETF, overtime_per_hour FROM job_roles WHERE role_des = @selectedJobRole";
                    SqlCommand command = new SqlCommand(selectQuery, connect);
                    command.Parameters.AddWithValue("@selectedJobRole", selectedJobRole);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        basicSalaryInput.Text = reader["basic_salary"].ToString();
                        EPFInput.Text = reader["EPF"].ToString();
                        ETFInput.Text = reader["ETF"].ToString();
                        OTInput.Text = reader["overtime_per_hour"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected job role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            salaryPanel.Visible = false;
            salaryUpdatePanel.Visible = true;

            LoadJobRoleData(selectJobRole.SelectedItem.ToString());
        }

        private void jobRole_Load(object sender, EventArgs e)
        {
            salaryPanel.Visible = true;
            salaryUpdatePanel.Visible = false;
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            if (basicSalaryInput.Text == "" || EPFInput.Text == "" || ETFInput.Text == "" || OTInput.Text == "")
            {
                MessageBox.Show("Please enter missing fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // Update query
                        string updateQuery = "UPDATE job_roles SET basic_salary = @basicSalary, EPF = @EPF, ETF = @ETF, overtime_per_hour = @OT WHERE role_des = @selectedJobRole";
                     
                        SqlCommand command = new SqlCommand(updateQuery, connect);
                        
                        command.Parameters.AddWithValue("@basicSalary", basicSalaryInput.Text);
                        command.Parameters.AddWithValue("@EPF", EPFInput.Text);
                        command.Parameters.AddWithValue("@ETF", ETFInput.Text);
                        command.Parameters.AddWithValue("@OT", OTInput.Text);
                        command.Parameters.AddWithValue("@selectedJobRole", selectJobRole.SelectedItem.ToString());

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error updating data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void SalaryInputChange(object sender, EventArgs e)
        {

        }
    }
}
