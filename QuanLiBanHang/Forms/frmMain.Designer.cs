namespace QuanLiBanHang.Forms
{
    partial class frmMain
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
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(103, 29);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(238, 34);
            mnuDangNhap.Text = "Đăng &nhập ...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(238, 34);
            mnuDangXuat.Text = "Đăng &xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(238, 34);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu ...";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(238, 34);
            mnuThoat.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, mnuKhachHang, mnuNhanVien, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(84, 29);
            mnuQuanLy.Text = "&Quản lí";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(281, 34);
            mnuLoaiSanPham.Text = "&Loại sản phẩm ...";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(281, 34);
            mnuHangSanXuat.Text = "&Hãng sản xuất ...";
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(281, 34);
            mnuSanPham.Text = "&Sản phẩm ...";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(281, 34);
            mnuKhachHang.Text = "&Khách hàng ...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(281, 34);
            mnuNhanVien.Text = "&Nhân viên ...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(281, 34);
            mnuHoaDon.Text = "&Hóa đơn bán hàng ...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(182, 29);
            mnuBaoCaoThongKe.Text = "&Báo cáo - Thống kê";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(292, 34);
            mnuThongKeSanPham.Text = "Thống kê &sản phẩm ...";
            mnuThongKeSanPham.Click += mnuThongKeSanPham_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(292, 34);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu ...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(93, 29);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(346, 34);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(346, 34);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip.Location = new Point(0, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(148, 25);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(536, 25);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(101, 25);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí bán hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private StatusStrip statusStrip;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
    }
}