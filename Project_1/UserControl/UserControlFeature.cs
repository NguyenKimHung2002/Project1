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
            txtFeatureId.Text = "Thêm mới không cần nhập";
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
                if (featureBLL.CheckExistsFeatureId(featureDTO) == 1)
                {
                    MessageBox.Show("Mã đặc tính đã tồn tại! Vui lòng chọn một mã đặc tính khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureId.Focus();
                }
                else
                {
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
        }

        private void btnUpdateFeature_Click(object sender, EventArgs e)
        {
            if (CheckInformationFeature())
            {
                featureDTO.FeatureName = txtFeatureName.Text;
                featureDTO.FeatureDescription = txtFeatureDescription.Text;
                featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
                if (featureDTO.FeatureId == f1.FeatureId && featureDTO.FeatureName == f1.FeatureName && featureDTO.FeatureDescription == f1.FeatureDescription)
                {
                    MessageBox.Show("Thông tin của bạn chưa được thay đổi bất cứ điều gì! Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureId.Focus();
                }
                else if (featureBLL.CheckExistsFeatureId(featureDTO) == 0)
                {
                    MessageBox.Show("Không tìm thấy đặc tính! Vui lòng kiểm tra lại mã đặc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureId.Focus();
                }
                else
                {
                    try
                    {
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
            if (CheckInformationFeature())
            {
                featureDTO.FeatureId = Int32.Parse(txtFeatureId.Text);
                if (featureBLL.CheckExistsFeatureId(featureDTO) == 0)
                {
                    MessageBox.Show("Không tìm thấy đặc tính! Vui lòng kiểm tra lại mã đặc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureId.Focus();
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private bool CheckInformationFeature()
        {
            //FeatureId
            if (!Int32.TryParse(txtFeatureId.Text, out int featureId))
            {
                MessageBox.Show("Mã đặc tính phải là một số, do hệ thống tự động cấp! Vui lòng nhập đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFeatureId.Focus();
                return false;
            }
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
                f1.FeatureId = Convert.ToInt32(txtFeatureId.Text);
                f1.FeatureName = txtFeatureName.Text;
                f1.FeatureDescription = txtFeatureDescription.Text;
            }
        }

        
    }
}
