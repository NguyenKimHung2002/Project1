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
    public partial class UserControlCategory : UserControl
    {
        CategoryBLL categoryBLL = new CategoryBLL();
        CategoryDTO categoryDTO = new CategoryDTO();
        FeatureBLL featureBLL = new FeatureBLL();
        FeatureDTO featureDTO = new FeatureDTO();
        FeatureByCategoryBLL featureByCategoryBLL = new FeatureByCategoryBLL();
        FeatureByCategoryDTO featureByCategoryDTO= new FeatureByCategoryDTO();
        
        public UserControlCategory()
        {
            InitializeComponent();
        }
        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            txtCategoryId.Text = "Thêm mới không cần nhập";
            txtSearchFollowCategoryName.Text = "Tìm kiếm theo tên danh mục";
            DataTable dt = featureBLL.GetFeatureNameBLL();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                var cell = dt.Rows[i][1];
                lbFeature.Items.Add(cell.ToString());
            }
        }
        private void txtCategoryId_Enter(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == "Thêm mới không cần nhập")
            {
                txtCategoryId.Text = "";
                txtCategoryId.ForeColor = Color.Black;
            }
        }
        private void txtCategoryId_Leave(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == "")
            {
                txtCategoryId.Text = "Thêm mới không cần nhập";
                txtCategoryId.ForeColor = Color.LightGray;
            }
        }
        private void txtSearchFollowCategoryName_Enter(object sender, EventArgs e)
        {
            if (txtSearchFollowCategoryName.Text == "Tìm kiếm theo tên danh mục")
            {
                txtSearchFollowCategoryName.Text = "";
                txtSearchFollowCategoryName.ForeColor = Color.Black;
            }
        }

        private void txtSearchFollowCategoryName_Leave(object sender, EventArgs e)
        {
            if (txtSearchFollowCategoryName.Text == "")
            {
                txtSearchFollowCategoryName.Text = "Tìm kiếm theo tên danh mục";
                txtSearchFollowCategoryName.ForeColor = Color.LightGray;
            }
        }
        private void ShowDataCategory()
        {
            dgvShowDataCategory.DataSource = categoryBLL.GetDataCategoryBLL();
        }
        public void Reset()
        {
            txtCategoryId.Text = "Thêm mới không cần nhập";
            txtCategoryName.Text = "";
            txtCategoryDescription.Text = "";
        }
        private void lbFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFeature.SelectedIndices.Count > 0)
            {
                lbShowFeature.Items.Clear();
                for (int i = 0; i<lbFeature.SelectedIndices.Count; i++)
                {
                    lbShowFeature.Items.Add(lbFeature.SelectedItems[i].ToString());
                }
            }
            else if (lbFeature.SelectedIndices.Count == 0)
            {
                lbShowFeature.Items.Clear();
            }
        }
        private void btnCreateNewCategory_Click(object sender, EventArgs e)
        {
            categoryDTO.CategoryName = txtCategoryName.Text;
            categoryDTO.CategoryDescription = txtCategoryDescription.Text;
            if (categoryDTO.CategoryName != "" && categoryDTO.CategoryDescription != "")
            {
                if (categoryBLL.AddCategoryBLL(categoryDTO) == true)
                {
                    featureByCategoryDTO.CategoryId = categoryBLL.GetLastestCategoryId(categoryDTO);
                    for(int i=0; i<lbShowFeature.Items.Count; i++)
                    {
                        featureDTO.FeatureName = lbShowFeature.Items[i].ToString();
                        featureByCategoryDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
                        if (featureByCategoryBLL.AddFeatureByCategoryBLL(featureByCategoryDTO) == true)
                        {
                            continue;
                        }
                    }
                    MessageBox.Show("Thêm thành công.");
                    ShowDataCategory();
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

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            categoryDTO.CategoryName = txtCategoryName.Text;
            categoryDTO.CategoryDescription = txtCategoryDescription.Text;
            categoryDTO.CategoryId = Int32.Parse(txtCategoryId.Text);
            if (txtCategoryName.Text != "" && txtCategoryDescription.Text != "" && txtCategoryId.Text != "")
            {
                if (categoryBLL.UpdateCategoryBLL(categoryDTO))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    ShowDataCategory();
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
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            categoryDTO.CategoryId = Int32.Parse(txtCategoryId.Text);
            if (txtCategoryId.Text != "" && txtCategoryName.Text != "" && txtCategoryDescription.Text != "")
            {
                if (categoryBLL.DeleteCategoryBLL(categoryDTO))
                {
                    MessageBox.Show("Xóa thành công.");
                    ShowDataCategory();
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
    }
}
