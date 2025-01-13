using Market.Business;
using System;
using System.Windows.Forms;

namespace MarketPresentation
{
    public partial class frm_registration : Form
    {
        public frm_registration()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // قراءة القيم من الحقول النصية
            string userName = txt_name.Text.Trim();
            string password = txt_pass.Text.Trim();
            string email = txt_email.Text.Trim();
            int age;
            string address = txt_adress.Text.Trim();
            string role = cmb_Role.SelectedItem?.ToString();

            // تحقق من صحة المدخلات
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || !int.TryParse(txt_age.Text.Trim(), out age))
            {
                MessageBox.Show("Please Enter The Correct text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // إنشاء كائن UserService
                UserService userService = new();

                // استدعاء طريقة AddUser لإضافة المستخدم
                int rowsAffected = userService.AddUser(userName, password, email, age, address, role);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User is Added.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // إغلاق النموذج
                                  // فتح نموذج تسجيل الدخول
                    frm_Login loginForm = new frm_Login();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Error in Registration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_registration_Load(object sender, EventArgs e)
        {
            //// Background
            //this.BackColor = ColorTranslator.FromHtml("#F0F8FF");

            //// text
            //lbl_Name.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_Adress.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_Age.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_email.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_pass.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_role.ForeColor = ColorTranslator.FromHtml("#37474F");
            //// button
            //btn_Submit.BackColor = ColorTranslator.FromHtml("#81D4FA");
            //btn_Submit.ForeColor = Color.White;
            //btn_Submit.MouseDown += (s, e) => btn_Submit.BackColor = ColorTranslator.FromHtml("#0288D1");
            //btn_Submit.MouseUp += (s, e) => btn_Submit.BackColor = ColorTranslator.FromHtml("#81D4FA");

            //btn_back.BackColor = ColorTranslator.FromHtml("#64B5F6");
            //btn_back.ForeColor = Color.White;
            //btn_back.MouseDown += (s, e) => btn_back.BackColor = ColorTranslator.FromHtml("#0288D1");
            //btn_back.MouseUp += (s, e) => btn_back.BackColor = ColorTranslator.FromHtml("#81D4FA");


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Show a confirmation message before closing the registration page
            DialogResult result = MessageBox.Show("Are you sure you want to go back to Login page?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the registration form
                this.Close();

                // Open the Login form
                frm_Login loginForm = new frm_Login(); // Assuming you have a frm_Login
                loginForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
