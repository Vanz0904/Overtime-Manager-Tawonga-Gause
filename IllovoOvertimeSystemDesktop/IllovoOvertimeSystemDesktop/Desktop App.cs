using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IllovoOvertimeSystemDesktop
{
    class IllovoOvertimeSystem
    {
        private string connectionString = "Server=localhost;Database=IllovoOvertimeSystem;User=root;Password=;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool AuthenticateEmployee(int employeeID, string password)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM Accounts WHERE EmployeeID = @EmployeeID AND Password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred during authentication: " + ex.Message);
                return false;
            }
        }

        public bool ClockIn(int employeeID, string type)
        {
            string currentStatus = GetClockStatus(employeeID);

            if (currentStatus == "In")
            {

                return false; 
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = GetConnection())
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO WorkHours (EmployeeID, TimeIn, Status, WorkHourType) VALUES (@EmployeeID, NOW(), 'In', @WorkType)";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                            cmd.Parameters.AddWithValue("@WorkType", type);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred during clock in: " + ex.Message);
                    return false;
                }
            }
            
        }

        public bool ClockOut(int employeeID)
        {
            string currentStatus = GetClockStatus(employeeID);

            if (currentStatus == "Out")
            {

                return false;
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = GetConnection())
                    {
                        connection.Open();

                        // Prepare the SQL query to update the clock-out record
                        string updateQuery = "UPDATE WorkHours SET Status = 'Out', TimeOut = NOW() WHERE EmployeeID = @EmployeeID AND Status = 'In'";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                            int rowsAffected = cmd.ExecuteNonQuery();


                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An error occurred while clocking out: " + ex.Message);
                    return false;
                }
            }
                
        }

        public string GetClockStatus(int employeeID)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Prepare the SQL query to retrieve the status for the specified employee ID
                    string query = "SELECT Status FROM WorkHours WHERE EmployeeID = @EmployeeID ORDER BY TimeIn DESC LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        // Execute the query and get the status
                        object result = cmd.ExecuteScalar();

                        
                        if (result == null)
                        {
                            return "Out"; // Employee is not clocked in
                        }
                        else
                        {
                            return result.ToString(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while checking clock status: " + ex.Message);
                return "Error";
            }
        }
    }

}
