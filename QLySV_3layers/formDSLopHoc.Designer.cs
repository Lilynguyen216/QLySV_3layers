namespace QLySV_3layers
{
    partial class formDSLopHoc
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
            btnThemmoi = new Button();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            dgvLopHoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            SuspendLayout();
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(676, 17);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 9;
            btnThemmoi.Text = "Thêm Mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(561, 18);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 8;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimkiem.Location = new Point(293, 19);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(242, 27);
            txtTimkiem.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(223, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 6;
            label1.Text = "Từ khoá";
            // 
            // dgvLopHoc
            // 
            dgvLopHoc.AllowUserToAddRows = false;
            dgvLopHoc.AllowUserToDeleteRows = false;
            dgvLopHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.Location = new Point(0, 84);
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.Name = "dgvLopHoc";
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.RowHeadersWidth = 51;
            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.Size = new Size(800, 349);
            dgvLopHoc.TabIndex = 5;
            dgvLopHoc.CellDoubleClick += dgvLopHoc_CellDoubleClick;
            // 
            // formDSLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Controls.Add(dgvLopHoc);
            Name = "formDSLopHoc";
            Text = "formDSLopHoc";
            Load += formDSLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemmoi;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private Label label1;
        private DataGridView dgvLopHoc;
    }
}