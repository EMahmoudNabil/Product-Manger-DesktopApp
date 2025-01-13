using Market.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Presentation
{
    public partial class frm_ChangePassword : Form
    {
        private int userId;
        UserService userService;
        public frm_ChangePassword(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            userService = new UserService();
        }

        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {
            //StyleButton(btn_Update, ColorTranslator.FromHtml("#007BFF"));
        }
        //private void StyleButton(Button btn, Color color)
        //{
        //    btn.BackColor = color;
        //    btn.ForeColor = Color.White;
        //    btn.FlatStyle = FlatStyle.Flat;
        //    btn.FlatAppearance.BorderSize = 0;
        //    btn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        //    btn.Cursor = Cursors.Hand;
        //}
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // تحقق مما إذا كانت كلمة المرور الجديدة تؤكد:
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من صحة كلمة المرور القديمة
            bool isOldPasswordValid = userService.CheckOldPassword(userId, oldPassword);

            if (!isOldPasswordValid)
            {
                MessageBox.Show("The old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // تحديث كلمة المرور في قاعدة البيانات
            int updateSuccess = userService.UpdatePassword(userId, newPassword);

            if (updateSuccess > 0)
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // إغلاق الفورم
            }
            else
            {
                MessageBox.Show("An error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this page?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
