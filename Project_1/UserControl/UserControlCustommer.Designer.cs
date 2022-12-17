namespace Project_1
{
    partial class UserControlCustommer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCustommer));
            this.dgvShowDataCustommer = new System.Windows.Forms.DataGridView();
            this.btnCreateNewCustommer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustommerPhone = new System.Windows.Forms.TextBox();
            this.txtCustommerName = new System.Windows.Forms.TextBox();
            this.lblCustommerPhone = new System.Windows.Forms.Label();
            this.lblCustommerName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFindFollowName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustommerNo = new System.Windows.Forms.TextBox();
            this.lblCustommerNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustommer)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowDataCustommer
            // 
            this.dgvShowDataCustommer.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataCustommer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataCustommer.Location = new System.Drawing.Point(414, 79);
            this.dgvShowDataCustommer.Name = "dgvShowDataCustommer";
            this.dgvShowDataCustommer.Size = new System.Drawing.Size(341, 220);
            this.dgvShowDataCustommer.TabIndex = 11;
            this.dgvShowDataCustommer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataCustommer_CellClick);
            // 
            // btnCreateNewCustommer
            // 
            this.btnCreateNewCustommer.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewCustommer.Image")));
            this.btnCreateNewCustommer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewCustommer.Location = new System.Drawing.Point(32, 264);
            this.btnCreateNewCustommer.Name = "btnCreateNewCustommer";
            this.btnCreateNewCustommer.Size = new System.Drawing.Size(95, 35);
            this.btnCreateNewCustommer.TabIndex = 0;
            this.btnCreateNewCustommer.Text = "Thêm mới";
            this.btnCreateNewCustommer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewCustommer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustommer.Click += new System.EventHandler(this.btnCreateNewCustommer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(158, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(276, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustommerPhone
            // 
            this.txtCustommerPhone.Location = new System.Drawing.Point(126, 86);
            this.txtCustommerPhone.Name = "txtCustommerPhone";
            this.txtCustommerPhone.Size = new System.Drawing.Size(160, 20);
            this.txtCustommerPhone.TabIndex = 19;
            // 
            // txtCustommerName
            // 
            this.txtCustommerName.Location = new System.Drawing.Point(126, 53);
            this.txtCustommerName.Name = "txtCustommerName";
            this.txtCustommerName.Size = new System.Drawing.Size(160, 20);
            this.txtCustommerName.TabIndex = 18;
            // 
            // lblCustommerPhone
            // 
            this.lblCustommerPhone.AutoSize = true;
            this.lblCustommerPhone.Location = new System.Drawing.Point(17, 89);
            this.lblCustommerPhone.Name = "lblCustommerPhone";
            this.lblCustommerPhone.Size = new System.Drawing.Size(73, 13);
            this.lblCustommerPhone.TabIndex = 17;
            this.lblCustommerPhone.Text = "Số điện thoại:";
            // 
            // lblCustommerName
            // 
            this.lblCustommerName.AutoSize = true;
            this.lblCustommerName.Location = new System.Drawing.Point(17, 56);
            this.lblCustommerName.Name = "lblCustommerName";
            this.lblCustommerName.Size = new System.Drawing.Size(57, 13);
            this.lblCustommerName.TabIndex = 16;
            this.lblCustommerName.Text = "Họ và tên:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtFindFollowName);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(414, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 22);
            this.panel7.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, -1);
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
            this.txtFindFollowName.Size = new System.Drawing.Size(167, 13);
            this.txtFindFollowName.TabIndex = 0;
            this.txtFindFollowName.TextChanged += new System.EventHandler(this.txtFindFollowName_TextChanged);
            this.txtFindFollowName.Enter += new System.EventHandler(this.txtFindFollowName_Enter);
            this.txtFindFollowName.Leave += new System.EventHandler(this.txtFindFollowName_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustommerNo);
            this.groupBox1.Controls.Add(this.lblCustommerNo);
            this.groupBox1.Controls.Add(this.txtCustommerName);
            this.groupBox1.Controls.Add(this.lblCustommerName);
            this.groupBox1.Controls.Add(this.txtCustommerPhone);
            this.groupBox1.Controls.Add(this.lblCustommerPhone);
            this.groupBox1.Location = new System.Drawing.Point(32, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 130);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtCustommerNo
            // 
            this.txtCustommerNo.ForeColor = System.Drawing.Color.LightGray;
            this.txtCustommerNo.Location = new System.Drawing.Point(126, 21);
            this.txtCustommerNo.Name = "txtCustommerNo";
            this.txtCustommerNo.Size = new System.Drawing.Size(160, 20);
            this.txtCustommerNo.TabIndex = 81;
            this.txtCustommerNo.Enter += new System.EventHandler(this.txtCustommerNo_Enter);
            this.txtCustommerNo.Leave += new System.EventHandler(this.txtCustommerNo_Leave);
            // 
            // lblCustommerNo
            // 
            this.lblCustommerNo.AutoSize = true;
            this.lblCustommerNo.Location = new System.Drawing.Point(17, 24);
            this.lblCustommerNo.Name = "lblCustommerNo";
            this.lblCustommerNo.Size = new System.Drawing.Size(99, 13);
            this.lblCustommerNo.TabIndex = 80;
            this.lblCustommerNo.Text = "Mã số khách hàng:";
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShowDataCustommer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreateNewCustommer);
            this.Name = "UserControlForm";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.UserControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustommer)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowDataCustommer;
        private System.Windows.Forms.Button btnCreateNewCustommer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCustommerPhone;
        private System.Windows.Forms.TextBox txtCustommerName;
        private System.Windows.Forms.Label lblCustommerPhone;
        private System.Windows.Forms.Label lblCustommerName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFindFollowName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustommerNo;
        private System.Windows.Forms.Label lblCustommerNo;
    }
}
