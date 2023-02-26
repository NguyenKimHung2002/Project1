namespace Project_1
{
    partial class UserControlCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCustomer));
            this.dgvShowDataCustomer = new System.Windows.Forms.DataGridView();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustommerPhone = new System.Windows.Forms.Label();
            this.lblCustommerName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchFollowCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustommerNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustomer)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowDataCustomer
            // 
            this.dgvShowDataCustomer.AllowUserToAddRows = false;
            this.dgvShowDataCustomer.AllowUserToDeleteRows = false;
            this.dgvShowDataCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataCustomer.Location = new System.Drawing.Point(507, 80);
            this.dgvShowDataCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowDataCustomer.Name = "dgvShowDataCustomer";
            this.dgvShowDataCustomer.ReadOnly = true;
            this.dgvShowDataCustomer.RowHeadersWidth = 51;
            this.dgvShowDataCustomer.Size = new System.Drawing.Size(505, 271);
            this.dgvShowDataCustomer.TabIndex = 11;
            this.dgvShowDataCustomer.TabStop = false;
            this.dgvShowDataCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataCustomer_CellClick);
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewCustomer.Image")));
            this.btnCreateNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(43, 257);
            this.btnCreateNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(127, 43);
            this.btnCreateNewCustomer.TabIndex = 4;
            this.btnCreateNewCustomer.Text = "Thêm mới";
            this.btnCreateNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(206, 257);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(368, 257);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(168, 106);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(212, 22);
            this.txtCustomerPhone.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(168, 65);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(212, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustommerPhone
            // 
            this.lblCustommerPhone.AutoSize = true;
            this.lblCustommerPhone.Location = new System.Drawing.Point(23, 110);
            this.lblCustommerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustommerPhone.Name = "lblCustommerPhone";
            this.lblCustommerPhone.Size = new System.Drawing.Size(88, 16);
            this.lblCustommerPhone.TabIndex = 17;
            this.lblCustommerPhone.Text = "Số điện thoại:";
            // 
            // lblCustommerName
            // 
            this.lblCustommerName.AutoSize = true;
            this.lblCustommerName.Location = new System.Drawing.Point(23, 69);
            this.lblCustommerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustommerName.Name = "lblCustommerName";
            this.lblCustommerName.Size = new System.Drawing.Size(67, 16);
            this.lblCustommerName.TabIndex = 16;
            this.lblCustommerName.Text = "Họ và tên:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtSearchFollowCustomerName);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(507, 46);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 27);
            this.panel7.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchFollowCustomerName
            // 
            this.txtSearchFollowCustomerName.BackColor = System.Drawing.Color.White;
            this.txtSearchFollowCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFollowCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFollowCustomerName.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFollowCustomerName.Location = new System.Drawing.Point(4, 5);
            this.txtSearchFollowCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFollowCustomerName.Name = "txtSearchFollowCustomerName";
            this.txtSearchFollowCustomerName.Size = new System.Drawing.Size(223, 16);
            this.txtSearchFollowCustomerName.TabIndex = 7;
            this.txtSearchFollowCustomerName.TextChanged += new System.EventHandler(this.txtSearchFollowCustomerName_TextChanged);
            this.txtSearchFollowCustomerName.Enter += new System.EventHandler(this.txtFindFollowName_Enter);
            this.txtSearchFollowCustomerName.Leave += new System.EventHandler(this.txtFindFollowName_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.lblCustommerNo);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lblCustommerName);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.lblCustommerPhone);
            this.groupBox1.Location = new System.Drawing.Point(48, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(427, 160);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomerId.Location = new System.Drawing.Point(168, 26);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(212, 22);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.Enter += new System.EventHandler(this.txtCustomerId_Enter);
            this.txtCustomerId.Leave += new System.EventHandler(this.txtCustomerId_Leave);
            // 
            // lblCustommerNo
            // 
            this.lblCustommerNo.AutoSize = true;
            this.lblCustommerNo.Location = new System.Drawing.Point(23, 30);
            this.lblCustommerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustommerNo.Name = "lblCustommerNo";
            this.lblCustommerNo.Size = new System.Drawing.Size(119, 16);
            this.lblCustommerNo.TabIndex = 80;
            this.lblCustommerNo.Text = "Mã số khách hàng:";
            // 
            // UserControlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShowDataCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreateNewCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlCustomer";
            this.Size = new System.Drawing.Size(1093, 591);
            this.Load += new System.EventHandler(this.UserControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustomer)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowDataCustomer;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustommerPhone;
        private System.Windows.Forms.Label lblCustommerName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchFollowCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustommerNo;
    }
}
