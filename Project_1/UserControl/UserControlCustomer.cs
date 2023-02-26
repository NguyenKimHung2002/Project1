using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicLayer;
using System.Runtime.Remoting;

namespace Project_1
{
    public partial class UserControlCustomer : UserControl
    {
        CustomerBLL customerBLL = new CustomerBLL();
        CustomerDTO customerDTO = new CustomerDTO();
        CustomerDTO c1 = new CustomerDTO();

        public UserControlCustomer()
        {
            InitializeComponent();
        }
        private void UserControlForm_Load(object sender, EventArgs e)
        {
            ShowDataCustomer();
            txtSearchFollowCustomerName.Text = "Tìm kiếm theo tên";
            txtCustomerId.Text = "Mã khách hàng tạo bởi hệ thống";
        }

        private void txtFindFollowName_Enter(object sender, EventArgs e)
        {
            if (txtSearchFollowCustomerName.Text == "Tìm kiếm theo tên")
            {
                txtSearchFollowCustomerName.Text = "";
                txtSearchFollowCustomerName.ForeColor = Color.Black;
            }
        }

        private void txtFindFollowName_Leave(object sender, EventArgs e)
        {
            if (txtSearchFollowCustomerName.Text == "")
            {
                txtSearchFollowCustomerName.Text = "Tìm kiếm theo tên";
                txtSearchFollowCustomerName.ForeColor = Color.Gray;
            }
        }
        private void txtCustomerId_Enter(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "Mã khách hàng tạo bởi hệ thống")
            {
                txtCustomerId.Text = "";
                txtCustomerId.ForeColor = Color.Black;
            }
        }
        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "")
            {
                txtCustomerId.Text = "Mã khách hàng tạo bởi hệ thống";
                txtCustomerId.ForeColor = Color.Gray;
            }
        }
        private void ShowDataCustomer()
        {
            dgvShowDataCustomer.DataSource = customerBLL.GetDataCustomerBLL();
            dgvShowDataCustomer.Columns[0].Width = 108;
            dgvShowDataCustomer.Columns[1].Width = 112;
            dgvShowDataCustomer.Columns[2].Width = 115;
        }
        private void Reset()
        {
            txtCustomerId.Text = "Mã khách hàng tạo bởi hệ thống";
            txtCustomerId.ForeColor = Color.Gray;
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
        }
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            if (CheckInformationCustomer())
            {
                customerDTO.CustomerName = txtCustomerName.Text;
                customerDTO.CustomerPhone = txtCustomerPhone.Text;
                if (customerBLL.CheckExistsCustomerIdBLL(customerDTO) == 1)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại! Vui lòng chọn một mã khách hàng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerId.Focus();
                }
                else if (customerBLL.CheckExistsCustomerPhoneBLL(customerDTO) == 1)
                {
                    MessageBox.Show("Số điện thoại đã được đăng ký! Vui lòng đăng ký với một số điện thoại khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerPhone.Focus();
                }
                else
                {
                    try
                    {
                        if (customerBLL.AddCustomerBLL(customerDTO) == true)
                        {
                            MessageBox.Show("Thêm thành công.");
                            ShowDataCustomer();
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
            
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "Mã khách hàng tạo bởi hệ thống")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhật thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerId.Focus();
            }
            else if (CheckInformationCustomer())
            {
                customerDTO.CustomerName = txtCustomerName.Text;
                customerDTO.CustomerPhone = txtCustomerPhone.Text;
                if (customerDTO.CustomerId == c1.CustomerId && customerDTO.CustomerName == c1.CustomerName && customerDTO.CustomerPhone == c1.CustomerPhone)
                {
                    MessageBox.Show("Thông tin của bạn chưa được thay đổi bất cứ điều gì! Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerId.Focus();
                }
                else if (customerBLL.CheckExistsCustomerPhoneBLL(customerDTO) == 1 && customerDTO.CustomerPhone != c1.CustomerPhone)
                {
                    MessageBox.Show("Số điện thoại cập nhật đã được đăng ký bởi một khách hàng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerPhone.Focus();
                }
                else
                {
                    try
                    {
                        if (customerBLL.UpdateCustomerBLL(customerDTO))
                        {
                            MessageBox.Show("Cập nhật thành công.");
                            ShowDataCustomer();
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
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "Mã khách hàng tạo bởi hệ thống")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerId.Focus();
            }
            else
            {
                try
                {
                    var deleteCustomer = MessageBox.Show("Việc xóa thông tin khách hàng sẽ đi kèm với việc mất toàn bộ thông tin mua hàng của khách hàng này! " +
                        "Bạn có thực sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (deleteCustomer == DialogResult.Yes)
                    {
                        customerDTO.CustomerId = Int32.Parse(txtCustomerId.Text);
                        if (customerBLL.DeleteCustomerBLL(customerDTO))
                        {
                            MessageBox.Show("Xóa thành công.");
                            ShowDataCustomer();
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
        private bool CheckInformationCustomer()
        {
            //CustomerName
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtCustomerName.Focus();
                return false;
            }
            //CustomerPhone
            if (txtCustomerPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerPhone.Focus();
                return false;
            }
            else if (!IsValidPhoneNumber(txtCustomerPhone.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải có độ dài là 10 và tất cả các kí tự đều là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                return false;
            }
            return true;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra độ dài của số điện thoại
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            // Kiểm tra tất cả các ký tự đều là số
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Nếu vượt qua tất cả các kiểm tra trên, số điện thoại là hợp lệ
            return true;
        }

        private void txtSearchFollowCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFollowCustomerName.Text != "" && txtSearchFollowCustomerName.Text != "Tìm kiếm theo tên")
            {
                customerDTO.SearchFollowCustomerName = txtSearchFollowCustomerName.Text;
                DataTable dt = customerBLL.SearchDataCustomerBLL(customerDTO);
                dgvShowDataCustomer.DataSource = dt;
            }
            else
            {
                ShowDataCustomer();
            }
        }

        private void dgvShowDataCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvShowDataCustomer.Rows[e.RowIndex];
                txtCustomerId.Text = Convert.ToString(row.Cells["Mã khách hàng"].Value);
                txtCustomerName.Text = Convert.ToString(row.Cells["Tên khách hàng"].Value);
                txtCustomerPhone.Text = Convert.ToString(row.Cells["SĐT khách hàng"].Value);
                c1.CustomerName = txtCustomerName.Text;
                c1.CustomerPhone = txtCustomerPhone.Text;
            }
        }
    }   
}
