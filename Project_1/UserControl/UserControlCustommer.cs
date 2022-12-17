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
    public partial class UserControlCustommer : UserControl
    {
        CustommerBLL custommerBLL = new CustommerBLL();
        
        public UserControlCustommer()
        {
            InitializeComponent();          
        }
        private void UserControlForm_Load(object sender, EventArgs e)
        {
            ShowDataCustommer();
            txtFindFollowName.Text = "Tìm kiếm theo tên";
            txtCustommerNo.Text = "Thêm mới không cần nhập";
        }
        public void ShowDataCustommer()
        {
            dgvShowDataCustommer.DataSource = custommerBLL.GetDataBLL();
        }
        public void Reset()
        {
            txtCustommerNo.Text = "Thêm mới không cần nhập";
            txtCustommerName.Text = "";
            txtCustommerPhone.Text = "";
        }

        private void txtFindFollowName_Enter(object sender, EventArgs e)
        {
            if(txtFindFollowName.Text == "Tìm kiếm theo tên")
            {
                txtFindFollowName.Text = "";
                txtFindFollowName.ForeColor = Color.Black;
            }
        }

        private void txtFindFollowName_Leave(object sender, EventArgs e)
        {
            if (txtFindFollowName.Text == "")
            {
                txtFindFollowName.Text = "Tìm kiếm theo tên";
                txtFindFollowName.ForeColor = Color.LightGray;
            }
        }

        private void txtCustommerNo_Enter(object sender, EventArgs e)
        {
            if (txtCustommerNo.Text == "Thêm mới không cần nhập")
            {
                txtCustommerNo.Text = "";
                txtCustommerNo.ForeColor = Color.Black;
            }
        }

        private void txtCustommerNo_Leave(object sender, EventArgs e)
        {
            if (txtCustommerNo.Text == "")
            {
                txtCustommerNo.Text = "Thêm mới không cần nhập";
                txtCustommerNo.ForeColor = Color.LightGray;
            }
        }
        private void dgvShowDataCustommer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                row = dgvShowDataCustommer.Rows[e.RowIndex];
                txtCustommerNo.Text = Convert.ToString(row.Cells["CustommerNo"].Value);
                txtCustommerName.Text = Convert.ToString(row.Cells["CustommerName"].Value);
                txtCustommerPhone.Text = Convert.ToString(row.Cells["CustommerPhone"].Value);
            }
        }

        private void btnCreateNewCustommer_Click(object sender, EventArgs e)
        {
            CustommerDTO custommerDTO = new CustommerDTO();
            custommerDTO.CustommerName = txtCustommerName.Text;
            custommerDTO.CustommerPhone = txtCustommerPhone.Text;
            if (custommerDTO.CustommerName != "" && custommerDTO.CustommerPhone != "")
            {
                if (custommerBLL.AddCustommerBLL(custommerDTO) == true)
                {
                    MessageBox.Show("Thêm thành công.");
                    ShowDataCustommer();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustommerDTO custommerDTO = new CustommerDTO();
            custommerDTO.CustommerName = txtCustommerName.Text;
            custommerDTO.CustommerPhone = txtCustommerPhone.Text;
            custommerDTO.CustommerNo = Int32.Parse(txtCustommerNo.Text);
            if (txtCustommerName.Text != "" && txtCustommerPhone.Text != "" && txtCustommerNo.Text != "")
            {
                if (custommerBLL.UpdateCustommerBLL(custommerDTO))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    ShowDataCustommer();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustommerDTO custommerDTO = new CustommerDTO();
            custommerDTO.CustommerNo = Int32.Parse(txtCustommerNo.Text);
            if(txtCustommerNo.Text != "" && txtCustommerName.Text != "" && txtCustommerPhone.Text != "")
            {
                if (custommerBLL.DeleteCustommerBLL(custommerDTO))
                {
                    MessageBox.Show("Xóa thành công.");
                    ShowDataCustommer();
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

        private void txtFindFollowName_TextChanged(object sender, EventArgs e)
        {
            if(txtFindFollowName.Text != "" && txtFindFollowName.Text != "Tìm kiếm theo tên")
            {
                string rowFilter = string.Format("{0} like '{1}'", "CustommerName", "*" + txtFindFollowName.Text + "*");
                (dgvShowDataCustommer.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else
            {
                ShowDataCustommer();
            }
        }       
    }
}
