namespace MarketPresentation
{
    partial class frm_registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registration));
            lbl_Name = new Label();
            lbl_email = new Label();
            lbl_pass = new Label();
            lbl_Age = new Label();
            lbl_Adress = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_adress = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            btn_Submit = new Button();
            lbl_role = new Label();
            cmb_Role = new ComboBox();
            btn_back = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = SystemColors.ControlDarkDark;
            lbl_Name.Location = new Point(342, 91);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(82, 21);
            lbl_Name.TabIndex = 3;
            lbl_Name.Text = "Full Name";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_email.Location = new Point(345, 297);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(48, 21);
            lbl_email.TabIndex = 5;
            lbl_email.Text = "Email";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pass.ForeColor = SystemColors.ControlDarkDark;
            lbl_pass.Location = new Point(342, 364);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(79, 21);
            lbl_pass.TabIndex = 7;
            lbl_pass.Text = "Password";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Age.ForeColor = SystemColors.ControlDarkDark;
            lbl_Age.Location = new Point(345, 155);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(40, 21);
            lbl_Age.TabIndex = 9;
            lbl_Age.Text = "Age";
            // 
            // lbl_Adress
            // 
            lbl_Adress.AutoSize = true;
            lbl_Adress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Adress.ForeColor = SystemColors.ControlDarkDark;
            lbl_Adress.Location = new Point(342, 225);
            lbl_Adress.Name = "lbl_Adress";
            lbl_Adress.Size = new Size(60, 21);
            lbl_Adress.TabIndex = 11;
            lbl_Adress.Text = "Adress";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(345, 117);
            txt_name.MaximumSize = new Size(360, 50);
            txt_name.MinimumSize = new Size(360, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write Full Name";
            txt_name.Size = new Size(360, 35);
            txt_name.TabIndex = 0;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(345, 179);
            txt_age.MaximumSize = new Size(360, 50);
            txt_age.MinimumSize = new Size(360, 35);
            txt_age.Name = "txt_age";
            txt_age.PlaceholderText = " 20 ";
            txt_age.Size = new Size(360, 35);
            txt_age.TabIndex = 1;
            // 
            // txt_adress
            // 
            txt_adress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_adress.Location = new Point(345, 249);
            txt_adress.MaximumSize = new Size(360, 50);
            txt_adress.MinimumSize = new Size(360, 35);
            txt_adress.Name = "txt_adress";
            txt_adress.PlaceholderText = "Cairo";
            txt_adress.Size = new Size(360, 35);
            txt_adress.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(345, 321);
            txt_email.MaximumSize = new Size(360, 50);
            txt_email.MinimumSize = new Size(360, 35);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Write Email";
            txt_email.Size = new Size(360, 35);
            txt_email.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(345, 388);
            txt_pass.MaximumSize = new Size(360, 50);
            txt_pass.MinimumSize = new Size(360, 35);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.PlaceholderText = "Write Password";
            txt_pass.Size = new Size(360, 35);
            txt_pass.TabIndex = 4;
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
            btn_Submit.Location = new Point(522, 501);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(183, 55);
            btn_Submit.TabIndex = 5;
            btn_Submit.Text = "Submit";
            btn_Submit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Submit.UseVisualStyleBackColor = false;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_role.ForeColor = SystemColors.ControlDarkDark;
            lbl_role.Location = new Point(342, 426);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(43, 21);
            lbl_role.TabIndex = 12;
            lbl_role.Text = "Role";
            // 
            // cmb_Role
            // 
            cmb_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_Role.FormattingEnabled = true;
            cmb_Role.Items.AddRange(new object[] { "Admin", "User" });
            cmb_Role.Location = new Point(345, 450);
            cmb_Role.Name = "cmb_Role";
            cmb_Role.Size = new Size(360, 29);
            cmb_Role.TabIndex = 5;
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
            btn_back.Location = new Point(342, 502);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(170, 54);
            btn_back.TabIndex = 14;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Market.Presentation.Properties.Resources.bubblemall;
            pictureBox1.Location = new Point(-85, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 418);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(338, 32);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 17;
            label2.Text = "Registration Form";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Market.Presentation.Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(716, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(342, 67);
            label1.Name = "label1";
            label1.Size = new Size(215, 13);
            label1.TabIndex = 20;
            label1.Text = "Fill out the form carefully for registration";
            // 
            // frm_registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(762, 581);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            Controls.Add(cmb_Role);
            Controls.Add(lbl_role);
            Controls.Add(btn_Submit);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(txt_adress);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(lbl_Adress);
            Controls.Add(lbl_Age);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_email);
            Controls.Add(lbl_Name);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += frm_registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lbl_Name;
        private Label lbl_email;
        private Label lbl_pass;
        private Label lbl_Age;
        private Label lbl_Adress;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_adress;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Button btn_Submit;
        private Label lbl_role;
        private ComboBox cmb_Role;
        private Button btn_back;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
