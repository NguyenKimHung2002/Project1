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

        public UserControlCustomer()
        {
            InitializeComponent();
        }
        private void UserControlForm_Load(object sender, EventArgs e)
        {
            ShowDataCustomer();
            txtSearchFollowCustomerName.Text = "Tìm kiếm theo tên";
            txtCustomerId.Text = "Thêm mới không cần nhập";
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
            if (txtCustomerId.Text == "Thêm mới không cần nhập")
            {
                txtCustomerId.Text = "";
                txtCustomerId.ForeColor = Color.Black;
            }
        }
        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "")
            {
                txtCustomerId.Text = "Thêm mới không cần nhập";
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
            txtCustomerId.Text = "Thêm mới không cần nhập";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
        }
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            customerDTO.CustomerName = txtCustomerName.Text;
            customerDTO.CustomerPhone = txtCustomerPhone.Text;
            try
            {
                if (customerDTO.CustomerName != "" && customerDTO.CustomerPhone != "")
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
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            customerDTO.CustomerName = txtCustomerName.Text;
            customerDTO.CustomerPhone = txtCustomerPhone.Text;
            customerDTO.CustomerId = Int32.Parse(txtCustomerId.Text);
            try
            {
                if (txtCustomerName.Text != "" && txtCustomerPhone.Text != "" && txtCustomerId.Text != "")
                {
                    if (customerBLL.UpdateCustomerBLL(customerDTO))
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        ShowDataCustomer();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            customerDTO.CustomerId = Int32.Parse(txtCustomerId.Text);
            try
            {
                if (txtCustomerId.Text != "" && txtCustomerName.Text != "" && txtCustomerPhone.Text != "")
                {
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
            }
        }
    }   
}
