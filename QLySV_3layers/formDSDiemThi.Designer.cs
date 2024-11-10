namespace QLySV_3layers
{
    partial class formDSDiemThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            label2 = new Label();
            cbbMonHoc = new ComboBox();
            dgvDiemThi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(288, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ khoá";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(367, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(210, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(594, 29);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.Location = new Point(694, 28);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Môn học";
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(85, 31);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(197, 28);
            cbbMonHoc.TabIndex = 6;
            // 
            // dgvDiemThi
            // 
            dgvDiemThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiemThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemThi.Location = new Point(8, 78);
            dgvDiemThi.Name = "dgvDiemThi";
            dgvDiemThi.RowHeadersWidth = 51;
            dgvDiemThi.Size = new Size(780, 360);
            dgvDiemThi.TabIndex = 7;
            // 
            // formDSDiemThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDiemThi);
            Controls.Add(cbbMonHoc);
            Controls.Add(label2);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDSDiemThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách điểm thi";
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private Label label2;
        private ComboBox cbbMonHoc;
        private DataGridView dgvDiemThi;
    }
}