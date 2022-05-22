namespace PasswordManagementSystem
{
    partial class MasterPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPassword));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMUPwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMPwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnMPwdCopy = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGenarateMp = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnpaste = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnMPwdCopy)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpaste)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 61);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(114, 15);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "User Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 104);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(133, 15);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Master Password";
            // 
            // txtMUPwd
            // 
            this.txtMUPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMUPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMUPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMUPwd.HintForeColor = System.Drawing.Color.DimGray;
            this.txtMUPwd.HintText = "Enter Your Password";
            this.txtMUPwd.isPassword = false;
            this.txtMUPwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMUPwd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMUPwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMUPwd.LineThickness = 1;
            this.txtMUPwd.Location = new System.Drawing.Point(164, 43);
            this.txtMUPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMUPwd.Name = "txtMUPwd";
            this.txtMUPwd.Size = new System.Drawing.Size(253, 33);
            this.txtMUPwd.TabIndex = 2;
            this.txtMUPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMUPwd.OnValueChanged += new System.EventHandler(this.txtMUPwd_OnValueChanged);
            // 
            // txtMPwd
            // 
            this.txtMPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMPwd.HintForeColor = System.Drawing.Color.DimGray;
            this.txtMPwd.HintText = "Master Password";
            this.txtMPwd.isPassword = false;
            this.txtMPwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMPwd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMPwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMPwd.LineThickness = 1;
            this.txtMPwd.Location = new System.Drawing.Point(164, 86);
            this.txtMPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPwd.Name = "txtMPwd";
            this.txtMPwd.Size = new System.Drawing.Size(253, 33);
            this.txtMPwd.TabIndex = 3;
            this.txtMPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnMPwdCopy
            // 
            this.btnMPwdCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnMPwdCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnMPwdCopy.Image")));
            this.btnMPwdCopy.ImageActive = null;
            this.btnMPwdCopy.Location = new System.Drawing.Point(392, 87);
            this.btnMPwdCopy.Name = "btnMPwdCopy";
            this.btnMPwdCopy.Size = new System.Drawing.Size(25, 25);
            this.btnMPwdCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMPwdCopy.TabIndex = 4;
            this.btnMPwdCopy.TabStop = false;
            this.btnMPwdCopy.Zoom = 10;
            this.btnMPwdCopy.Click += new System.EventHandler(this.btnMPwdCopy_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnClose);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(451, 36);
            this.gunaGradientPanel1.TabIndex = 20;
            this.gunaGradientPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaGradientPanel1_MouseClick);
            this.gunaGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaGradientPanel1_MouseDown);
            this.gunaGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaGradientPanel1_MouseMove);
            this.gunaGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaGradientPanel1_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(427, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenarateMp
            // 
            this.btnGenarateMp.AnimationHoverSpeed = 0.07F;
            this.btnGenarateMp.AnimationSpeed = 0.03F;
            this.btnGenarateMp.BackColor = System.Drawing.Color.Transparent;
            this.btnGenarateMp.BaseColor = System.Drawing.Color.White;
            this.btnGenarateMp.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateMp.BorderSize = 1;
            this.btnGenarateMp.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGenarateMp.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGenarateMp.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenarateMp.CheckedImage = null;
            this.btnGenarateMp.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGenarateMp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenarateMp.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenarateMp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarateMp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateMp.Image = null;
            this.btnGenarateMp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenarateMp.LineColor = System.Drawing.Color.White;
            this.btnGenarateMp.Location = new System.Drawing.Point(304, 126);
            this.btnGenarateMp.Name = "btnGenarateMp";
            this.btnGenarateMp.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateMp.OnHoverBorderColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateMp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenarateMp.OnHoverImage = null;
            this.btnGenarateMp.OnHoverLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenarateMp.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenarateMp.Radius = 20;
            this.btnGenarateMp.Size = new System.Drawing.Size(119, 41);
            this.btnGenarateMp.TabIndex = 21;
            this.btnGenarateMp.Text = "Generate";
            this.btnGenarateMp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenarateMp.Click += new System.EventHandler(this.btnGenarateMp_Click);
            // 
            // btnpaste
            // 
            this.btnpaste.BackColor = System.Drawing.Color.Transparent;
            this.btnpaste.Image = ((System.Drawing.Image)(resources.GetObject("btnpaste.Image")));
            this.btnpaste.ImageActive = null;
            this.btnpaste.Location = new System.Drawing.Point(392, 43);
            this.btnpaste.Name = "btnpaste";
            this.btnpaste.Size = new System.Drawing.Size(25, 25);
            this.btnpaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnpaste.TabIndex = 22;
            this.btnpaste.TabStop = false;
            this.btnpaste.Zoom = 10;
            this.btnpaste.Click += new System.EventHandler(this.btnpaste_Click);
            // 
            // MasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 172);
            this.Controls.Add(this.btnpaste);
            this.Controls.Add(this.btnGenarateMp);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.btnMPwdCopy);
            this.Controls.Add(this.txtMPwd);
            this.Controls.Add(this.txtMUPwd);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterPassword";
            this.Load += new System.EventHandler(this.MasterPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMPwdCopy)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpaste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMUPwd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMPwd;
        private Bunifu.Framework.UI.BunifuImageButton btnMPwdCopy;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenarateMp;
        private Bunifu.Framework.UI.BunifuImageButton btnpaste;
    }
}