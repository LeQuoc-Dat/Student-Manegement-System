using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
namespace Student_Manegement_System
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        public bool AllowLogin()
        {
            if (txt_Tendangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return false;
            }
            if (txt_Matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return false;
            }
            return true;

        }
        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            SMSDataContext db = new SMSDataContext();
            Table<TaiKhoan> taikhoan = db.GetTable<TaiKhoan>();
            var tdn = (from tendangnhap in taikhoan where (txt_Tendangnhap.Text.Equals(tendangnhap.Tendangnhap)) select tendangnhap.Tendangnhap);
            var mk = (from matkhau in taikhoan where (txt_Matkhau.Text.Equals(matkhau.matkhau)) select matkhau.matkhau).FirstOrDefault();
            if (!AllowLogin())
                return;
            if (null != tdn)
            {
               if (null != mk)
                {
                    var lnd = (from loainguoidung in taikhoan where(txt_Tendangnhap.Text.Equals(loainguoidung.Tendangnhap)) select loainguoidung.LoaiNguoiDung).FirstOrDefault();
                    string st_lnd = Convert.ToString(lnd);
                    if (st_lnd == "Admin")
                    {
                        frm_Admin fr_admin = new frm_Admin();
                        this.Hide();
                        fr_admin.Show();
                    }    
                    if (st_lnd=="Sinh viên")
                    {
                        MessageBox.Show("B");
                    }
                    if (st_lnd==("Giảng viên"))
                    {
                        MessageBox.Show("C");
                    }    
                }
               else
                {
                    MessageBox.Show("Sai mật khẩu!");
                    return;

                }   
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản không tồn tại!");
                return;
            }
        }
    }
}
