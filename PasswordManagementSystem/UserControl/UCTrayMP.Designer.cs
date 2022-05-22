namespace PasswordManagementSystem
{
    partial class UCTrayMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTrayMP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxicon = new System.Windows.Forms.PictureBox();
            this.btntraycopy = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTrayPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserNameMp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblWebNameMp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTrayCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntraycopy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pboxicon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 40);
            this.panel1.TabIndex = 4;
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
            // btntraycopy
            // 
            this.btntraycopy.BackColor = System.Drawing.Color.Transparent;
            this.btntraycopy.Image = ((System.Drawing.Image)(resources.GetObject("btntraycopy.Image")));
            this.btntraycopy.ImageActive = null;
            this.btntraycopy.Location = new System.Drawing.Point(334, 10);
            this.btntraycopy.Name = "btntraycopy";
            this.btntraycopy.Size = new System.Drawing.Size(20, 20);
            this.btntraycopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntraycopy.TabIndex = 11;
            this.btntraycopy.TabStop = false;
            this.btntraycopy.Zoom = 10;
            this.btntraycopy.Click += new System.EventHandler(this.btntraycopy_Click);
            // 
            // lblTrayPassword
            // 
            this.lblTrayPassword.AutoSize = true;
            this.lblTrayPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblTrayPassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrayPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrayPassword.Location = new System.Drawing.Point(259, 22);
            this.lblTrayPassword.Name = "lblTrayPassword";
            this.lblTrayPassword.Size = new System.Drawing.Size(62, 17);
            this.lblTrayPassword.TabIndex = 10;
            this.lblTrayPassword.Text = "Password";
            this.lblTrayPassword.Visible = false;
            // 
            // lblUserNameMp
            // 
            this.lblUserNameMp.AutoSize = true;
            this.lblUserNameMp.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameMp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameMp.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserNameMp.Location = new System.Drawing.Point(172, 13);
            this.lblUserNameMp.Name = "lblUserNameMp";
            this.lblUserNameMp.Size = new System.Drawing.Size(41, 14);
            this.lblUserNameMp.TabIndex = 9;
            this.lblUserNameMp.Text = "User 1";
            // 
            // lblWebNameMp
            // 
            this.lblWebNameMp.AutoSize = true;
            this.lblWebNameMp.BackColor = System.Drawing.Color.Transparent;
            this.lblWebNameMp.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebNameMp.ForeColor = System.Drawing.Color.Black;
            this.lblWebNameMp.Location = new System.Drawing.Point(53, 5);
            this.lblWebNameMp.Name = "lblWebNameMp";
            this.lblWebNameMp.Size = new System.Drawing.Size(69, 16);
            this.lblWebNameMp.TabIndex = 8;
            this.lblWebNameMp.Text = "Facebook";
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
            this.lblTrayCategory.TabIndex = 12;
            this.lblTrayCategory.Text = "Category";
            // 
            // UCTrayMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTrayCategory);
            this.Controls.Add(this.btntraycopy);
            this.Controls.Add(this.lblTrayPassword);
            this.Controls.Add(this.lblUserNameMp);
            this.Controls.Add(this.lblWebNameMp);
            this.Controls.Add(this.panel1);
            this.Name = "UCTrayMP";
            this.Size = new System.Drawing.Size(364, 40);
            this.Load += new System.EventHandler(this.UCTrayMP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntraycopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxicon;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btntraycopy;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrayPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserNameMp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWebNameMp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTrayCategory;

        public string Title1 { get; internal set; }
    }
}
