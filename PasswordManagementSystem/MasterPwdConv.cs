using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class MasterPwdConv : Form
    {
        string hash = "MsPwd12#";
        public MasterPwdConv()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void btnMPwdConvertor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMPwdConCopy_Click(object sender, EventArgs e)
        {
            if (txtConMUPwd.Text == "")
            {
                MessageBox.Show("Please Genarate Master Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(txtConMUPwd.Text);
                txtConMUPwd.Text = "";
                txtConMPwd.Text = "";
            }

        }

        private void btnConvertMp_Click(object sender, EventArgs e)
        {
            if (txtConMPwd.Text != "" || txtConMUPwd.Text !="")
            {
                byte[] data = Convert.FromBase64String(txtConMPwd.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        txtConMUPwd.Text = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }else
            {
                MessageBox.Show("Please Enter Your Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {

            txtConMPwd.Text = Clipboard.GetText();
        }

        private void gunaGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void gunaGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void gunaGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
    }

