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
    public partial class UCDelete : UserControl
    {
        Connection con = new Connection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();
        String query;
        public UCDelete()
        {
            InitializeComponent();
        }

        private void UCDelete_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDeleteSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
            String category = comboBoxDeleteSearch.Text;
            String str = "Select UserName  from MainTbl  where Category ='" + category + "'";
            SqlCommand cmd = new SqlCommand(str, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            txtSearchDelete.Text = "";
            lblCat.Text = "";
            lblNotes.Text = "";
            lblPass.Text = "";
            lblURL.Text = "";
            lblUserName.Text = "";
            lblWeb.Text = "";
        }

        private void txtSearchDelete_OnValueChanged(object sender, EventArgs e)
        {
           
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
            String user = txtSearchDelete.Text;
            String str2 = "Select UserName from MainTbl where WebName ='" + user + "' and WebName like '" + txtSearchDelete.Text + "%'";
            SqlCommand cmd2 = new SqlCommand(str2, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            comboBoxDeleteSearch.Text = "";
            lblCat.Text = "";
            lblNotes.Text = "";
            lblPass.Text = "";
            lblURL.Text = "";
            lblUserName.Text = "";
            lblWeb.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "Delete from MainTbl where Password='" + lblPass.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                lblURL.Text = ds.Tables[0].Rows[0][1].ToString();
                lblWeb.Text = ds.Tables[0].Rows[0][2].ToString();
                lblCat.Text = ds.Tables[0].Rows[0][3].ToString();
                lblUserName.Text = ds.Tables[0].Rows[0][4].ToString();
                lblPass.Text = ds.Tables[0].Rows[0][5].ToString();
                lblNotes.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch { }
        }
    }
}
