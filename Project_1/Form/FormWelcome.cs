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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
