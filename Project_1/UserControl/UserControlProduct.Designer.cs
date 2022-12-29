namespace Project_1
{
    partial class UserControlProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProduct));
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFindFollowName = new System.Windows.Forms.TextBox();
            this.dgvShowDataProduct = new System.Windows.Forms.DataGridView();
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.gbCategoryByProduct = new System.Windows.Forms.GroupBox();
            this.lbShowCategory = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFeatureByProduct = new System.Windows.Forms.GroupBox();
            this.lbShowFeature = new System.Windows.Forms.ListBox();
            this.lbFeature = new System.Windows.Forms.ListBox();
            this.lblFeatureName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.txtExportPrice = new System.Windows.Forms.TextBox();
            this.lblExportPrice = new System.Windows.Forms.Label();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.lblImportPrice = new System.Windows.Forms.Label();
            this.txtProductUnit = new System.Windows.Forms.TextBox();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataProduct)).BeginInit();
            this.gbProductInformation.SuspendLayout();
            this.gbCategoryByProduct.SuspendLayout();
            this.gbFeatureByProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtFindFollowName);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(461, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(301, 22);
            this.panel7.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(275, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtFindFollowName
            // 
            this.txtFindFollowName.BackColor = System.Drawing.Color.White;
            this.txtFindFollowName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFindFollowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindFollowName.ForeColor = System.Drawing.Color.LightGray;
            this.txtFindFollowName.Location = new System.Drawing.Point(3, 3);
            this.txtFindFollowName.Name = "txtFindFollowName";
            this.txtFindFollowName.Size = new System.Drawing.Size(266, 13);
            this.txtFindFollowName.TabIndex = 0;
            // 
            // dgvShowDataProduct
            // 
            this.dgvShowDataProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataProduct.Location = new System.Drawing.Point(461, 65);
            this.dgvShowDataProduct.Name = "dgvShowDataProduct";
            this.dgvShowDataProduct.Size = new System.Drawing.Size(340, 326);
            this.dgvShowDataProduct.TabIndex = 79;
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.gbCategoryByProduct);
            this.gbProductInformation.Controls.Add(this.gbFeatureByProduct);
            this.gbProductInformation.Controls.Add(this.textBox4);
            this.gbProductInformation.Controls.Add(this.lblProductDescription);
            this.gbProductInformation.Controls.Add(this.txtExportPrice);
            this.gbProductInformation.Controls.Add(this.lblExportPrice);
            this.gbProductInformation.Controls.Add(this.txtImportPrice);
            this.gbProductInformation.Controls.Add(this.lblImportPrice);
            this.gbProductInformation.Controls.Add(this.txtProductUnit);
            this.gbProductInformation.Controls.Add(this.lblProductUnit);
            this.gbProductInformation.Controls.Add(this.txtProductId);
            this.gbProductInformation.Controls.Add(this.lblProductId);
            this.gbProductInformation.Controls.Add(this.txtProductName);
            this.gbProductInformation.Controls.Add(this.lblProductName);
            this.gbProductInformation.Controls.Add(this.txtProductQuantity);
            this.gbProductInformation.Controls.Add(this.lblProductQuantity);
            this.gbProductInformation.Location = new System.Drawing.Point(18, 37);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(437, 314);
            this.gbProductInformation.TabIndex = 84;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Thông tin sản phẩm";
            // 
            // gbCategoryByProduct
            // 
            this.gbCategoryByProduct.Controls.Add(this.lbShowCategory);
            this.gbCategoryByProduct.Controls.Add(this.lbCategory);
            this.gbCategoryByProduct.Controls.Add(this.label1);
            this.gbCategoryByProduct.Location = new System.Drawing.Point(184, 21);
            this.gbCategoryByProduct.Name = "gbCategoryByProduct";
            this.gbCategoryByProduct.Size = new System.Drawing.Size(253, 134);
            this.gbCategoryByProduct.TabIndex = 99;
            this.gbCategoryByProduct.TabStop = false;
            this.gbCategoryByProduct.Text = "Danh mục sản phẩm thuộc vào";
            // 
            // lbShowCategory
            // 
            this.lbShowCategory.FormattingEnabled = true;
            this.lbShowCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShowCategory.Location = new System.Drawing.Point(9, 44);
            this.lbShowCategory.Name = "lbShowCategory";
            this.lbShowCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbShowCategory.Size = new System.Drawing.Size(112, 82);
            this.lbShowCategory.TabIndex = 82;
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCategory.Location = new System.Drawing.Point(127, 19);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCategory.Size = new System.Drawing.Size(120, 108);
            this.lbCategory.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Đặc tính:";
            // 
            // gbFeatureByProduct
            // 
            this.gbFeatureByProduct.Controls.Add(this.lbShowFeature);
            this.gbFeatureByProduct.Controls.Add(this.lbFeature);
            this.gbFeatureByProduct.Controls.Add(this.lblFeatureName);
            this.gbFeatureByProduct.Location = new System.Drawing.Point(184, 162);
            this.gbFeatureByProduct.Name = "gbFeatureByProduct";
            this.gbFeatureByProduct.Size = new System.Drawing.Size(253, 152);
            this.gbFeatureByProduct.TabIndex = 98;
            this.gbFeatureByProduct.TabStop = false;
            this.gbFeatureByProduct.Text = "Đặc tính bổ sung cho sản phẩm";
            // 
            // lbShowFeature
            // 
            this.lbShowFeature.FormattingEnabled = true;
            this.lbShowFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShowFeature.Location = new System.Drawing.Point(9, 51);
            this.lbShowFeature.Name = "lbShowFeature";
            this.lbShowFeature.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbShowFeature.Size = new System.Drawing.Size(112, 95);
            this.lbShowFeature.TabIndex = 82;
            // 
            // lbFeature
            // 
            this.lbFeature.FormattingEnabled = true;
            this.lbFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFeature.Location = new System.Drawing.Point(127, 38);
            this.lbFeature.Name = "lbFeature";
            this.lbFeature.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFeature.Size = new System.Drawing.Size(120, 108);
            this.lbFeature.TabIndex = 81;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 236);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 72);
            this.textBox4.TabIndex = 89;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(7, 216);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(86, 13);
            this.lblProductDescription.TabIndex = 88;
            this.lblProductDescription.Text = "Mô tả sản phẩm:";
            // 
            // txtExportPrice
            // 
            this.txtExportPrice.Location = new System.Drawing.Point(86, 185);
            this.txtExportPrice.Name = "txtExportPrice";
            this.txtExportPrice.Size = new System.Drawing.Size(86, 20);
            this.txtExportPrice.TabIndex = 87;
            // 
            // lblExportPrice
            // 
            this.lblExportPrice.AutoSize = true;
            this.lblExportPrice.Location = new System.Drawing.Point(7, 188);
            this.lblExportPrice.Name = "lblExportPrice";
            this.lblExportPrice.Size = new System.Drawing.Size(49, 13);
            this.lblExportPrice.TabIndex = 86;
            this.lblExportPrice.Text = "Giá xuất:";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(86, 152);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(86, 20);
            this.txtImportPrice.TabIndex = 85;
            // 
            // lblImportPrice
            // 
            this.lblImportPrice.AutoSize = true;
            this.lblImportPrice.Location = new System.Drawing.Point(7, 155);
            this.lblImportPrice.Name = "lblImportPrice";
            this.lblImportPrice.Size = new System.Drawing.Size(53, 13);
            this.lblImportPrice.TabIndex = 84;
            this.lblImportPrice.Text = "Giá nhập:";
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Location = new System.Drawing.Point(88, 118);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Size = new System.Drawing.Size(84, 20);
            this.txtProductUnit.TabIndex = 83;
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(7, 119);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(57, 13);
            this.lblProductUnit.TabIndex = 82;
            this.lblProductUnit.Text = "Đơn vị đo:";
            // 
            // txtProductId
            // 
            this.txtProductId.ForeColor = System.Drawing.Color.LightGray;
            this.txtProductId.Location = new System.Drawing.Point(86, 21);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(86, 20);
            this.txtProductId.TabIndex = 81;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(6, 24);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(74, 13);
            this.lblProductId.TabIndex = 80;
            this.lblProductId.Text = "Mã sản phẩm:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(84, 20);
            this.txtProductName.TabIndex = 18;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(88, 86);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(84, 20);
            this.txtProductQuantity.TabIndex = 19;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(6, 89);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(61, 13);
            this.lblProductQuantity.TabIndex = 17;
            this.lblProductQuantity.Text = "Định lượng:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(231, 357);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(77, 34);
            this.btnDeleteProduct.TabIndex = 83;
            this.btnDeleteProduct.Text = "         Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.Image")));
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.Location = new System.Drawing.Point(129, 357);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(87, 34);
            this.btnUpdateProduct.TabIndex = 82;
            this.btnUpdateProduct.Text = "Cập nhật";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewProduct.Image")));
            this.btnCreateNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewProduct.Location = new System.Drawing.Point(22, 357);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(88, 34);
            this.btnCreateNewProduct.TabIndex = 81;
            this.btnCreateNewProduct.Text = "Thêm mới";
            this.btnCreateNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCreateNewProduct);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvShowDataProduct);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(820, 480);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataProduct)).EndInit();
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.gbCategoryByProduct.ResumeLayout(false);
            this.gbCategoryByProduct.PerformLayout();
            this.gbFeatureByProduct.ResumeLayout(false);
            this.gbFeatureByProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFindFollowName;
        private System.Windows.Forms.DataGridView dgvShowDataProduct;
        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnCreateNewProduct;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox txtExportPrice;
        private System.Windows.Forms.Label lblExportPrice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.TextBox txtProductUnit;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.GroupBox gbFeatureByProduct;
        private System.Windows.Forms.ListBox lbShowFeature;
        private System.Windows.Forms.ListBox lbFeature;
        private System.Windows.Forms.Label lblFeatureName;
        private System.Windows.Forms.GroupBox gbCategoryByProduct;
        private System.Windows.Forms.ListBox lbShowCategory;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.Label label1;
    }
}
