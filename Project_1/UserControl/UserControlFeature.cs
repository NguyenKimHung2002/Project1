using System;
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
        FeatureDTO f1 = new FeatureDTO();
        public UserControlFeature()
        {
            InitializeComponent();
        }
        private void UserControlFeature_Load(object sender, EventArgs e)
        {
            dgvShowDataFeature.DataSource = featureBLL.GetDataFeatureBLL();
            dgvShowDataFeature.Columns[0].Width = 90;
            dgvShowDataFeature.Columns[1].Width = 112;
            dgvShowDataFeature.Columns[2].Width = 200;
            txtFeatureId.Text = "Mã đặc tính tạo bởi hệ thống";
            txtSearchFollowFeatureName.Text = "Tìm kiếm theo tên đặc tính";
        }

        private void txtFeatureId_Enter(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "Mã đặc tính tạo bởi hệ thống")
            {
                txtFeatureId.Text = "";
                txtFeatureId.ForeColor = Color.Black;
            }
        }

        private void txtFeatureId_Leave(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "")
            {
                txtFeatureId.Text = "Mã đặc tính tạo bởi hệ thống";
                txtFeatureId.ForeColor = Color.Gray;
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
                txtSearchFollowFeatureName.ForeColor = Color.Gray;
            }
        }

        private void ShowDataFeature()
        {
            dgvShowDataFeature.DataSource = featureBLL.GetDataFeatureBLL();
        }
        public void Reset()
        {
            txtFeatureId.Text = "Mã đặc tính tạo bởi hệ thống";
            txtFeatureId.ForeColor = Color.Gray;
            txtFeatureName.Text = "";
            txtFeatureDescription.Text = "";
        }       

        private void btnCreateNewFeature_Click(object sender, EventArgs e)
        {
            if (CheckInformationFeature())
            {
                featureDTO.FeatureName = txtFeatureName.Text;
                featureDTO.FeatureDescription = txtFeatureDescription.Text;
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateFeature_Click(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "Mã đặc tính tạo bởi hệ thống")
            {
                MessageBox.Show("Vui lòng chọn đặc tính muốn cập nhật thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFeatureId.Focus();
            }
            else
            {
                featureDTO.FeatureName = txtFeatureName.Text;
                featureDTO.FeatureDescription = txtFeatureDescription.Text;
                if (featureDTO.FeatureName == f1.FeatureName && featureDTO.FeatureDescription == f1.FeatureDescription)
                {
                    MessageBox.Show("Thông tin của bạn chưa được thay đổi bất cứ điều gì! Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureId.Focus();
                }
                else
                {
                    try
                    {
                        featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
                        if (featureBLL.UpdateFeatureBLL(featureDTO))
                        {
                            MessageBox.Show("Cập nhật thành công.");
                            ShowDataFeature();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnDeleteFeature_Click(object sender, EventArgs e)
        {
            if (txtFeatureId.Text == "Mã đặc tính tạo bởi hệ thống")
            {
                MessageBox.Show("Vui lòng chọn đặc tính muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFeatureId.Focus();
            }
            else
            {
                try
                {
                    var deleteFeature = MessageBox.Show("Việc xóa đặc tính này sẽ dẫn đến các nhãn dán đặc tính này đến sản phẩm đều bị gỡ bỏ. " +
                        "Bạn có chắc chắn muốn xóa đặc tính này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (deleteFeature == DialogResult.Yes)
                    {
                        featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool CheckInformationFeature()
        {
            //FeatureName
            if (txtFeatureName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đặc tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtFeatureName.Focus();
                return false;
            }
            return true;
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
                f1.FeatureName = txtFeatureName.Text;
                f1.FeatureDescription = txtFeatureDescription.Text;
            }
        }

        
    }
}
