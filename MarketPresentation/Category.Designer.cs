namespace Market.Presentation
{
    partial class frm_catecory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_catecory));
            txt_Catname = new TextBox();
            lbl_CatName = new Label();
            dgv_category = new DataGridView();
            btn_Create = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_category).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_Catname
            // 
            txt_Catname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Catname.Location = new Point(26, 159);
            txt_Catname.MaximumSize = new Size(340, 50);
            txt_Catname.MinimumSize = new Size(340, 35);
            txt_Catname.Name = "txt_Catname";
            txt_Catname.PlaceholderText = "Write Category Here......";
            txt_Catname.Size = new Size(340, 35);
            txt_Catname.TabIndex = 4;
            // 
            // lbl_CatName
            // 
            lbl_CatName.AutoSize = true;
            lbl_CatName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CatName.ForeColor = SystemColors.ControlDarkDark;
            lbl_CatName.Location = new Point(26, 126);
            lbl_CatName.Name = "lbl_CatName";
            lbl_CatName.Size = new Size(169, 30);
            lbl_CatName.TabIndex = 5;
            lbl_CatName.Text = "Category Name";
            // 
            // dgv_category
            // 
            dgv_category.BackgroundColor = SystemColors.ActiveCaption;
            dgv_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_category.Dock = DockStyle.Right;
            dgv_category.Location = new Point(387, 0);
            dgv_category.Name = "dgv_category";
            dgv_category.Size = new Size(404, 526);
            dgv_category.TabIndex = 6;
            dgv_category.CellClick += dgv_category_CellClick;
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
            btn_Create.Location = new Point(26, 258);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(165, 54);
            btn_Create.TabIndex = 7;
            btn_Create.Text = "Add";
            btn_Create.TextAlign = ContentAlignment.MiddleLeft;
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Highlight;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ButtonFace;
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleRight;
            btn_update.Location = new Point(197, 258);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(165, 54);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.TextAlign = ContentAlignment.MiddleLeft;
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonFace;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(26, 328);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(165, 50);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 464);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(241, 13);
            label1.TabIndex = 35;
            label1.Text = "Add , Update and delete Category of Product ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(11, 37);
            label2.Name = "label2";
            label2.Size = new Size(216, 32);
            label2.TabIndex = 34;
            label2.Text = "Category Product";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(197, 328);
            button1.Name = "button1";
            button1.Size = new Size(165, 50);
            button1.TabIndex = 36;
            button1.Text = "Clear";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frm_catecory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(791, 526);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Create);
            Controls.Add(dgv_category);
            Controls.Add(txt_Catname);
            Controls.Add(lbl_CatName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_catecory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            Load += frm_catecory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_category).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Catname;
        private Label lbl_CatName;
        private DataGridView dgv_category;
        private Button btn_Create;
        private Button btn_update;
        private Button btn_delete;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}