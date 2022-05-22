using PasswordManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordManagementSystem
{
    public partial class MasterPwd : Form
    {
       
        public MasterPwd()
        {
            InitializeComponent();
        }
        string hash = "MsPwd12#";
        int mouseX = 0, mouseY = 0;
        bool mouseDown;


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtMPAddUPwd.Text != "")
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(txtMPAddUPwd.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        txtAddMpwd.Text = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter User Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MasterPwd_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnMPAdd_Click(object sender, EventArgs e)
        { if (txtAddMpwd.Text != "" || txtMPAddName.Text != "" || txtMPAddUName.Text != "" || cboxMPAddCat.Text != "")
            {
                Connection con = new Connection();
                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }
               
                string query1 = "insert into MPTbl values('" + txtMPAddURL.Text + "','" + txtMPAddName.Text + "','" + cboxMPAddCat.SelectedItem.ToString() + "','" + txtMPAddUName.Text + "','" + txtAddMpwd.Text + "','" + txtMPAddNote.Text + "')";
                SqlCommand cmd = new SqlCommand(query1, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                txtMPAddURL.Text = "";
                txtMPAddUPwd.Text = "";
                txtMPAddUName.Text = "";
                txtMPAddNote.Text = "";
                txtMPAddName.Text = "";
                txtAddMpwd.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 10;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
       