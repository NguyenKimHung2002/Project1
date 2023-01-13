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
using System.Security;

namespace Project_1
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();           
        }
        private void FormLogIn_Shown(object sender, EventArgs e)
        {
            txtAccount.Focus();
            
        }
        StaffBLL staffBLL = new StaffBLL();
        public static string NameLogIn = "";
        public static int StaffNoLogIn = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginHandling();
        }
        private void LoginHandling()
        {
            Cursor = Cursors.AppStarting;
            StaffDTO staffDTO = new StaffDTO();
            staffDTO.StaffAccount = txtAccount.Text;
            staffDTO.StaffPassword = txtPassword.Text;
            int code = staffBLL.CheckLoginBLL(staffDTO);
            if(btnDangNhap.BackColor == Color.FromArgb(0, 122, 204))
            {
                if (code == 0)
                {
                    NameLogIn = staffBLL.GetStaffNameBLL(staffDTO);
                    StaffNoLogIn = staffBLL.GetStaffNoBLL(staffDTO);
                    //MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtAccount.Focus();
                }
                else if (code == 1)
                {
                    //MessageBox.Show("Chào mừng Manager đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Cursor = Cursors.Default;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (btnShowPass.ImageIndex == 0)
            {
                btnShowPass.ImageIndex = 1;
                txtPassword.PasswordChar = '\0';
                txtPassword.Focus();
            }
            else
            {
                btnShowPass.ImageIndex = 0;
                txtPassword.PasswordChar = '●';
                txtPassword.Focus();
            }
        }

        private void btnShowPass_MouseHover(object sender, EventArgs e)
        {
            if (btnShowPass.ImageIndex == 0)
                toolTip1.Show("Hiện mật khẩu", btnShowPass);
            else
                toolTip1.Show("Ẩn mật khẩu", btnShowPass);
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                btnDangNhap.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                btnDangNhap.BackColor = Color.DimGray;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                btnDangNhap.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                btnDangNhap.BackColor = Color.DimGray;
            }
        }

        private void txtAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtAccount.Text != "" && txtPassword.Text != "")
            {
                if(e.KeyCode == Keys.Enter)
                {
                    LoginHandling();
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtAccount.Text != "" && txtPassword.Text != "")
            {
                if(e.KeyCode == Keys.Enter)
                {
                    LoginHandling();
                }
            }
        }
    }
}
