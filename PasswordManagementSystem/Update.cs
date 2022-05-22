using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using PasswordManagementSystem.Class;

namespace PasswordManagementSystem
{
    public partial class Update : Form
    {

        //SqlDataAdapter da = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        
        Connection con = new Connection();
        String query;
        string hash = "MsPwd12#";
        public Update()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void btnUpdate_Click(object sender, EventArgs e)
        {



            if (txtMPEditUserName.Text != "" || txtMPEditWeb.Text != "" || txtMPEditPwd.Text != "")
            {

                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }

                string query1 = "Update MPTbl set MPURL= '" + txtMPEditURL.Text + "',MPWebName='" + txtMPEditWeb.Text + "' , MPCategory= '" + cboxMPEditCat.SelectedItem.ToString() + "',MPUserName='" + txtMPEditUserName.Text + "',MPassword='" + txtMPEditPwd.Text + "',MPNotes='" + txtMPEditNotes.Text + "' where MPassword= '" + txtMPEditPwd.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMPEditURL.Text = "";
                txtMPEditWeb.Text = "";
                cboxMPEditCat.Text = "";
                txtMPEditUserName.Text = "";
                txtMPEditPwd.Text = "";
                txtMPEditNotes.Text = "";
                listBoxMPEditSearch.Items.Clear();
                comboBoxMPEditSearch.Text = "";
            }
            else
            {
                MessageBox.Show("Select and Update your Account!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            btnEditHidePwd.Visible = false;
        }

        private void comboBoxMPEditSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxMPEditSearch.Items.Clear();
            String category = comboBoxMPEditSearch.Text;
            String str = "Select MPUserName  from MPTbl  where MPCategory ='" + category + "'";
            SqlCommand cmd = new SqlCommand(str, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMPEditSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            txtMPEditURL.Text = "";
            txtMPEditWeb.Text = "";
            cboxMPEditCat.Text = "";
            txtMPEditUserName.Text = "";
            txtMPEditPwd.Text = "";
            txtMPEditNotes.Text = "";

        }

        private void txtMPEditSearch_OnValueChanged(object sender, EventArgs e)
        {

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            comboBoxMPEditSearch.Text = "";
            listBoxMPEditSearch.Items.Clear();
            String user = txtMPEditSearch.Text;
            String str2 = "Select MPUserName from MPTbl where MPWebName ='" + user + "' and MPWebName like '" + txtMPEditSearch.Text + "%'";
            SqlCommand cmd2 = new SqlCommand(str2, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMPEditSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            txtMPEditURL.Text = "";
            txtMPEditWeb.Text = "";
            cboxMPEditCat.Text = "";
            txtMPEditUserName.Text = "";
            txtMPEditPwd.Text = "";
            txtMPEditNotes.Text = "";

        }

        private void listBoxMPEditSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String text = listBoxMPEditSearch.GetItemText(listBoxMPEditSearch.SelectedItem);
            listBoxMPEditSearch.Text = text;
            query = "Select * from MPTbl where MPUserName='" + text + "'";

            SqlCommand cmd = new SqlCommand(query, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            try
            {
                txtMPEditURL.Text = ds.Tables[0].Rows[0][1].ToString();
                txtMPEditWeb.Text = ds.Tables[0].Rows[0][2].ToString();
                cboxMPEditCat.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMPEditUserName.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMPEditPwd.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMPEditNotes.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch { }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //byte[] data = UTF8Encoding.UTF8.GetBytes(txtMPEditPwd.Text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        txtMPEditPwd.Text = Convert.ToBase64String(results, 0, results.Length);
            //    }
            //}
        }

        private void btnEditHidePwd_Click(object sender, EventArgs e)
        {
            btnEditShowPwd.Visible = true;
            btnEditHidePwd.Visible = false;
            if (txtMPEditPwd.PasswordChar == '\0')
            {
                btnEditShowPwd.BringToFront();
                txtMPEditPwd.PasswordChar = '*';

            }
        }

        private void btnEditShowPwd_Click(object sender, EventArgs e)
        {
            btnEditShowPwd.Visible = false;
            btnEditHidePwd.Visible = true;
            if (txtMPEditPwd.PasswordChar == '*')

            {
                btnEditHidePwd.BringToFront();
                txtMPEditPwd.PasswordChar = '\0';

            }
        }

        private void txtMPEditSearch_Click(object sender, EventArgs e)
        {
            comboBoxMPEditSearch.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Convertor_Click(object sender, EventArgs e)
        {
            //byte[] data = Convert.FromBase64String(txtMPEditPwd.Text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateDecryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        txtMPEditPwd.Text = UTF8Encoding.UTF8.GetString(results);
            //    }
            //}
        }

       

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 400;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

       
    }
}

