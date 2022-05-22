using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordManagementSystem
{
    public partial class UCTrayMP : UserControl
    {
        string hash = "MsPwd12#";
        public UCTrayMP()
        {
            InitializeComponent();
        }
        #region Properties
        private string _title;
        private string _message;
        private string _password;
        private string _category;



        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblWebNameMp.Text = value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblUserNameMp.Text = value; }
        }
        [Category("Custom Props")]
        public string Password
        {
            get { return _password; }
            set { _password = value; lblTrayPassword.Text = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; lblTrayCategory.Text = value; }
        }
        #endregion
        private void UCTrayMP_Load(object sender, EventArgs e)
        {

        }

        private void btntraycopy_Click(object sender, EventArgs e)
        {


            byte[] data = Convert.FromBase64String(lblTrayPassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lblTrayPassword.Text = UTF8Encoding.UTF8.GetString(results);


                    Clipboard.SetText(lblTrayPassword.Text);
                }
            }
        }
    }
}
