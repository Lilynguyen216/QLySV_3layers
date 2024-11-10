using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySV_3layers
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string matkhau = "";
        public string loaitk = "";

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc

            if (cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản", "Tài khoản không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtTenDangNhap.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
            }
            #endregion

            tendangnhap = txtTenDangNhap.Text;
            //string loaitk = "";

            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            #endregion

            List<CustomParameters> lst = new List<CustomParameters>()
            {
                new CustomParameters()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameters()
                {
                    key = "@taikhoan",
                    value = txtTenDangNhap.Text
                },
                new CustomParameters()
                {
                    key = "@matkhau",
                    value = txtMatKhau.Text
                }
            };

            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
            //this.Hide();
        }

        private void cbbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
