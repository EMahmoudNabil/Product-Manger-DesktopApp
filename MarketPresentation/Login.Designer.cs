namespace MarketPresentation
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            txt_name = new TextBox();
            lbl_username = new Label();
            txt_Pass = new TextBox();
            lbl_password = new Label();
            btn_back = new Button();
            btn_Login = new Button();
            lbl_link = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            pictureBox2 = new PictureBox();
            chk_password = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(362, 215);
            txt_name.MaximumSize = new Size(340, 50);
            txt_name.MinimumSize = new Size(340, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write User Name ......";
            txt_name.Size = new Size(340, 35);
            txt_name.TabIndex = 8;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 14F);
            lbl_username.ForeColor = SystemColors.ControlDarkDark;
            lbl_username.Location = new Point(362, 187);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(107, 25);
            lbl_username.TabIndex = 9;
            lbl_username.Text = "User Name";
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Pass.Location = new Point(362, 309);
            txt_Pass.MaximumSize = new Size(340, 50);
            txt_Pass.MaxLength = 15;
            txt_Pass.MinimumSize = new Size(340, 35);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PasswordChar = '*';
            txt_Pass.PlaceholderText = "*******************";
            txt_Pass.Size = new Size(340, 35);
            txt_Pass.TabIndex = 10;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Semibold", 14F);
            lbl_password.ForeColor = SystemColors.ControlDarkDark;
            lbl_password.Location = new Point(362, 281);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(91, 25);
            lbl_password.TabIndex = 11;
            lbl_password.Text = "Password";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Image = Market.Presentation.Properties.Resources.icons8_back_501;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(366, 388);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(146, 54);
            btn_back.TabIndex = 13;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.Highlight;
            btn_Login.BackgroundImageLayout = ImageLayout.None;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.ButtonFace;
            btn_Login.Image = (Image)resources.GetObject("btn_Login.Image");
            btn_Login.ImageAlign = ContentAlignment.MiddleRight;
            btn_Login.Location = new Point(537, 388);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(165, 54);
            btn_Login.TabIndex = 12;
            btn_Login.Text = "Login";
            btn_Login.TextAlign = ContentAlignment.MiddleLeft;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // lbl_link
            // 
            lbl_link.AutoSize = true;
            lbl_link.Cursor = Cursors.Hand;
            lbl_link.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_link.ForeColor = SystemColors.ControlDarkDark;
            lbl_link.LinkColor = Color.FromArgb(64, 64, 64);
            lbl_link.Location = new Point(394, 458);
            lbl_link.Name = "lbl_link";
            lbl_link.Size = new Size(270, 15);
            lbl_link.TabIndex = 14;
            lbl_link.TabStop = true;
            lbl_link.Text = "If you haven`t accout you can click to registration ";
            lbl_link.LinkClicked += lbl_link_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(362, 73);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 16;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(366, 116);
            label2.Name = "label2";
            label2.Size = new Size(230, 13);
            label2.TabIndex = 17;
            label2.Text = "Welecome To BubbleMall Application Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Market.Presentation.Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(670, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // chk_password
            // 
            chk_password.AutoSize = true;
            chk_password.ForeColor = SystemColors.ControlDarkDark;
            chk_password.Location = new Point(366, 350);
            chk_password.Name = "chk_password";
            chk_password.Size = new Size(108, 19);
            chk_password.TabIndex = 19;
            chk_password.Text = "Show Password";
            chk_password.UseVisualStyleBackColor = true;
            chk_password.CheckedChanged += chk_password_CheckedChanged;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(717, 499);
            Controls.Add(chk_password);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_link);
            Controls.Add(btn_back);
            Controls.Add(btn_Login);
            Controls.Add(txt_Pass);
            Controls.Add(lbl_password);
            Controls.Add(txt_name);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private Label lbl_username;
        private TextBox txt_Pass;
        private Label lbl_password;
        private Button btn_back;
        private Button btn_Login;
        private LinkLabel lbl_link;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox2;
        private CheckBox chk_password;
    }
}