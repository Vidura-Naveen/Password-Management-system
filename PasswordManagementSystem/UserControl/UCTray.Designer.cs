namespace PasswordManagementSystem
{
    partial class UCTray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTray));
            this.pboxicon = new System.Windows.Forms.PictureBox();
            this.lblWebName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrayPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btntraycopy = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTrayCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxicon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntraycopy)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxicon
            // 
            this.pboxicon.Image = ((System.Drawing.Image)(resources.GetObject("pboxicon.Image")));
            this.pboxicon.Location = new System.Drawing.Point(12, 8);
            this.pboxicon.Name = "pboxicon";
            this.pboxicon.Size = new System.Drawing.Size(25, 25);
            this.pboxicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxicon.TabIndex = 0;
            this.pboxicon.TabStop = false;
            // 
            // lblWebName
            // 
            this.lblWebName.AutoSize = true;
            this.lblWebName.BackColor = System.Drawing.Color.Transparent;
            this.lblWebName.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebName.ForeColor = System.Drawing.Color.Black;
            this.lblWebName.Location = new System.Drawing.Point(53, 3);
            this.lblWebName.Name = "lblWebName";
            this.lblWebName.Size = new System.Drawing.Size(69, 16);
            this.lblWebName.TabIndex = 1;
            this.lblWebName.Text = "Facebook";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(178, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 14);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User 1";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pboxicon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 40);
            this.panel1.TabIndex = 3;
            // 
            // lblTrayPassword
            // 
            this.lblTrayPassword.AutoSize = true;
            this.lblTrayPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblTrayPassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrayPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrayPassword.Location = new System.Drawing.Point(262, 22);
            this.lblTrayPassword.Name = "lblTrayPassword";
            this.lblTrayPassword.Size = new System.Drawing.Size(62, 17);
            this.lblTrayPassword.TabIndex = 6;
            this.lblTrayPassword.Text = "Password";
            this.lblTrayPassword.Visible = false;
            // 
            // btntraycopy
            // 
            this.btntraycopy.BackColor = System.Drawing.Color.Transparent;
            this.btntraycopy.Image = ((System.Drawing.Image)(resources.GetObject("btntraycopy.Image")));
            this.btntraycopy.ImageActive = null;
            this.btntraycopy.Location = new System.Drawing.Point(337, 11);
            this.btntraycopy.Name = "btntraycopy";
            this.btntraycopy.Size = new System.Drawing.Size(20, 20);
            this.btntraycopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntraycopy.TabIndex = 7;
            this.btntraycopy.TabStop = false;
            this.btntraycopy.Zoom = 10;
            this.btntraycopy.Click += new System.EventHandler(this.btntraycopy_Click);
            // 
            // lblTrayCategory
            // 
            this.lblTrayCategory.AutoSize = true;
            this.lblTrayCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblTrayCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrayCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrayCategory.Location = new System.Drawing.Point(54, 23);
            this.lblTrayCategory.Name = "lblTrayCategory";
            this.lblTrayCategory.Size = new System.Drawing.Size(53, 14);
            this.lblTrayCategory.TabIndex = 8;
            this.lblTrayCategory.Text = "Category";
            // 
            // UCTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTrayCategory);
            this.Controls.Add(this.btntraycopy);
            this.Controls.Add(this.lblTrayPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWebName);
            this.Controls.Add(this.panel1);
            this.Name = "UCTray";
            this.Size = new System.Drawing.Size(364, 40);
            this.Load += new System.EventHandler(this.UCTray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxicon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btntraycopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxicon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWebName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrayPassword;
        private Bunifu.Framework.UI.BunifuImageButton btntraycopy;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrayCategory;
    }
}
