using PasswordManagementSystem.Class;
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

namespace PasswordManagementSystem
{
    public partial class Form1 : Form
    {
        Connection con = new Connection();
        SqlDataAdapter da = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
            
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void Form1_Load(object sender, EventArgs e)
        {
            register1.Visible = false;
            btnHide.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            register1.Visible = false;
            //login1.BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            register1.Visible = true;
            register1.BringToFront();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 100;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" || txtPassword.Text != "")
            {


                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }
                string query = "Select * from RegTbl where Email='" + txtEmail.Text.Trim() + "' and RegPassword ='" + txtPassword.Text.Trim() + "'";
                da = new SqlDataAdapter(query, con.connect);
                DataTable dtb1 = new DataTable();
                da.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {

                    Dashboard ds = new Dashboard();
                    this.Hide();
                    ds.Show();

                    Form1 form = new Form1();
                    form.Close();
                }

                else
                {
                    MessageBox.Show("Check Your UserName And Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please Enter Details for both User Name & Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1 fn = new Form1();
            fn.Close();

            txtEmail.Text = "";
            txtPassword.Text = "";

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnHide.Visible = true;
            if (txtPassword.PasswordChar == '*')

            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';

            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
