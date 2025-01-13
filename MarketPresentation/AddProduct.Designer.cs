namespace MarketPresentation
{
    partial class frm_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProduct));
            txt_Productname = new TextBox();
            lbl_ProdName = new Label();
            lbl_Category = new Label();
            cmb_category = new ComboBox();
            lbl_Price = new Label();
            lbl_Quantity = new Label();
            lbl_discription = new Label();
            rtxt_discription = new RichTextBox();
            btn_Create = new Button();
            btn_back = new Button();
            num_Price = new NumericUpDown();
            num_Quantity = new NumericUpDown();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_Productname
            // 
            txt_Productname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Productname.Location = new Point(202, 33);
            txt_Productname.MaximumSize = new Size(340, 50);
            txt_Productname.MinimumSize = new Size(340, 35);
            txt_Productname.Name = "txt_Productname";
            txt_Productname.PlaceholderText = "Write Name Product Here......";
            txt_Productname.Size = new Size(340, 35);
            txt_Productname.TabIndex = 1;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.ForeColor = SystemColors.ControlDarkDark;
            lbl_ProdName.Location = new Point(24, 39);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(119, 21);
            lbl_ProdName.TabIndex = 7;
            lbl_ProdName.Text = " Name Product";
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Category.ForeColor = SystemColors.ControlDarkDark;
            lbl_Category.Location = new Point(27, 100);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(71, 21);
            lbl_Category.TabIndex = 9;
            lbl_Category.Text = "Categoy";
            // 
            // cmb_category
            // 
            cmb_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_category.FormattingEnabled = true;
            cmb_category.Location = new Point(202, 100);
            cmb_category.MaximumSize = new Size(340, 0);
            cmb_category.MinimumSize = new Size(340, 0);
            cmb_category.Name = "cmb_category";
            cmb_category.Size = new Size(340, 29);
            cmb_category.TabIndex = 2;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Price.ForeColor = SystemColors.ControlDarkDark;
            lbl_Price.Location = new Point(27, 171);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(46, 21);
            lbl_Price.TabIndex = 11;
            lbl_Price.Text = "Price";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Quantity.ForeColor = SystemColors.ControlDarkDark;
            lbl_Quantity.Location = new Point(27, 242);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(72, 21);
            lbl_Quantity.TabIndex = 14;
            lbl_Quantity.Text = "Quantity";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_discription.ForeColor = SystemColors.ControlDarkDark;
            lbl_discription.Location = new Point(24, 355);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(89, 21);
            lbl_discription.TabIndex = 15;
            lbl_discription.Text = "Discription";
            // 
            // rtxt_discription
            // 
            rtxt_discription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxt_discription.Location = new Point(202, 314);
            rtxt_discription.Name = "rtxt_discription";
            rtxt_discription.Size = new Size(340, 113);
            rtxt_discription.TabIndex = 5;
            rtxt_discription.Text = "";
            // 
            // btn_Create
            // 
            btn_Create.BackColor = SystemColors.Highlight;
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Create.ForeColor = SystemColors.ButtonFace;
            btn_Create.Image = (Image)resources.GetObject("btn_Create.Image");
            btn_Create.ImageAlign = ContentAlignment.MiddleRight;
            btn_Create.Location = new Point(377, 446);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(165, 54);
            btn_Create.TabIndex = 6;
            btn_Create.Text = "Add";
            btn_Create.TextAlign = ContentAlignment.MiddleLeft;
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(202, 446);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(165, 54);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // num_Price
            // 
            num_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_Price.ForeColor = SystemColors.WindowFrame;
            num_Price.ImeMode = ImeMode.NoControl;
            num_Price.Location = new Point(202, 166);
            num_Price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            num_Price.Name = "num_Price";
            num_Price.Size = new Size(340, 29);
            num_Price.TabIndex = 3;
            // 
            // num_Quantity
            // 
            num_Quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_Quantity.ForeColor = SystemColors.WindowFrame;
            num_Quantity.ImeMode = ImeMode.NoControl;
            num_Quantity.Location = new Point(202, 237);
            num_Quantity.Name = "num_Quantity";
            num_Quantity.Size = new Size(340, 29);
            num_Quantity.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Market.Presentation.Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(546, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frm_AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(580, 512);
            Controls.Add(pictureBox2);
            Controls.Add(num_Quantity);
            Controls.Add(num_Price);
            Controls.Add(btn_back);
            Controls.Add(btn_Create);
            Controls.Add(rtxt_discription);
            Controls.Add(lbl_discription);
            Controls.Add(lbl_Quantity);
            Controls.Add(lbl_Price);
            Controls.Add(cmb_category);
            Controls.Add(lbl_Category);
            Controls.Add(txt_Productname);
            Controls.Add(lbl_ProdName);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            Load += frm_Product_Load;
            ((System.ComponentModel.ISupportInitialize)num_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Productname;
        private Label lbl_ProdName;
        private Label lbl_Category;
        private ComboBox cmb_category;
        private Label lbl_Price;
        private Label lbl_Quantity;
        private Label lbl_discription;
        private RichTextBox rtxt_discription;
        private Button btn_Create;
        private Button btn_back;
        private NumericUpDown num_Price;
        private NumericUpDown num_Quantity;
        private PictureBox pictureBox2;
    }
}