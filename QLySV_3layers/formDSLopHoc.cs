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
    public partial class formDSLopHoc : Form
    {
        public formDSLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void formDSLopHoc_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }

        private void loadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameters> lstPara = new List<CustomParameters>()
            {
                new CustomParameters()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadDSLH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formLopHoc(null).ShowDialog();
            loadDSLH();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new formLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                loadDSLH();
            }
        }
    }
}
