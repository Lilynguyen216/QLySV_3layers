using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QLySV_3layers
{
    public partial class formSinhVien : Form
    {
        public formSinhVien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void formSinhVien_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show("Ma sinh vien nhan duoc: " + msv);*/
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "them moi sinh vien";
            }
            else
            {
                this.Text = "cap nhat thong tin sinh vien";
                var r = new Database().Select("selectSV '" + msv + "'");
                //MessageBox.Show(r[0].ToString());
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }

                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }

            string gioitinh = rbtNam.Checked? "1" : "0";

            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string email = txtEmail.Text;   
            string dienthoai = txtDienthoai.Text;

            List<CustomParameters> lstPara = new List<CustomParameters>();
            if (string.IsNullOrEmpty (msv))
            {
                sql = "ThemMoiSV";       
            }   
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameters()
                {
                    key = "masinhvien",
                    value = msv
                });
            }

            lstPara.Add(new CustomParameters()
            {
                key = "@ho",
                value = ho
            });

            lstPara.Add(new CustomParameters()
            {
                key = "@tendem",
                value = tendem
            });

            lstPara.Add(new CustomParameters()
            {
                key = "@ten",
                value = ten
            });

            lstPara.Add(new CustomParameters()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameters()
            {
                key = "@email",
                value = email
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }

        }
    }
}
