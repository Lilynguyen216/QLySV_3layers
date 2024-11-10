namespace QLySV_3layers
{
    public partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            databaseBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            monHocToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem = new ToolStripMenuItem();
            lopHocToolStripMenuItem = new ToolStripMenuItem();
            dangKiToolStripMenuItem = new ToolStripMenuItem();
            dangKiMonHocToolStripMenuItem = new ToolStripMenuItem();
            traCuuDiemToolStripMenuItem = new ToolStripMenuItem();
            chamDiemToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, quanLyToolStripMenuItem, dangKiToolStripMenuItem, chamDiemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(773, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(88, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(181, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(181, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, monHocToolStripMenuItem, giaoVienToolStripMenuItem, lopHocToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(73, 24);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(154, 26);
            sinhVienToolStripMenuItem.Text = "Sinh viên";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // monHocToolStripMenuItem
            // 
            monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            monHocToolStripMenuItem.Size = new Size(154, 26);
            monHocToolStripMenuItem.Text = "Môn học";
            monHocToolStripMenuItem.Click += monHocToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem
            // 
            giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            giaoVienToolStripMenuItem.Size = new Size(154, 26);
            giaoVienToolStripMenuItem.Text = "Giáo viên";
            giaoVienToolStripMenuItem.Click += giaoVienToolStripMenuItem_Click;
            // 
            // lopHocToolStripMenuItem
            // 
            lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            lopHocToolStripMenuItem.Size = new Size(154, 26);
            lopHocToolStripMenuItem.Text = "Lớp học";
            lopHocToolStripMenuItem.Click += diemThiToolStripMenuItem_Click;
            // 
            // dangKiToolStripMenuItem
            // 
            dangKiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangKiMonHocToolStripMenuItem, traCuuDiemToolStripMenuItem });
            dangKiToolStripMenuItem.Name = "dangKiToolStripMenuItem";
            dangKiToolStripMenuItem.Size = new Size(136, 24);
            dangKiToolStripMenuItem.Text = "Đăng kí môn học";
            dangKiToolStripMenuItem.Click += dangKiToolStripMenuItem_Click;
            // 
            // dangKiMonHocToolStripMenuItem
            // 
            dangKiMonHocToolStripMenuItem.Name = "dangKiMonHocToolStripMenuItem";
            dangKiMonHocToolStripMenuItem.Size = new Size(205, 26);
            dangKiMonHocToolStripMenuItem.Text = "Đăng kí môn học";
            dangKiMonHocToolStripMenuItem.Click += dangKiMonHocToolStripMenuItem_Click;
            // 
            // traCuuDiemToolStripMenuItem
            // 
            traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            traCuuDiemToolStripMenuItem.Size = new Size(205, 26);
            traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            traCuuDiemToolStripMenuItem.Click += traCuuDiemToolStripMenuItem_Click;
            // 
            // chamDiemToolStripMenuItem
            // 
            chamDiemToolStripMenuItem.Name = "chamDiemToolStripMenuItem";
            chamDiemToolStripMenuItem.Size = new Size(99, 24);
            chamDiemToolStripMenuItem.Text = "Chấm điểm";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(773, 422);
            pnlContent.TabIndex = 3;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += formMain_Load;
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource databaseBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem monHocToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem;
        private ToolStripMenuItem lopHocToolStripMenuItem;
        private ToolStripMenuItem dangKiToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem dangKiMonHocToolStripMenuItem;
        private ToolStripMenuItem traCuuDiemToolStripMenuItem;
        private ToolStripMenuItem chamDiemToolStripMenuItem;
    }
}
