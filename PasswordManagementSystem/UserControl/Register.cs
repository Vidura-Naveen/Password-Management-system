using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PasswordManagementSystem.Class;

namespace PasswordManagementSystem
{
    public partial class Register : UserControl
    {
        Connection con = new Connection();
        SqlDataAdapter da = new SqlDataAdapter();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            btnHide.Visible = false;
        }

      

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtRegEmail.Text != "" || txtRegPassword.Text != "" || txtRegUserName.Text != "")
            {
                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }

                string query1 = "insert into RegTbl values('" + txtRegUserName.Text + "','" + txtRegEmail.Text + "','" + txtRegPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query1, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Please Fill all the Field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtRegUserName.Text = "";
            txtRegPassword.Text = "";
            txtRegEmail.Text = "";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            if (txtRegPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtRegPassword.PasswordChar = '*';

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnHide.Visible = true;
            if (txtRegPassword.PasswordChar == '*')

            {
                btnHide.BringToFront();
                txtRegPassword.PasswordChar = '\0';

            }
        }
    }
}
