namespace Market.Presentation
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            dgv_Product = new DataGridView();
            panel1 = new Panel();
            lbl_Name = new Label();
            pictureBox1 = new PictureBox();
            pic_min = new PictureBox();
            pic_max = new PictureBox();
            pic_Close = new PictureBox();
            piconlarge = new Panel();
            panel11 = new Panel();
            pictureBox14 = new PictureBox();
            txt_search = new TextBox();
            btn_Logout = new Button();
            btn_Cat = new Button();
            pAddFav = new Panel();
            button17 = new Button();
            pictureBox11 = new PictureBox();
            pDeletFav = new Panel();
            button18 = new Button();
            pictureBox12 = new PictureBox();
            pEditProduct = new Panel();
            button11 = new Button();
            pictureBox7 = new PictureBox();
            pViewFav = new Panel();
            button19 = new Button();
            pictureBox13 = new PictureBox();
            pAddProduct = new Panel();
            button12 = new Button();
            pictureBox8 = new PictureBox();
            pDeleteProduct = new Panel();
            button13 = new Button();
            pictureBox9 = new PictureBox();
            pViewProduct = new Panel();
            button14 = new Button();
            pictureBox10 = new PictureBox();
            button15 = new Button();
            button16 = new Button();
            button2 = new Button();
            btn_cat1 = new Button();
            button21 = new Button();
            button22 = new Button();
            pictureBox15 = new PictureBox();
            piconSmall = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Product).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            piconlarge.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            pAddFav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            pDeletFav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            pEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pViewFav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            pAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pViewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            piconSmall.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Product
            // 
            dgv_Product.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgv_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Product.GridColor = SystemColors.ControlText;
            dgv_Product.Location = new Point(211, 96);
            dgv_Product.Name = "dgv_Product";
            dgv_Product.Size = new Size(924, 571);
            dgv_Product.TabIndex = 2;
            dgv_Product.CellContentClick += dgv_Product_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pic_min);
            panel1.Controls.Add(pic_max);
            panel1.Controls.Add(pic_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 43);
            panel1.TabIndex = 3;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = SystemColors.ButtonHighlight;
            lbl_Name.Location = new Point(47, 5);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(0, 30);
            lbl_Name.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pic_min
            // 
            pic_min.Image = (Image)resources.GetObject("pic_min.Image");
            pic_min.Location = new Point(1015, 5);
            pic_min.Name = "pic_min";
            pic_min.Size = new Size(35, 35);
            pic_min.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_min.TabIndex = 2;
            pic_min.TabStop = false;
            pic_min.Click += pic_min_Click;
            // 
            // pic_max
            // 
            pic_max.Enabled = false;
            pic_max.Image = (Image)resources.GetObject("pic_max.Image");
            pic_max.Location = new Point(1056, 5);
            pic_max.Name = "pic_max";
            pic_max.Size = new Size(35, 35);
            pic_max.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_max.TabIndex = 1;
            pic_max.TabStop = false;
            pic_max.Click += pic_max_Click;
            // 
            // pic_Close
            // 
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(1097, 5);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 0;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // piconlarge
            // 
            piconlarge.BackColor = Color.FromArgb(64, 64, 64);
            piconlarge.Controls.Add(panel11);
            piconlarge.Controls.Add(btn_Logout);
            piconlarge.Controls.Add(btn_Cat);
            piconlarge.Controls.Add(pAddFav);
            piconlarge.Controls.Add(pDeletFav);
            piconlarge.Controls.Add(pEditProduct);
            piconlarge.Controls.Add(pViewFav);
            piconlarge.Controls.Add(pAddProduct);
            piconlarge.Controls.Add(pDeleteProduct);
            piconlarge.Controls.Add(pViewProduct);
            piconlarge.Controls.Add(button15);
            piconlarge.Controls.Add(button16);
            piconlarge.Dock = DockStyle.Left;
            piconlarge.Location = new Point(54, 43);
            piconlarge.Name = "piconlarge";
            piconlarge.Size = new Size(200, 624);
            piconlarge.TabIndex = 16;
            piconlarge.Visible = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(pictureBox14);
            panel11.Controls.Add(txt_search);
            panel11.Location = new Point(3, 25);
            panel11.Name = "panel11";
            panel11.Size = new Size(194, 36);
            panel11.TabIndex = 20;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(3, 5);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(35, 29);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 1;
            pictureBox14.TabStop = false;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search.Location = new Point(44, 5);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search products...";
            txt_search.Size = new Size(147, 29);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(64, 64, 64);
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Image = (Image)resources.GetObject("btn_Logout.Image");
            btn_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Logout.Location = new Point(3, 493);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(191, 43);
            btn_Logout.TabIndex = 19;
            btn_Logout.Text = "Logout";
            btn_Logout.TextAlign = ContentAlignment.MiddleRight;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Cat
            // 
            btn_Cat.BackColor = Color.FromArgb(64, 64, 64);
            btn_Cat.FlatAppearance.BorderSize = 0;
            btn_Cat.FlatStyle = FlatStyle.Flat;
            btn_Cat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cat.ForeColor = Color.White;
            btn_Cat.Image = (Image)resources.GetObject("btn_Cat.Image");
            btn_Cat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cat.Location = new Point(12, 396);
            btn_Cat.Name = "btn_Cat";
            btn_Cat.Size = new Size(174, 43);
            btn_Cat.TabIndex = 18;
            btn_Cat.Text = "Category";
            btn_Cat.TextAlign = ContentAlignment.MiddleRight;
            btn_Cat.UseVisualStyleBackColor = false;
            btn_Cat.Click += btn_Cat_Click;
            // 
            // pAddFav
            // 
            pAddFav.Controls.Add(button17);
            pAddFav.Controls.Add(pictureBox11);
            pAddFav.Cursor = Cursors.Hand;
            pAddFav.Location = new Point(20, 351);
            pAddFav.Name = "pAddFav";
            pAddFav.Size = new Size(138, 28);
            pAddFav.TabIndex = 17;
            pAddFav.Click += pAddFav_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(64, 64, 64);
            button17.BackgroundImageLayout = ImageLayout.None;
            button17.Cursor = Cursors.Hand;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.White;
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(47, 1);
            button17.Name = "button17";
            button17.Size = new Size(88, 25);
            button17.TabIndex = 9;
            button17.Text = "Add Favorites";
            button17.TextAlign = ContentAlignment.MiddleRight;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(6, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(26, 24);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            pictureBox11.Click += button17_Click;
            // 
            // pDeletFav
            // 
            pDeletFav.Controls.Add(button18);
            pDeletFav.Controls.Add(pictureBox12);
            pDeletFav.Cursor = Cursors.Hand;
            pDeletFav.Location = new Point(20, 318);
            pDeletFav.Name = "pDeletFav";
            pDeletFav.Size = new Size(141, 33);
            pDeletFav.TabIndex = 16;
            pDeletFav.Click += pDeletFav_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(64, 64, 64);
            button18.BackgroundImageLayout = ImageLayout.None;
            button18.Cursor = Cursors.Hand;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.ForeColor = Color.White;
            button18.ImageAlign = ContentAlignment.MiddleLeft;
            button18.Location = new Point(39, 2);
            button18.Name = "button18";
            button18.Size = new Size(102, 28);
            button18.TabIndex = 9;
            button18.Text = "Delete Favorites";
            button18.TextAlign = ContentAlignment.MiddleRight;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(6, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(27, 27);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 10;
            pictureBox12.TabStop = false;
            pictureBox12.Click += button18_Click;
            // 
            // pEditProduct
            // 
            pEditProduct.Controls.Add(button11);
            pEditProduct.Controls.Add(pictureBox7);
            pEditProduct.Cursor = Cursors.Hand;
            pEditProduct.Location = new Point(20, 208);
            pEditProduct.Name = "pEditProduct";
            pEditProduct.Size = new Size(135, 26);
            pEditProduct.TabIndex = 15;
            pEditProduct.Click += pEditProduct_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(64, 64, 64);
            button11.BackgroundImageLayout = ImageLayout.None;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(47, 0);
            button11.Name = "button11";
            button11.Size = new Size(88, 24);
            button11.TabIndex = 9;
            button11.Text = "Edit Product";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(8, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(23, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += button11_Click_1;
            // 
            // pViewFav
            // 
            pViewFav.Controls.Add(button19);
            pViewFav.Controls.Add(pictureBox13);
            pViewFav.Cursor = Cursors.Hand;
            pViewFav.Location = new Point(20, 284);
            pViewFav.Name = "pViewFav";
            pViewFav.Size = new Size(135, 33);
            pViewFav.TabIndex = 15;
            pViewFav.Click += pViewFav_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(64, 64, 64);
            button19.BackgroundImageLayout = ImageLayout.None;
            button19.Cursor = Cursors.Hand;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = Color.White;
            button19.ImageAlign = ContentAlignment.MiddleLeft;
            button19.Location = new Point(39, 2);
            button19.Name = "button19";
            button19.Size = new Size(96, 27);
            button19.TabIndex = 9;
            button19.Text = "View Favorites";
            button19.TextAlign = ContentAlignment.MiddleRight;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(6, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(27, 26);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 10;
            pictureBox13.TabStop = false;
            pictureBox13.Click += button19_Click;
            // 
            // pAddProduct
            // 
            pAddProduct.Controls.Add(button12);
            pAddProduct.Controls.Add(pictureBox8);
            pAddProduct.Cursor = Cursors.Hand;
            pAddProduct.Location = new Point(20, 179);
            pAddProduct.Name = "pAddProduct";
            pAddProduct.Size = new Size(138, 28);
            pAddProduct.TabIndex = 14;
            pAddProduct.Click += pAddProduct_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(64, 64, 64);
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(47, 1);
            button12.Name = "button12";
            button12.Size = new Size(88, 25);
            button12.TabIndex = 9;
            button12.Text = "Add Product";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click_1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(6, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(26, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            pictureBox8.Click += button12_Click_1;
            // 
            // pDeleteProduct
            // 
            pDeleteProduct.Controls.Add(button13);
            pDeleteProduct.Controls.Add(pictureBox9);
            pDeleteProduct.Cursor = Cursors.Hand;
            pDeleteProduct.Location = new Point(20, 146);
            pDeleteProduct.Name = "pDeleteProduct";
            pDeleteProduct.Size = new Size(135, 33);
            pDeleteProduct.TabIndex = 14;
            pDeleteProduct.Click += pDeleteProduct_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(64, 64, 64);
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(47, 2);
            button13.Name = "button13";
            button13.Size = new Size(94, 28);
            button13.TabIndex = 9;
            button13.Text = "Delete Product";
            button13.TextAlign = ContentAlignment.MiddleRight;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(6, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(27, 27);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 10;
            pictureBox9.TabStop = false;
            pictureBox9.Click += button13_Click_1;
            // 
            // pViewProduct
            // 
            pViewProduct.Controls.Add(button14);
            pViewProduct.Controls.Add(pictureBox10);
            pViewProduct.Cursor = Cursors.Hand;
            pViewProduct.Location = new Point(20, 112);
            pViewProduct.Name = "pViewProduct";
            pViewProduct.Size = new Size(135, 33);
            pViewProduct.TabIndex = 13;
            pViewProduct.Click += pViewProduct_Click;
            pViewProduct.Paint += pViewProduct_Paint;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(64, 64, 64);
            button14.BackgroundImageLayout = ImageLayout.None;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(47, 2);
            button14.Name = "button14";
            button14.Size = new Size(88, 27);
            button14.TabIndex = 9;
            button14.Text = "View Product";
            button14.TextAlign = ContentAlignment.MiddleRight;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(6, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(27, 26);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 10;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(64, 64, 64);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.White;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(12, 240);
            button15.Name = "button15";
            button15.Size = new Size(174, 43);
            button15.TabIndex = 1;
            button15.Text = "Favorites";
            button15.TextAlign = ContentAlignment.MiddleRight;
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(64, 64, 64);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.White;
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.ImageAlign = ContentAlignment.MiddleLeft;
            button16.Location = new Point(12, 67);
            button16.Name = "button16";
            button16.Size = new Size(174, 45);
            button16.TabIndex = 0;
            button16.Text = "Products";
            button16.TextAlign = ContentAlignment.MiddleRight;
            button16.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(40, 39);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_cat1
            // 
            btn_cat1.BackColor = Color.FromArgb(64, 64, 64);
            btn_cat1.FlatAppearance.BorderSize = 0;
            btn_cat1.FlatStyle = FlatStyle.Flat;
            btn_cat1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cat1.ForeColor = Color.White;
            btn_cat1.Image = (Image)resources.GetObject("btn_cat1.Image");
            btn_cat1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cat1.Location = new Point(4, 270);
            btn_cat1.Name = "btn_cat1";
            btn_cat1.Size = new Size(174, 43);
            btn_cat1.TabIndex = 23;
            btn_cat1.Text = "Category";
            btn_cat1.TextAlign = ContentAlignment.MiddleRight;
            btn_cat1.UseVisualStyleBackColor = false;
            btn_cat1.Click += btn_cat1_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(64, 64, 64);
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.ForeColor = Color.White;
            button21.Image = (Image)resources.GetObject("button21.Image");
            button21.ImageAlign = ContentAlignment.MiddleLeft;
            button21.Location = new Point(1, 199);
            button21.Name = "button21";
            button21.Size = new Size(174, 43);
            button21.TabIndex = 22;
            button21.Text = "Favorites";
            button21.TextAlign = ContentAlignment.MiddleRight;
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(64, 64, 64);
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.ForeColor = Color.White;
            button22.Image = (Image)resources.GetObject("button22.Image");
            button22.ImageAlign = ContentAlignment.MiddleLeft;
            button22.Location = new Point(1, 131);
            button22.Name = "button22";
            button22.Size = new Size(174, 45);
            button22.TabIndex = 21;
            button22.Text = "Products";
            button22.TextAlign = ContentAlignment.MiddleRight;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(6, 61);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(45, 39);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 24;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // piconSmall
            // 
            piconSmall.BackColor = Color.FromArgb(64, 64, 64);
            piconSmall.Controls.Add(button1);
            piconSmall.Controls.Add(pictureBox15);
            piconSmall.Controls.Add(button22);
            piconSmall.Controls.Add(button21);
            piconSmall.Controls.Add(btn_cat1);
            piconSmall.Dock = DockStyle.Left;
            piconSmall.Location = new Point(0, 43);
            piconSmall.Name = "piconSmall";
            piconSmall.Size = new Size(54, 624);
            piconSmall.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 495);
            button1.Name = "button1";
            button1.Size = new Size(191, 43);
            button1.TabIndex = 21;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(254, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(881, 39);
            panel2.TabIndex = 17;
            // 
            // frm_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1135, 667);
            Controls.Add(panel2);
            Controls.Add(piconlarge);
            Controls.Add(piconSmall);
            Controls.Add(panel1);
            Controls.Add(dgv_Product);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += frm_Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Product).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            piconlarge.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            pAddFav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            pDeletFav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            pEditProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pViewFav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            pAddProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pDeleteProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pViewProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            piconSmall.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_Product;
        private Panel panel1;
        private PictureBox pic_min;
        private PictureBox pic_max;
        private PictureBox pic_Close;
        private PictureBox pictureBox1;
        private Label lbl_Name;
        private Panel piconlarge;
        private Panel pEditProduct;
        private Button button11;
        private PictureBox pictureBox7;
        private Panel pAddProduct;
        private Button button12;
        private PictureBox pictureBox8;
        private Panel pDeleteProduct;
        private Button button13;
        private PictureBox pictureBox9;
        private Panel pViewProduct;
        private Button button14;
        private PictureBox pictureBox10;
        private Button button15;
        private Button button16;
        private Panel pAddFav;
        private Button button17;
        private PictureBox pictureBox11;
        private Panel pDeletFav;
        private Button button18;
        private PictureBox pictureBox12;
        private Panel pViewFav;
        private Button button19;
        private PictureBox pictureBox13;
        private Button btn_Cat;
        private Panel panel11;
        private PictureBox pictureBox14;
        private TextBox txt_search;
        private Button button2;
        private Button btn_cat1;
        private Button button21;
        private Button button22;
        private PictureBox pictureBox15;
        private Panel piconSmall;
        private Panel panel2;
        private Button btn_Logout;
        private Button button1;
    }
}