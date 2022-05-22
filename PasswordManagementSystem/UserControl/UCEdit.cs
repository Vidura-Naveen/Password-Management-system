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
    public partial class UCEdit : UserControl
    {
        Connection con = new Connection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();
        String query;
        public UCEdit()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int len = 10;
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            txtEditPwd.Text = result.ToString();
        }


  

        private void comboBoxEditSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
            String category = comboBoxEditSearch.Text;
            String str = "Select UserName , WebName from MainTbl  where Category ='" + category + "'";
            SqlCommand cmd = new SqlCommand(str, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            txtEditURL.Text = "";
            txtEditWeb.Text = "";
            cboxEditCat.Text = "";
            txtEditUserName.Text = "";
            txtEditPwd.Text = "";
            txtEditNotes.Text = "";

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
            String user = bunifuMaterialTextbox5.Text;
            String str2 = "Select UserName from MainTbl where WebName ='" + user + "' and WebName like '" + bunifuMaterialTextbox5.Text + "%'";
            SqlCommand cmd2 = new SqlCommand(str2, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            txtEditURL.Text = "";
            txtEditWeb.Text = "";
            cboxEditCat.Text = "";
            txtEditUserName.Text = "";
            txtEditPwd.Text = "";
            txtEditNotes.Text = "";
        }

        private void UCEdit_Load(object sender, EventArgs e)
        {
            btnEditHidePwd.Visible = false;

            //btnEditPast.Visible = false;
        }

        private void btnEditMasterPwd_Click(object sender, EventArgs e)
        {
            //MasterPassword mp = new MasterPassword();
            //mp.Show();
            
        }

        private void btnEditPast_Click(object sender, EventArgs e)
        {
            //txtEditPwd.Text = Clipboard.GetText();
        }

        private void btnEditShowPwd_Click(object sender, EventArgs e)
        {
            btnEditShowPwd.Visible = false;
            btnEditHidePwd.Visible = true;
            if (txtEditPwd.PasswordChar == '*')

            {
                btnEditHidePwd.BringToFront();
               txtEditPwd.PasswordChar = '\0';

            }
        }

        private void btnEditHidePwd_Click(object sender, EventArgs e)
        {
            btnEditShowPwd.Visible = true;
            btnEditHidePwd.Visible = false;
            if (txtEditPwd.PasswordChar == '\0')
            {
                btnEditShowPwd.BringToFront();
                txtEditPwd.PasswordChar = '*';

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEditWeb.Text != "" || txtEditUserName.Text != "" || txtEditPwd.Text != "")
            {
                
                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }
                
                string query1 = "Update MainTbl set URL= '" + txtEditURL.Text + "',WebName='" + txtEditWeb.Text + "' , Category= '" + cboxEditCat.SelectedItem.ToString() + "',UserName='" + txtEditUserName.Text + "',Password='" + txtEditPwd.Text + "',Notes='" + txtEditNotes.Text + "' where Password= '" + txtEditPwd.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Please Select Details For Update","Error!" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtEditURL.Text = "";
            txtEditWeb.Text = "";
            cboxEditCat.Text = "";
            txtEditUserName.Text = "";
            txtEditPwd.Text = "";
            txtEditNotes.Text = "";
            listBoxSearch.Items.Clear();
            comboBoxEditSearch.Text="";
            bunifuMaterialTextbox5.Text = "";


        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblPlaceSubTotal.Text = "";

            ////UpDownPlaceOrder.ResetText();
            ////UpDownPlaceOrder.Show();
            ////btnAddPlaceOrder.Show();
            
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            String text = listBoxSearch.GetItemText(listBoxSearch.SelectedItem);
            listBoxSearch.Text = text;
            query = "Select * from MainTbl where UserName='" + text + "'";

            SqlCommand cmd = new SqlCommand(query, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            try
            {
               txtEditURL.Text = ds.Tables[0].Rows[0][1].ToString();
               txtEditWeb.Text = ds.Tables[0].Rows[0][2].ToString();
               cboxEditCat.Text = ds.Tables[0].Rows[0][3].ToString();
               txtEditUserName.Text = ds.Tables[0].Rows[0][4].ToString();
               txtEditPwd.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEditNotes.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch { }
        }

    }
}
    
    



