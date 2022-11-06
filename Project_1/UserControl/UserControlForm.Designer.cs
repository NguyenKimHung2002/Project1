namespace Project_1
{
    partial class UserControlForm
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
            this.dgvShowDataCustommer = new System.Windows.Forms.DataGridView();
            this.btnAddNewCustommer = new System.Windows.Forms.Button();
            this.txtCustommerPhone = new System.Windows.Forms.TextBox();
            this.txtCustommerName = new System.Windows.Forms.TextBox();
            this.lblCustommerPhone = new System.Windows.Forms.Label();
            this.llblCustommerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustommer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowDataCustommer
            // 
            this.dgvShowDataCustommer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataCustommer.Location = new System.Drawing.Point(279, 16);
            this.dgvShowDataCustommer.Name = "dgvShowDataCustommer";
            this.dgvShowDataCustommer.Size = new System.Drawing.Size(364, 163);
            this.dgvShowDataCustommer.TabIndex = 11;
            // 
            // btnAddNewCustommer
            // 
            this.btnAddNewCustommer.Location = new System.Drawing.Point(98, 119);
            this.btnAddNewCustommer.Name = "btnAddNewCustommer";
            this.btnAddNewCustommer.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewCustommer.TabIndex = 10;
            this.btnAddNewCustommer.Text = "Thêm";
            this.btnAddNewCustommer.UseVisualStyleBackColor = true;
            this.btnAddNewCustommer.Click += new System.EventHandler(this.btnAddNewCustommer_Click);
            // 
            // txtCustommerPhone
            // 
            this.txtCustommerPhone.Location = new System.Drawing.Point(127, 78);
            this.txtCustommerPhone.Name = "txtCustommerPhone";
            this.txtCustommerPhone.Size = new System.Drawing.Size(121, 20);
            this.txtCustommerPhone.TabIndex = 9;
            // 
            // txtCustommerName
            // 
            this.txtCustommerName.Location = new System.Drawing.Point(127, 39);
            this.txtCustommerName.Name = "txtCustommerName";
            this.txtCustommerName.Size = new System.Drawing.Size(121, 20);
            this.txtCustommerName.TabIndex = 8;
            // 
            // lblCustommerPhone
            // 
            this.lblCustommerPhone.AutoSize = true;
            this.lblCustommerPhone.Location = new System.Drawing.Point(41, 81);
            this.lblCustommerPhone.Name = "lblCustommerPhone";
            this.lblCustommerPhone.Size = new System.Drawing.Size(73, 13);
            this.lblCustommerPhone.TabIndex = 7;
            this.lblCustommerPhone.Text = "Số điện thoại:";
            // 
            // llblCustommerName
            // 
            this.llblCustommerName.AutoSize = true;
            this.llblCustommerName.Location = new System.Drawing.Point(41, 42);
            this.llblCustommerName.Name = "llblCustommerName";
            this.llblCustommerName.Size = new System.Drawing.Size(57, 13);
            this.llblCustommerName.TabIndex = 6;
            this.llblCustommerName.Text = "Họ và tên:";
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShowDataCustommer);
            this.Controls.Add(this.btnAddNewCustommer);
            this.Controls.Add(this.txtCustommerPhone);
            this.Controls.Add(this.txtCustommerName);
            this.Controls.Add(this.lblCustommerPhone);
            this.Controls.Add(this.llblCustommerName);
            this.Name = "UserControlForm";
            this.Size = new System.Drawing.Size(673, 195);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataCustommer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowDataCustommer;
        private System.Windows.Forms.Button btnAddNewCustommer;
        private System.Windows.Forms.TextBox txtCustommerPhone;
        private System.Windows.Forms.TextBox txtCustommerName;
        private System.Windows.Forms.Label lblCustommerPhone;
        private System.Windows.Forms.Label llblCustommerName;
    }
}
