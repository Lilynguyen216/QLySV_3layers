namespace QLySV_3layers
{
    partial class formGV
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
            txtHo = new TextBox();
            txtTendem = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mtbNgaysinh = new MaskedTextBox();
            label5 = new Label();
            rbtNam = new RadioButton();
            rbtNu = new RadioButton();
            txtDienthoai = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDiachi = new TextBox();
            label8 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 35);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(248, 32);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(351, 27);
            txtHo.TabIndex = 1;
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(248, 78);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(351, 27);
            txtTendem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 81);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đệm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(248, 124);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(351, 27);
            txtTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 127);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 182);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(248, 231);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(188, 27);
            mtbNgaysinh.TabIndex = 7;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 234);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh";
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(279, 180);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(62, 24);
            rbtNam.TabIndex = 9;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(438, 180);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(50, 24);
            rbtNu.TabIndex = 10;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(248, 293);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(351, 27);
            txtDienthoai.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(164, 296);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 11;
            label6.Text = "Điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(248, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 27);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 341);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(248, 384);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(351, 27);
            txtDiachi.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 387);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 15;
            label8.Text = "Địa chỉ";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(264, 456);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(394, 456);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // formGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDiachi);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtDienthoai);
            Controls.Add(label6);
            Controls.Add(rbtNu);
            Controls.Add(rbtNam);
            Controls.Add(label5);
            Controls.Add(mtbNgaysinh);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(txtTendem);
            Controls.Add(label2);
            Controls.Add(txtHo);
            Controls.Add(label1);
            Name = "formGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formGV";
            Load += formGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHo;
        private TextBox txtTendem;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtbNgaysinh;
        private Label label5;
        private RadioButton rbtNam;
        private RadioButton rbtNu;
        private TextBox txtDienthoai;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDiachi;
        private Label label8;
        private Button btnLuu;
        private Button btnHuy;
    }
}