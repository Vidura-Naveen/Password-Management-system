using PasswordManagementSystem.Class;
using PasswordManagementSystem.Properties;
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
    public partial class Dashboard : Form
    {
        Connection con = new Connection();
        
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
          

        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;


        private void customizeDesign()
        {
            pnlAccount.Visible = false;
           
        }
        private void hideSubmenu()
        {
            if (pnlAccount.Visible == true)

                pnlAccount.Visible = false;
           
        }
        private void showSubmenu(Panel subMmenu)
        {
            if (subMmenu.Visible == false)
            {
                hideSubmenu();
                subMmenu.Visible = true;
            }
            else
            {
                subMmenu.Visible = false;
            }
        }
        private void GenarateDynamicUserControl()
        {

            flowLayoutPanel1.Controls.Clear();

            Getdata Objbll = new Getdata();
            DataTable dt = Objbll.GetItems();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UCTray[] listItems = new UCTray[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            listItems[i] = new  UCTray();
                            listItems[i].Title = row["WebName"].ToString();
                            listItems[i].Message = row["UserName"].ToString();
                            listItems[i].Password = row["Password"].ToString();
                            listItems[i].Category = row["Category"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);
                            

                        }
                    }
                }
            }

        }

        private void GenarateDynamicUserControl1()
        {
            flowLayoutPanel2.Controls.Clear();
            GetDataMp Objbll = new GetDataMp();
            DataTable dt = Objbll.GetItems();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UCTrayMP[] listItems = new UCTrayMP[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new UCTrayMP();
                            listItems[i].Title = row["MPWebName"].ToString();
                            listItems[i].Message = row["MPUserName"].ToString();
                            listItems[i].Password = row["MPassword"].ToString();
                            listItems[i].Category = row["MPCategory"].ToString();

                            flowLayoutPanel2.Controls.Add(listItems[i]);
                            

                        }
                    }
                }
            }

        }

     

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GenarateDynamicUserControl();
            GenarateDynamicUserControl1();

            ucDashboardLoad1.Visible = true;
            ucDashboardLoad1.BringToFront();

            ucAddAccount1.Visible = false;
            ucDelete1.Visible = false;
            ucEdit1.Visible = false;

            btnBack.Visible = false;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GenarateDynamicUserControl();
            GenarateDynamicUserControl1();
           
        }


       

        private void btnmpadd_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnmpupdate_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnmpdelete_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnmpsearch_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            showSubmenu(pnlAccount);
        }

        private void btnPwdTray_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
        }

        private void btnMpwdTray_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ucAddAccount1.Visible = true;
            ucAddAccount1.BringToFront();
            btnBack.Visible = true;
        }

        private void btnDashUpdate_Click(object sender, EventArgs e)
        {
            ucEdit1.Visible = true;
            ucEdit1.BringToFront();
            btnBack.Visible = true;
        }

        private void btnDashdelete_Click_1(object sender, EventArgs e)
        {
            ucDelete1.Visible = true;
            ucDelete1.BringToFront();
            btnBack.Visible = true;
        }

        private void btnDashsearch_Click_1(object sender, EventArgs e)
        {
            //ucSearch1.Visible = true;
            //ucSearch1.BringToFront();
            //btnBack.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

          
            MasterPwd add = new MasterPwd();
            add.Show();
            btnBack.Visible = false;
            ucDashboardLoad1.Visible = true;
            ucDashboardLoad1.BringToFront();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            btnBack.Visible = false;
            ucDashboardLoad1.Visible = true;
            ucDashboardLoad1.BringToFront();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MasPwdDelete delete = new MasPwdDelete();
            delete.Show();
            btnBack.Visible = false;
            ucDashboardLoad1.Visible = true;
            ucDashboardLoad1.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucDashboardLoad1.Visible = true;
            ucDashboardLoad1.BringToFront();
            btnBack.Visible = false;

        }

        private void btnConvertor_Click(object sender, EventArgs e)
        {
            MasterPwdConv mpc = new MasterPwdConv();
            mpc.Show();
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            MasterPassword mpg = new MasterPassword();
            mpg.Show();

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
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        

       
   

        

    


