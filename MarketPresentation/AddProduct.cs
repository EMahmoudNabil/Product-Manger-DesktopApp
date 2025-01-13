using Market.Business;
using Market.Presentation;
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
    public partial class frm_AddProduct : Form
    {

        CategoriesService categoriesService;
        ProductService productService;
        public frm_AddProduct()
        {
            InitializeComponent();
            categoriesService = new CategoriesService();
            productService = new ProductService();
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {


            DataTable Cats = categoriesService.GetCategory();
            cmb_category.DataSource = Cats;
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "ID";
            StyleAddProductForm();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrWhiteSpace(txt_Productname.Text))
            {
                MessageBox.Show("Please enter Product Name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cmb_category.Text))
            {
                MessageBox.Show("Please Select Category Name.");
                return;
            }
            if (num_Price.Value <= 0)
            {
                MessageBox.Show("Price must be a positive value.");
                return;
            }
            if (num_Quantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be a positive value.");
                return;
            }

            //creation
            int result = productService.AddProduct(txt_Productname.Text, (int)cmb_category.SelectedValue, num_Price.Value, (int)num_Quantity.Value, rtxt_discription.Text);
            if (result > 0)
            {
                MessageBox.Show("Product Added");

                txt_Productname.Text = "";
                cmb_category.SelectedValue = 0;
                num_Price.Value = 0;
                num_Quantity.Value = 0;
                rtxt_discription.Text = "";
            }
        }

        private void StyleAddProductForm()
        {
            // تنسيق الخلفية
            this.BackColor = Color.FromArgb(240, 248, 255); // أزرق باهت جدًا

            // تنسيق النصوص (Labels)
            foreach (Control control in this.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(55, 71, 79); // رمادي مائل للأزرق
                    lbl.Font = new Font("Arial", 12, FontStyle.Bold); // خط غامق
                }
                else if (control is TextBox txt)
                {
                    // تنسيق TextBox
                    //txt.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //txt.ForeColor = Color.White; // نص أبيض
                    txt.Font = new Font("Arial", 12);
                }
                else if (control is ComboBox cmb)
                {
                    // تنسيق ComboBox
                    //cmb.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //cmb.ForeColor = Color.White; // نص أبيض
                    cmb.Font = new Font("Arial", 12);
                }
                else if (control is Button btn)
                {
                    // تنسيق الأزرار
                    btn.BackColor = Color.FromArgb(2, 136, 209); // أزرق متوسط
                    btn.ForeColor = Color.White; // نص أبيض
                    btn.FlatStyle = FlatStyle.Flat; // إزالة التأثير ثلاثي الأبعاد
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0; // إزالة الإطار الخارجي
                }
                else if (control is NumericUpDown num)
                {
                    // تنسيق NumericUpDown
                    //num.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //num.ForeColor = Color.White; // نص أبيض
                    num.Font = new Font("Arial", 12);
                }
                else if (control is RichTextBox rtxt)
                {
                    // تنسيق RichTextBox
                    //rtxt.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //rtxt.ForeColor = Color.White; // نص أبيض
                    rtxt.Font = new Font("Arial", 12);
                }
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
