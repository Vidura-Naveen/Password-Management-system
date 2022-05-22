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
using System.Security.Cryptography;

namespace PasswordManagementSystem
{
    public partial class UCTray : UserControl
    {
        

        public UCTray()
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
            set { _title = value; lblWebName.Text = value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblUserName.Text = value; }
        }
        [Category("Custom Props")]
        public string Password
        {
            get { return _password; }
            set { _password = value; lblTrayPassword.Text = value; }
        }
        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lblTrayCategory.Text = value; }
        }
        #endregion


        private void UCTray_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btntraycopy_Click(object sender, EventArgs e)
        {
        
                    Clipboard.SetText(lblTrayPassword.Text);
                }
            }


           
        }
    

    



