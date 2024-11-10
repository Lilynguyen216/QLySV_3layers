namespace QLySV_3layers
{
    partial class formDSGV
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
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            dgvDSGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).BeginInit();
            SuspendLayout();
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(246, 34);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(323, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(243, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(584, 30);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.Location = new Point(694, 30);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // dgvDSGV
            // 
            dgvDSGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSGV.Location = new Point(0, 106);
            dgvDSGV.MultiSelect = false;
            dgvDSGV.Name = "dgvDSGV";
            dgvDSGV.RowHeadersWidth = 51;
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.Size = new Size(800, 344);
            dgvDSGV.TabIndex = 4;
            dgvDSGV.CellDoubleClick += dgvDSGV_CellDoubleClick;
            // 
            // formDSGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSGV);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lbTimKiem);
            Name = "formDSGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách giáo viên";
            Load += formDSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private DataGridView dgvDSGV;
    }
}