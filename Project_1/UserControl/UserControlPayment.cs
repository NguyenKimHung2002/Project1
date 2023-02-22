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
    public partial class UserControlPayment : UserControl
    {
        StaffBLL staffBLL = new StaffBLL();
        CustomerBLL customerBLL = new CustomerBLL();
        CustomerDTO customerDTO = new CustomerDTO();
        ProductBLL productBLL = new ProductBLL();
        ProductDTO productDTO = new ProductDTO();
        CategoryBLL categoryBLL = new CategoryBLL();
        FeatureBLL featureBLL = new FeatureBLL();
        FeatureDTO featureDTO = new FeatureDTO();
        InvoiceBLL invoiceBLL = new InvoiceBLL();
        InvoiceDetailBLL invoiceDetailBLL = new InvoiceDetailBLL();
        private int pageSize = 10;
        private int pageIndex;
        private int totalRecords;
        private int totalPages;
        public decimal totalMoney;
        private bool isSearched;
        public UserControlPayment()
        {
            InitializeComponent();           
        }
        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            Reset();
            txtCustomerPhone.Text = "Nhập vào số điện thoại";
        }
        private void ShowDataPayment()
        {
            lblPageNumber.Text = pageIndex + "/" + totalPages;
            productDTO.PageSize = pageSize;
            productDTO.PageIndex = pageIndex;
            if(isSearched)
            {
                productDTO.SearchDataPayment = txtSearchDataPayment.Text;
                dgvShowDataPayment.DataSource = productBLL.SearchDataPaymentBLL(productDTO);
            }
            else
            {
                if (picSuccess.Visible)
                {

                    customerDTO.CustomerPhone = txtCustomerPhone.Text;
                    dgvShowDataPayment.DataSource = productBLL.GetSortedDataPaymentBLL(productDTO, customerDTO);
                }
                else
                {
                    dgvShowDataPayment.DataSource = productBLL.GetDataPaymentBLL(productDTO);
                }
            }
            dgvShowDataPayment.Columns[0].Width = 60;
            dgvShowDataPayment.Columns[3].Width = 80;
            dgvShowDataPayment.Columns[4].Width = 84;
            dgvShowDataPayment.Columns[5].Width = 80;
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            if(pageIndex > 1)
            {
                pageIndex--;
                ShowDataPayment();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(pageIndex < totalPages)
            {
                pageIndex++;
                ShowDataPayment();
            }
        }
        private void txtCustommerPhone_Enter(object sender, EventArgs e)
        {
            if(txtCustomerPhone.Text == "Nhập vào số điện thoại")
            {
                txtCustomerPhone.Text = "";
                txtCustomerPhone.ForeColor = Color.Black;
            }
        }

        private void txtCustommerPhone_Leave(object sender, EventArgs e)
        {
            if(txtCustomerPhone.Text == "")
            {
                txtCustomerPhone.Text = "Nhập vào số điện thoại";
                txtCustomerPhone.ForeColor = Color.Gray;
            }
        }
        private void txtSearchDataPayment_Enter(object sender, EventArgs e)
        {
            if (txtSearchDataPayment.Text == "Tìm kiếm (theo ID, tên SP)")
            {
                txtSearchDataPayment.Text = "";
                txtSearchDataPayment.ForeColor = Color.Black;
            }
        }

        private void txtSearchDataPayment_Leave(object sender, EventArgs e)
        {

            if (txtSearchDataPayment.Text == "")
            {
                txtSearchDataPayment.Text = "Tìm kiếm (theo ID, tên SP)";
                txtSearchDataPayment.ForeColor = Color.Gray;
            }
        }
        private void txtProductNumber_Enter(object sender, EventArgs e)
        {
            if(txtProductNumber.Text == "Số lượng")
            {
                txtProductNumber.Text = "";
                txtProductNumber.ForeColor = Color.Black;
            }
        }

        private void txtProductNumber_Leave(object sender, EventArgs e)
        {
            if(txtProductNumber.Text == "")
            {
                txtProductNumber.Text = "Số lượng";
                txtProductNumber.ForeColor = Color.Gray;
            }
        }
        private void txtMonneyCustommerPay_Enter(object sender, EventArgs e)
        {
            if(txtMonneyCustommerPay.Text == "Nhập và nhấn Enter")
            {
                txtMonneyCustommerPay.Text = "";
                txtMonneyCustommerPay.ForeColor = Color.Black;
            }
        }

        private void txtMonneyCustommerPay_Leave(object sender, EventArgs e)
        {
            if(txtMonneyCustommerPay.Text == "")
            {
                txtMonneyCustommerPay.Text = "Nhập và nhấn Enter";
                txtMonneyCustommerPay.ForeColor = Color.Gray;
            }
        }
        private void txtCustommerPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text != "" || txtCustomerPhone.Text != "Nhập vào số điện thoại")
            {
                customerDTO.CustomerPhone = txtCustomerPhone.Text;
                DataTable dt = customerBLL.GetCustomerName(customerDTO);
                if(dt.Rows.Count != 1)
                {
                    picSuccess.Visible =false;
                    txtCustomerName.Text = "";
                }
                else
                {
                    picSuccess.Visible = true;
                    txtCustomerName.Text = dt.Rows[0][0].ToString();
                    ShowDataPayment();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvShowDataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvShowDataPayment.Rows[e.RowIndex];
                txtProductNumber.Text = "1";
                lblProductId.Text = Convert.ToString(row.Cells["Mã sản phẩm"].Value);
            }
        }

        private void Reset()
        {
            pageIndex = 1;
            totalRecords = productBLL.GetTotalDataProductBLL();
            totalPages = totalRecords / pageSize + 1;
            ShowDataPayment();
            txtSearchDataPayment.Text = "Tìm kiếm (theo ID, tên SP)";
            txtProductNumber.Text = "Số lượng";
            txtMonneyCustommerPay.Text = "Nhập và nhấn Enter";

            var dt = productBLL.RecommendTrendingProductsBLL();
            dgvSuggestions.DataSource = dt;
            dgvSuggestions.Columns[0].Width = 60;
            dgvSuggestions.Columns[3].Width = 80;
            dgvSuggestions.Columns[4].Width = 84;
            dgvSuggestions.Columns[5].Width = 80;
            dgvSuggestions.Columns[6].Width = 120;

            txtSearchDataPayment.ForeColor = Color.Gray;
            btnPayment.BackColor = Color.Gray;
            btnCancel.BackColor = Color.Gray;
        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.ProductId = lblProductId.Text;
            DataTable dt = productBLL.AddInvoiceDetailBLL(productDTO);
            if (!Int32.TryParse(txtProductNumber.Text, out int id))
            {
                MessageBox.Show("Số lượng sản phẩm phải là một số nguyên dương! Vui lòng kiểm tra lại số lượng sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductNumber.Focus();
            }
            else if (Int32.TryParse(txtProductNumber.Text, out int productNumber) && productNumber <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm phải là một số nguyên dương! Vui lòng kiểm tra lại số lượng sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductNumber.Focus();
            }
            else
            {
                try
                {
                    if (txtProductNumber.Text != "Số lượng")
                    {
                        int intoMoney = Convert.ToInt32(dt.Rows[0].ItemArray[1]) * Convert.ToInt32(txtProductNumber.Text);
                        DataGridViewRow r = checkExistInvoice(productDTO.ProductId);
                        if (r != null)
                        {
                            var unitPrice = Convert.ToInt32(r.Cells[2].Value);
                            var number = Convert.ToInt32(r.Cells[4].Value);
                            number = number + Convert.ToInt32(txtProductNumber.Text);
                            r.Cells[4].Value = number;
                            r.Cells[5].Value = number * unitPrice;
                            dgvInvoiceDetail.Refresh();
                        }
                        else dgvInvoiceDetail.Rows.Insert(dgvInvoiceDetail.Rows.Count, productDTO.ProductId, dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[1], "", txtProductNumber.Text, intoMoney.ToString(), " + ", " - ", " x ");
                    }
                    else
                    {
                        dgvInvoiceDetail.Rows.Insert(dgvInvoiceDetail.Rows.Count, productDTO.ProductId, dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[1], "", "1", dt.Rows[0].ItemArray[1], " + ", " - ", " x ");
                    }
                    LoadSumInvoice();
                    if (dgvInvoiceDetail.Rows.Count >= 2)
                    {
                        dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count - 2].Selected = false;
                        dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count - 1].Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }      
        }
        private DataGridViewRow checkExistInvoice(string productID)
        {
            foreach(DataGridViewRow row in dgvInvoiceDetail.Rows)
            {
                if (row.Cells[0].Value.ToString() == productID)
                {
                    return row;
                }
            }
            return null;
        }
        private void LoadSumInvoice()
        {
            decimal sum = 0;
            for (int i = 0; i<dgvInvoiceDetail.Rows.Count; i++)
            {
                sum += decimal.Parse(dgvInvoiceDetail.Rows[i].Cells[5].Value.ToString());
            }
            lblSumMoney.Text = sum.ToString() + " đ";
            btnCancel.BackColor = Color.OrangeRed;
        }

        private void txtMonneyCustommerPay_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMonneyCustommerPay.Text == "")
            {
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                totalMoney = Convert.ToInt32(lblSumMoney.Text.Substring(0, lblSumMoney.Text.Length-2));
                if (totalMoney <= decimal.Parse(txtMonneyCustommerPay.Text))
                {
                    txtExcessMoneyReturned.Text = Convert.ToDecimal((Math.Abs(totalMoney - decimal.Parse(txtMonneyCustommerPay.Text)))) + "";
                    btnPayment.BackColor = Color.Green;
                }
                else
                {
                    txtExcessMoneyReturned.Text = "Không đủ";
                    btnPayment.BackColor = Color.Gray;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(btnCancel.BackColor == Color.OrangeRed)
            {
                dgvInvoiceDetail.Rows.Clear();
                lblSumMoney.Text = "0";
                txtExcessMoneyReturned.Text = "";
                Reset();
                lblProductId.Text = "Sản phẩm";
                txtCustomerPhone.Text = "Nhập vào số điện thoại";
                txtCustomerPhone.ForeColor = Color.Gray;
                txtProductNumber.ForeColor = Color.Gray;
                txtMonneyCustommerPay.ForeColor = Color.Gray;
            }            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.CustomerPhone = txtCustomerPhone.Text;
            if(picSuccess.Visible == false)
            {
                MessageBox.Show("Vui lòng chọn khách hàng thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnPayment.BackColor == Color.Green)
            {
                InvoiceDTO invoiceDTO = new InvoiceDTO();
                invoiceDTO.InvoiceDateTime = DateTime.Now;
                invoiceDTO.CustomerId = customerBLL.GetCustomerIdBLL(customerDTO);
                invoiceDTO.StaffId = FormLogIn.StaffNoLogIn;
                invoiceDTO.PaymentMethod = "Tiền mặt";
               
                if (invoiceBLL.CreateInvoiceBLL(invoiceDTO))
                {
                    for (int i = 0; i<dgvInvoiceDetail.Rows.Count; i++)
                    {
                        StaffDTO staffDTO = new StaffDTO();
                        InvoiceDetailDTO invoiceDetailDTO = new InvoiceDetailDTO();
                        invoiceDetailDTO.InvoiceId = invoiceBLL.GetInvoiceNoBLL(invoiceDTO);
                        invoiceDetailDTO.ProductId = dgvInvoiceDetail.Rows[i].Cells[0].Value.ToString();
                        invoiceDetailDTO.UnitPrice = Convert.ToInt32(dgvInvoiceDetail.Rows[i].Cells[2].Value.ToString());
                        invoiceDetailDTO.QuantityNo = Convert.ToInt32(dgvInvoiceDetail.Rows[i].Cells[4].Value.ToString());
                        if (invoiceDetailBLL.CreateInvoiceDetailBLL(invoiceDetailDTO) == false)
                        {
                            MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvInvoiceDetail.Rows.Clear();
                    lblSumMoney.Text = "0";
                    txtExcessMoneyReturned.Text = "";
                    Reset();
                    txtCustomerPhone.Text = "Nhập vào số điện thoại";
                    txtCustomerPhone.ForeColor = Color.Gray;
                    txtProductNumber.ForeColor = Color.Gray;
                    txtMonneyCustommerPay.ForeColor = Color.Gray;
                }
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtProductNumber.Text, out int productNumber))
            {
                productNumber++;
                txtProductNumber.Text = productNumber.ToString();
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductNumber.Text, out int productNumber))
            {
                if(productNumber > 1)
                {
                    productNumber--;
                    txtProductNumber.Text = productNumber.ToString();
                }
            }
        }

        private void dgvInvoiceDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvInvoiceDetail.CurrentCell;
            if(cell.Value.ToString() == " + ")
            {
                DataGridViewRow row = cell.OwningRow;
                var unitPrice = Convert.ToInt32(row.Cells[2].Value);
                var number = Convert.ToInt32(row.Cells[4].Value);
                number++;
                row.Cells[4].Value = number;
                row.Cells[5].Value = number * unitPrice;
                dgvInvoiceDetail.Refresh();
            }
            else if(cell.Value.ToString() == " - ")
            {
                DataGridViewRow row = cell.OwningRow;
                var unitPrice = Convert.ToInt32(row.Cells[2].Value);
                var number = Convert.ToInt32(row.Cells[4].Value);
                number--;
                if(number > 0)
                {
                    row.Cells[4].Value = number;
                    row.Cells[5].Value = number * unitPrice;
                }
                else
                {
                    dgvInvoiceDetail.Rows.Remove(row);
                }
                dgvInvoiceDetail.Refresh();
            }
            else if (cell.Value.ToString() == " x ")
            {
                DataGridViewRow row = cell.OwningRow;
                dgvInvoiceDetail.Rows.Remove(row);
                dgvInvoiceDetail.Refresh();
            }
            else if(e.RowIndex != -1)
            {
                DataGridViewRow row = cell.OwningRow;
                productDTO.ProductId = row.Cells[0].Value.ToString();
                var dt = productBLL.GetSuggestionsBLL(productDTO);
                dgvSuggestions.DataSource = dt;
                dgvSuggestions.Columns[0].Width = 60;
                dgvSuggestions.Columns[3].Width = 80;
                dgvSuggestions.Columns[4].Width = 84;
                dgvSuggestions.Columns[5].Width = 80;
            }
            LoadSumInvoice();
        }

        private void txtSearchDataPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchDataPayment.Text != "" && txtSearchDataPayment.Text != "Tìm kiếm (theo ID, tên SP)")
            {
                ProductDTO productDTO = new ProductDTO();
                productDTO.PageIndex = pageIndex;
                productDTO.PageSize = pageSize;
                productDTO.SearchDataPayment = txtSearchDataPayment.Text;
                isSearched = true;
                pageIndex = 1;
                totalRecords = productBLL.GetTotalSearchProductBLL(productDTO);
                totalPages = totalRecords / pageSize + 1;
                //dgvShowDataPayment.DataSource = productBLL.SearchDataPaymentBLL(productDTO);
                ShowDataPayment();
            }
            else
            {
                isSearched = false;
                pageIndex = 1;
                totalRecords = productBLL.GetTotalDataProductBLL();
                totalPages = totalRecords / pageSize + 1;
                ShowDataPayment();
            }
        }

        private void dgvSuggestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvSuggestions.Rows[e.RowIndex];
                txtProductNumber.Text = "1";
                lblProductId.Text = Convert.ToString(row.Cells["Mã sản phẩm"].Value);
            }
        }
    }
}
