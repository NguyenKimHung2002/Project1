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

namespace Project_1
{
    public partial class UserControlForm : UserControl
    {
        CustommerBLL custommerBLL = new CustommerBLL();
        public void ShowDataCustommer()
        {
            dgvShowDataCustommer.DataSource = custommerBLL.GetDataBLL();
        }
        public UserControlForm()
        {
            InitializeComponent();
            ShowDataCustommer();
        }
        public void Reset()
        {
            txtCustommerName.Text = "";
            txtCustommerPhone.Text = "";
        }
        private void btnAddNewCustommer_Click(object sender, EventArgs e)
        {
            CustommerDTO custommerDTO = new CustommerDTO();
            custommerDTO.CustommerName = txtCustommerName.Text;
            custommerDTO.CustommerPhone = txtCustommerPhone.Text;
            if (custommerDTO.CustommerName != "" && custommerDTO.CustommerPhone != "")
            {
                if(custommerBLL.AddCustommerBLL(custommerDTO) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    ShowDataCustommer();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ.");
            }
        }
    }
}
