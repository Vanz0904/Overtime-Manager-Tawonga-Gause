using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IllovoOvertimeSystemDesktop
{
    public partial class clockout : Form
    {
        private IllovoOvertimeSystem ot;

        public clockout()
        {
            InitializeComponent();
            ot = new IllovoOvertimeSystem();

            this.FormClosing += clockout_FormClosing;
        }

        private void clockout_FormClosing(object sender, FormClosingEventArgs e)
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


            if (ot.AuthenticateEmployee(employeeId, password))
            {
                if (ot.ClockOut(employeeId))
                {
                    MessageBox.Show("Time out recorded");
                }
                else
                {

                    MessageBox.Show("You are already clocked out.");
                }
            }
            else
            {

                MessageBox.Show("Authentication failed.");
            }
        }
    }
}
