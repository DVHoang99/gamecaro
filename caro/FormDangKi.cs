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
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

        public void TaoTaiKhoan()
        {
            GameCaroEntities data = new GameCaroEntities();
            
            DangKi a = new DangKi();
            
            a.UserName = txtUserName.Text ;
            a.Name = txtUserName.Text;
            a.PassWord = txtPassWord.Text;
            a.RepassWord = txtRePassWord.Text;
            USER b = new USER();
            int c = data.USERs.Where(m => m.UserName.Equals(a.UserName)).Count();
            if (c ==0 )
            {
                if (a.PassWord.Equals(a.RepassWord))
                {

                    b.UserName = a.UserName;
                    b.Name = a.Name;
                    b.PassWord = a.PassWord;
                    data.USERs.Add(b);
                    data.SaveChanges();
                    MessageBox.Show("Đăng kí thành công!!!");
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Và Nhập lại Mật Khẩu phải Trùng Nhau");
                }
            } 
            else
            {
                MessageBox.Show("Tên Tài Khoản Đã Được Đăng Kí!!!");
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan();
        }
    }
}
