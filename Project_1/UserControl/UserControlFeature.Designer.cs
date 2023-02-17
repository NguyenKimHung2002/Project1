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
            this.txtFeatureDescription.Location = new System.Drawing.Point(132, 108);
            this.txtFeatureDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeatureDescription.Multiline = true;
            this.txtFeatureDescription.Name = "txtFeatureDescription";
            this.txtFeatureDescription.Size = new System.Drawing.Size(212, 111);
            this.txtFeatureDescription.TabIndex = 3;
            // 
            // lblFeatureDescription
            // 
            this.lblFeatureDescription.AutoSize = true;
            this.lblFeatureDescription.Location = new System.Drawing.Point(8, 112);
            this.lblFeatureDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureDescription.Name = "lblFeatureDescription";
            this.lblFeatureDescription.Size = new System.Drawing.Size(92, 16);
            this.lblFeatureDescription.TabIndex = 88;
            this.lblFeatureDescription.Text = "Mô tả đặc tính:";
            // 
            // txtFeatureId
            // 
            this.txtFeatureId.ForeColor = System.Drawing.Color.Gray;
            this.txtFeatureId.Location = new System.Drawing.Point(132, 26);
            this.txtFeatureId.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeatureId.Name = "txtFeatureId";
            this.txtFeatureId.Size = new System.Drawing.Size(212, 22);
            this.txtFeatureId.TabIndex = 1;
            this.txtFeatureId.Enter += new System.EventHandler(this.txtFeatureId_Enter);
            this.txtFeatureId.Leave += new System.EventHandler(this.txtFeatureId_Leave);
            // 
            // lblFeatureId
            // 
            this.lblFeatureId.AutoSize = true;
            this.lblFeatureId.Location = new System.Drawing.Point(8, 30);
            this.lblFeatureId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureId.Name = "lblFeatureId";
            this.lblFeatureId.Size = new System.Drawing.Size(78, 16);
            this.lblFeatureId.TabIndex = 80;
            this.lblFeatureId.Text = "Mã đặc tính:";
            // 
            // txtFeatureName
            // 
            this.txtFeatureName.Location = new System.Drawing.Point(132, 65);
            this.txtFeatureName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.Size = new System.Drawing.Size(212, 22);
            this.txtFeatureName.TabIndex = 2;
            // 
            // lblFeatureName
            // 
            this.lblFeatureName.AutoSize = true;
            this.lblFeatureName.Location = new System.Drawing.Point(8, 69);
            this.lblFeatureName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureName.Name = "lblFeatureName";
            this.lblFeatureName.Size = new System.Drawing.Size(83, 16);
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
            this.gbFeatureInformation.Location = new System.Drawing.Point(25, 47);
            this.gbFeatureInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gbFeatureInformation.Name = "gbFeatureInformation";
            this.gbFeatureInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gbFeatureInformation.Size = new System.Drawing.Size(381, 238);
            this.gbFeatureInformation.TabIndex = 90;
            this.gbFeatureInformation.TabStop = false;
            this.gbFeatureInformation.Text = "Thông tin đặc tính";
            // 
            // btnDeleteFeature
            // 
            this.btnDeleteFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFeature.Image")));
            this.btnDeleteFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFeature.Location = new System.Drawing.Point(308, 304);
            this.btnDeleteFeature.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFeature.Name = "btnDeleteFeature";
            this.btnDeleteFeature.Size = new System.Drawing.Size(103, 42);
            this.btnDeleteFeature.TabIndex = 6;
            this.btnDeleteFeature.Text = "         Xóa";
            this.btnDeleteFeature.UseVisualStyleBackColor = true;
            this.btnDeleteFeature.Click += new System.EventHandler(this.btnDeleteFeature_Click);
            // 
            // btnUpdateFeature
            // 
            this.btnUpdateFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateFeature.Image")));
            this.btnUpdateFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFeature.Location = new System.Drawing.Point(172, 304);
            this.btnUpdateFeature.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFeature.Name = "btnUpdateFeature";
            this.btnUpdateFeature.Size = new System.Drawing.Size(116, 42);
            this.btnUpdateFeature.TabIndex = 5;
            this.btnUpdateFeature.Text = "Cập nhật";
            this.btnUpdateFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateFeature.UseVisualStyleBackColor = true;
            this.btnUpdateFeature.Click += new System.EventHandler(this.btnUpdateFeature_Click);
            // 
            // dgvShowDataFeature
            // 
            this.dgvShowDataFeature.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowDataFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataFeature.Location = new System.Drawing.Point(440, 81);
            this.dgvShowDataFeature.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowDataFeature.Name = "dgvShowDataFeature";
            this.dgvShowDataFeature.RowHeadersWidth = 51;
            this.dgvShowDataFeature.Size = new System.Drawing.Size(620, 401);
            this.dgvShowDataFeature.TabIndex = 85;
            this.dgvShowDataFeature.TabStop = false;
            this.dgvShowDataFeature.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataFeature_CellClick);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(367, -1);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(32, 27);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 61;
            this.picSearch.TabStop = false;
            // 
            // txtSearchFollowFeatureName
            // 
            this.txtSearchFollowFeatureName.BackColor = System.Drawing.Color.White;
            this.txtSearchFollowFeatureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFollowFeatureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFollowFeatureName.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFollowFeatureName.Location = new System.Drawing.Point(4, 4);
            this.txtSearchFollowFeatureName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFollowFeatureName.Name = "txtSearchFollowFeatureName";
            this.txtSearchFollowFeatureName.Size = new System.Drawing.Size(355, 16);
            this.txtSearchFollowFeatureName.TabIndex = 7;
            this.txtSearchFollowFeatureName.TextChanged += new System.EventHandler(this.txtSearchFollowFeatureName_TextChanged);
            this.txtSearchFollowFeatureName.Enter += new System.EventHandler(this.txtSearchFollowFeatureName_Enter);
            this.txtSearchFollowFeatureName.Leave += new System.EventHandler(this.txtSearchFollowFeatureName_Leave);
            // 
            // btnCreateNewFeature
            // 
            this.btnCreateNewFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewFeature.Image")));
            this.btnCreateNewFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewFeature.Location = new System.Drawing.Point(29, 304);
            this.btnCreateNewFeature.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNewFeature.Name = "btnCreateNewFeature";
            this.btnCreateNewFeature.Size = new System.Drawing.Size(117, 42);
            this.btnCreateNewFeature.TabIndex = 4;
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
            this.panelSearchFeature.Location = new System.Drawing.Point(440, 47);
            this.panelSearchFeature.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearchFeature.Name = "panelSearchFeature";
            this.panelSearchFeature.Size = new System.Drawing.Size(401, 27);
            this.panelSearchFeature.TabIndex = 86;
            // 
            // UserControlFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFeatureInformation);
            this.Controls.Add(this.btnDeleteFeature);
            this.Controls.Add(this.btnUpdateFeature);
            this.Controls.Add(this.dgvShowDataFeature);
            this.Controls.Add(this.btnCreateNewFeature);
            this.Controls.Add(this.panelSearchFeature);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlFeature";
            this.Size = new System.Drawing.Size(1093, 591);
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
