namespace QLySV_3layers
{
    partial class formDSMHDaDKy
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
            dgvDSMHDky = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnDKyMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDky).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMHDky
            // 
            dgvDSMHDky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMHDky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMHDky.Location = new Point(-62, 59);
            dgvDSMHDky.MultiSelect = false;
            dgvDSMHDky.Name = "dgvDSMHDky";
            dgvDSMHDky.RowHeadersWidth = 51;
            dgvDSMHDky.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMHDky.Size = new Size(867, 424);
            dgvDSMHDky.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(211, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ khoá";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(290, 17);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(268, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(564, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDKyMoi
            // 
            btnDKyMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDKyMoi.Location = new Point(664, 17);
            btnDKyMoi.Name = "btnDKyMoi";
            btnDKyMoi.Size = new Size(124, 29);
            btnDKyMoi.TabIndex = 4;
            btnDKyMoi.Text = "Đăng kí mới";
            btnDKyMoi.UseVisualStyleBackColor = true;
            btnDKyMoi.Click += btnDKyMoi_Click;
            // 
            // formDSMHDaDKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDKyMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvDSMHDky);
            Name = "formDSMHDaDKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách môn học đã đăng kí";
            Load += formDSMHDaDKy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMHDky;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnDKyMoi;
    }
}