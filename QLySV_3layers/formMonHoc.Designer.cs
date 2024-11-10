namespace QLySV_3layers
{
    partial class formMonHoc
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
            btnLuu = new Button();
            btnHuy = new Button();
            txtTenMH = new TextBox();
            txtSoTC = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên môn học";
            label1.Click += label1_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(582, 37);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(694, 37);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(117, 39);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(277, 27);
            txtTenMH.TabIndex = 6;
            // 
            // txtSoTC
            // 
            txtSoTC.Location = new Point(476, 39);
            txtSoTC.Name = "txtSoTC";
            txtSoTC.Size = new Size(91, 27);
            txtSoTC.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 42);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Số TC";
            // 
            // formMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 104);
            Controls.Add(txtSoTC);
            Controls.Add(label2);
            Controls.Add(txtTenMH);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(label1);
            Name = "formMonHoc";
            Text = "formMonHoc";
            Load += formMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLuu;
        private Button btnHuy;
        private TextBox txtTenMH;
        private TextBox txtSoTC;
        private Label label2;
    }
}