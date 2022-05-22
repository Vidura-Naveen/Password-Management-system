using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordManagementSystem
{
    public partial class MasterPassword : Form
    {
        public MasterPassword()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        string hash = "MsPwd12#";
        private void btnMPwdGenarator_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMPwdCopy_Click(object sender, EventArgs e)
        {
            if(txtMPwd.Text == "")
            {
                MessageBox.Show("Please Genarate Master Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            else {
                Clipboard.SetText(txtMPwd.Text );
            }
            txtMUPwd.Text = "";
            txtMPwd.Text = "";
        }

        private void btnMPwdBack_Click(object sender, EventArgs e)
        {
            //UCAddAccount Add = new UCAddAccount();
            //Add.Show();

            //this.Hide();
        }

        private void txtMUPwd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MasterPassword_Load(object sender, EventArgs e)
        {
            this.Width = 450;
            this.Height =  170;
        }

        private void btnGenarateMp_Click(object sender, EventArgs e)
        {
            if (txtMUPwd.Text == "")
            {
                MessageBox.Show("please Enter User Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(txtMUPwd.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        txtMPwd.Text = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
            }
        }

        private void btnpaste_Click(object sender, EventArgs e)
        {
            txtMUPwd.Text = Clipboard.GetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gunaGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                mouseX = MousePosition.X - 10;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void gunaGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void gunaGradientPanel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void gunaGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false ;
        }
    }
}
