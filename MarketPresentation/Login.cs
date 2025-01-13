using Market.Business;
using Market.Presentation;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketPresentation
{
    public partial class frm_Login : Form
    {


        public frm_Login()
        {

            InitializeComponent();
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frm_registration registrationForm = new frm_registration();
            registrationForm.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text.Trim();
            string password = txt_Pass.Text;

            UserService userService = new UserService();

            try
            {
                DataTable userTable = userService.AuthenticateUser(username, password);

                if (userTable.Rows.Count > 0)
                {
                    Console.WriteLine(userTable);

                    string role = userTable.Rows[0]["Role"].ToString();
                    int userID = Convert.ToInt32(userTable.Rows[0]["ID"]);
                    string userName = userTable.Rows[0]["Name"].ToString();

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_Home homeForm = new frm_Home(role, userID, userName);
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //// Background
            //this.BackColor = ColorTranslator.FromHtml("#F0F8FF");

            //// text
            //lbl_username.ForeColor = ColorTranslator.FromHtml("#37474F");

            //lbl_password.ForeColor = ColorTranslator.FromHtml("#37474F");
            //lbl_link.ForeColor = ColorTranslator.FromHtml("#78909C");

            //// button
            //btn_Login.BackColor = ColorTranslator.FromHtml("#81D4FA");
            //btn_Login.ForeColor = Color.White;
            //btn_Login.MouseDown += (s, e) => btn_Login.BackColor = ColorTranslator.FromHtml("#0288D1");
            //btn_Login.MouseUp += (s, e) => btn_Login.BackColor = ColorTranslator.FromHtml("#81D4FA");

            //btn_back.BackColor = ColorTranslator.FromHtml("#64B5F6");
            //btn_back.ForeColor = Color.White;
            //btn_back.MouseDown += (s, e) => btn_back.BackColor = ColorTranslator.FromHtml("#0288D1");
            //btn_back.MouseUp += (s, e) => btn_back.BackColor = ColorTranslator.FromHtml("#81D4FA");



        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Show a confirmation message before closing the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks "Yes" to close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_password.Checked)
            {
                txt_Pass.PasswordChar = '\0'; 
            }
            else
            {
                txt_Pass.PasswordChar = '*';
            }
        }
    }
}
