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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
  //--------Chương trình đào tạo------------//
        private void btn_ThemCTDT_Click(object sender, EventArgs e)
        {
            SMSDataContext db = new SMSDataContext();
            Table<Chuongtrinhdaotao> ctdt = db.GetTable<Chuongtrinhdaotao>();

        }

        private void btn_XoaCTDT_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaCTDT_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------Chương trình đào tạo----------------------------------------------//
        //----------------------------------------------Giảng viên--------------------------------------------------------/

        private void btn_ThemGV_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaGV_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaGV_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimkiemGV_Click(object sender, EventArgs e)
        {

        }


        //-----------------------------------------------Giảng viên----------------------------------------------------------//
        //------------------------------------------------Sinh viên----------------------------------------------------------//
        private void btn_TimkiemSV_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemSV_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {

        }
    }
}
