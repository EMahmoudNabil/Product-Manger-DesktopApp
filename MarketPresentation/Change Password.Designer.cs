namespace Market.Presentation
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            txtOldPassword = new TextBox();
            lbl_OldPassword = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            btn_back = new Button();
            btn_Update = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 14F);
            txtOldPassword.Location = new Point(354, 167);
            txtOldPassword.MaximumSize = new Size(340, 50);
            txtOldPassword.MaxLength = 15;
            txtOldPassword.MinimumSize = new Size(340, 35);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.PlaceholderText = "*******************";
            txtOldPassword.Size = new Size(340, 35);
            txtOldPassword.TabIndex = 12;
            // 
            // lbl_OldPassword
            // 
            lbl_OldPassword.AutoSize = true;
            lbl_OldPassword.Font = new Font("Segoe UI Semibold", 12F);
            lbl_OldPassword.ForeColor = SystemColors.ControlDarkDark;
            lbl_OldPassword.Location = new Point(354, 132);
            lbl_OldPassword.Name = "lbl_OldPassword";
            lbl_OldPassword.Size = new Size(109, 21);
            lbl_OldPassword.TabIndex = 13;
            lbl_OldPassword.Text = "Old Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 14F);
            txtNewPassword.Location = new Point(354, 244);
            txtNewPassword.MaximumSize = new Size(340, 50);
            txtNewPassword.MaxLength = 15;
            txtNewPassword.MinimumSize = new Size(340, 35);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "*******************";
            txtNewPassword.Size = new Size(340, 35);
            txtNewPassword.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 14F);
            txtConfirmPassword.Location = new Point(354, 323);
            txtConfirmPassword.MaximumSize = new Size(340, 50);
            txtConfirmPassword.MaxLength = 15;
            txtConfirmPassword.MinimumSize = new Size(340, 35);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "*******************";
            txtConfirmPassword.Size = new Size(340, 35);
            txtConfirmPassword.TabIndex = 15;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 12F);
            lblNewPassword.ForeColor = SystemColors.ControlDarkDark;
            lblNewPassword.Location = new Point(354, 220);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(116, 21);
            lblNewPassword.TabIndex = 16;
            lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 12F);
            lblConfirmPassword.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmPassword.Location = new Point(354, 299);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(179, 21);
            lblConfirmPassword.TabIndex = 17;
            lblConfirmPassword.Text = "Confirm New Password";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(344, 407);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(165, 54);
            btn_back.TabIndex = 19;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.Highlight;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = SystemColors.ButtonFace;
            btn_Update.Image = (Image)resources.GetObject("btn_Update.Image");
            btn_Update.ImageAlign = ContentAlignment.MiddleRight;
            btn_Update.Location = new Point(529, 407);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(165, 54);
            btn_Update.TabIndex = 18;
            btn_Update.Text = "Update";
            btn_Update.TextAlign = ContentAlignment.MiddleLeft;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(681, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(354, 85);
            label1.Name = "label1";
            label1.Size = new Size(122, 13);
            label1.TabIndex = 33;
            label1.Text = "Update your Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(344, 53);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 32;
            label2.Text = "Change Password";
            // 
            // frm_ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(728, 510);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            Controls.Add(btn_Update);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lbl_OldPassword);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frm_ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldPassword;
        private Label lbl_OldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private Button btn_back;
        private Button btn_Update;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}