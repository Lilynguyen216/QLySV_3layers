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
    public partial class formDSMH : Form
    {
        public formDSMH()
        {
            InitializeComponent();
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new formMonHoc(mamh).ShowDialog();
                LoadDSMH();
            }
        }
        private string tukhoa = "";

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formMonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void LoadDSMH()
        {
            List<CustomParameters> lstPara = new List<CustomParameters>();
            lstPara.Add(new CustomParameters()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void formDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số TC";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            LoadDSMH();
        }

        private void dgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
