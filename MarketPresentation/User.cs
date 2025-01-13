using Market.Business;
using Market.Presentation;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPresentation
{
   

    public partial class frm_UserProfile : Form
    {
        private int currentUserId;
        private DataTable currentUserData;
        UserService userService;

        public Action<string> OnUserNameUpdated;
        public frm_UserProfile(DataTable userData ,int currentUserId)
        {
            InitializeComponent();

            this.currentUserId = currentUserId;
            if (userData.Rows.Count > 0)
            {
                this.currentUserData = userData;
            }

            //currentUser = userData.Rows[0];
            LoadUserData();
            userService = new UserService();
        }

        private void LoadUserData()
        {
            if (currentUserData != null && currentUserData.Rows.Count > 0)
            {
                DataRow user = currentUserData.Rows[0];
                txt_name.Text = user["Name"].ToString();
                txt_email.Text = user["Email"].ToString();
                txt_age.Text = user["Age"].ToString();
                txt_adress.Text = user["Address"].ToString();

            }
            else
            {
                MessageBox.Show("User data not found.");
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            string updatedName = txt_name.Text;
            string updatedEmail = txt_email.Text;
            int updatedAge = int.Parse(txt_age.Text);
            string updatedAddress = txt_adress.Text;



            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_email.Text) ||
         string.IsNullOrWhiteSpace(txt_age.Text) || string.IsNullOrWhiteSpace(txt_adress.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataRow user = currentUserData.Rows[0];
                userService.UpdateUser(Convert.ToInt32(user["ID"]), updatedName, updatedEmail, updatedAge, updatedAddress);
                MessageBox.Show("User information updated successfully!");
                // إرسال التحديث إلى الشاشة الرئيسية
                OnUserNameUpdated?.Invoke(updatedName);
                this.Close();
            }
        }

        private void frm_UserProfile_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
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

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frm_ChangePassword changePasswordForm = new frm_ChangePassword(currentUserId);
            changePasswordForm.ShowDialog();
        }
    }
}
