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

namespace QLySV_3layers
{
    public partial class formDSSV : Form
    {
        public formDSSV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string tukhoa = "";

        private void formDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void LoadDSSV()
        {
            List<CustomParameters> lstPara = new List<CustomParameters>();
            lstPara.Add(new CustomParameters()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);

            dgvSinhVien.Columns["masinhvien"].HeaderText = "Ma SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Ho ten";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngay sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Gioi tinh";
            dgvSinhVien.Columns["quequan"].HeaderText = "Que quan";
            dgvSinhVien.Columns["diachi"].HeaderText = "Dia chi";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Dien thoai";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
        }

        private void dgvSinhVien_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                /* MessageBox.Show("Ma sinh vien: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());*/
                new formSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV();
        }
    }
}
