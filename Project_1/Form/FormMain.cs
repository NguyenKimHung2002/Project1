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
    public partial class FormMain : Form
    {
        //StaffBLL staffBLL = new StaffBLL();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //StaffDTO staffDTO = new StaffDTO();
            //FormLogIn formLogIn = new FormLogIn();
            lblPer.Text = "Admin";
            lblName.Text = FormLogIn.NameLogIn;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void moveSidePanel(Control control)
        {
            panelSide.Top = control.Top;
            panelSide.Height = control.Height;
        }
        private void btnCustommer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnCustommer);
            UserControlCustommer userControlForm = new UserControlCustommer();
            userControlForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlForm);
            Cursor = Cursors.Default;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnPayment);
            UserControlPayment userControlPayment = new UserControlPayment();
            userControlPayment.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlPayment);
            Cursor = Cursors.Default;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblTimeCur.Text = String.Format("{0:hh:mm:ss tt dd/MM/yyyy}", dt);
        }
    }
}
