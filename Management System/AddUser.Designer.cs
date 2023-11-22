namespace Management_System
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddUser
            // 
            this.gbAddUser.BackColor = System.Drawing.Color.Azure;
            this.gbAddUser.Controls.Add(this.label2);
            this.gbAddUser.Controls.Add(this.linkLabel1);
            this.gbAddUser.Controls.Add(this.btnClear2);
            this.gbAddUser.Controls.Add(this.btnConfirm);
            this.gbAddUser.Controls.Add(this.txtAdmin);
            this.gbAddUser.Controls.Add(this.txtConfirm);
            this.gbAddUser.Controls.Add(this.txtPw);
            this.gbAddUser.Controls.Add(this.txtNewUser);
            this.gbAddUser.Controls.Add(this.label1);
            this.gbAddUser.Controls.Add(this.lbladmin);
            this.gbAddUser.Controls.Add(this.lblConfirm);
            this.gbAddUser.Controls.Add(this.lblPass);
            this.gbAddUser.Controls.Add(this.lblUname);
            this.gbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddUser.Location = new System.Drawing.Point(57, 171);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(493, 503);
            this.gbAddUser.TabIndex = 0;
            this.gbAddUser.TabStop = false;
            this.gbAddUser.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(161, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Canot contain any Symbols(!,@,#,$,%,&)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(285, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 22);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ">>Back to Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.LightGray;
            this.btnClear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear2.Location = new System.Drawing.Point(281, 369);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(122, 37);
            this.btnClear2.TabIndex = 11;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Location = new System.Drawing.Point(88, 369);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 37);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(191, 250);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(232, 27);
            this.txtAdmin.TabIndex = 9;
            this.txtAdmin.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(205, 184);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(236, 27);
            this.txtConfirm.TabIndex = 8;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(133, 132);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(236, 27);
            this.txtPw.TabIndex = 7;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(178, 59);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(278, 27);
            this.txtNewUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(180, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Admin must confirm the New User Adding";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Location = new System.Drawing.Point(24, 253);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(161, 20);
            this.lbladmin.TabIndex = 4;
            this.lbladmin.Text = "Admin Password :";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(24, 191);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(175, 20);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "Confirm Password :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(24, 135);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(103, 20);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password :";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(24, 66);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(148, 20);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "New Username :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(605, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddUser;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}