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
    public partial class formLopHoc : Form
    {
        public formLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameters> lst = new List<CustomParameters>()
            {
                new CustomParameters()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            // load dữ liệu cho 2 combobox môn học và giáo viên
            cbbMonHoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonHoc.DisplayMember = "tenmonhoc";
            cbbMonHoc.ValueMember = "mamonhoc";
            cbbMonHoc.SelectedIndex = -1;

            cbbGiaoVien.DataSource = db.SelectData("selectAllGV", lst);
            cbbGiaoVien.DisplayMember = "hoten";
            cbbGiaoVien.ValueMember = "magiaovien";
            cbbGiaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonHoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql = "";

            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (cbbGiaoVien.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }

            List<CustomParameters> lst = new List<CustomParameters>();
            if (string.IsNullOrEmpty (malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameters
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameters
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameters
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }
            lst.Add(new CustomParameters
            {
                key = "@mamonhoc",
                value = cbbMonHoc.SelectedValue.ToString()
            });
            lst.Add(new CustomParameters
            {
                key = "@magiaovien",
                value = cbbGiaoVien.SelectedValue.ToString()
            });
            
            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }

        }
    }
}
