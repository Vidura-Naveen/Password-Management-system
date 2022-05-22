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
    public partial class UCAddAccount : UserControl
    {
        Connection con = new Connection();
        public UCAddAccount()
        {
            InitializeComponent();
        }
        
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

       
        private void btnAddMasterPwd_Click(object sender, EventArgs e)
        {
            //MasterPassword mp = new MasterPassword();
            //mp.Show();
            btnGenarateAdd.Enabled = true;
            //btnAddPast.Visible = true;

            /////*  this.Hide()*/;
        }

        private void btnAddPast_Click(object sender, EventArgs e)
        {
            //txtAddPwd.Text = Clipboard.GetText();
        }

        private void btnAddShowPwd_Click(object sender, EventArgs e)
        {
            btnAddShowPwd.Visible = false;
            btnAddHidePwd.Visible = true;
            if (txtAddPwd.PasswordChar == '*')
          
            {
                btnAddHidePwd.BringToFront();
                txtAddPwd.PasswordChar = '\0' ;

            }
        }

        private void btnAddHidePwd_Click(object sender, EventArgs e)
        {
            btnAddShowPwd.Visible = true;
            btnAddHidePwd.Visible = false;
            if (txtAddPwd.PasswordChar == '\0')
            {
                btnAddShowPwd.BringToFront();
                txtAddPwd.PasswordChar = '*';

            }
        }

        private void UCAddAccount_Load(object sender, EventArgs e)
        {
            btnAddHidePwd.Visible = false;

            //btnAddCreate.Visible = false;
            btnGenarateAdd.Enabled = false;
        }

        private void btnAddCreate_Click(object sender, EventArgs e)
        {
            if (txtAddWeb.Text != "" || txtAddUserName.Text != "" || txtAddPwd.Text != "")
            {
                
                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }
                
                string query1 = "insert into MainTbl values('" + txtAddURL.Text + "','" + txtAddWeb.Text + "','" + cboxAddCat.SelectedItem.ToString() + "','" + txtAddUserName.Text + "','" + txtAddPwd.Text + "','" + txtAddNotes.Text + "')";
                SqlCommand cmd = new SqlCommand(query1, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            else
            {
                MessageBox.Show("Please Enter your Details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtAddNotes.Text = "";
            txtAddPwd.Text = "";
            txtAddURL.Text = "";
            txtAddUserName.Text = "";
            txtAddWeb.Text = "";
            cboxAddCat.Text = "";
            
            
        }

        private void txtAddPwd_MouseClick(object sender, MouseEventArgs e)
        {
       
            
                btnGenarateAdd.Enabled = true;
            
            
            
        }

        private void btnGenarateAdd_Click(object sender, EventArgs e)
        {
            int len = 10;
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            txtAddPwd.Text = result.ToString();
        }
    }
    }

