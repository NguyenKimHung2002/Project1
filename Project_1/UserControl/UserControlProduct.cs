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
        ProductDTO p1 = new ProductDTO();
        FeatureBLL featureBLL = new FeatureBLL();
        FeatureDTO featureDTO = new FeatureDTO();
        FeatureDTO f1 = new FeatureDTO();
        FeatureByProductBLL featureByProductBLL = new FeatureByProductBLL();
        FeatureByProductDTO featureByProductDTO = new FeatureByProductDTO();
        FeatureByProductDTO fBP1 = new FeatureByProductDTO();
        public UserControlProduct()
        {
            InitializeComponent();
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            Reset();
            ShowDataProduct();
            ShowFeatureByProduct();
        }
        private void ShowDataProduct()
        {
            dgvShowDataProduct.DataSource = productBLL.GetDataProductBLL();
            dgvShowDataProduct.Columns[6].Width = 300;
        }
        private void ShowFeatureByProduct()
        {
            cbFeatureName.Items.Clear();
            cbFeatureName.Text = "Tất cả";
            DataTable dt = featureBLL.GetFeatureNameBLL();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cell = dt.Rows[i][1];
                cbFeatureName.Items.Add(cell.ToString());
            }
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
            txtSearchProduct.Text = "Tìm kiếm (theo ID, tên sản phẩm)";
            txtSearchProduct.ForeColor = Color.Gray;
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
            if(txtSearchProduct.Text == "Tìm kiếm (theo ID, tên sản phẩm)")
            {
                txtSearchProduct.Text = "";
                txtSearchProduct.ForeColor = Color.Black;
            }
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if(txtSearchProduct.Text == "")
            {
                txtSearchProduct.Text = "Tìm kiếm (theo ID, tên sản phẩm)";
                txtSearchProduct.ForeColor = Color.Gray;
            }
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            if (CheckInformationProduct() == true)
            {
                productDTO.ProductId = txtProductId.Text;
                productDTO.ProductName = txtProductName.Text;
                productDTO.ProductUnit = txtProductUnit.Text;
                productDTO.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
                productDTO.ImportPrice = txtImportPrice.Text;
                productDTO.ExportPrice = txtExportPrice.Text;
                productDTO.ProductDescription = txtProductDescription.Text;
                if (productBLL.CheckExistProductIdBLL(productDTO) == 1)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại! Vui lòng chọn một mã sản phẩm khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductId.Focus();
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (CheckInformationProduct() == true)
            {
                productDTO.ProductId = txtProductId.Text;
                productDTO.ProductName = txtProductName.Text;
                productDTO.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
                productDTO.ProductUnit = txtProductUnit.Text;
                productDTO.ImportPrice = txtImportPrice.Text;
                productDTO.ExportPrice = txtExportPrice.Text;
                productDTO.ProductDescription = txtProductDescription.Text;
                if (productDTO.ProductId == p1.ProductId && productDTO.ProductName == p1.ProductName && productDTO.ProductQuantity == p1.ProductQuantity && productDTO.ProductUnit == p1.ProductUnit
                    && productDTO.ImportPrice == p1.ImportPrice && productDTO.ExportPrice == p1.ExportPrice && productDTO.ProductDescription == p1.ProductDescription)
                {
                    MessageBox.Show("Thông tin của bạn chưa được thay đổi bất cứ điều gì! Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductId.Focus();
                }
                else if (productBLL.CheckExistProductIdBLL(productDTO) == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm! Vui lòng kiểm tra lại mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductId.Focus();
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(CheckInformationProduct() == true)
            {
                productDTO.ProductId = txtProductId.Text;
                if (productBLL.CheckExistProductIdBLL(productDTO) == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm! Vui lòng kiểm tra lại mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductId.Focus();
                }
                else
                {
                    try
                    {
                        var deleteProduct = MessageBox.Show("Việc xóa sản phẩm này sẽ dẫn đến thông tin sản phẩm này trong tất các hóa đơn sẽ bị xóa bỏ. " +
                            "Tính toán hóa đơn trong quá khứ sẽ không còn chính xác nữa. Hãy chắc chắn rằng những hóa đơn liên quan đã được sao lưu. " +
                            "Bạn có chắc chắn muốn xóa sản phẩm này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (deleteProduct == DialogResult.Yes)
                        {
                            if (productBLL.DeleteProductBLL(productDTO))
                            {
                                MessageBox.Show("Xóa thành công.");
                                txtProductId.Text = "Nhập mã sản phẩm";
                                txtProductId.ForeColor = Color.Gray;
                                txtProductName.Text = "";
                                txtImportPrice.Text = "";
                                txtExportPrice.Text = "";
                                txtProductQuantity.Text = "";
                                txtProductUnit.Text = "";
                                txtProductDescription.Text = "";
                                ShowDataProduct();
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }            }
        }
        private bool CheckInformationProduct()
        {
            //ProductId
            if (txtProductId.Text == "" || txtProductId.Text == "Nhập mã sản phẩm")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return false;
            }
            //ProductName
            if(txtProductName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductName.Focus();
                return false;
            }
            //ProductQuantity
            if(txtProductQuantity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập định lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductQuantity.Focus();
                return false;
            }
            else if (!Int32.TryParse(txtProductQuantity.Text, out int productQuantity)){
                MessageBox.Show("Định lượng sản phẩm phải là một số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductQuantity.Focus();
                return false;
            }
            //ProductUnit
            if (txtProductUnit.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị định lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductUnit.Focus();
                return false;
            }
            //ImportPrice
            if (txtImportPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtImportPrice.Focus();
                return false;
            }
            else if (!Int32.TryParse(txtImportPrice.Text, out int imp)){
                MessageBox.Show("Giá sản phẩm nhập vào phải là một số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImportPrice.Focus();
                return false;
            }
            //ExportPrice
            if (txtExportPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá bán sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExportPrice.Focus();
                return false;
            }
            else if (!Int32.TryParse(txtExportPrice.Text, out int exp))
            {
                MessageBox.Show("Giá bán sản phẩm phải là một số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExportPrice.Focus();
                return false;
            }
            return true;
        }
        private void btnAddSticker_Click(object sender, EventArgs e)
        {
            if (CheckInformationFeatureByProduct())
            {
                featureByProductDTO.ProductId = txtProductId.Text;
                featureDTO.FeatureName = cbFeatureName.Text;
                featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
                featureByProductDTO.FeatureValue = txtFeatureValue.Text;
                if (featureByProductBLL.CheckExistsFeatureByProductBLL(featureByProductDTO, featureDTO) == 1)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại đặ c tính này! Vui lòng chỉnh sửa thông tin đặc tính này hoặc thêm mới đặc tính khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateSticker_Click(object sender, EventArgs e)
        {
            if (CheckInformationFeatureByProduct())
            {
                featureByProductDTO.ProductId = txtProductId.Text;
                featureDTO.FeatureName = cbFeatureName.Text;
                featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
                featureByProductDTO.FeatureValue = txtFeatureValue.Text;
                if (featureByProductDTO.ProductId == fBP1.ProductId && featureDTO.FeatureName == f1.FeatureName && featureByProductDTO.FeatureValue == fBP1.FeatureValue)
                {
                    MessageBox.Show("Thông tin Nhãn dãn chưa được thay đổi bất cứ điều gì! Chỉnh sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeatureValue.Focus();
                }
                else if (featureByProductBLL.CheckExistsFeatureByProductBLL(featureByProductDTO, featureDTO) == 0)
                {
                    MessageBox.Show("Sản phẩm không tồn tại đặc tính này! Vui lòng kiểm tra lại đặc tính của sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnDeleteSticker_Click(object sender, EventArgs e)
        {
            if (CheckInformationFeatureByProduct())
            {
                featureByProductDTO.ProductId = txtProductId.Text;
                featureDTO.FeatureName = cbFeatureName.Text;
                featureByProductDTO.FeatureId = featureBLL.GetFeatureIdByFeatureNameBLL(featureDTO);
                if (featureByProductBLL.CheckExistsFeatureByProductBLL(featureByProductDTO, featureDTO) == 0)
                {
                    MessageBox.Show("Sản phẩm không tồn tại đặc tính này! Vui lòng kiểm tra lại đặc tính của sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private bool CheckInformationFeatureByProduct()
        {
            //ProductId
            if (txtProductId.Text == "" || txtProductId.Text == "Nhập mã sản phẩm")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return false;
            }
            //cbFeatureName
            if (cbFeatureName.Text == "Tất cả")
            {
                MessageBox.Show("Vui lòng chọn tên đặc tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
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
                p1.ProductId = txtProductId.Text;
                p1.ProductName = txtProductName.Text;
                p1.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
                p1.ProductUnit = txtProductUnit.Text;
                p1.ImportPrice = txtImportPrice.Text;
                p1.ExportPrice = txtExportPrice.Text;
                p1.ProductDescription = txtProductDescription.Text;
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
                f1.FeatureName = cbFeatureName.Text;
                fBP1.ProductId = txtProductId.Text;
                fBP1.FeatureValue = txtFeatureValue.Text;
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