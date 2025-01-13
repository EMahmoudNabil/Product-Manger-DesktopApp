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
    public partial class frm_catecory : Form
    {

        CategoriesService catecoryService;

        public frm_catecory()
        {
            InitializeComponent();
            catecoryService = new CategoriesService();
        }

        private void frm_catecory_Load(object sender, EventArgs e)
        {
            DataTable dt = catecoryService.GetCategory();
            dgv_category.DataSource = dt;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

            //// ضبط الألوان والخطوط الأساسية
            //this.BackColor = ColorTranslator.FromHtml("#E8F0FE");
            //txt_Catname.BackColor = Color.White;
            //txt_Catname.ForeColor = ColorTranslator.FromHtml("#4A4A4A");
            //txt_Catname.Font = new Font("Segoe UI", 14F, FontStyle.Regular);

            //lbl_CatName.ForeColor = ColorTranslator.FromHtml("#333333");
            //lbl_CatName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);

            // تصميم DataGridView
            StyleDataGridView(dgv_category);

            //// تخصيص أزرار العمليات
            //StyleButton(btn_Create, ColorTranslator.FromHtml("#28A745")); // زر إضافة باللون الأخضر
            //StyleButton(btn_update, ColorTranslator.FromHtml("#007BFF")); // زر تعديل باللون الأزرق
            //StyleButton(btn_delete, ColorTranslator.FromHtml("#DC3545")); // زر حذف باللون الأحمر


        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrWhiteSpace(txt_Catname.Text))
            {
                MessageBox.Show("Please enter Category Name.");
                return;
            }
            //creation
            int result = catecoryService.addCategory(txt_Catname.Text);
            if (result > 0)
            {
                MessageBox.Show("Category Added");
                DataTable dt = catecoryService.GetCategory();
                dgv_category.DataSource = dt;
                txt_Catname.Text = "";
            }

        }

        private int selectedCatId = -1;
        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_category.Rows[e.RowIndex];

                txt_Catname.Text = row.Cells["Name"].Value.ToString();


                selectedCatId = Convert.ToInt32(row.Cells["ID"].Value);
                btn_Create.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
            else
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txt_Catname.Text))
            {
                MessageBox.Show("Please enter Category Name.");
                return;
            }
            int result = catecoryService.UpdateCategory(selectedCatId, txt_Catname.Text);
            if (result > 0)
            {
                MessageBox.Show("Category Updated");
                DataTable dt = catecoryService.GetCategory();
                dgv_category.DataSource = dt;
                txt_Catname.Text = "";
                btn_Create.Enabled = true;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txt_Catname.Text))
            {
                MessageBox.Show("Please enter Category Name.");
                return;
            }
            int result = catecoryService.deleteCategory(selectedCatId);
            if (result > 0)
            {
                MessageBox.Show("Category deleted");
                DataTable dt = catecoryService.GetCategory();
                dgv_category.DataSource = dt;
                txt_Catname.Text = "";
                btn_Create.Enabled = true;
            }
        }


        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = ColorTranslator.FromHtml("#F8FAFC");
            dgv.GridColor = ColorTranslator.FromHtml("#D1D5DB");
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1E3A8A");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#374151");
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#BFDBFE");
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowHeadersVisible = false; // إخفاء الأعمدة الجانبية
            dgv.EnableHeadersVisualStyles = false; // تعطيل الأنماط الافتراضية
        }

        // دالة تخصيص الأزرار
        private void StyleButton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Catname.Text = "";
        }
    }
}
