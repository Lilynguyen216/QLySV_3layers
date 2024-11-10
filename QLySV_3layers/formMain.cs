using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLySV_3layers
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;

        private void formMain_Load(object sender, EventArgs e)
        {
            // form main dùng hiển thị điểm SV
            //var db = new Database();
            // dataGridView1.DataSource = db.SelectData(null, null);
            var fn = new formDangNhap();
            fn.ShowDialog();

            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                chamDiemToolStripMenuItem.Visible = false;
                dangKiToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    dangKiToolStripMenuItem.Visible = false;

                }
                else
                {
                    chamDiemToolStripMenuItem.Visible = false;
                }
            }

            formWelcome f = new formWelcome();
            AddForm(f);

        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSGV f = new formDSGV();
            AddForm(f);
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSSV f = new formDSSV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSMH f = new formDSMH();
            AddForm(f);
        }

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSLopHoc f = new formDSLopHoc();
            AddForm(f);
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangKiMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangKiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formDSMHDaDKy(taikhoan);
            AddForm(f);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
