namespace QLySV_3layers
{
    partial class formDangNhap
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
            label1 = new Label();
            cbbLoaiTaiKhoan = new ComboBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 53);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại tài khoản";
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Items.AddRange(new object[] { "Quản trị viên", "Giáo viên", "Sinh viên" });
            cbbLoaiTaiKhoan.Location = new Point(272, 50);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(236, 28);
            cbbLoaiTaiKhoan.TabIndex = 1;
            cbbLoaiTaiKhoan.SelectedIndexChanged += cbbLoaiTaiKhoan_SelectedIndexChanged;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(272, 115);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(236, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 118);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(272, 187);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(236, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(272, 263);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(404, 263);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // formDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 340);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(label1);
            Name = "formDangNhap";
            Text = "formDangNhap";
            Load += formDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbLoaiTaiKhoan;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label3;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}