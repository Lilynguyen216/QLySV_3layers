namespace QLySV_3layers
{
    partial class formLopHoc
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
            cbbMonHoc = new ComboBox();
            cbbGiaoVien = new ComboBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(255, 37);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(256, 28);
            cbbMonHoc.TabIndex = 1;
            // 
            // cbbGiaoVien
            // 
            cbbGiaoVien.FormattingEnabled = true;
            cbbGiaoVien.Location = new Point(255, 84);
            cbbGiaoVien.Name = "cbbGiaoVien";
            cbbGiaoVien.Size = new Size(256, 28);
            cbbGiaoVien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Giáo viên";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(269, 143);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(394, 143);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // formLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 205);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cbbGiaoVien);
            Controls.Add(label2);
            Controls.Add(cbbMonHoc);
            Controls.Add(label1);
            Name = "formLopHoc";
            Text = "formLopHoc";
            Load += formLopHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbMonHoc;
        private ComboBox cbbGiaoVien;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}