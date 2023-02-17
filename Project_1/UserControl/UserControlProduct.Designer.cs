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
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvShowDataProduct = new System.Windows.Forms.DataGridView();
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
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
            this.gbFeatureByProduct = new System.Windows.Forms.GroupBox();
            this.UpdateSticker = new System.Windows.Forms.Button();
            this.btnDeleteSticker = new System.Windows.Forms.Button();
            this.btnAddSticker = new System.Windows.Forms.Button();
            this.dgvShowStickers = new System.Windows.Forms.DataGridView();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtFeatureValue = new System.Windows.Forms.TextBox();
            this.cbFeatureName = new System.Windows.Forms.ComboBox();
            this.lblFeature = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataProduct)).BeginInit();
            this.gbProductInformation.SuspendLayout();
            this.gbFeatureByProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStickers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtSearchProduct);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(499, 19);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 27);
            this.panel7.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.White;
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchProduct.Location = new System.Drawing.Point(4, 4);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(355, 16);
            this.txtSearchProduct.TabIndex = 16;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
            // 
            // dgvShowDataProduct
            // 
            this.dgvShowDataProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataProduct.Location = new System.Drawing.Point(499, 54);
            this.dgvShowDataProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowDataProduct.Name = "dgvShowDataProduct";
            this.dgvShowDataProduct.RowHeadersWidth = 51;
            this.dgvShowDataProduct.Size = new System.Drawing.Size(569, 492);
            this.dgvShowDataProduct.TabIndex = 79;
            this.dgvShowDataProduct.TabStop = false;
            this.dgvShowDataProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataProduct_CellClick);
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.txtProductDescription);
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
            this.gbProductInformation.Location = new System.Drawing.Point(24, 19);
            this.gbProductInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gbProductInformation.Size = new System.Drawing.Size(455, 257);
            this.gbProductInformation.TabIndex = 84;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Thông tin sản phẩm";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(235, 118);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(193, 128);
            this.txtProductDescription.TabIndex = 7;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(231, 94);
            this.lblProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(105, 16);
            this.lblProductDescription.TabIndex = 88;
            this.lblProductDescription.Text = "Mô tả sản phẩm:";
            // 
            // txtExportPrice
            // 
            this.txtExportPrice.Location = new System.Drawing.Point(115, 224);
            this.txtExportPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtExportPrice.Name = "txtExportPrice";
            this.txtExportPrice.Size = new System.Drawing.Size(92, 22);
            this.txtExportPrice.TabIndex = 6;
            // 
            // lblExportPrice
            // 
            this.lblExportPrice.AutoSize = true;
            this.lblExportPrice.Location = new System.Drawing.Point(9, 227);
            this.lblExportPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportPrice.Name = "lblExportPrice";
            this.lblExportPrice.Size = new System.Drawing.Size(58, 16);
            this.lblExportPrice.TabIndex = 86;
            this.lblExportPrice.Text = "Giá xuất:";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(115, 184);
            this.txtImportPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(92, 22);
            this.txtImportPrice.TabIndex = 5;
            // 
            // lblImportPrice
            // 
            this.lblImportPrice.AutoSize = true;
            this.lblImportPrice.Location = new System.Drawing.Point(9, 188);
            this.lblImportPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportPrice.Name = "lblImportPrice";
            this.lblImportPrice.Size = new System.Drawing.Size(64, 16);
            this.lblImportPrice.TabIndex = 84;
            this.lblImportPrice.Text = "Giá nhập:";
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Location = new System.Drawing.Point(115, 145);
            this.txtProductUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Size = new System.Drawing.Size(92, 22);
            this.txtProductUnit.TabIndex = 4;
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(9, 148);
            this.lblProductUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(66, 16);
            this.lblProductUnit.TabIndex = 82;
            this.lblProductUnit.Text = "Đơn vị đo:";
            // 
            // txtProductId
            // 
            this.txtProductId.ForeColor = System.Drawing.Color.Gray;
            this.txtProductId.Location = new System.Drawing.Point(115, 26);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(245, 22);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.Enter += new System.EventHandler(this.txtProductId_Enter);
            this.txtProductId.Leave += new System.EventHandler(this.txtProductId_Leave);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(8, 30);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(91, 16);
            this.lblProductId.TabIndex = 80;
            this.lblProductId.Text = "Mã sản phẩm:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(115, 65);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(245, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(8, 69);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(115, 106);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(92, 22);
            this.txtProductQuantity.TabIndex = 3;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(8, 110);
            this.lblProductQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(72, 16);
            this.lblProductQuantity.TabIndex = 17;
            this.lblProductQuantity.Text = "Định lượng:";
            // 
            // gbFeatureByProduct
            // 
            this.gbFeatureByProduct.Controls.Add(this.UpdateSticker);
            this.gbFeatureByProduct.Controls.Add(this.btnDeleteSticker);
            this.gbFeatureByProduct.Controls.Add(this.btnAddSticker);
            this.gbFeatureByProduct.Controls.Add(this.dgvShowStickers);
            this.gbFeatureByProduct.Controls.Add(this.lblValue);
            this.gbFeatureByProduct.Controls.Add(this.txtFeatureValue);
            this.gbFeatureByProduct.Controls.Add(this.cbFeatureName);
            this.gbFeatureByProduct.Controls.Add(this.lblFeature);
            this.gbFeatureByProduct.Location = new System.Drawing.Point(24, 329);
            this.gbFeatureByProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gbFeatureByProduct.Name = "gbFeatureByProduct";
            this.gbFeatureByProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gbFeatureByProduct.Size = new System.Drawing.Size(455, 223);
            this.gbFeatureByProduct.TabIndex = 99;
            this.gbFeatureByProduct.TabStop = false;
            this.gbFeatureByProduct.Text = "Dán nhãn đặc tính";
            // 
            // UpdateSticker
            // 
            this.UpdateSticker.Location = new System.Drawing.Point(196, 187);
            this.UpdateSticker.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateSticker.Name = "UpdateSticker";
            this.UpdateSticker.Size = new System.Drawing.Size(87, 28);
            this.UpdateSticker.TabIndex = 14;
            this.UpdateSticker.Text = "Chỉnh sửa";
            this.UpdateSticker.UseVisualStyleBackColor = true;
            this.UpdateSticker.Click += new System.EventHandler(this.UpdateSticker_Click);
            // 
            // btnDeleteSticker
            // 
            this.btnDeleteSticker.Location = new System.Drawing.Point(303, 187);
            this.btnDeleteSticker.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSticker.Name = "btnDeleteSticker";
            this.btnDeleteSticker.Size = new System.Drawing.Size(109, 28);
            this.btnDeleteSticker.TabIndex = 15;
            this.btnDeleteSticker.Text = "Gỡ nhãn dán";
            this.btnDeleteSticker.UseVisualStyleBackColor = true;
            this.btnDeleteSticker.Click += new System.EventHandler(this.btnDeleteSticker_Click);
            // 
            // btnAddSticker
            // 
            this.btnAddSticker.Location = new System.Drawing.Point(25, 187);
            this.btnAddSticker.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSticker.Name = "btnAddSticker";
            this.btnAddSticker.Size = new System.Drawing.Size(151, 28);
            this.btnAddSticker.TabIndex = 13;
            this.btnAddSticker.Text = "Dán nhãn sản phẩm";
            this.btnAddSticker.UseVisualStyleBackColor = true;
            this.btnAddSticker.Click += new System.EventHandler(this.btnAddSticker_Click);
            // 
            // dgvShowStickers
            // 
            this.dgvShowStickers.AllowUserToAddRows = false;
            this.dgvShowStickers.AllowUserToDeleteRows = false;
            this.dgvShowStickers.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowStickers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStickers.Location = new System.Drawing.Point(14, 70);
            this.dgvShowStickers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowStickers.Name = "dgvShowStickers";
            this.dgvShowStickers.ReadOnly = true;
            this.dgvShowStickers.RowHeadersWidth = 36;
            this.dgvShowStickers.Size = new System.Drawing.Size(414, 109);
            this.dgvShowStickers.TabIndex = 86;
            this.dgvShowStickers.TabStop = false;
            this.dgvShowStickers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowStickers_CellClick);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(229, 19);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(102, 16);
            this.lblValue.TabIndex = 85;
            this.lblValue.Text = "Giá trị tương đối:";
            // 
            // txtFeatureValue
            // 
            this.txtFeatureValue.Location = new System.Drawing.Point(233, 39);
            this.txtFeatureValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeatureValue.Name = "txtFeatureValue";
            this.txtFeatureValue.Size = new System.Drawing.Size(195, 22);
            this.txtFeatureValue.TabIndex = 12;
            // 
            // cbFeatureName
            // 
            this.cbFeatureName.FormattingEnabled = true;
            this.cbFeatureName.Location = new System.Drawing.Point(15, 39);
            this.cbFeatureName.Margin = new System.Windows.Forms.Padding(4);
            this.cbFeatureName.Name = "cbFeatureName";
            this.cbFeatureName.Size = new System.Drawing.Size(192, 24);
            this.cbFeatureName.TabIndex = 11;
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(11, 20);
            this.lblFeature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(57, 16);
            this.lblFeature.TabIndex = 80;
            this.lblFeature.Text = "Đặc tính:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(341, 279);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(112, 48);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "         Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.Image")));
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.Location = new System.Drawing.Point(196, 279);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(127, 48);
            this.btnUpdateProduct.TabIndex = 9;
            this.btnUpdateProduct.Text = "Cập nhật";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewProduct.Image")));
            this.btnCreateNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewProduct.Location = new System.Drawing.Point(49, 279);
            this.btnCreateNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(127, 48);
            this.btnCreateNewProduct.TabIndex = 8;
            this.btnCreateNewProduct.Text = "Thêm mới";
            this.btnCreateNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(949, 554);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 33);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Tải lại trang";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbFeatureByProduct);
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCreateNewProduct);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvShowDataProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(1103, 591);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataProduct)).EndInit();
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.gbFeatureByProduct.ResumeLayout(false);
            this.gbFeatureByProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStickers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchProduct;
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
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox txtExportPrice;
        private System.Windows.Forms.Label lblExportPrice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.TextBox txtProductUnit;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.GroupBox gbFeatureByProduct;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtFeatureValue;
        private System.Windows.Forms.ComboBox cbFeatureName;
        private System.Windows.Forms.DataGridView dgvShowStickers;
        private System.Windows.Forms.Button btnAddSticker;
        private System.Windows.Forms.Button UpdateSticker;
        private System.Windows.Forms.Button btnDeleteSticker;
        private System.Windows.Forms.Button btnReset;
    }
}
