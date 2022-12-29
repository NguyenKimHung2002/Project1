namespace Project_1
{
    partial class UserControlFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFeature));
            this.txtFeatureDescription = new System.Windows.Forms.TextBox();
            this.lblFeatureDescription = new System.Windows.Forms.Label();
            this.txtFeatureId = new System.Windows.Forms.TextBox();
            this.lblFeatureId = new System.Windows.Forms.Label();
            this.txtFeatureName = new System.Windows.Forms.TextBox();
            this.lblFeatureName = new System.Windows.Forms.Label();
            this.gbFeatureInformation = new System.Windows.Forms.GroupBox();
            this.btnDeleteFeature = new System.Windows.Forms.Button();
            this.btnUpdateFeature = new System.Windows.Forms.Button();
            this.dgvShowDataFeature = new System.Windows.Forms.DataGridView();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchFollowFeatureName = new System.Windows.Forms.TextBox();
            this.btnCreateNewFeature = new System.Windows.Forms.Button();
            this.panelSearchFeature = new System.Windows.Forms.Panel();
            this.gbFeatureInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.panelSearchFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFeatureDescription
            // 
            this.txtFeatureDescription.Location = new System.Drawing.Point(99, 88);
            this.txtFeatureDescription.Multiline = true;
            this.txtFeatureDescription.Name = "txtFeatureDescription";
            this.txtFeatureDescription.Size = new System.Drawing.Size(160, 91);
            this.txtFeatureDescription.TabIndex = 89;
            // 
            // lblFeatureDescription
            // 
            this.lblFeatureDescription.AutoSize = true;
            this.lblFeatureDescription.Location = new System.Drawing.Point(6, 91);
            this.lblFeatureDescription.Name = "lblFeatureDescription";
            this.lblFeatureDescription.Size = new System.Drawing.Size(81, 13);
            this.lblFeatureDescription.TabIndex = 88;
            this.lblFeatureDescription.Text = "Mô tả đặc tính:";
            // 
            // txtFeatureId
            // 
            this.txtFeatureId.ForeColor = System.Drawing.Color.LightGray;
            this.txtFeatureId.Location = new System.Drawing.Point(99, 21);
            this.txtFeatureId.Name = "txtFeatureId";
            this.txtFeatureId.Size = new System.Drawing.Size(160, 20);
            this.txtFeatureId.TabIndex = 81;
            this.txtFeatureId.Enter += new System.EventHandler(this.txtFeatureId_Enter);
            this.txtFeatureId.Leave += new System.EventHandler(this.txtFeatureId_Leave);
            // 
            // lblFeatureId
            // 
            this.lblFeatureId.AutoSize = true;
            this.lblFeatureId.Location = new System.Drawing.Point(6, 24);
            this.lblFeatureId.Name = "lblFeatureId";
            this.lblFeatureId.Size = new System.Drawing.Size(69, 13);
            this.lblFeatureId.TabIndex = 80;
            this.lblFeatureId.Text = "Mã đặc tính:";
            // 
            // txtFeatureName
            // 
            this.txtFeatureName.Location = new System.Drawing.Point(99, 53);
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.Size = new System.Drawing.Size(160, 20);
            this.txtFeatureName.TabIndex = 18;
            // 
            // lblFeatureName
            // 
            this.lblFeatureName.AutoSize = true;
            this.lblFeatureName.Location = new System.Drawing.Point(6, 56);
            this.lblFeatureName.Name = "lblFeatureName";
            this.lblFeatureName.Size = new System.Drawing.Size(73, 13);
            this.lblFeatureName.TabIndex = 16;
            this.lblFeatureName.Text = "Tên đặc tính:";
            // 
            // gbFeatureInformation
            // 
            this.gbFeatureInformation.Controls.Add(this.txtFeatureDescription);
            this.gbFeatureInformation.Controls.Add(this.lblFeatureDescription);
            this.gbFeatureInformation.Controls.Add(this.txtFeatureId);
            this.gbFeatureInformation.Controls.Add(this.lblFeatureId);
            this.gbFeatureInformation.Controls.Add(this.txtFeatureName);
            this.gbFeatureInformation.Controls.Add(this.lblFeatureName);
            this.gbFeatureInformation.Location = new System.Drawing.Point(19, 38);
            this.gbFeatureInformation.Name = "gbFeatureInformation";
            this.gbFeatureInformation.Size = new System.Drawing.Size(286, 193);
            this.gbFeatureInformation.TabIndex = 90;
            this.gbFeatureInformation.TabStop = false;
            this.gbFeatureInformation.Text = "Thông tin đặc tính";
            // 
            // btnDeleteFeature
            // 
            this.btnDeleteFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFeature.Image")));
            this.btnDeleteFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFeature.Location = new System.Drawing.Point(231, 247);
            this.btnDeleteFeature.Name = "btnDeleteFeature";
            this.btnDeleteFeature.Size = new System.Drawing.Size(77, 34);
            this.btnDeleteFeature.TabIndex = 89;
            this.btnDeleteFeature.Text = "         Xóa";
            this.btnDeleteFeature.UseVisualStyleBackColor = true;
            this.btnDeleteFeature.Click += new System.EventHandler(this.btnDeleteFeature_Click);
            // 
            // btnUpdateFeature
            // 
            this.btnUpdateFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateFeature.Image")));
            this.btnUpdateFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFeature.Location = new System.Drawing.Point(129, 247);
            this.btnUpdateFeature.Name = "btnUpdateFeature";
            this.btnUpdateFeature.Size = new System.Drawing.Size(87, 34);
            this.btnUpdateFeature.TabIndex = 88;
            this.btnUpdateFeature.Text = "Cập nhật";
            this.btnUpdateFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateFeature.UseVisualStyleBackColor = true;
            this.btnUpdateFeature.Click += new System.EventHandler(this.btnUpdateFeature_Click);
            // 
            // dgvShowDataFeature
            // 
            this.dgvShowDataFeature.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataFeature.Location = new System.Drawing.Point(330, 66);
            this.dgvShowDataFeature.Name = "dgvShowDataFeature";
            this.dgvShowDataFeature.Size = new System.Drawing.Size(465, 326);
            this.dgvShowDataFeature.TabIndex = 85;
            this.dgvShowDataFeature.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataFeature_CellClick);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(275, -1);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 22);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 61;
            this.picSearch.TabStop = false;
            // 
            // txtSearchFollowFeatureName
            // 
            this.txtSearchFollowFeatureName.BackColor = System.Drawing.Color.White;
            this.txtSearchFollowFeatureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFollowFeatureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFollowFeatureName.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchFollowFeatureName.Location = new System.Drawing.Point(3, 3);
            this.txtSearchFollowFeatureName.Name = "txtSearchFollowFeatureName";
            this.txtSearchFollowFeatureName.Size = new System.Drawing.Size(266, 13);
            this.txtSearchFollowFeatureName.TabIndex = 0;
            this.txtSearchFollowFeatureName.TextChanged += new System.EventHandler(this.txtSearchFollowFeatureName_TextChanged);
            this.txtSearchFollowFeatureName.Enter += new System.EventHandler(this.txtSearchFollowFeatureName_Enter);
            this.txtSearchFollowFeatureName.Leave += new System.EventHandler(this.txtSearchFollowFeatureName_Leave);
            // 
            // btnCreateNewFeature
            // 
            this.btnCreateNewFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewFeature.Image")));
            this.btnCreateNewFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewFeature.Location = new System.Drawing.Point(22, 247);
            this.btnCreateNewFeature.Name = "btnCreateNewFeature";
            this.btnCreateNewFeature.Size = new System.Drawing.Size(88, 34);
            this.btnCreateNewFeature.TabIndex = 87;
            this.btnCreateNewFeature.Text = "Thêm mới";
            this.btnCreateNewFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewFeature.UseVisualStyleBackColor = true;
            this.btnCreateNewFeature.Click += new System.EventHandler(this.btnCreateNewFeature_Click);
            // 
            // panelSearchFeature
            // 
            this.panelSearchFeature.BackColor = System.Drawing.Color.White;
            this.panelSearchFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchFeature.Controls.Add(this.picSearch);
            this.panelSearchFeature.Controls.Add(this.txtSearchFollowFeatureName);
            this.panelSearchFeature.ForeColor = System.Drawing.Color.Black;
            this.panelSearchFeature.Location = new System.Drawing.Point(330, 38);
            this.panelSearchFeature.Name = "panelSearchFeature";
            this.panelSearchFeature.Size = new System.Drawing.Size(301, 22);
            this.panelSearchFeature.TabIndex = 86;
            // 
            // UserControlFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFeatureInformation);
            this.Controls.Add(this.btnDeleteFeature);
            this.Controls.Add(this.btnUpdateFeature);
            this.Controls.Add(this.dgvShowDataFeature);
            this.Controls.Add(this.btnCreateNewFeature);
            this.Controls.Add(this.panelSearchFeature);
            this.Name = "UserControlFeature";
            this.Size = new System.Drawing.Size(820, 480);
            this.Load += new System.EventHandler(this.UserControlFeature_Load);
            this.gbFeatureInformation.ResumeLayout(false);
            this.gbFeatureInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.panelSearchFeature.ResumeLayout(false);
            this.panelSearchFeature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeatureDescription;
        private System.Windows.Forms.Label lblFeatureDescription;
        private System.Windows.Forms.TextBox txtFeatureId;
        private System.Windows.Forms.Label lblFeatureId;
        private System.Windows.Forms.TextBox txtFeatureName;
        private System.Windows.Forms.Label lblFeatureName;
        private System.Windows.Forms.GroupBox gbFeatureInformation;
        private System.Windows.Forms.Button btnDeleteFeature;
        private System.Windows.Forms.Button btnUpdateFeature;
        private System.Windows.Forms.DataGridView dgvShowDataFeature;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchFollowFeatureName;
        private System.Windows.Forms.Button btnCreateNewFeature;
        private System.Windows.Forms.Panel panelSearchFeature;
    }
}
