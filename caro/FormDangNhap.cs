using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        public void DangNhap()
        {
            GameCaroEntities data = new GameCaroEntities();
            DangNhap b = new DangNhap();
            b.UserName = txtUserName.Text;
            b.PassWord = txtPassWord.Text;
            int k= data.USERs.Where(m => m.UserName.Equals(b.UserName) && m.PassWord.Equals(b.PassWord)).Count();
            if(k == 1)
            {
                FormIndex frm = new FormIndex();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu!!!");
            }

        }
        private void btnSUp_Click(object sender, EventArgs e)
        {
            FormDangKi frm = new FormDangKi();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
    }
}
