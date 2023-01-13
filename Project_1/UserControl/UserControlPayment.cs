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
        ProductBLL productBLL = new ProductBLL();
        CategoryBLL categoryBLL = new CategoryBLL();
        FeatureBLL featureBLL = new FeatureBLL();
        InvoiceBLL invoiceBLL = new InvoiceBLL();
        InvoiceDetailBLL invoiceDetailBLL = new InvoiceDetailBLL();
        public decimal totalMoney;
        public UserControlPayment()
        {
            InitializeComponent();           
        }
        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void LoadCategoryName()
        {
            DataTable dt = categoryBLL.GetCategoryNameBLL();
            DataRow dr = dt.NewRow();
            dr["Tên Loại SP"] = "Tất cả";
            dt.Rows.Add(dr);
            cbCategoryName.DataSource = dt;
            cbCategoryName.DisplayMember = "Tên Loại SP";
            cbCategoryName.SelectedIndex = cbCategoryName.Items.Count - 1;
        }
        private void LoadFeatureName()
        {
            DataTable dt = featureBLL.GetFeatureNameBLL();
            DataRow dr = dt.NewRow();
            dr["Mã đặc tính"] = "-1";
            dr["Đặc tính"] = "Tất cả";
            dt.Rows.Add(dr);
            cbFeatureName.DataSource = dt;
            cbFeatureName.DisplayMember = "Đặc tính nổi bật";
            cbFeatureName.ValueMember = "Đặc tính";
            cbFeatureName.SelectedIndex = cbFeatureName.Items.Count - 1;
        }
        private void ShowDataPayment()
        {
            dgvShowDataPayment.DataSource = productBLL.GetDataPaymentBLL();
        }
        private void PhoneText_Enter(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text == "Nhập vào số điện thoại")
            {
                txtCustomerPhone.Text = "";
                txtCustomerPhone.ForeColor = Color.Black;
            }
        }

        private void PhoneText_Leave(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text == "")
            {
                txtCustomerPhone.Text = "Nhập vào số điện thoại";
                txtCustomerPhone.ForeColor = Color.LightGray;
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
                txtCustomerPhone.ForeColor = Color.LightGray;
            }
        }
        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Tên sản phẩm")
            {
                txtProductName.Text = "";
                txtProductName.ForeColor = Color.Black;
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if(txtProductName.Text == "")
            {
                txtProductName.Text = "Tên sản phẩm";
                txtProductName.ForeColor = Color.LightGray;
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
            CustomerDTO customerDTO = new CustomerDTO();
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
                txtProductName.Text = Convert.ToString(row.Cells["Tên sản phẩm"].Value);
                txtProductNumber.Text = "1";
                //cbFeatureName.Text = Convert.ToString(row.Cells["FeatureName"].Value);
                lblProductNo.Text = Convert.ToString(row.Cells["Mã sản phẩm"].Value);
                txtProductName.ForeColor = Color.Black;
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            Reset();
            txtCustomerPhone.ForeColor = Color.LightGray;
            txtProductName.ForeColor = Color.LightGray;
            txtProductNumber.ForeColor = Color.Gray;
            txtMonneyCustommerPay.ForeColor = Color.Gray;
        }
        private void Reset()
        {
            LoadCategoryName();
            LoadFeatureName();
            ShowDataPayment();
            txtCustomerPhone.Text = "Nhập vào số điện thoại";
            txtProductName.Text = "Tên sản phẩm";
            txtProductNumber.Text = "Số lượng";
            txtMonneyCustommerPay.Text = "Nhập và nhấn Enter";
            btnPayment.BackColor = Color.Gray;
            btnCancel.BackColor = Color.Gray;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtProductName.Text != "Tên sản phẩm")
            {
                ProductDTO productDTO = new ProductDTO();
                productDTO.SearchDataPayment = txtProductName.Text;
                dgvShowDataPayment.DataSource = productBLL.SearchDataPaymentBLL(productDTO);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.ProductId = lblProductNo.Text;
            DataTable dt = productBLL.AddInvoiceDetailBLL(productDTO);
            try
            {
                if (txtProductNumber.Text != "1" && txtProductNumber.Text != "Số lượng")
                {
                    int intoMoney = Convert.ToInt32(dt.Rows[0].ItemArray[1]) * Convert.ToInt32(txtProductNumber.Text);
                    dgvInvoiceDetail.Rows.Insert(dgvInvoiceDetail.Rows.Count, productDTO.ProductId, dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[1], "", txtProductNumber.Text, intoMoney.ToString(), "-", "+");
                }
                else
                {
                    dgvInvoiceDetail.Rows.Insert(dgvInvoiceDetail.Rows.Count, productDTO.ProductId, dt.Rows[0].ItemArray[0], dt.Rows[0].ItemArray[1], "", "1", dt.Rows[0].ItemArray[1], "-", "+");
                }        
                LoadSumInvoice();
                sum = 0;
                if (dgvInvoiceDetail.Rows.Count >= 2)
                {
                    dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count-2].Selected = false;
                    dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count-1].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Vui lòng chọn sản phẩm muốn thêm vào hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        private decimal sum = 0;
        private void LoadSumInvoice()
        {
            for(int i=0; i<dgvInvoiceDetail.Rows.Count; i++)
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
                if (totalMoney < decimal.Parse(txtMonneyCustommerPay.Text))
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
                sum = 0;
                txtCustomerPhone.ForeColor = Color.LightGray;
                txtProductName.ForeColor = Color.LightGray;
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
                }
            }
        }

    }
}
