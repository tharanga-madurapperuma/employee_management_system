using MySql.Data.MySqlClient;
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
    public partial class attendence_Control : UserControl
    {
        public attendence_Control()
        {
            InitializeComponent();
        }


        SqlConnection connect
                           = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        private void attendence_Control_Load(object sender, EventArgs e)
        {
            dailyPanel.Visible = true;
            monthPanel.Visible = false;
            LoaddataGridView2();

        }

        private void ShowPanel(Panel panelToShow)
        {
            monthPanel.Visible = false;
            dailyPanel.Visible = false;
            

            panelToShow.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(dailyPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPanel(monthPanel);
            UpdateAllWorkHours();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (empID.Text == "")
            {
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        
                        string selectQuery = "SELECT COUNT(*) FROM attendance WHERE employee_id = @employeeId AND attendance_date = @date";
                        using (SqlCommand checkRecord = new SqlCommand(selectQuery, connect))
                        {
                            checkRecord.Parameters.AddWithValue("@employeeId", empID.Text.Trim());
                            checkRecord.Parameters.AddWithValue("@date", pickDate.Value.Date);

                            int count = Convert.ToInt32(checkRecord.ExecuteScalar());

                            if (count >= 1)
                            {
                                MessageBox.Show("Record for employee ID " + empID.Text + " on " + pickDate.Value + " already exists.",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {


                                
                                string insertQuery = "INSERT INTO attendance (employee_id, attendance_date, time_in, time_out) VALUES (@employeeId, @date, @timeIn, @timeOut)";
                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeId", empID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", pickDate.Value);
                                    cmd.Parameters.AddWithValue("@timeIn", pickTimeIn.Value); 
                                    cmd.Parameters.AddWithValue("@timeOut", picktimeOut.Value); 

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Record added successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dataGridView2.Update();
                                        dataGridView2.Refresh();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
            


        }




        private void button2_Click(object sender, EventArgs e)
            
        {
            if (empSearchId.Text == "")
            {
                MessageBox.Show("Please enter Employee ID","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string employeeId = empSearchId.Text; // Use empID.Text for consistency
                    int year = monthYearPick.Value.Year; // Correct variable name
                    int month = monthYearPick.Value.Month; // Correct variable name

                    SearchWorkHours(employeeId, year, month);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid Employee ID format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void updateDB_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateAllWorkHours()
        {
            string selectEmployeesQuery = @"
        SELECT DISTINCT 
            employee_id, 
            DATEPART(YEAR, attendance_date) AS year, 
            DATEPART(MONTH, attendance_date) AS month
        FROM attendance;";

            string selectWorkHoursQuery = @"
        SELECT 
            SUM(DATEDIFF(MINUTE, time_in, time_out)) / 60.0 AS total_work_hours
        FROM 
            attendance
        WHERE 
            employee_id = @employeeId
            AND DATEPART(YEAR, attendance_date) = @year
            AND DATEPART(MONTH, attendance_date) = @month
        GROUP BY 
            employee_id;";

            string updateOrInsertQuery = @"
        IF EXISTS (SELECT 1 FROM work_hours WHERE employee_id = @employeeId AND DATEPART(YEAR, month) = @year AND DATEPART(MONTH, month) = @month)
        BEGIN
            UPDATE work_hours
            SET total_work_hours = @totalWorkHours
            WHERE employee_id = @employeeId AND DATEPART(YEAR, month) = @year AND DATEPART(MONTH, month) = @month;
        END
        ELSE
        BEGIN
            INSERT INTO work_hours (employee_id, month, total_work_hours)
            VALUES (@employeeId, @date, @totalWorkHours);
        END;";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve all unique employee IDs and months
                    using (SqlCommand selectEmployeesCmd = new SqlCommand(selectEmployeesQuery, connection))
                    using (SqlDataReader reader = selectEmployeesCmd.ExecuteReader())
                    {
                        List<Tuple<string, int, int>> employeeMonths = new List<Tuple<string, int, int>>();

                        while (reader.Read())
                        {
                            string employeeId = reader.GetString(0);
                            int year = reader.GetInt32(1);
                            int month = reader.GetInt32(2);
                            employeeMonths.Add(new Tuple<string, int, int>(employeeId, year, month));
                        }

                        reader.Close();

                        // Loop through each employee and month combination to update work hours
                        foreach (var employeeMonth in employeeMonths)
                        {
                            string employeeId = employeeMonth.Item1;
                            int year = employeeMonth.Item2;
                            int month = employeeMonth.Item3;

                            using (SqlCommand selectWorkHoursCmd = new SqlCommand(selectWorkHoursQuery, connection))
                            {
                                selectWorkHoursCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                selectWorkHoursCmd.Parameters.AddWithValue("@year", year);
                                selectWorkHoursCmd.Parameters.AddWithValue("@month", month);

                                using (SqlDataReader workHoursReader = selectWorkHoursCmd.ExecuteReader())
                                {
                                    if (workHoursReader.Read())
                                    {
                                        double totalWorkHours = workHoursReader.IsDBNull(0) ? 0.0 : Convert.ToDouble(workHoursReader.GetDecimal(0));
                                        DateTime monthDate = new DateTime(year, month, 1);

                                        workHoursReader.Close(); // Close the reader before executing another command

                                        using (SqlCommand updateOrInsertCmd = new SqlCommand(updateOrInsertQuery, connection))
                                        {
                                            updateOrInsertCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                            updateOrInsertCmd.Parameters.AddWithValue("@year", year);
                                            updateOrInsertCmd.Parameters.AddWithValue("@month", month);
                                            updateOrInsertCmd.Parameters.AddWithValue("@totalWorkHours", totalWorkHours);
                                            updateOrInsertCmd.Parameters.AddWithValue("@date", monthDate);

                                            updateOrInsertCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        workHoursReader.Close(); // Close the reader if no records found
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Work hours updated successfully for all employees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void SearchWorkHours(string employeeId, int year, int month)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30";

            string query = @"
        SELECT 
            total_work_hours, 
            total_ot 
        FROM 
            work_hours 
        WHERE 
            employee_id = @employeeId 
            AND DATEPART(YEAR, month) = @year 
            AND DATEPART(MONTH, month) = @month";

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@month", month);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal totalWorkHours = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                decimal totalOT = 0;

                                if (totalWorkHours > 320)
                                {
                                    totalOT = totalWorkHours - 320;
                                }

                                workHours.Text = totalWorkHours.ToString();
                                OT.Text = totalOT.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No records found for the specified employee and month.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoaddataGridView2()
        {
            try
            {
                string query = "SELECT employee_id, attendance_date, time_in, time_out FROM attendance";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;

                    dataGridView2.Update();
                    dataGridView2.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30";

            
            string query = "SELECT employee_id, attendance_date, time_in, time_out FROM attendance";

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open(); 

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader); 

                            
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dailyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void workHours_Click(object sender, EventArgs e)
        {

        }

        private void OT_Click(object sender, EventArgs e)
        {

        }
    }
}

