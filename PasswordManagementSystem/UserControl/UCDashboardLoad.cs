using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class UCDashboardLoad : UserControl
    {
        public UCDashboardLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaLabel1.Text = DateTime.Now.ToString("HH:mm");
            gunaLabel2.Text = DateTime.Now.ToString("ss");
            gunaLabel3.Text = DateTime.Now.ToString("MMM dd yyyy");
            gunaLabel4.Text = DateTime.Now.ToString("dddd");
            gunaLabel2.Location = new Point(gunaLabel1.Location.X + gunaLabel1.Width - 5, gunaLabel2.Location.Y);
        }

        private void UCDashboardLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
