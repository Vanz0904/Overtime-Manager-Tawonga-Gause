using System;
using System.Windows.Forms;

namespace IllovoOvertimeSystemDesktop
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void buttonClockIn_Click(object sender, EventArgs e)
        {
            clockin cin = new clockin();
            this.Hide(); cin.Show();

        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            clockout cout = new clockout();
            this.Hide(); cout.Show();
        }
    }
}
