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
    public partial class formDSMHDaDKy : Form
    {
        private string masv;
        private string tukhoa = "";
        public formDSMHDaDKy(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void formDSMHDaDKy_Load(object sender, EventArgs e)
        {
            LoadMonDKy();

        }

        private void LoadMonDKy()
        {
            List<CustomParameters> lst = new List<CustomParameters>()
            {
                new CustomParameters()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDaDKy", lst);
        }


        private void btnDKyMoi_Click(object sender, EventArgs e)
        {
            formDangKyMonHoc fn = new formDangKyMonHoc(masv);
            fn.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadMonDKy();
        }
    }
}
