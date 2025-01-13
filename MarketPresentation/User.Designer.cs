namespace MarketPresentation
{
    partial class frm_UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserProfile));
            btn_back = new Button();
            btn_Submit = new Button();
            txt_email = new TextBox();
            txt_adress = new TextBox();
            txt_age = new TextBox();
            txt_name = new TextBox();
            lbl_Adress = new Label();
            lbl_Age = new Label();
            lbl_email = new Label();
            lbl_Name = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lbl_link = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            btn_back.Location = new Point(464, 423);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(163, 54);
            btn_back.TabIndex = 28;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_Submit
            // 
            btn_Submit.BackColor = SystemColors.Highlight;
            btn_Submit.FlatAppearance.BorderSize = 0;
            btn_Submit.FlatStyle = FlatStyle.Flat;
            btn_Submit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.ForeColor = SystemColors.ButtonFace;
            btn_Submit.Image = (Image)resources.GetObject("btn_Submit.Image");
            btn_Submit.ImageAlign = ContentAlignment.MiddleRight;
            btn_Submit.Location = new Point(655, 423);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(169, 55);
            btn_Submit.TabIndex = 22;
            btn_Submit.Text = "Update";
            btn_Submit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Submit.UseVisualStyleBackColor = false;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(464, 340);
            txt_email.MaximumSize = new Size(360, 50);
            txt_email.MinimumSize = new Size(360, 35);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Write Email";
            txt_email.Size = new Size(360, 35);
            txt_email.TabIndex = 18;
            // 
            // txt_adress
            // 
            txt_adress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_adress.Location = new Point(464, 268);
            txt_adress.MaximumSize = new Size(360, 50);
            txt_adress.MinimumSize = new Size(360, 35);
            txt_adress.Name = "txt_adress";
            txt_adress.PlaceholderText = "Cairo";
            txt_adress.Size = new Size(360, 35);
            txt_adress.TabIndex = 17;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(464, 198);
            txt_age.MaximumSize = new Size(360, 50);
            txt_age.MinimumSize = new Size(360, 35);
            txt_age.Name = "txt_age";
            txt_age.PlaceholderText = " 20 ";
            txt_age.Size = new Size(360, 35);
            txt_age.TabIndex = 16;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(464, 134);
            txt_name.MaximumSize = new Size(360, 50);
            txt_name.MinimumSize = new Size(360, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write Full Name";
            txt_name.Size = new Size(360, 35);
            txt_name.TabIndex = 15;
            // 
            // lbl_Adress
            // 
            lbl_Adress.AutoSize = true;
            lbl_Adress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Adress.ForeColor = SystemColors.ControlDarkDark;
            lbl_Adress.Location = new Point(461, 244);
            lbl_Adress.Name = "lbl_Adress";
            lbl_Adress.Size = new Size(60, 21);
            lbl_Adress.TabIndex = 26;
            lbl_Adress.Text = "Adress";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Age.ForeColor = SystemColors.ControlDarkDark;
            lbl_Age.Location = new Point(464, 174);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(40, 21);
            lbl_Age.TabIndex = 25;
            lbl_Age.Text = "Age";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_email.Location = new Point(464, 316);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(48, 21);
            lbl_email.TabIndex = 23;
            lbl_email.Text = "Email";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = SystemColors.ControlDarkDark;
            lbl_Name.Location = new Point(461, 110);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(82, 21);
            lbl_Name.TabIndex = 19;
            lbl_Name.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(461, 79);
            label1.Name = "label1";
            label1.Size = new Size(138, 13);
            label1.TabIndex = 31;
            label1.Text = "Update your imformation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(456, 38);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 30;
            label2.Text = "Profile Form";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Market.Presentation.Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(843, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_link
            // 
            lbl_link.AutoSize = true;
            lbl_link.Cursor = Cursors.Hand;
            lbl_link.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_link.ForeColor = SystemColors.ControlDarkDark;
            lbl_link.LinkColor = Color.FromArgb(64, 64, 64);
            lbl_link.Location = new Point(101, 484);
            lbl_link.Name = "lbl_link";
            lbl_link.Size = new Size(228, 15);
            lbl_link.TabIndex = 33;
            lbl_link.TabStop = true;
            lbl_link.Text = "If you need to change Password click here";
            lbl_link.LinkClicked += lbl_link_LinkClicked;
            // 
            // frm_UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(883, 527);
            Controls.Add(lbl_link);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            Controls.Add(btn_Submit);
            Controls.Add(txt_email);
            Controls.Add(txt_adress);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(lbl_Adress);
            Controls.Add(lbl_Age);
            Controls.Add(lbl_email);
            Controls.Add(lbl_Name);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_UserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile ";
            Load += frm_UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_Submit;
        private TextBox txt_email;
        private TextBox txt_adress;
        private TextBox txt_age;
        private TextBox txt_name;
        private Label lbl_Adress;
        private Label lbl_Age;
        private Label lbl_email;
        private Label lbl_Name;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private LinkLabel lbl_link;
    }
}