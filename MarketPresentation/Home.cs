using Market.Business;
using Market.Presentation;
using MarketPresentation;
using System;
using System.Data;
using System.Windows.Forms;

namespace Market.Presentation
{
    public partial class frm_Home : Form
    {
        private string UserRole;
        private int currentUserId;
        private string currentUserName;

        UserService userService;
        ProductService productService;

        public frm_Home(string userRole, int userId, string userName)
        {
            InitializeComponent();
            this.UserRole = userRole;
            this.currentUserId = userId;
            this.currentUserName = userName;

            UpdateMenuStrip();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

            dgv_Product.ForeColor = ColorTranslator.FromHtml("#F0F8FF");
            SetMenuVisibility();

            StyleDataGridView(dgv_Product);
            userService = new UserService();
            productService = new ProductService();
            //toolStripTextBox1.ForeColor = Color.Gray;

            //toolStripTextBox1.Text = "Search products...";
            txt_search.GotFocus += txt_search_GotFocus;
            txt_search.LostFocus += txt_search_LostFocus;

            txt_search.TextChanged += txt_search_TextChanged;

            LoadProducts();
        }
        //private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    string searchText = toolStripTextBox1.Text.Trim();

        //    if (string.IsNullOrEmpty(searchText) || searchText == "Search products...")
        //    {
        //        LoadProducts();
        //    }
        //    else
        //    {
        //        productService.GetProducts(searchText);
        //    }
        //}

        private void txt_search_GotFocus(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search products...")
            {
                txt_search.Text = string.Empty;
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                txt_search.ForeColor = Color.Gray;
                txt_search.Text = "Search products...";
                LoadProducts();
            }
            else
            {
                LoadProducts(txt_search.Text);
            }
        }
        private void UpdateMenuStrip()
        {

            //userToolStripMenuItem.Text = currentUserName;
            lbl_Name.Text = currentUserName;
        }
        private void SetMenuVisibility()
        {
            bool isAdmin = UserRole == UserRoles.Admin;

            //addProductToolStripMenuItem.Visible = isAdmin;
            //editProductToolStripMenuItem.Visible = isAdmin;
            //deleteProductToolStripMenuItem.Visible = isAdmin;
            //categoriesToolStripMenuItem.Visible = isAdmin;



            pAddProduct.Visible = isAdmin;
            pEditProduct.Visible = isAdmin;
            pDeleteProduct.Visible = isAdmin;
            btn_Cat.Visible = isAdmin;
            btn_cat1.Visible = isAdmin;
        }

        private void LoadProducts(string searchTerm = null)
        {
            try
            {
                ProductService productService = new ProductService();
                DataTable products = productService.GetProducts(searchTerm);
                dgv_Product.DataSource = products;


                if (dgv_Product.Columns.Count > 0)
                {
                    dgv_Product.Columns["ID"].HeaderText = "Product ID";
                    dgv_Product.Columns["Name"].HeaderText = "Product Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private int GetSelectedProductId()
        {
            if (dgv_Product.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgv_Product.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a product first.");
                return -1;
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddProduct addProductForm = new frm_AddProduct();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgv_Product.CurrentRow != null)
            {
                DataGridViewRow row = dgv_Product.CurrentRow;

                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string name = row.Cells["Name"].Value.ToString();
                string categoryName = row.Cells["CategoryName"].Value.ToString();
                int categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                string description = row.Cells["Discription"].Value.ToString();

                frm_EditProduct editProductForm = new frm_EditProduct(id, name, categoryId, categoryName, price, quantity, description);
                editProductForm.ShowDialog();
                LoadProducts();

            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId();
            if (productId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ProductService productService = new ProductService();
                        productService.DeleteProduct(productId);
                        MessageBox.Show("Product deleted successfully.");
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}");
                    }
                }
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_catecory categoriesForm = new frm_catecory();
            categoriesForm.ShowDialog();
        }

        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId();
            if (productId != -1)
            {
                try
                {
                    FavoriteService favoriteService = new FavoriteService();
                    int rowsAffected = favoriteService.AddToFavorite(currentUserId, productId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added to favorites successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to favorites.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding to favorites: {ex.Message}");
                }
            }
        }

        private void viewFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FavoriteService favoriteService = new FavoriteService();
                DataTable favorites = favoriteService.GetFavoritesByUserId(currentUserId);

                if (favorites != null && favorites.Rows.Count > 0)
                {
                    dgv_Product.DataSource = favorites;
                }
                else
                {
                    MessageBox.Show("No favorites found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading favorites: {ex.Message}");
            }
        }

        private void removeFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int favoriteId = GetSelectedFavoriteId();
            if (favoriteId != -1)
            {
                try
                {
                    FavoriteService favoriteService = new FavoriteService();
                    int rowsAffected = favoriteService.RemoveFromFavorite(favoriteId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Favorite removed successfully.");
                        viewFavoritesToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove favorite.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing favorite: {ex.Message}");
                }
            }
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(240, 248, 255); // أزرق باهت جدًا

            dgv.GridColor = Color.FromArgb(200, 200, 200); // رمادي فاتح


            dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // أبيض
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79); // رمادي مائل للأزرق
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 212, 250); // أزرق باهت
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // أبيض
            dgv.DefaultCellStyle.Font = new Font("Arial", 12);


            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 136, 209); // أزرق متوسط
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // أبيض
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;


            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // أبيض
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79); // رمادي مائل للأزرق


            dgv.RowTemplate.Height = 30;


            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;


            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private int GetSelectedFavoriteId()
        {
            if (dgv_Product.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgv_Product.SelectedRows[0].Cells["FavoriteID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a favorite first.");
                return -1;
            }
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_UserProfile profileForm = new frm_UserProfile(userService.GetCurrentUser(currentUserId));
            //profileForm.ShowDialog();

            //userToolStripMenuItem.Text = currentUserName;

            DataTable userData = userService.GetCurrentUser(currentUserId);

            if (userData.Rows.Count > 0)
            {
                var profileForm = new frm_UserProfile(userData, currentUserId);
                profileForm.OnUserNameUpdated = (updatedName) =>
                {

                    this.currentUserName = updatedName;
                    UpdateMenuStrip();
                };

                profileForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangePassword changePasswordForm = new frm_ChangePassword(currentUserId);
            changePasswordForm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void pic_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable userData = userService.GetCurrentUser(currentUserId);

            if (userData.Rows.Count > 0)
            {
                var profileForm = new frm_UserProfile(userData, currentUserId);
                profileForm.OnUserNameUpdated = (updatedName) =>
                {

                    this.currentUserName = updatedName;
                    UpdateMenuStrip();
                };

                profileForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frm_Login LoginsForm = new frm_Login();
                LoginsForm.ShowDialog();
            }
        }

        private void pViewProduct_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void pAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void pEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void pDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            frm_catecory categoriesForm = new frm_catecory();
            categoriesForm.ShowDialog();
        }

        private void pViewFav_Click(object sender, EventArgs e)
        {

        }

        private void pAddFav_Click(object sender, EventArgs e)
        {

        }

        private void pDeletFav_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "Search products...")
            {
                LoadProducts();
            }
            else
            {
                productService.GetProducts(searchText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (piconlarge.Visible == false)
            {
                piconlarge.Visible = true;
                piconSmall.Visible = false;
            }
            else
            {
                piconlarge.Visible = false;
                piconSmall.Visible = true;
            }
        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piconlarge.Visible = true;
            piconSmall.Visible = false;
            txt_search.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            piconlarge.Visible = true;
            piconSmall.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            piconlarge.Visible = true;
            piconSmall.Visible = false;
        }

        private void btn_cat1_Click(object sender, EventArgs e)
        {
            frm_catecory categoriesForm = new frm_catecory();
            categoriesForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frm_Login LoginsForm = new frm_Login();
                LoginsForm.ShowDialog();
            }
        }

        private void pViewProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId();
            if (productId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ProductService productService = new ProductService();
                        productService.DeleteProduct(productId);
                        MessageBox.Show("Product deleted successfully.");
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}");
                    }
                }
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            frm_AddProduct addProductForm = new frm_AddProduct();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (dgv_Product.CurrentRow != null)
            {
                DataGridViewRow row = dgv_Product.CurrentRow;

                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string name = row.Cells["Name"].Value.ToString();
                string categoryName = row.Cells["CategoryName"].Value.ToString();
                int categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                string description = row.Cells["Discription"].Value.ToString();

                frm_EditProduct editProductForm = new frm_EditProduct(id, name, categoryId, categoryName, price, quantity, description);
                editProductForm.ShowDialog();
                LoadProducts();

            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                FavoriteService favoriteService = new FavoriteService();
                DataTable favorites = favoriteService.GetFavoritesByUserId(currentUserId);

                if (favorites != null && favorites.Rows.Count > 0)
                {
                    dgv_Product.DataSource = favorites;
                }
                else
                {
                    MessageBox.Show("No favorites found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading favorites: {ex.Message}");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int favoriteId = GetSelectedFavoriteId();
            if (favoriteId != -1)
            {
                try
                {
                    FavoriteService favoriteService = new FavoriteService();
                    int rowsAffected = favoriteService.RemoveFromFavorite(favoriteId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Favorite removed successfully.");
                        viewFavoritesToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove favorite.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing favorite: {ex.Message}");
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId();
            if (productId != -1)
            {
                try
                {
                    FavoriteService favoriteService = new FavoriteService();
                    int rowsAffected = favoriteService.AddToFavorite(currentUserId, productId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added to favorites successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to favorites.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding to favorites: {ex.Message}");
                }
            }
        }
    }

    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
