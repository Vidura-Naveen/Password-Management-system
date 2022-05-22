namespace PasswordManagementSystem
{
    partial class UCAddAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddAccount));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddURL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddWeb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddNotes = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnAddShowPwd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddHidePwd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtAddPwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxAddCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenarateAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddShowPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddHidePwd)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(38, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "URL";
            // 
            // txtAddURL
            // 
            this.txtAddURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddURL.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddURL.HintForeColor = System.Drawing.Color.Silver;
            this.txtAddURL.HintText = "Enter Web URL";
            this.txtAddURL.isPassword = false;
            this.txtAddURL.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddURL.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddURL.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddURL.LineThickness = 1;
            this.txtAddURL.Location = new System.Drawing.Point(30, 54);
            this.txtAddURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddURL.Name = "txtAddURL";
            this.txtAddURL.Size = new System.Drawing.Size(438, 33);
            this.txtAddURL.TabIndex = 1;
            this.txtAddURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddURL.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 16);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Account Name";
            // 
            // txtAddWeb
            // 
            this.txtAddWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddWeb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddWeb.HintForeColor = System.Drawing.Color.Silver;
            this.txtAddWeb.HintText = "Enter Web Name";
            this.txtAddWeb.isPassword = false;
            this.txtAddWeb.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddWeb.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddWeb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddWeb.LineThickness = 1;
            this.txtAddWeb.Location = new System.Drawing.Point(30, 128);
            this.txtAddWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddWeb.Name = "txtAddWeb";
            this.txtAddWeb.Size = new System.Drawing.Size(190, 33);
            this.txtAddWeb.TabIndex = 3;
            this.txtAddWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(248, 107);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Category";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(27, 184);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(78, 16);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "User Name";
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddUserName.HintForeColor = System.Drawing.Color.Silver;
            this.txtAddUserName.HintText = "Enter User Name";
            this.txtAddUserName.isPassword = false;
            this.txtAddUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddUserName.LineThickness = 1;
            this.txtAddUserName.Location = new System.Drawing.Point(30, 204);
            this.txtAddUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(438, 33);
            this.txtAddUserName.TabIndex = 6;
            this.txtAddUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(27, 255);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(67, 16);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(27, 355);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Notes";
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAddNotes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNotes.Location = new System.Drawing.Point(30, 374);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(438, 73);
            this.txtAddNotes.TabIndex = 18;
            // 
            // btnAddShowPwd
            // 
            this.btnAddShowPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnAddShowPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddShowPwd.Image")));
            this.btnAddShowPwd.ImageActive = null;
            this.btnAddShowPwd.Location = new System.Drawing.Point(453, 292);
            this.btnAddShowPwd.Name = "btnAddShowPwd";
            this.btnAddShowPwd.Size = new System.Drawing.Size(15, 15);
            this.btnAddShowPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddShowPwd.TabIndex = 15;
            this.btnAddShowPwd.TabStop = false;
            this.btnAddShowPwd.Zoom = 10;
            this.btnAddShowPwd.Click += new System.EventHandler(this.btnAddShowPwd_Click);
            // 
            // btnAddCreate
            // 
            this.btnAddCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(145)))), ((int)(((byte)(39)))));
            this.btnAddCreate.BackColor = System.Drawing.Color.White;
            this.btnAddCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCreate.BorderRadius = 0;
            this.btnAddCreate.ButtonText = "Save";
            this.btnAddCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCreate.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCreate.Iconimage = null;
            this.btnAddCreate.Iconimage_right = null;
            this.btnAddCreate.Iconimage_right_Selected = null;
            this.btnAddCreate.Iconimage_Selected = null;
            this.btnAddCreate.IconMarginLeft = 0;
            this.btnAddCreate.IconMarginRight = 0;
            this.btnAddCreate.IconRightVisible = true;
            this.btnAddCreate.IconRightZoom = 0D;
            this.btnAddCreate.IconVisible = true;
            this.btnAddCreate.IconZoom = 90D;
            this.btnAddCreate.IsTab = false;
            this.btnAddCreate.Location = new System.Drawing.Point(362, 462);
            this.btnAddCreate.Name = "btnAddCreate";
            this.btnAddCreate.Normalcolor = System.Drawing.Color.White;
            this.btnAddCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(145)))), ((int)(((byte)(39)))));
            this.btnAddCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCreate.selected = false;
            this.btnAddCreate.Size = new System.Drawing.Size(105, 40);
            this.btnAddCreate.TabIndex = 11;
            this.btnAddCreate.Text = "Save";
            this.btnAddCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCreate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(145)))), ((int)(((byte)(39)))));
            this.btnAddCreate.TextFont = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCreate.Click += new System.EventHandler(this.btnAddCreate_Click);
            // 
            // btnAddHidePwd
            // 
            this.btnAddHidePwd.BackColor = System.Drawing.Color.Transparent;
            this.btnAddHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHidePwd.Image")));
            this.btnAddHidePwd.ImageActive = null;
            this.btnAddHidePwd.Location = new System.Drawing.Point(453, 292);
            this.btnAddHidePwd.Name = "btnAddHidePwd";
            this.btnAddHidePwd.Size = new System.Drawing.Size(15, 15);
            this.btnAddHidePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddHidePwd.TabIndex = 19;
            this.btnAddHidePwd.TabStop = false;
            this.btnAddHidePwd.Zoom = 10;
            this.btnAddHidePwd.Click += new System.EventHandler(this.btnAddHidePwd_Click);
            // 
            // txtAddPwd
            // 
            this.txtAddPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPwd.Location = new System.Drawing.Point(30, 286);
            this.txtAddPwd.Multiline = true;
            this.txtAddPwd.Name = "txtAddPwd";
            this.txtAddPwd.PasswordChar = '*';
            this.txtAddPwd.Size = new System.Drawing.Size(417, 33);
            this.txtAddPwd.TabIndex = 20;
            this.txtAddPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddPwd_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(30, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 1);
            this.panel1.TabIndex = 21;
            // 
            // cboxAddCat
            // 
            this.cboxAddCat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAddCat.FormattingEnabled = true;
            this.cboxAddCat.Items.AddRange(new object[] {
            "Social Media",
            "Mail Services",
            "Education ",
            "Finance",
            "Entertaintment",
            "Other"});
            this.cboxAddCat.Location = new System.Drawing.Point(251, 136);
            this.cboxAddCat.Name = "cboxAddCat";
            this.cboxAddCat.Size = new System.Drawing.Size(217, 25);
            this.cboxAddCat.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(127, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(311, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(90, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "*";
            // 
            // btnGenarateAdd
            // 
            this.btnGenarateAdd.AnimationHoverSpeed = 0.07F;
            this.btnGenarateAdd.AnimationSpeed = 0.03F;
            this.btnGenarateAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnGenarateAdd.BaseColor = System.Drawing.Color.White;
            this.btnGenarateAdd.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateAdd.BorderSize = 1;
            this.btnGenarateAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGenarateAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGenarateAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenarateAdd.CheckedImage = null;
            this.btnGenarateAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGenarateAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenarateAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenarateAdd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarateAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateAdd.Image = null;
            this.btnGenarateAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenarateAdd.LineColor = System.Drawing.Color.White;
            this.btnGenarateAdd.Location = new System.Drawing.Point(349, 313);
            this.btnGenarateAdd.Name = "btnGenarateAdd";
            this.btnGenarateAdd.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateAdd.OnHoverBorderColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenarateAdd.OnHoverImage = null;
            this.btnGenarateAdd.OnHoverLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenarateAdd.Radius = 20;
            this.btnGenarateAdd.Size = new System.Drawing.Size(119, 41);
            this.btnGenarateAdd.TabIndex = 45;
            this.btnGenarateAdd.Text = "Generate";
            this.btnGenarateAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenarateAdd.Click += new System.EventHandler(this.btnGenarateAdd_Click);
            // 
            // UCAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGenarateAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxAddCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddHidePwd);
            this.Controls.Add(this.txtAddNotes);
            this.Controls.Add(this.btnAddShowPwd);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.btnAddCreate);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtAddUserName);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtAddWeb);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtAddURL);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtAddPwd);
            this.Name = "UCAddAccount";
            this.Size = new System.Drawing.Size(495, 520);
            this.Load += new System.EventHandler(this.UCAddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddShowPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddHidePwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddURL;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddWeb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCreate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuImageButton btnAddShowPwd;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAddNotes;
        private Bunifu.Framework.UI.BunifuImageButton btnAddHidePwd;
        private System.Windows.Forms.TextBox txtAddPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxAddCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenarateAdd;
    }
}
