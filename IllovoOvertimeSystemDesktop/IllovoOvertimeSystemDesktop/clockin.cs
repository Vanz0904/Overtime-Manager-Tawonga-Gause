using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace IllovoOvertimeSystemDesktop
{
    public partial class clockin : Form
    {
        private IllovoOvertimeSystem ot;


        public clockin()
        {
            InitializeComponent();
            ot = new IllovoOvertimeSystem();

            this.FormClosing += clockin_FormClosing;
        }

        private void clockin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;


                welcome welcomeForm = new welcome();
                welcomeForm.Show();


                this.Hide();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int employeeId = Int32.Parse(textBoxEmployeeId.Text.Trim());
            string password = textBoxPassword.Text;
            string type;
            
            if (radioButtonOvertime.Checked)
            {
                type = "Overtime";
            }
            else
            {
                type = "Regular";
            }

            if (ot.AuthenticateEmployee(employeeId, password))
            {
                if (ot.ClockIn(employeeId, type))
                {
                    MessageBox.Show("Time in recorded");
                }
                else
                {
                    
                    MessageBox.Show("You are already clocked in.");
                }
            }
            else
            {
                
                MessageBox.Show("Invalid credentials.");
            }
        }



        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOvertime_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
