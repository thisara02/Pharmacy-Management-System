namespace Management_System
{
    partial class FrmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.btnAddSupplier);
            this.groupBox1.Controls.Add(this.btnAddMedicine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(43, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(69, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Browse Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(437, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add New Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(450, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add New Medicine";
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowser.BackgroundImage")));
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowser.Location = new System.Drawing.Point(38, 300);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(264, 193);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.BackgroundImage")));
            this.btnAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSupplier.Location = new System.Drawing.Point(375, 303);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(303, 186);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.BackgroundImage")));
            this.btnAddMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMedicine.Location = new System.Drawing.Point(375, 57);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(303, 186);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(26, 57);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(276, 186);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(700, 115);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 739);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard-Sunethra Pharmacy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
    }
}