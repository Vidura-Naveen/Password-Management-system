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
    public partial class MasPwdDelete : Form
    {
        Connection con = new Connection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();
        String query;
        public MasPwdDelete()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblCat.Text != "" || lblPass.Text != "" || lblUserName.Text !="" || lblWeb.Text !="")

            {
               
                if (ConnectionState.Closed == con.connect.State)
                {
                    con.connect.Open();
                }
                
                string query = "Delete from MPTbl where MPassword='" + lblPass.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con.connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully","Success!",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
            else
            {
                MessageBox.Show("Please Select Details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtSearchDelete.Text = "";
            lblCat.Text = "";
            lblNotes.Text = "";
            lblPass.Text = "";
            lblURL.Text = "";
            lblUserName.Text = "";
            lblWeb.Text = "";
            listBoxSearch.Text = "";
            comboBoxDeleteSearch.Text = "";
        }

        private void comboBoxDeleteSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
            String category = comboBoxDeleteSearch.Text;
            String str = "Select MPUserName  from MPTbl  where MPCategory ='" + category + "'";
            SqlCommand cmd = new SqlCommand(str, con.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
               
            }
            
            




        }

        private void txtSearchDelete_OnValueChanged(object sender, EventArgs e)
        {
           
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            listBoxSearch.Items.Clear();
                String user = txtSearchDelete.Text;
                String str2 = "Select MPUserName from MPTbl where MPWebName ='" + user + "' and MPWebName like '" + txtSearchDelete.Text + "%'";
                SqlCommand cmd2 = new SqlCommand(str2, con.connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                da.Fill(ds);


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                
            }

          



        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            String text = listBoxSearch.GetItemText(listBoxSearch.SelectedItem);
            listBoxSearch.Text = text;
            query = "Select * from MPTbl where MPUserName='" + text + "'";

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

        private void txtSearchDelete_Click(object sender, EventArgs e)
        {
            comboBoxDeleteSearch.Text = "";
            lblCat.Text = "";
            lblNotes.Text = "";
            lblPass.Text = "";
            lblURL.Text = "";
            lblUserName.Text = "";
            lblWeb.Text = "";
            listBoxSearch.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MasPwdDelete_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
    }
