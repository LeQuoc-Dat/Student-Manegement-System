
namespace Student_Manegement_System
{
    partial class frm_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin));
            this.tab_QLnganh = new System.Windows.Forms.TabPage();
            this.txt_TimkiemNganh = new System.Windows.Forms.TextBox();
            this.dgv_Nganh = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemNganh = new System.Windows.Forms.Button();
            this.btn_SuaNganh = new System.Windows.Forms.Button();
            this.btn_XoaNganh = new System.Windows.Forms.Button();
            this.btn_ThemNganh = new System.Windows.Forms.Button();
            this.tab_QLtaikhoan = new System.Windows.Forms.TabPage();
            this.txt_TimkiemTK = new System.Windows.Forms.TextBox();
            this.dvg_TK = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemTK = new System.Windows.Forms.Button();
            this.btn_SuaTK = new System.Windows.Forms.Button();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.btn_ThemTK = new System.Windows.Forms.Button();
            this.tab_QLketquahoctap = new System.Windows.Forms.TabPage();
            this.txt_TimkiemKQHT = new System.Windows.Forms.TextBox();
            this.dgv_KQHT = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemKQHT = new System.Windows.Forms.Button();
            this.btn_QuanlyKQHT = new System.Windows.Forms.Button();
            this.tab_QLsinhvien = new System.Windows.Forms.TabPage();
            this.txt_TimkiemSV = new System.Windows.Forms.TextBox();
            this.dgv_SV = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemSV = new System.Windows.Forms.Button();
            this.btn_SuaSV = new System.Windows.Forms.Button();
            this.btn_XoaSV = new System.Windows.Forms.Button();
            this.btn_ThemSV = new System.Windows.Forms.Button();
            this.tab_QLgiangvien = new System.Windows.Forms.TabPage();
            this.btn_LophocphanGV = new System.Windows.Forms.Button();
            this.btn_SuaGV = new System.Windows.Forms.Button();
            this.txt_TimkiemGV = new System.Windows.Forms.TextBox();
            this.dgv_GV = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemGV = new System.Windows.Forms.Button();
            this.btn_XoaGV = new System.Windows.Forms.Button();
            this.btn_ThemGV = new System.Windows.Forms.Button();
            this.tab_SMS = new System.Windows.Forms.TabControl();
            this.tab_QLchuongtrinhdaotao = new System.Windows.Forms.TabPage();
            this.txt_TimkiemCTDT = new System.Windows.Forms.TextBox();
            this.dgv_CTDT = new System.Windows.Forms.DataGridView();
            this.btn_TimkiemCTDT = new System.Windows.Forms.Button();
            this.btn_SuaCTDT = new System.Windows.Forms.Button();
            this.btn_XoaCTDT = new System.Windows.Forms.Button();
            this.btn_ThemCTDT = new System.Windows.Forms.Button();
            this.tab_Thongtintaikhoan = new System.Windows.Forms.TabPage();
            this.tab_QLnganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nganh)).BeginInit();
            this.tab_QLtaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TK)).BeginInit();
            this.tab_QLketquahoctap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KQHT)).BeginInit();
            this.tab_QLsinhvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).BeginInit();
            this.tab_QLgiangvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).BeginInit();
            this.tab_SMS.SuspendLayout();
            this.tab_QLchuongtrinhdaotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_QLnganh
            // 
            this.tab_QLnganh.Controls.Add(this.txt_TimkiemNganh);
            this.tab_QLnganh.Controls.Add(this.dgv_Nganh);
            this.tab_QLnganh.Controls.Add(this.btn_TimkiemNganh);
            this.tab_QLnganh.Controls.Add(this.btn_SuaNganh);
            this.tab_QLnganh.Controls.Add(this.btn_XoaNganh);
            this.tab_QLnganh.Controls.Add(this.btn_ThemNganh);
            this.tab_QLnganh.Location = new System.Drawing.Point(4, 25);
            this.tab_QLnganh.Name = "tab_QLnganh";
            this.tab_QLnganh.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLnganh.Size = new System.Drawing.Size(911, 460);
            this.tab_QLnganh.TabIndex = 5;
            this.tab_QLnganh.Text = "Quản lý ngành";
            this.tab_QLnganh.UseVisualStyleBackColor = true;
            // 
            // txt_TimkiemNganh
            // 
            this.txt_TimkiemNganh.Location = new System.Drawing.Point(8, 9);
            this.txt_TimkiemNganh.Name = "txt_TimkiemNganh";
            this.txt_TimkiemNganh.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemNganh.TabIndex = 17;
            // 
            // dgv_Nganh
            // 
            this.dgv_Nganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nganh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Nganh.Location = new System.Drawing.Point(3, 78);
            this.dgv_Nganh.Name = "dgv_Nganh";
            this.dgv_Nganh.RowHeadersWidth = 51;
            this.dgv_Nganh.RowTemplate.Height = 24;
            this.dgv_Nganh.Size = new System.Drawing.Size(905, 379);
            this.dgv_Nganh.TabIndex = 16;
            // 
            // btn_TimkiemNganh
            // 
            this.btn_TimkiemNganh.Location = new System.Drawing.Point(311, 9);
            this.btn_TimkiemNganh.Name = "btn_TimkiemNganh";
            this.btn_TimkiemNganh.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemNganh.TabIndex = 15;
            this.btn_TimkiemNganh.Text = "Tìm kiếm";
            this.btn_TimkiemNganh.UseVisualStyleBackColor = true;
            // 
            // btn_SuaNganh
            // 
            this.btn_SuaNganh.Location = new System.Drawing.Point(828, 33);
            this.btn_SuaNganh.Name = "btn_SuaNganh";
            this.btn_SuaNganh.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaNganh.TabIndex = 14;
            this.btn_SuaNganh.Text = "Sửa";
            this.btn_SuaNganh.UseVisualStyleBackColor = true;
            // 
            // btn_XoaNganh
            // 
            this.btn_XoaNganh.Location = new System.Drawing.Point(747, 33);
            this.btn_XoaNganh.Name = "btn_XoaNganh";
            this.btn_XoaNganh.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaNganh.TabIndex = 13;
            this.btn_XoaNganh.Text = "Xóa";
            this.btn_XoaNganh.UseVisualStyleBackColor = true;
            // 
            // btn_ThemNganh
            // 
            this.btn_ThemNganh.Location = new System.Drawing.Point(666, 33);
            this.btn_ThemNganh.Name = "btn_ThemNganh";
            this.btn_ThemNganh.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNganh.TabIndex = 12;
            this.btn_ThemNganh.Text = "Thêm";
            this.btn_ThemNganh.UseVisualStyleBackColor = true;
            // 
            // tab_QLtaikhoan
            // 
            this.tab_QLtaikhoan.Controls.Add(this.txt_TimkiemTK);
            this.tab_QLtaikhoan.Controls.Add(this.dvg_TK);
            this.tab_QLtaikhoan.Controls.Add(this.btn_TimkiemTK);
            this.tab_QLtaikhoan.Controls.Add(this.btn_SuaTK);
            this.tab_QLtaikhoan.Controls.Add(this.btn_XoaTK);
            this.tab_QLtaikhoan.Controls.Add(this.btn_ThemTK);
            this.tab_QLtaikhoan.Location = new System.Drawing.Point(4, 25);
            this.tab_QLtaikhoan.Name = "tab_QLtaikhoan";
            this.tab_QLtaikhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLtaikhoan.Size = new System.Drawing.Size(911, 460);
            this.tab_QLtaikhoan.TabIndex = 4;
            this.tab_QLtaikhoan.Text = "Quản lý tài khoản";
            this.tab_QLtaikhoan.UseVisualStyleBackColor = true;
            // 
            // txt_TimkiemTK
            // 
            this.txt_TimkiemTK.Location = new System.Drawing.Point(8, 9);
            this.txt_TimkiemTK.Name = "txt_TimkiemTK";
            this.txt_TimkiemTK.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemTK.TabIndex = 17;
            // 
            // dvg_TK
            // 
            this.dvg_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_TK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvg_TK.Location = new System.Drawing.Point(3, 78);
            this.dvg_TK.Name = "dvg_TK";
            this.dvg_TK.RowHeadersWidth = 51;
            this.dvg_TK.RowTemplate.Height = 24;
            this.dvg_TK.Size = new System.Drawing.Size(905, 379);
            this.dvg_TK.TabIndex = 16;
            // 
            // btn_TimkiemTK
            // 
            this.btn_TimkiemTK.Location = new System.Drawing.Point(311, 9);
            this.btn_TimkiemTK.Name = "btn_TimkiemTK";
            this.btn_TimkiemTK.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemTK.TabIndex = 15;
            this.btn_TimkiemTK.Text = "Tìm kiếm";
            this.btn_TimkiemTK.UseVisualStyleBackColor = true;
            // 
            // btn_SuaTK
            // 
            this.btn_SuaTK.Location = new System.Drawing.Point(828, 33);
            this.btn_SuaTK.Name = "btn_SuaTK";
            this.btn_SuaTK.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaTK.TabIndex = 14;
            this.btn_SuaTK.Text = "Sửa";
            this.btn_SuaTK.UseVisualStyleBackColor = true;
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.Location = new System.Drawing.Point(747, 33);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaTK.TabIndex = 13;
            this.btn_XoaTK.Text = "Xóa";
            this.btn_XoaTK.UseVisualStyleBackColor = true;
            // 
            // btn_ThemTK
            // 
            this.btn_ThemTK.Location = new System.Drawing.Point(666, 33);
            this.btn_ThemTK.Name = "btn_ThemTK";
            this.btn_ThemTK.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemTK.TabIndex = 12;
            this.btn_ThemTK.Text = "Thêm";
            this.btn_ThemTK.UseVisualStyleBackColor = true;
            // 
            // tab_QLketquahoctap
            // 
            this.tab_QLketquahoctap.Controls.Add(this.txt_TimkiemKQHT);
            this.tab_QLketquahoctap.Controls.Add(this.dgv_KQHT);
            this.tab_QLketquahoctap.Controls.Add(this.btn_TimkiemKQHT);
            this.tab_QLketquahoctap.Controls.Add(this.btn_QuanlyKQHT);
            this.tab_QLketquahoctap.Location = new System.Drawing.Point(4, 25);
            this.tab_QLketquahoctap.Name = "tab_QLketquahoctap";
            this.tab_QLketquahoctap.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLketquahoctap.Size = new System.Drawing.Size(911, 460);
            this.tab_QLketquahoctap.TabIndex = 3;
            this.tab_QLketquahoctap.Text = "Quản lý kết quả học tập";
            this.tab_QLketquahoctap.UseVisualStyleBackColor = true;
            // 
            // txt_TimkiemKQHT
            // 
            this.txt_TimkiemKQHT.Location = new System.Drawing.Point(8, 9);
            this.txt_TimkiemKQHT.Name = "txt_TimkiemKQHT";
            this.txt_TimkiemKQHT.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemKQHT.TabIndex = 17;
            // 
            // dgv_KQHT
            // 
            this.dgv_KQHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KQHT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_KQHT.Location = new System.Drawing.Point(3, 78);
            this.dgv_KQHT.Name = "dgv_KQHT";
            this.dgv_KQHT.RowHeadersWidth = 51;
            this.dgv_KQHT.RowTemplate.Height = 24;
            this.dgv_KQHT.Size = new System.Drawing.Size(905, 379);
            this.dgv_KQHT.TabIndex = 16;
            // 
            // btn_TimkiemKQHT
            // 
            this.btn_TimkiemKQHT.Location = new System.Drawing.Point(311, 9);
            this.btn_TimkiemKQHT.Name = "btn_TimkiemKQHT";
            this.btn_TimkiemKQHT.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemKQHT.TabIndex = 15;
            this.btn_TimkiemKQHT.Text = "Tìm kiếm";
            this.btn_TimkiemKQHT.UseVisualStyleBackColor = true;
            // 
            // btn_QuanlyKQHT
            // 
            this.btn_QuanlyKQHT.Location = new System.Drawing.Point(771, 33);
            this.btn_QuanlyKQHT.Name = "btn_QuanlyKQHT";
            this.btn_QuanlyKQHT.Size = new System.Drawing.Size(132, 39);
            this.btn_QuanlyKQHT.TabIndex = 12;
            this.btn_QuanlyKQHT.Text = "Quản lý điểm";
            this.btn_QuanlyKQHT.UseVisualStyleBackColor = true;
            // 
            // tab_QLsinhvien
            // 
            this.tab_QLsinhvien.Controls.Add(this.txt_TimkiemSV);
            this.tab_QLsinhvien.Controls.Add(this.dgv_SV);
            this.tab_QLsinhvien.Controls.Add(this.btn_TimkiemSV);
            this.tab_QLsinhvien.Controls.Add(this.btn_SuaSV);
            this.tab_QLsinhvien.Controls.Add(this.btn_XoaSV);
            this.tab_QLsinhvien.Controls.Add(this.btn_ThemSV);
            this.tab_QLsinhvien.Location = new System.Drawing.Point(4, 25);
            this.tab_QLsinhvien.Name = "tab_QLsinhvien";
            this.tab_QLsinhvien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLsinhvien.Size = new System.Drawing.Size(911, 460);
            this.tab_QLsinhvien.TabIndex = 2;
            this.tab_QLsinhvien.Text = "Quản lý sinh viên";
            this.tab_QLsinhvien.UseVisualStyleBackColor = true;
            // 
            // txt_TimkiemSV
            // 
            this.txt_TimkiemSV.Location = new System.Drawing.Point(8, 14);
            this.txt_TimkiemSV.Name = "txt_TimkiemSV";
            this.txt_TimkiemSV.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemSV.TabIndex = 11;
            // 
            // dgv_SV
            // 
            this.dgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SV.Location = new System.Drawing.Point(3, 78);
            this.dgv_SV.Name = "dgv_SV";
            this.dgv_SV.RowHeadersWidth = 51;
            this.dgv_SV.RowTemplate.Height = 24;
            this.dgv_SV.Size = new System.Drawing.Size(905, 379);
            this.dgv_SV.TabIndex = 10;
            // 
            // btn_TimkiemSV
            // 
            this.btn_TimkiemSV.Location = new System.Drawing.Point(311, 14);
            this.btn_TimkiemSV.Name = "btn_TimkiemSV";
            this.btn_TimkiemSV.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemSV.TabIndex = 9;
            this.btn_TimkiemSV.Text = "Tìm kiếm";
            this.btn_TimkiemSV.UseVisualStyleBackColor = true;
            this.btn_TimkiemSV.Click += new System.EventHandler(this.btn_TimkiemSV_Click);
            // 
            // btn_SuaSV
            // 
            this.btn_SuaSV.Location = new System.Drawing.Point(828, 38);
            this.btn_SuaSV.Name = "btn_SuaSV";
            this.btn_SuaSV.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaSV.TabIndex = 8;
            this.btn_SuaSV.Text = "Sửa";
            this.btn_SuaSV.UseVisualStyleBackColor = true;
            this.btn_SuaSV.Click += new System.EventHandler(this.btn_SuaSV_Click);
            // 
            // btn_XoaSV
            // 
            this.btn_XoaSV.Location = new System.Drawing.Point(747, 38);
            this.btn_XoaSV.Name = "btn_XoaSV";
            this.btn_XoaSV.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaSV.TabIndex = 7;
            this.btn_XoaSV.Text = "Xóa";
            this.btn_XoaSV.UseVisualStyleBackColor = true;
            this.btn_XoaSV.Click += new System.EventHandler(this.btn_XoaSV_Click);
            // 
            // btn_ThemSV
            // 
            this.btn_ThemSV.Location = new System.Drawing.Point(666, 38);
            this.btn_ThemSV.Name = "btn_ThemSV";
            this.btn_ThemSV.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemSV.TabIndex = 6;
            this.btn_ThemSV.Text = "Thêm";
            this.btn_ThemSV.UseVisualStyleBackColor = true;
            this.btn_ThemSV.Click += new System.EventHandler(this.btn_ThemSV_Click);
            // 
            // tab_QLgiangvien
            // 
            this.tab_QLgiangvien.Controls.Add(this.btn_LophocphanGV);
            this.tab_QLgiangvien.Controls.Add(this.btn_SuaGV);
            this.tab_QLgiangvien.Controls.Add(this.txt_TimkiemGV);
            this.tab_QLgiangvien.Controls.Add(this.dgv_GV);
            this.tab_QLgiangvien.Controls.Add(this.btn_TimkiemGV);
            this.tab_QLgiangvien.Controls.Add(this.btn_XoaGV);
            this.tab_QLgiangvien.Controls.Add(this.btn_ThemGV);
            this.tab_QLgiangvien.Location = new System.Drawing.Point(4, 25);
            this.tab_QLgiangvien.Name = "tab_QLgiangvien";
            this.tab_QLgiangvien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLgiangvien.Size = new System.Drawing.Size(911, 460);
            this.tab_QLgiangvien.TabIndex = 1;
            this.tab_QLgiangvien.Text = "Quản lý giảng viên";
            this.tab_QLgiangvien.UseVisualStyleBackColor = true;
            // 
            // btn_LophocphanGV
            // 
            this.btn_LophocphanGV.Location = new System.Drawing.Point(521, 38);
            this.btn_LophocphanGV.Name = "btn_LophocphanGV";
            this.btn_LophocphanGV.Size = new System.Drawing.Size(121, 34);
            this.btn_LophocphanGV.TabIndex = 12;
            this.btn_LophocphanGV.Text = "Lớp học phần";
            this.btn_LophocphanGV.UseVisualStyleBackColor = true;
            // 
            // btn_SuaGV
            // 
            this.btn_SuaGV.Location = new System.Drawing.Point(828, 38);
            this.btn_SuaGV.Name = "btn_SuaGV";
            this.btn_SuaGV.Size = new System.Drawing.Size(75, 34);
            this.btn_SuaGV.TabIndex = 11;
            this.btn_SuaGV.Text = "Sửa";
            this.btn_SuaGV.UseVisualStyleBackColor = true;
            this.btn_SuaGV.Click += new System.EventHandler(this.btn_SuaGV_Click);
            // 
            // txt_TimkiemGV
            // 
            this.txt_TimkiemGV.Location = new System.Drawing.Point(8, 14);
            this.txt_TimkiemGV.Name = "txt_TimkiemGV";
            this.txt_TimkiemGV.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemGV.TabIndex = 10;
            // 
            // dgv_GV
            // 
            this.dgv_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_GV.Location = new System.Drawing.Point(3, 78);
            this.dgv_GV.Name = "dgv_GV";
            this.dgv_GV.RowHeadersWidth = 51;
            this.dgv_GV.RowTemplate.Height = 24;
            this.dgv_GV.Size = new System.Drawing.Size(905, 379);
            this.dgv_GV.TabIndex = 9;
            // 
            // btn_TimkiemGV
            // 
            this.btn_TimkiemGV.Location = new System.Drawing.Point(311, 14);
            this.btn_TimkiemGV.Name = "btn_TimkiemGV";
            this.btn_TimkiemGV.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemGV.TabIndex = 8;
            this.btn_TimkiemGV.Text = "Tìm kiếm";
            this.btn_TimkiemGV.UseVisualStyleBackColor = true;
            this.btn_TimkiemGV.Click += new System.EventHandler(this.btn_TimkiemGV_Click);
            // 
            // btn_XoaGV
            // 
            this.btn_XoaGV.Location = new System.Drawing.Point(747, 38);
            this.btn_XoaGV.Name = "btn_XoaGV";
            this.btn_XoaGV.Size = new System.Drawing.Size(75, 34);
            this.btn_XoaGV.TabIndex = 7;
            this.btn_XoaGV.Text = "Xóa";
            this.btn_XoaGV.UseVisualStyleBackColor = true;
            this.btn_XoaGV.Click += new System.EventHandler(this.btn_XoaGV_Click);
            // 
            // btn_ThemGV
            // 
            this.btn_ThemGV.Location = new System.Drawing.Point(662, 38);
            this.btn_ThemGV.Name = "btn_ThemGV";
            this.btn_ThemGV.Size = new System.Drawing.Size(79, 34);
            this.btn_ThemGV.TabIndex = 6;
            this.btn_ThemGV.Text = "Thêm";
            this.btn_ThemGV.UseVisualStyleBackColor = true;
            this.btn_ThemGV.Click += new System.EventHandler(this.btn_ThemGV_Click);
            // 
            // tab_SMS
            // 
            this.tab_SMS.Controls.Add(this.tab_QLchuongtrinhdaotao);
            this.tab_SMS.Controls.Add(this.tab_QLgiangvien);
            this.tab_SMS.Controls.Add(this.tab_QLsinhvien);
            this.tab_SMS.Controls.Add(this.tab_QLketquahoctap);
            this.tab_SMS.Controls.Add(this.tab_QLtaikhoan);
            this.tab_SMS.Controls.Add(this.tab_QLnganh);
            this.tab_SMS.Controls.Add(this.tab_Thongtintaikhoan);
            this.tab_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_SMS.Location = new System.Drawing.Point(0, 0);
            this.tab_SMS.Name = "tab_SMS";
            this.tab_SMS.SelectedIndex = 0;
            this.tab_SMS.Size = new System.Drawing.Size(919, 489);
            this.tab_SMS.TabIndex = 0;
            // 
            // tab_QLchuongtrinhdaotao
            // 
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.txt_TimkiemCTDT);
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.dgv_CTDT);
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.btn_TimkiemCTDT);
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.btn_SuaCTDT);
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.btn_XoaCTDT);
            this.tab_QLchuongtrinhdaotao.Controls.Add(this.btn_ThemCTDT);
            this.tab_QLchuongtrinhdaotao.Location = new System.Drawing.Point(4, 25);
            this.tab_QLchuongtrinhdaotao.Name = "tab_QLchuongtrinhdaotao";
            this.tab_QLchuongtrinhdaotao.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLchuongtrinhdaotao.Size = new System.Drawing.Size(911, 460);
            this.tab_QLchuongtrinhdaotao.TabIndex = 0;
            this.tab_QLchuongtrinhdaotao.Text = "Quản lý chương trinh đào tạo";
            this.tab_QLchuongtrinhdaotao.UseVisualStyleBackColor = true;
            // 
            // txt_TimkiemCTDT
            // 
            this.txt_TimkiemCTDT.Location = new System.Drawing.Point(8, 25);
            this.txt_TimkiemCTDT.Name = "txt_TimkiemCTDT";
            this.txt_TimkiemCTDT.Size = new System.Drawing.Size(297, 22);
            this.txt_TimkiemCTDT.TabIndex = 5;
            // 
            // dgv_CTDT
            // 
            this.dgv_CTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_CTDT.Location = new System.Drawing.Point(3, 78);
            this.dgv_CTDT.Name = "dgv_CTDT";
            this.dgv_CTDT.RowHeadersWidth = 51;
            this.dgv_CTDT.RowTemplate.Height = 24;
            this.dgv_CTDT.Size = new System.Drawing.Size(905, 379);
            this.dgv_CTDT.TabIndex = 4;
            // 
            // btn_TimkiemCTDT
            // 
            this.btn_TimkiemCTDT.Location = new System.Drawing.Point(311, 25);
            this.btn_TimkiemCTDT.Name = "btn_TimkiemCTDT";
            this.btn_TimkiemCTDT.Size = new System.Drawing.Size(75, 23);
            this.btn_TimkiemCTDT.TabIndex = 3;
            this.btn_TimkiemCTDT.Text = "Tìm kiếm";
            this.btn_TimkiemCTDT.UseVisualStyleBackColor = true;
            // 
            // btn_SuaCTDT
            // 
            this.btn_SuaCTDT.Location = new System.Drawing.Point(828, 49);
            this.btn_SuaCTDT.Name = "btn_SuaCTDT";
            this.btn_SuaCTDT.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaCTDT.TabIndex = 2;
            this.btn_SuaCTDT.Text = "Sửa";
            this.btn_SuaCTDT.UseVisualStyleBackColor = true;
            this.btn_SuaCTDT.Click += new System.EventHandler(this.btn_SuaCTDT_Click);
            // 
            // btn_XoaCTDT
            // 
            this.btn_XoaCTDT.Location = new System.Drawing.Point(747, 49);
            this.btn_XoaCTDT.Name = "btn_XoaCTDT";
            this.btn_XoaCTDT.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaCTDT.TabIndex = 1;
            this.btn_XoaCTDT.Text = "Xóa";
            this.btn_XoaCTDT.UseVisualStyleBackColor = true;
            this.btn_XoaCTDT.Click += new System.EventHandler(this.btn_XoaCTDT_Click);
            // 
            // btn_ThemCTDT
            // 
            this.btn_ThemCTDT.Location = new System.Drawing.Point(666, 49);
            this.btn_ThemCTDT.Name = "btn_ThemCTDT";
            this.btn_ThemCTDT.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemCTDT.TabIndex = 0;
            this.btn_ThemCTDT.Text = "Thêm";
            this.btn_ThemCTDT.UseVisualStyleBackColor = true;
            this.btn_ThemCTDT.Click += new System.EventHandler(this.btn_ThemCTDT_Click);
            // 
            // tab_Thongtintaikhoan
            // 
            this.tab_Thongtintaikhoan.Location = new System.Drawing.Point(4, 25);
            this.tab_Thongtintaikhoan.Name = "tab_Thongtintaikhoan";
            this.tab_Thongtintaikhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Thongtintaikhoan.Size = new System.Drawing.Size(911, 460);
            this.tab_Thongtintaikhoan.TabIndex = 6;
            this.tab_Thongtintaikhoan.Text = "Thông tin tài khoản";
            this.tab_Thongtintaikhoan.UseVisualStyleBackColor = true;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 489);
            this.Controls.Add(this.tab_SMS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Admin";
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Admin_FormClosing);
            this.tab_QLnganh.ResumeLayout(false);
            this.tab_QLnganh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nganh)).EndInit();
            this.tab_QLtaikhoan.ResumeLayout(false);
            this.tab_QLtaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TK)).EndInit();
            this.tab_QLketquahoctap.ResumeLayout(false);
            this.tab_QLketquahoctap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KQHT)).EndInit();
            this.tab_QLsinhvien.ResumeLayout(false);
            this.tab_QLsinhvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).EndInit();
            this.tab_QLgiangvien.ResumeLayout(false);
            this.tab_QLgiangvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).EndInit();
            this.tab_SMS.ResumeLayout(false);
            this.tab_QLchuongtrinhdaotao.ResumeLayout(false);
            this.tab_QLchuongtrinhdaotao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_QLnganh;
        private System.Windows.Forms.TextBox txt_TimkiemNganh;
        private System.Windows.Forms.DataGridView dgv_Nganh;
        private System.Windows.Forms.Button btn_TimkiemNganh;
        private System.Windows.Forms.Button btn_SuaNganh;
        private System.Windows.Forms.Button btn_XoaNganh;
        private System.Windows.Forms.Button btn_ThemNganh;
        private System.Windows.Forms.TabPage tab_QLtaikhoan;
        private System.Windows.Forms.TextBox txt_TimkiemTK;
        private System.Windows.Forms.DataGridView dvg_TK;
        private System.Windows.Forms.Button btn_TimkiemTK;
        private System.Windows.Forms.Button btn_SuaTK;
        private System.Windows.Forms.Button btn_XoaTK;
        private System.Windows.Forms.Button btn_ThemTK;
        private System.Windows.Forms.TabPage tab_QLketquahoctap;
        private System.Windows.Forms.TextBox txt_TimkiemKQHT;
        private System.Windows.Forms.DataGridView dgv_KQHT;
        private System.Windows.Forms.Button btn_TimkiemKQHT;
        private System.Windows.Forms.Button btn_QuanlyKQHT;
        private System.Windows.Forms.TabPage tab_QLsinhvien;
        private System.Windows.Forms.TextBox txt_TimkiemSV;
        private System.Windows.Forms.DataGridView dgv_SV;
        private System.Windows.Forms.Button btn_TimkiemSV;
        private System.Windows.Forms.Button btn_SuaSV;
        private System.Windows.Forms.Button btn_XoaSV;
        private System.Windows.Forms.Button btn_ThemSV;
        private System.Windows.Forms.TabPage tab_QLgiangvien;
        private System.Windows.Forms.Button btn_LophocphanGV;
        private System.Windows.Forms.Button btn_SuaGV;
        private System.Windows.Forms.TextBox txt_TimkiemGV;
        private System.Windows.Forms.DataGridView dgv_GV;
        private System.Windows.Forms.Button btn_TimkiemGV;
        private System.Windows.Forms.Button btn_XoaGV;
        private System.Windows.Forms.Button btn_ThemGV;
        private System.Windows.Forms.TabControl tab_SMS;
        private System.Windows.Forms.TabPage tab_QLchuongtrinhdaotao;
        private System.Windows.Forms.TextBox txt_TimkiemCTDT;
        private System.Windows.Forms.DataGridView dgv_CTDT;
        private System.Windows.Forms.Button btn_TimkiemCTDT;
        private System.Windows.Forms.Button btn_SuaCTDT;
        private System.Windows.Forms.Button btn_XoaCTDT;
        private System.Windows.Forms.Button btn_ThemCTDT;
        private System.Windows.Forms.TabPage tab_Thongtintaikhoan;
    }
}