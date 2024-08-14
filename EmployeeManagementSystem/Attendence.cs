using Google.Protobuf.WellKnownTypes;
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
    public partial class Attendence : UserControl
    {
        public Attendence()
        {
            InitializeComponent();
        }


        SqlConnection connect
            = new SqlConnection(dataSource.dataString);

        private void attendence_Control_Load(object sender, EventArgs e)
        {
            dailyPanel.Visible = true;
            monthPanel.Visible = false;

        }

        private void ShowPanel(Panel panelToShow)
        {
            monthPanel.Visible = false;
            dailyPanel.Visible = false;
            leavePanel.Visible = false;

            panelToShow.Visible = true;
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

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPanel(leavePanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan timeIn = pickTimeIn.Value.TimeOfDay;
            TimeSpan timeOut = picktimeOut.Value.TimeOfDay;

            // Calculate total working hours
            TimeSpan totalHours = timeOut - timeIn;

            // Calculate OT hours (assuming default working hours are 8 hours)
            TimeSpan otHours = totalHours > TimeSpan.FromHours(8) ? totalHours - TimeSpan.FromHours(8) : TimeSpan.Zero;

            decimal ot = (decimal)otHours.TotalHours;

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

                        // Check if the employee record already exists for the given date
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
                                // Insert the new record into the database
                                string insertQuery = "INSERT INTO attendance (employee_id, attendance_date, time_in, time_out, ot_hours) VALUES (@employeeId, @date, @timeIn, @timeOut, @ot)";
                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeId", empID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", pickDate.Value);
                                    cmd.Parameters.AddWithValue("@timeIn", pickTimeIn.Value);
                                    cmd.Parameters.AddWithValue("@timeOut", picktimeOut.Value);
                                    cmd.Parameters.AddWithValue("@ot", ot); 

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Record added successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    employeeDataSet1.Clear();
                                    sqlDataAdapter1.Fill(employeeDataSet1);
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
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string selectWorkHoursAndOtQuery = @"
        SELECT 
            SUM(DATEDIFF(MINUTE, time_in, time_out)) / 60.0 AS total_work_hours,
            SUM(ot_hours) AS total_ot_hours
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
        SET total_work_hours = @totalWorkHours,
            total_ot = @totalOtHours
        WHERE employee_id = @employeeId AND DATEPART(YEAR, month) = @year AND DATEPART(MONTH, month) = @month;
    END
    ELSE
    BEGIN
        INSERT INTO work_hours (employee_id, month, total_work_hours, total_ot)
        VALUES (@employeeId, @date, @totalWorkHours, @totalOtHours);
    END;";

            string connectionString = dataSource.dataString;

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

                        // Loop through each employee and month combination to update work hours and OT hours
                        foreach (var employeeMonth in employeeMonths)
                        {
                            string employeeId = employeeMonth.Item1;
                            int year = employeeMonth.Item2;
                            int month = employeeMonth.Item3;

                            using (SqlCommand selectWorkHoursAndOtCmd = new SqlCommand(selectWorkHoursAndOtQuery, connection))
                            {
                                selectWorkHoursAndOtCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                selectWorkHoursAndOtCmd.Parameters.AddWithValue("@year", year);
                                selectWorkHoursAndOtCmd.Parameters.AddWithValue("@month", month);

                                using (SqlDataReader workHoursReader = selectWorkHoursAndOtCmd.ExecuteReader())
                                {
                                    if (workHoursReader.Read())
                                    {
                                        double totalWorkHours = workHoursReader.IsDBNull(0) ? 0.0 : Convert.ToDouble(workHoursReader.GetDecimal(0));
                                        double totalOtHours = workHoursReader.IsDBNull(1) ? 0.0 : Convert.ToDouble(workHoursReader.GetDecimal(1));
                                        DateTime monthDate = new DateTime(year, month, 1);

                                        workHoursReader.Close(); // Close the reader before executing another command

                                        using (SqlCommand updateOrInsertCmd = new SqlCommand(updateOrInsertQuery, connection))
                                        {
                                            updateOrInsertCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                            updateOrInsertCmd.Parameters.AddWithValue("@year", year);
                                            updateOrInsertCmd.Parameters.AddWithValue("@month", month);
                                            updateOrInsertCmd.Parameters.AddWithValue("@totalWorkHours", totalWorkHours);
                                            updateOrInsertCmd.Parameters.AddWithValue("@totalOtHours", totalOtHours); // Add total OT hours
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

                    MessageBox.Show("Work hours and OT hours updated successfully for all employees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void SearchWorkHours(string employeeId, int year, int month)
        {
            string connectionString = dataSource.dataString;

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
                                decimal totalOT = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

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

        private void monthBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(monthPanel);
            UpdateAllWorkHours();
            UpdateAllLeaveDays();
            employeeDataSet1.Clear();
            sqlDataAdapter1.Fill(employeeDataSet1);
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(dailyPanel);
        }

        private void LeaveInsert_Click(object sender, EventArgs e)
        {
            string employeeId = leaveempID.Text.Trim();
            DateTime leaveDate = leaveDatePicker.Value.Date;
            double leaveTypeValue = GetLeaveType();
            string reason = leaveReasonTextBox.Text.Trim();

            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (leaveTypeValue == 0)
            {
                MessageBox.Show("Please select a leave type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter a reason for leave", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO leave_records (employee_id, leave_date, leave_type_value, reason) VALUES (@employeeId, @leaveDate, @leaveType, @reason)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@leaveDate", leaveDate);
                        cmd.Parameters.AddWithValue("@leaveType", leaveTypeValue);
                        cmd.Parameters.AddWithValue("@reason", reason);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Leave record added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetLeaveType()
        {
            if (halfDayRadioButton.Checked)
                return 4;
            if (fullDayRadioButton.Checked)
                return 8;

            return 0;
        }

        private void UpdateAllLeaveDays()
        {
            string selectEmployeesQuery = @"
                                            SELECT DISTINCT 
                                                employee_id, 
                                                DATEPART(YEAR, leave_date) AS year, 
                                                DATEPART(MONTH, leave_date) AS month
                                            FROM leave_records;";

            string selectLeaveDaysQuery = @"
                                            SELECT 
                                                ISNULL(SUM(leave_type_value), 0) AS total_leave_days
                                            FROM 
                                                leave_records
                                            WHERE 
                                                employee_id = @employeeId
                                            AND DATEPART(YEAR, leave_date) = @year
                                            AND DATEPART(MONTH, leave_date) = @month
                                            GROUP BY 
                                                employee_id;";

            string updateOrInsertQuery = @"
                                            IF EXISTS (SELECT 1 FROM leave_days WHERE employee_id = @employeeId AND DATEPART(YEAR, leave_month) = @year AND DATEPART(MONTH, leave_month) = @month)
                                            BEGIN
                                                UPDATE leave_days
                                                SET total_leave_days = @totalLeaveDays
                                                WHERE employee_id = @employeeId AND DATEPART(YEAR, leave_month) = @year AND DATEPART(MONTH, leave_month) = @month;
                                            END
                                            ELSE
                                            BEGIN
                                                INSERT INTO leave_days (employee_id, leave_month, total_leave_days)
                                                VALUES (@employeeId, @leaveMonth, @totalLeaveDays);
                                            END;";

            string connectionString = dataSource.dataString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve all unique employee IDs and leave months
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

                        // Loop through each employee and month combination to update leave days
                        foreach (var employeeMonth in employeeMonths)
                        {
                            string employeeId = employeeMonth.Item1;
                            int year = employeeMonth.Item2;
                            int month = employeeMonth.Item3;

                            using (SqlCommand selectLeaveDaysCmd = new SqlCommand(selectLeaveDaysQuery, connection))
                            {
                                selectLeaveDaysCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                selectLeaveDaysCmd.Parameters.AddWithValue("@year", year);
                                selectLeaveDaysCmd.Parameters.AddWithValue("@month", month);

                                try
                                {
                                    using (SqlDataReader leaveDaysReader = selectLeaveDaysCmd.ExecuteReader())
                                    {
                                        if (leaveDaysReader.Read())
                                        {
                                            object totalLeaveDaysObj = leaveDaysReader[0];
                                            string totalLeaveDaysType = totalLeaveDaysObj.GetType().ToString();

                                            try
                                            {
                                                decimal totalLeaveDays = leaveDaysReader.IsDBNull(0) ? 0.0m : Convert.ToDecimal(totalLeaveDaysObj);
                                                DateTime leaveMonthDate = new DateTime(year, month, 1);

                                                leaveDaysReader.Close(); // Close the reader before executing another command

                                                using (SqlCommand updateOrInsertCmd = new SqlCommand(updateOrInsertQuery, connection))
                                                {
                                                    updateOrInsertCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                                    updateOrInsertCmd.Parameters.AddWithValue("@year", year);
                                                    updateOrInsertCmd.Parameters.AddWithValue("@month", month);
                                                    updateOrInsertCmd.Parameters.AddWithValue("@totalLeaveDays", totalLeaveDays);
                                                    updateOrInsertCmd.Parameters.AddWithValue("@leaveMonth", leaveMonthDate);

                                                    updateOrInsertCmd.ExecuteNonQuery();
                                                }
                                            }
                                            catch (InvalidCastException icEx)
                                            {
                                                MessageBox.Show($"Invalid cast when processing total_leave_days: {icEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            leaveDaysReader.Close(); // Close the reader if no records found
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred while retrieving leave days: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    MessageBox.Show("Leave days updated successfully for all employees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void SearchLeaveDays(string employeeId, int year, int month)
        {
            string connectionString = dataSource.dataString;

            string query = @"
                            SELECT 
                                ISNULL(total_leave_days / 8.0, 0) AS adjusted_leave_days
                            FROM 
                                leave_days
                            WHERE 
                                employee_id = @employeeId 
                                AND DATEPART(YEAR, leave_month) = @year 
                                AND DATEPART(MONTH, leave_month) = @month";

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
                                decimal adjustedLeaveDays = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                leaveDaysTextBox.Text = adjustedLeaveDays.ToString(); // Assuming leaveDays is a control to display the leave days
                            }
                            else
                            {
                                MessageBox.Show("No leave records found for the specified employee and month.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (empSearchId.Text == "")
            {
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string employeeId = empSearchId.Text; // Use empID.Text for consistency
                    int year = monthYearPick.Value.Year; // Correct variable name
                    int month = monthYearPick.Value.Month; // Correct variable name

                    SearchWorkHours(employeeId, year, month);
                    SearchLeaveDays(employeeId, year, month);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid Employee ID format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dailyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }
    }
}
