namespace QLySV_3layers
{
    partial class formDangKyMonHoc
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
            components = new System.ComponentModel.Container();
            dgvDSLH = new DataGridView();
            databaseBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLH
            // 
            dgvDSLH.AllowUserToAddRows = false;
            dgvDSLH.AllowUserToDeleteRows = false;
            dgvDSLH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLH.Location = new Point(0, 0);
            dgvDSLH.MultiSelect = false;
            dgvDSLH.Name = "dgvDSLH";
            dgvDSLH.ReadOnly = true;
            dgvDSLH.RowHeadersWidth = 51;
            dgvDSLH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLH.Size = new Size(800, 450);
            dgvDSLH.TabIndex = 0;
            dgvDSLH.CellContentClick += dgvDSLH_CellContentClick;
            dgvDSLH.CellDoubleClick += dgvDSLH_CellDoubleClick;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // formDangKyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSLH);
            Name = "formDangKyMonHoc";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách lớp học";
            Load += formDangKyMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgvDSLH;
        private BindingSource databaseBindingSource;
    }
}