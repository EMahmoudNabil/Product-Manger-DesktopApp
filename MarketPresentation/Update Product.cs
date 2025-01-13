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
    public partial class frm_EditProduct : Form
    {

        private int productId;
        private string productName;
        private int categoryId;
        private decimal price;
        private int quantity;
        private string description;
        CategoriesService categoriesService;
        public frm_EditProduct(int id, string name, int categoryId, string categoryName, decimal price, int quantity, string description)
        {


            InitializeComponent();
            Console.WriteLine(name);

            this.productId = id;
            this.productName = name;
            this.categoryId = categoryId;
            this.price = price;
            this.quantity = quantity;
            this.description = description;
            categoriesService = new CategoriesService();

            this.Load += frm_EditProduct_Load;
        }

        private void frm_EditProduct_Load(object sender, EventArgs e)
        {
            ApplyStyleToForm();

            txt_Productname.Text = productName;
            rtxt_discription.Text = description;
            num_Price.Value = price;
            num_Quantity.Value = quantity;
            cmb_category.SelectedValue = categoryId;
            cmb_category.DataSource = categoriesService.GetCategory();
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "ID";


            cmb_category.SelectedValue = categoryId;

            Console.WriteLine($"Name: {productName}, CategoryID: {categoryId}, Price: {price}, Quantity: {quantity}");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string productName = txt_Productname.Text;
            int categoryId = (int)cmb_category.SelectedValue;
            decimal productPrice = Convert.ToDecimal(num_Price.Text);
            string quantity = num_Quantity.Text;
            string description = rtxt_discription.Text;


            ProductService productService = new ProductService();
            int result = productService.UpdateProduct(productId, productName, categoryId, productPrice, quantity, description);

            if (result > 0)
            {
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while updating the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStyleToForm()
        {

            this.BackColor = Color.FromArgb(240, 248, 255);

            // تنسيق جميع العناصر في النموذج
            foreach (Control control in this.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(55, 71, 79); // رمادي مائل للأزرق
                    lbl.Font = new Font("Arial", 12, FontStyle.Bold); // خط غامق
                }
                else if (control is TextBox txt)
                {
                    //txt.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //txt.ForeColor = Color.White; // نص أبيض
                    txt.Font = new Font("Arial", 12);
                }
                else if (control is ComboBox cmb)
                {
                    //cmb.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //cmb.ForeColor = Color.White; // نص أبيض
                    cmb.Font = new Font("Arial", 12);
                }
                else if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(2, 136, 209); // أزرق متوسط
                    btn.ForeColor = Color.White; // نص أبيض
                    btn.FlatStyle = FlatStyle.Flat; // إزالة التأثير ثلاثي الأبعاد
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0; // إزالة الإطار الخارجي
                }
                else if (control is NumericUpDown num)
                {
                    //num.BackColor = Color.FromArgb(33, 33, 33); // رمادي غامق
                    //num.ForeColor = Color.White; // نص أبيض
                    num.Font = new Font("Arial", 12);
                }
                else if (control is RichTextBox rtxt)
                {
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
