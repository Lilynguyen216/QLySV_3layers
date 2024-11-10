using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLySV_3layers
{
    public partial class formDangKyMonHoc : Form
    {

        
        public formDangKyMonHoc(string masv)
        {
            InitializeComponent();
        }
        private string msv = "";

        private void formDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số TC";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";
        }
        private void LoadDSLH()
        {
            List<CustomParameters> lstPara = new List<CustomParameters>();
            lstPara.Add(new CustomParameters()
            {
                key = "@masinhvien",
                value = msv
            });
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy", lstPara);
        }

        private void dgvDSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index > 0) 
            {
                if (DialogResult.Yes == 
                    MessageBox.Show (
                        "Bạn muốn đăng kí học phần [ " + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]?",
                        "Xác nhận đăng kí",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        )
                    )
                {
                    List<CustomParameters> lstPara = new List<CustomParameters> ();
                    lstPara.Add(new CustomParameters()
                    {
                        key = "@masinhvien",
                        value = msv
                    });
                    lstPara.Add(new CustomParameters()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });

                    var rs = new Database().ExeCute("[dkyhoc]", lstPara);
                    if ( rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng kí");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đã đăng kí học phần thành công");
                        LoadDSLH();
                    }
                }
            }
        }
    }
}
