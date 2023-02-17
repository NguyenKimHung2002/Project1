using BusinessLogicLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class UserControlProduct : UserControl
    {
        ProductBLL productBLL = new ProductBLL();
        ProductDTO productDTO = new ProductDTO();
        FeatureBLL featureBLL = new FeatureBLL();
        FeatureDTO featureDTO = new FeatureDTO();
        FeatureByProductBLL featureByProductBLL = new FeatureByProductBLL();
        FeatureByProductDTO featureByProductDTO = new FeatureByProductDTO();
        public UserControlProduct()
        {
            InitializeComponent();
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            Reset();
            ShowDataProduct();
        }
        private void ShowDataProduct()
        {
            dgvShowDataProduct.DataSource = productBLL.GetDataProductBLL();
            dgvShowDataProduct.Columns[6].Width = 300;
        }
        private void ShowFeatureByProduct()
        {
            cbFeatureName.Text = "Tất cả";
            txtFeatureValue.Text = "";
            featureByProductDTO.ProductId = txtProductId.Text;
            dgvShowStickers.DataSource = featureByProductBLL.GetFeatureByProductBLL(featureByProductDTO);
            dgvShowStickers.Columns[0].Width = 120;
            dgvShowStickers.Columns[1].Width = 150;
        }
        private void Reset()
        {
            txtProductId.Text = "Nhập mã sản phẩm";
            txtProductId.ForeColor = Color.Gray;
            txtProductName.Text = "";
            txtImportPrice.Text = "";
            txtExportPrice.Text = "";
            txtProductQuantity.Text = "";
            txtProductUnit.Text = "";
            txtProductDescription.Text = "";
            txtSearchProduct.Text = "Tìm kiếm sản phẩm";
            txtSearchProduct.ForeColor = Color.Gray;
            DataTable dt = featureBLL.GetFeatureNameBLL();
            DataRow dr = dt.NewRow();
            dr["Mã đặc tính"] = "-1";
            dr["Đặc tính"] = "Tất cả";
            dt.Rows.Add(dr);
            cbFeatureName.DataSource = dt;
            cbFeatureName.DisplayMember = "Đặc tính nổi bật";
            cbFeatureName.ValueMember = "Đặc tính";
            cbFeatureName.SelectedIndex = cbFeatureName.Items.Count - 1;
            txtFeatureValue.Text = "";
        }
        private void txtProductId_Enter(object sender, EventArgs e)
        {
            if(txtProductId.Text == "Nhập mã sản phẩm")
            {
                txtProductId.Text = "";
                txtProductId.ForeColor = Color.Black;
            }
        }

        private void txtProductId_Leave(object sender, EventArgs e)
        {
            if(txtProductId.Text == "")
            {
                txtProductId.Text = "Nhập mã sản phẩm";
                txtProductId.ForeColor = Color.Gray;
            }
        }

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if(txtSearchProduct.Text == "Tìm kiếm sản phẩm")
            {
                txtSearchProduct.Text = "";
                txtSearchProduct.ForeColor = Color.Black;
            }
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if(txtSearchProduct.Text == "")
            {
                txtSearchProduct.Text = "Tìm kiếm sản phẩm";
                txtSearchProduct.ForeColor = Color.Gray;
            }
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            productDTO.ProductId = txtProductId.Text;
            productDTO.ProductName = txtProductName.Text;
            productDTO.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            productDTO.ProductUnit = txtProductUnit.Text;
            productDTO.ImportPrice = txtImportPrice.Text;
            productDTO.ExportPrice = txtExportPrice.Text;
            productDTO.ProductDescription = txtProductDescription.Text;
            try
            {
                productDTO.ProductDescription = txtProductDescription.Text;
                if (productDTO.ProductId != "" && productDTO.ProductName != "" && productDTO.ProductQuantity != -1 && productDTO.ProductUnit != ""
                    && productDTO.ImportPrice != "" && productDTO.ExportPrice != "")
                {
                    if (productBLL.AddProductBLL(productDTO) == true)
                    {
                        MessageBox.Show("Thêm thành công.");
                        ShowDataProduct();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            productDTO.ProductId = txtProductId.Text;
            productDTO.ProductName = txtProductName.Text;
            productDTO.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            productDTO.ProductUnit = txtProductUnit.Text;
            productDTO.ImportPrice = txtImportPrice.Text;
            productDTO.ExportPrice = txtExportPrice.Text;
            productDTO.ProductDescription = txtProductDescription.Text;
            try
            {
                if (productDTO.ProductId != "" && productDTO.ProductName != "" && productDTO.ProductQuantity != -1 && productDTO.ProductUnit != ""
                    && productDTO.ImportPrice != "" && productDTO.ExportPrice != "")
                {
                    if (productBLL.UpdateProductBLL(productDTO) == true)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        ShowDataProduct();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            productDTO.ProductId = txtProductId.Text;
            try
            {
                if (productDTO.ProductId != "" && productDTO.ProductName != "" && productDTO.ProductQuantity != -1 && productDTO.ProductUnit != ""
                    && productDTO.ImportPrice != "" && productDTO.ExportPrice != "" && productDTO.ProductDescription != "")
                {
                    if (productBLL.DeleteProductBLL(productDTO))
                    {
                        MessageBox.Show("Xóa thành công.");
                        ShowDataProduct();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddSticker_Click(object sender, EventArgs e)
        {
            featureByProductDTO.ProductId = txtProductId.Text;
            featureDTO.FeatureName = cbFeatureName.Text;
            featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
            featureByProductDTO.FeatureValue = txtFeatureValue.Text;
            try
            {
                if (txtProductId.Text != "" && cbFeatureName.Text != "Tất cả" && txtFeatureValue.Text != "")
                {
                    if (featureByProductBLL.AddFeatureByProductBLL(featureByProductDTO) == true)
                    {
                        MessageBox.Show("Dán nhãn sản phẩm thành công.");
                        ShowFeatureByProduct();
                    }
                    else
                    {
                        MessageBox.Show("Dán nhãn sản phẩm không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSticker_Click(object sender, EventArgs e)
        {
            featureByProductDTO.ProductId = txtProductId.Text;
            featureDTO.FeatureName = FeatureNameChange;
            featureByProductDTO.FeatureIdChange = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
            featureDTO.FeatureName = cbFeatureName.Text;
            featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
            featureByProductDTO.FeatureValue = txtFeatureValue.Text;
            try
            {
                if (txtProductId.Text != "" && cbFeatureName.Text != "Tất cả" && txtFeatureValue.Text != "")
                {
                    if (featureByProductBLL.UpdateFeatureByProductBLL(featureByProductDTO) == true)
                    {
                        MessageBox.Show("Cập nhật nhãn dán thành công.");
                        ShowFeatureByProduct();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhãn dán không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSticker_Click(object sender, EventArgs e)
        {
            featureByProductDTO.ProductId = txtProductId.Text;
            featureDTO.FeatureName = cbFeatureName.Text;
            featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
            try
            {
                if (txtProductId.Text != "" && cbFeatureName.Text != "Tất cả" && txtFeatureValue.Text != "")
                {
                    if (featureByProductBLL.DeleteFeatureByProductBLL(featureByProductDTO) == true)
                    {
                        MessageBox.Show("Gỡ nhãn dán thành công.");
                        ShowFeatureByProduct();
                    }
                    else
                    {
                        MessageBox.Show("Gỡ nhãn dán không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public static string FeatureNameChange { get; set; }
        private void dgvShowDataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if(e.RowIndex != -1)
            {
                row = dgvShowDataProduct.Rows[e.RowIndex];
                txtProductId.Text = Convert.ToString(row.Cells["Mã sản phẩm"].Value);
                txtProductName.Text = Convert.ToString(row.Cells["Tên sản phẩm"].Value);
                txtProductQuantity.Text = Convert.ToString(row.Cells["Định lượng"].Value);
                txtProductUnit.Text = Convert.ToString(row.Cells["Đơn vị đo"].Value);
                txtImportPrice.Text = Convert.ToString(row.Cells["Giá nhập"].Value);
                txtExportPrice.Text = Convert.ToString(row.Cells["Giá xuất"].Value);
                txtProductDescription.Text = Convert.ToString(row.Cells["Mô tả"].Value);
                txtFeatureValue.Text = "";
                cbFeatureName.Text = "Tất cả";
                ShowFeatureByProduct();

            }
        }

        private void dgvShowStickers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvShowStickers.Rows[e.RowIndex];
                cbFeatureName.Text = Convert.ToString(row.Cells["Tên đặc tính"].Value);
                txtFeatureValue.Text = Convert.ToString(row.Cells["Giá trị tương đối"].Value);
                FeatureNameChange = cbFeatureName.Text;
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchProduct.Text != "" && txtSearchProduct.Text != "Tìm kiếm sản phẩm")
            {
                productDTO.SearchDataProduct = txtSearchProduct.Text;
                DataTable dt = productBLL.SearchDataProductBLL(productDTO);
                dgvShowDataProduct.DataSource = dt;
            }
            else
            {
                ShowDataProduct();
            }
        }
    }
}