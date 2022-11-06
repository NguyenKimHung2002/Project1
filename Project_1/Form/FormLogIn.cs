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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        StaffBLL staffBLL = new StaffBLL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            StaffDTO staffDTO = new StaffDTO();
            staffDTO.StaffAccount = txtAccount.Text;
            staffDTO.StaffPassword = txtPassword.Text;
            int code = staffBLL.CheckLoginBLL(staffDTO);
            if (code == 0)
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain formMain = new FormMain();
                this.Close();
                formMain.ShowDialog();
            }
            else if (code == 1)
            {
                MessageBox.Show("Chào mừng Manager đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (code == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAccount.Text = "";
                txtPassword.Text = "";
                txtAccount.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAccount.Text = "";
                txtPassword.Text = "";
                txtAccount.Focus();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
