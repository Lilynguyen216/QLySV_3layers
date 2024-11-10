using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySV_3layers
{
    public partial class formGV : Form
    {
        public formGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private string mgv;
        private string nguoithucthi = "admin";

        private void formGV_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                rbtNam.Checked = r["gioitinh"].ToString() == "1" ? true : false;
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime ngaysinh;
            List<CustomParameters> lstPara = new List<CustomParameters>();
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }

            if(string.IsNullOrEmpty(mgv))
            {
                sql = "insertGV";
                lstPara.Add(new CustomParameters()
                {
                    key = "@nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameters()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi
                });
                lstPara.Add(new CustomParameters()
                {
                    key = "@magiaovien",
                    value = mgv
                });
            }
            lstPara.Add(new CustomParameters()
            {
                key = "@ho",
                value = txtHo.Text
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@tendem",
                value = txtTendem.Text
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@ten",
                value = txtTen.Text
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@gioitinh",
                value = rbtNam.Checked?"1":"0"
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@email",
                value = txtEmail.Text
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@dienthoai",
                value = txtDienthoai.Text
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@diachi",
                value = txtDiachi.Text
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if(string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật giáo viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }


        }
    }
}
