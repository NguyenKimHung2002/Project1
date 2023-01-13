namespace Project_1
{
    partial class UserControlPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustommerName = new System.Windows.Forms.Label();
            this.lblCustommerPhone = new System.Windows.Forms.Label();
            this.picSuccess = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnAddToInvoice = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.cbFeatureName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picFilterProductName = new System.Windows.Forms.PictureBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExcessMoneyReturned = new System.Windows.Forms.TextBox();
            this.lblExcessMoneyReturned = new System.Windows.Forms.Label();
            this.txtMonneyCustommerPay = new System.Windows.Forms.TextBox();
            this.lblMoneyCustommerPay = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblSumMoney = new System.Windows.Forms.Label();
            this.lblSumInvoice = new System.Windows.Forms.Label();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.ColMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvShowDataPayment = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.lblProductNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bộ lọc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustommerName
            // 
            this.lblCustommerName.AutoSize = true;
            this.lblCustommerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustommerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustommerName.Location = new System.Drawing.Point(28, 88);
            this.lblCustommerName.Name = "lblCustommerName";
            this.lblCustommerName.Size = new System.Drawing.Size(86, 13);
            this.lblCustommerName.TabIndex = 63;
            this.lblCustommerName.Text = "Tên khách hàng";
            this.lblCustommerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustommerPhone
            // 
            this.lblCustommerPhone.AutoSize = true;
            this.lblCustommerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustommerPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCustommerPhone.Location = new System.Drawing.Point(44, 50);
            this.lblCustommerPhone.Name = "lblCustommerPhone";
            this.lblCustommerPhone.Size = new System.Drawing.Size(70, 13);
            this.lblCustommerPhone.TabIndex = 64;
            this.lblCustommerPhone.Text = "Số điện thoại";
            this.lblCustommerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSuccess
            // 
            this.picSuccess.Image = ((System.Drawing.Image)(resources.GetObject("picSuccess.Image")));
            this.picSuccess.Location = new System.Drawing.Point(317, 70);
            this.picSuccess.Name = "picSuccess";
            this.picSuccess.Size = new System.Drawing.Size(42, 39);
            this.picSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuccess.TabIndex = 65;
            this.picSuccess.TabStop = false;
            this.picSuccess.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(408, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 480);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(423, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tên sản phẩm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.Location = new System.Drawing.Point(656, 94);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(104, 21);
            this.btnResetFilter.TabIndex = 71;
            this.btnResetFilter.Text = "Làm mới bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnAddToInvoice
            // 
            this.btnAddToInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            this.btnAddToInvoice.FlatAppearance.BorderSize = 0;
            this.btnAddToInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToInvoice.ForeColor = System.Drawing.Color.White;
            this.btnAddToInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToInvoice.Location = new System.Drawing.Point(430, 435);
            this.btnAddToInvoice.Name = "btnAddToInvoice";
            this.btnAddToInvoice.Size = new System.Drawing.Size(126, 21);
            this.btnAddToInvoice.TabIndex = 70;
            this.btnAddToInvoice.Text = "Thêm vào hóa đơn";
            this.btnAddToInvoice.UseVisualStyleBackColor = false;
            this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(725, 47);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 75;
            this.label25.Text = "Đặc tính nổi bật";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFeatureName
            // 
            this.cbFeatureName.BackColor = System.Drawing.Color.White;
            this.cbFeatureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbFeatureName.ForeColor = System.Drawing.Color.Black;
            this.cbFeatureName.FormattingEnabled = true;
            this.cbFeatureName.Location = new System.Drawing.Point(728, 66);
            this.cbFeatureName.Name = "cbFeatureName";
            this.cbFeatureName.Size = new System.Drawing.Size(81, 21);
            this.cbFeatureName.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(624, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Loại sản phẩm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.BackColor = System.Drawing.Color.White;
            this.cbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCategoryName.ForeColor = System.Drawing.Color.Black;
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(627, 66);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(79, 21);
            this.cbCategoryName.TabIndex = 69;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.picFilterProductName);
            this.panel7.Controls.Add(this.txtProductName);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(422, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 21);
            this.panel7.TabIndex = 77;
            // 
            // picFilterProductName
            // 
            this.picFilterProductName.Image = ((System.Drawing.Image)(resources.GetObject("picFilterProductName.Image")));
            this.picFilterProductName.Location = new System.Drawing.Point(168, -1);
            this.picFilterProductName.Name = "picFilterProductName";
            this.picFilterProductName.Size = new System.Drawing.Size(24, 22);
            this.picFilterProductName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilterProductName.TabIndex = 61;
            this.picFilterProductName.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.LightGray;
            this.txtProductName.Location = new System.Drawing.Point(3, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(164, 13);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 30);
            this.label4.TabIndex = 78;
            this.label4.Text = "Thông tin hóa đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(412, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 30);
            this.label5.TabIndex = 79;
            this.label5.Text = "Danh sách sản phẩm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExcessMoneyReturned
            // 
            this.txtExcessMoneyReturned.BackColor = System.Drawing.Color.White;
            this.txtExcessMoneyReturned.Enabled = false;
            this.txtExcessMoneyReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcessMoneyReturned.ForeColor = System.Drawing.Color.Black;
            this.txtExcessMoneyReturned.Location = new System.Drawing.Point(140, 420);
            this.txtExcessMoneyReturned.Name = "txtExcessMoneyReturned";
            this.txtExcessMoneyReturned.Size = new System.Drawing.Size(189, 20);
            this.txtExcessMoneyReturned.TabIndex = 84;
            // 
            // lblExcessMoneyReturned
            // 
            this.lblExcessMoneyReturned.AutoSize = true;
            this.lblExcessMoneyReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcessMoneyReturned.ForeColor = System.Drawing.Color.Black;
            this.lblExcessMoneyReturned.Location = new System.Drawing.Point(28, 423);
            this.lblExcessMoneyReturned.Name = "lblExcessMoneyReturned";
            this.lblExcessMoneyReturned.Size = new System.Drawing.Size(55, 13);
            this.lblExcessMoneyReturned.TabIndex = 86;
            this.lblExcessMoneyReturned.Text = "Tiền thừa:";
            this.lblExcessMoneyReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonneyCustommerPay
            // 
            this.txtMonneyCustommerPay.BackColor = System.Drawing.Color.White;
            this.txtMonneyCustommerPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonneyCustommerPay.ForeColor = System.Drawing.Color.Gray;
            this.txtMonneyCustommerPay.Location = new System.Drawing.Point(140, 394);
            this.txtMonneyCustommerPay.Name = "txtMonneyCustommerPay";
            this.txtMonneyCustommerPay.Size = new System.Drawing.Size(189, 20);
            this.txtMonneyCustommerPay.TabIndex = 85;
            this.txtMonneyCustommerPay.Enter += new System.EventHandler(this.txtMonneyCustommerPay_Enter);
            this.txtMonneyCustommerPay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonneyCustommerPay_KeyUp);
            this.txtMonneyCustommerPay.Leave += new System.EventHandler(this.txtMonneyCustommerPay_Leave);
            // 
            // lblMoneyCustommerPay
            // 
            this.lblMoneyCustommerPay.AutoSize = true;
            this.lblMoneyCustommerPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyCustommerPay.ForeColor = System.Drawing.Color.Black;
            this.lblMoneyCustommerPay.Location = new System.Drawing.Point(28, 397);
            this.lblMoneyCustommerPay.Name = "lblMoneyCustommerPay";
            this.lblMoneyCustommerPay.Size = new System.Drawing.Size(106, 13);
            this.lblMoneyCustommerPay.TabIndex = 87;
            this.lblMoneyCustommerPay.Text = "Tiền khách hàng trả:";
            this.lblMoneyCustommerPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(243, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 25);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Gray;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPayment.Location = new System.Drawing.Point(77, 448);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(87, 25);
            this.btnPayment.TabIndex = 82;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSumMoney.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSumMoney.Location = new System.Drawing.Point(137, 367);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.Size = new System.Drawing.Size(13, 13);
            this.lblSumMoney.TabIndex = 80;
            this.lblSumMoney.Text = "0";
            this.lblSumMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumInvoice
            // 
            this.lblSumInvoice.AutoSize = true;
            this.lblSumInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumInvoice.ForeColor = System.Drawing.Color.Black;
            this.lblSumInvoice.Location = new System.Drawing.Point(29, 367);
            this.lblSumInvoice.Name = "lblSumInvoice";
            this.lblSumInvoice.Size = new System.Drawing.Size(78, 13);
            this.lblSumInvoice.TabIndex = 81;
            this.lblSumInvoice.Text = "Tổng hóa đơn:";
            this.lblSumInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.AllowUserToAddRows = false;
            this.dgvInvoiceDetail.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaSP,
            this.ColProductName,
            this.ColDonGia,
            this.ColKhuyenMai,
            this.ColSoLuong,
            this.ColSum,
            this.ColRemove,
            this.ColCreate});
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(0, 150);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.ReadOnly = true;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(408, 212);
            this.dgvInvoiceDetail.TabIndex = 88;
            // 
            // ColMaSP
            // 
            this.ColMaSP.HeaderText = "Mã SP";
            this.ColMaSP.Name = "ColMaSP";
            this.ColMaSP.ReadOnly = true;
            this.ColMaSP.Width = 64;
            // 
            // ColProductName
            // 
            this.ColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProductName.HeaderText = "Tên SP";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            this.ColDonGia.Width = 50;
            // 
            // ColKhuyenMai
            // 
            this.ColKhuyenMai.HeaderText = "KM";
            this.ColKhuyenMai.Name = "ColKhuyenMai";
            this.ColKhuyenMai.ReadOnly = true;
            this.ColKhuyenMai.Visible = false;
            this.ColKhuyenMai.Width = 40;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.ReadOnly = true;
            this.ColSoLuong.Width = 76;
            // 
            // ColSum
            // 
            this.ColSum.HeaderText = "Thành tiền";
            this.ColSum.Name = "ColSum";
            this.ColSum.ReadOnly = true;
            this.ColSum.Width = 84;
            // 
            // ColRemove
            // 
            this.ColRemove.HeaderText = "";
            this.ColRemove.Name = "ColRemove";
            this.ColRemove.ReadOnly = true;
            this.ColRemove.Visible = false;
            this.ColRemove.Width = 15;
            // 
            // ColCreate
            // 
            this.ColCreate.HeaderText = "";
            this.ColCreate.Name = "ColCreate";
            this.ColCreate.ReadOnly = true;
            this.ColCreate.Visible = false;
            this.ColCreate.Width = 15;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.LightGray;
            this.txtCustomerPhone.Location = new System.Drawing.Point(120, 47);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerPhone.TabIndex = 89;
            this.txtCustomerPhone.TextChanged += new System.EventHandler(this.txtCustommerPhone_TextChanged);
            this.txtCustomerPhone.Enter += new System.EventHandler(this.txtCustommerPhone_Enter);
            this.txtCustomerPhone.Leave += new System.EventHandler(this.txtCustommerPhone_Leave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerName.TabIndex = 90;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(117, 69);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 13);
            this.lblNote.TabIndex = 92;
            // 
            // dgvShowDataPayment
            // 
            this.dgvShowDataPayment.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataPayment.Location = new System.Drawing.Point(412, 150);
            this.dgvShowDataPayment.Name = "dgvShowDataPayment";
            this.dgvShowDataPayment.Size = new System.Drawing.Size(408, 240);
            this.dgvShowDataPayment.TabIndex = 93;
            this.dgvShowDataPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataProduct_CellClick);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(778, 402);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 26);
            this.btnNext.TabIndex = 94;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPageNumber.Location = new System.Drawing.Point(744, 407);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(40, 20);
            this.lblPageNumber.TabIndex = 96;
            this.lblPageNumber.Text = "1/10";
            this.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.White;
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.Image")));
            this.btnPre.Location = new System.Drawing.Point(711, 402);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(27, 26);
            this.btnPre.TabIndex = 95;
            this.btnPre.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(480, 94);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(67, 21);
            this.btnApply.TabIndex = 97;
            this.btnApply.Text = "Áp dụng";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtProductNumber.Location = new System.Drawing.Point(480, 409);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(76, 20);
            this.txtProductNumber.TabIndex = 98;
            this.txtProductNumber.Enter += new System.EventHandler(this.txtProductNumber_Enter);
            this.txtProductNumber.Leave += new System.EventHandler(this.txtProductNumber_Leave);
            // 
            // lblProductNo
            // 
            this.lblProductNo.AutoSize = true;
            this.lblProductNo.Location = new System.Drawing.Point(426, 412);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(55, 13);
            this.lblProductNo.TabIndex = 99;
            this.lblProductNo.Text = "Sản phẩm";
            // 
            // UserControlPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblProductNo);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.dgvShowDataPayment);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.dgvInvoiceDetail);
            this.Controls.Add(this.txtExcessMoneyReturned);
            this.Controls.Add(this.lblExcessMoneyReturned);
            this.Controls.Add(this.txtMonneyCustommerPay);
            this.Controls.Add(this.lblMoneyCustommerPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblSumMoney);
            this.Controls.Add(this.lblSumInvoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnAddToInvoice);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbFeatureName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCategoryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picSuccess);
            this.Controls.Add(this.lblCustommerName);
            this.Controls.Add(this.lblCustommerPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlPayment";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.UserControlPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustommerName;
        private System.Windows.Forms.Label lblCustommerPhone;
        private System.Windows.Forms.PictureBox picSuccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnAddToInvoice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbFeatureName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picFilterProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExcessMoneyReturned;
        private System.Windows.Forms.Label lblExcessMoneyReturned;
        private System.Windows.Forms.TextBox txtMonneyCustommerPay;
        private System.Windows.Forms.Label lblMoneyCustommerPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblSumMoney;
        private System.Windows.Forms.Label lblSumInvoice;
        private System.Windows.Forms.DataGridView dgvInvoiceDetail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvShowDataPayment;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.Label lblProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreate;
    }
}
