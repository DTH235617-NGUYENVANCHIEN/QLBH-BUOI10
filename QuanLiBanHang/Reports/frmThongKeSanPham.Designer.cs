namespace QuanLiBanHang.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            cboHangSanXuat = new ComboBox();
            label2 = new Label();
            cboLoaiSanPham = new ComboBox();
            btnLocKetQua = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Bottom;
            reportViewer.Location = new Point(0, 92);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 358);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 1;
            label1.Text = "Hãng Sản Xuất";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(148, 32);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(182, 33);
            cboHangSanXuat.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 35);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 3;
            label2.Text = "Loại Sản Phẩm";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(471, 29);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(182, 33);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(676, 28);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(112, 34);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 6;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private ComboBox cboHangSanXuat;
        private Label label2;
        private ComboBox cboLoaiSanPham;
        private Button btnLocKetQua;
        private Panel panel1;
    }
}