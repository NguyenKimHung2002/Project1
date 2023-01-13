namespace Project_1
{
    partial class UserControlCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCategory));
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gbFeatureInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbShowFeature = new System.Windows.Forms.ListBox();
            this.lbFeature = new System.Windows.Forms.ListBox();
            this.lblFeatureName = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.dgvShowDataCategory = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchFollowCategoryName = new System.Windows.Forms.TextBox();
            this.btnCreateNewCategory = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gbFeatureInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(99, 88);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(221, 91);
            this.txtCategoryDescription.TabIndex = 89;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(6, 91);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(87, 13);
            this.lblCategoryDescription.TabIndex = 88;
            this.lblCategoryDescription.Text = "Mô tả danh mục:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.ForeColor = System.Drawing.Color.LightGray;
            this.txtCategoryId.Location = new System.Drawing.Point(99, 21);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(221, 20);
            this.txtCategoryId.TabIndex = 81;
            this.txtCategoryId.Enter += new System.EventHandler(this.txtCategoryId_Enter);
            this.txtCategoryId.Leave += new System.EventHandler(this.txtCategoryId_Leave);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(6, 24);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(75, 13);
            this.lblCategoryId.TabIndex = 80;
            this.lblCategoryId.Text = "Mã danh mục:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(99, 53);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(221, 20);
            this.txtCategoryName.TabIndex = 18;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(6, 56);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(79, 13);
            this.lblCategoryName.TabIndex = 16;
            this.lblCategoryName.Text = "Tên danh mục:";
            // 
            // gbFeatureInformation
            // 
            this.gbFeatureInformation.Controls.Add(this.groupBox1);
            this.gbFeatureInformation.Controls.Add(this.txtCategoryDescription);
            this.gbFeatureInformation.Controls.Add(this.lblCategoryDescription);
            this.gbFeatureInformation.Controls.Add(this.txtCategoryId);
            this.gbFeatureInformation.Controls.Add(this.lblCategoryId);
            this.gbFeatureInformation.Controls.Add(this.txtCategoryName);
            this.gbFeatureInformation.Controls.Add(this.lblCategoryName);
            this.gbFeatureInformation.Location = new System.Drawing.Point(21, 36);
            this.gbFeatureInformation.Name = "gbFeatureInformation";
            this.gbFeatureInformation.Size = new System.Drawing.Size(338, 364);
            this.gbFeatureInformation.TabIndex = 96;
            this.gbFeatureInformation.TabStop = false;
            this.gbFeatureInformation.Text = "Thông tin danh mục";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbShowFeature);
            this.groupBox1.Controls.Add(this.lbFeature);
            this.groupBox1.Controls.Add(this.lblFeatureName);
            this.groupBox1.Location = new System.Drawing.Point(15, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 152);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặc tính của danh mục";
            // 
            // lbShowFeature
            // 
            this.lbShowFeature.FormattingEnabled = true;
            this.lbShowFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShowFeature.Location = new System.Drawing.Point(6, 51);
            this.lbShowFeature.Name = "lbShowFeature";
            this.lbShowFeature.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbShowFeature.Size = new System.Drawing.Size(131, 95);
            this.lbShowFeature.TabIndex = 82;
            // 
            // lbFeature
            // 
            this.lbFeature.FormattingEnabled = true;
            this.lbFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFeature.Location = new System.Drawing.Point(146, 25);
            this.lbFeature.Name = "lbFeature";
            this.lbFeature.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFeature.Size = new System.Drawing.Size(153, 121);
            this.lbFeature.TabIndex = 81;
            this.lbFeature.SelectedIndexChanged += new System.EventHandler(this.lbFeature_SelectedIndexChanged);
            // 
            // lblFeatureName
            // 
            this.lblFeatureName.AutoSize = true;
            this.lblFeatureName.Location = new System.Drawing.Point(6, 24);
            this.lblFeatureName.Name = "lblFeatureName";
            this.lblFeatureName.Size = new System.Drawing.Size(52, 13);
            this.lblFeatureName.TabIndex = 80;
            this.lblFeatureName.Text = "Đặc tính:";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(264, 419);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(77, 34);
            this.btnDeleteCategory.TabIndex = 95;
            this.btnDeleteCategory.Text = "         Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Image")));
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(150, 419);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(87, 34);
            this.btnUpdateCategory.TabIndex = 94;
            this.btnUpdateCategory.Text = "Cập nhật";
            this.btnUpdateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // dgvShowDataCategory
            // 
            this.dgvShowDataCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataCategory.Location = new System.Drawing.Point(383, 64);
            this.dgvShowDataCategory.Name = "dgvShowDataCategory";
            this.dgvShowDataCategory.Size = new System.Drawing.Size(414, 336);
            this.dgvShowDataCategory.TabIndex = 91;
            this.dgvShowDataCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataCategory_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchFollowCategoryName
            // 
            this.txtSearchFollowCategoryName.BackColor = System.Drawing.Color.White;
            this.txtSearchFollowCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFollowCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFollowCategoryName.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchFollowCategoryName.Location = new System.Drawing.Point(3, 3);
            this.txtSearchFollowCategoryName.Name = "txtSearchFollowCategoryName";
            this.txtSearchFollowCategoryName.Size = new System.Drawing.Size(236, 13);
            this.txtSearchFollowCategoryName.TabIndex = 0;
            this.txtSearchFollowCategoryName.Enter += new System.EventHandler(this.txtSearchFollowCategoryName_Enter);
            this.txtSearchFollowCategoryName.Leave += new System.EventHandler(this.txtSearchFollowCategoryName_Leave);
            // 
            // btnCreateNewCategory
            // 
            this.btnCreateNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewCategory.Image")));
            this.btnCreateNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewCategory.Location = new System.Drawing.Point(36, 419);
            this.btnCreateNewCategory.Name = "btnCreateNewCategory";
            this.btnCreateNewCategory.Size = new System.Drawing.Size(88, 34);
            this.btnCreateNewCategory.TabIndex = 93;
            this.btnCreateNewCategory.Text = "Thêm mới";
            this.btnCreateNewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewCategory.UseVisualStyleBackColor = true;
            this.btnCreateNewCategory.Click += new System.EventHandler(this.btnCreateNewCategory_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtSearchFollowCategoryName);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(383, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 22);
            this.panel7.TabIndex = 92;
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFeatureInformation);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.dgvShowDataCategory);
            this.Controls.Add(this.btnCreateNewCategory);
            this.Controls.Add(this.panel7);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.UserControlCategory_Load);
            this.gbFeatureInformation.ResumeLayout(false);
            this.gbFeatureInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.GroupBox gbFeatureInformation;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.DataGridView dgvShowDataCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchFollowCategoryName;
        private System.Windows.Forms.Button btnCreateNewCategory;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFeatureName;
        private System.Windows.Forms.ListBox lbFeature;
        private System.Windows.Forms.ListBox lbShowFeature;
    }
}
