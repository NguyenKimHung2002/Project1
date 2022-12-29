﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace Project_1
{
    public partial class UserControlFeature : UserControl
    {
        FeatureBLL featureBLL = new FeatureBLL();
        FeatureDTO featureDTO = new FeatureDTO();
        public UserControlFeature()
        {
            InitializeComponent();
        }
        private void UserControlFeature_Load(object sender, EventArgs e)
        {
            dgvShowDataFeature.DataSource = featureBLL.GetDataFeatureBLL();
            txtFeatureId.Text = "Thêm mới không cần nhập";
            txtSearchFollowFeatureName.Text = "Tìm kiếm theo tên đặc tính";
        }

        private void txtFeatureId_Enter(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "Thêm mới không cần nhập")
            {
                txtFeatureId.Text = "";
                txtFeatureId.ForeColor = Color.Black;
            }
        }

        private void txtFeatureId_Leave(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "")
            {
                txtFeatureId.Text = "Thêm mới không cần nhập";
                txtFeatureId.ForeColor = Color.LightGray;
            }
        }
        private void txtSearchFollowFeatureName_Enter(object sender, EventArgs e)
        {
            if (txtSearchFollowFeatureName.Text == "Tìm kiếm theo tên đặc tính")
            {
                txtSearchFollowFeatureName.Text = "";
                txtSearchFollowFeatureName.ForeColor = Color.Black;
            }
        }

        private void txtSearchFollowFeatureName_Leave(object sender, EventArgs e)
        {
            if (txtSearchFollowFeatureName.Text == "")
            {
                txtSearchFollowFeatureName.Text = "Tìm kiếm theo tên đặc tính";
                txtSearchFollowFeatureName.ForeColor = Color.LightGray;
            }
        }

        private void ShowDataFeature()
        {
            dgvShowDataFeature.DataSource = featureBLL.GetDataFeatureBLL();
        }
        public void Reset()
        {
            txtFeatureId.Text = "Thêm mới không cần nhập";
            txtFeatureName.Text = "";
            txtFeatureDescription.Text = "";
        }       

        private void btnCreateNewFeature_Click(object sender, EventArgs e)
        {
            featureDTO.FeatureName = txtFeatureName.Text;
            featureDTO.FeatureDescription = txtFeatureDescription.Text;
            if (featureDTO.FeatureName != "" && featureDTO.FeatureDescription != "")
            {
                if (featureBLL.AddFeatureBLL(featureDTO) == true)
                {
                    MessageBox.Show("Thêm thành công.");
                    ShowDataFeature();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ.");
            }
        }

        private void btnUpdateFeature_Click(object sender, EventArgs e)
        {
            featureDTO.FeatureName = txtFeatureName.Text;
            featureDTO.FeatureDescription = txtFeatureDescription.Text;
            featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
            if (txtFeatureName.Text != "" && txtFeatureDescription.Text != "" && txtFeatureId.Text != "")
            {
                if (featureBLL.UpdateFeatureBLL(featureDTO))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    ShowDataFeature();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ.");
            }
        }

        private void btnDeleteFeature_Click(object sender, EventArgs e)
        {
            featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
            if (txtFeatureId.Text != "" && txtFeatureName.Text != "" && txtFeatureDescription.Text != "")
            {
                if (featureBLL.DeleteFeatureBLL(featureDTO))
                {
                    MessageBox.Show("Xóa thành công.");
                    ShowDataFeature();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ.");
            }
        }
        private void txtSearchFollowFeatureName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFollowFeatureName.Text != "" && txtSearchFollowFeatureName.Text != "Tìm kiếm theo tên đặc tính")
            {
                featureDTO.SearchFollowFeatureName = txtSearchFollowFeatureName.Text;
                DataTable dt = featureBLL.SearchDataFeatureBLL(featureDTO);
                dgvShowDataFeature.DataSource = dt;
            }
            else
            {
                ShowDataFeature();
            }
        }
        private void dgvShowDataFeature_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvShowDataFeature.Rows[e.RowIndex];
                txtFeatureId.Text = Convert.ToString(row.Cells["Mã đặc tính"].Value);
                txtFeatureName.Text = Convert.ToString(row.Cells["Tên đặc tính"].Value);
                txtFeatureDescription.Text = Convert.ToString(row.Cells["Mô tả"].Value);
            }
        }

        
    }
}