namespace QuanLiBanHang.Reports
{
    partial class frmThongKeDoanhThu
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
            panel1 = new Panel();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Bottom;
            reportViewer.Location = new Point(0, 101);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 349);
            reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(btnHienTatCa);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 101);
            panel1.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(375, 36);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(141, 31);
            dtpDenNgay.TabIndex = 7;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(98, 36);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(141, 31);
            dtpTuNgay.TabIndex = 6;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(676, 31);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(112, 34);
            btnHienTatCa.TabIndex = 5;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(548, 33);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(112, 34);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 38);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeDoanhThu";
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Button btnHienTatCa;
        private Button btnLocKetQua;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
    }
}